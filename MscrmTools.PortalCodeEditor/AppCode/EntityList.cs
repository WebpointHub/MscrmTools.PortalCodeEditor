﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace MscrmTools.PortalCodeEditor.AppCode
{
    public class EntityList : EditablePortalItem
    {
        #region Constants
        public const string NODEKEY = "EntityList";
        public const string NODENAME = "Entity Lists";
        #endregion

        #region Variables

        private readonly Entity innerRecord;

        #endregion Variables

        #region Constructor

        public EntityList(Entity record)
        {
            Id = record.Id;
            JavaScript = new CodeItem(record.GetAttributeValue<string>("adx_registerstartupscript"), CodeItemType.JavaScript, false, this);
            Name = record.GetAttributeValue<string>("adx_name");
            WebsiteReference = record.GetAttributeValue<EntityReference>("adx_websiteid") ??
                               new EntityReference("adx_website", Guid.Empty);

            innerRecord = record;
            Items.Add(JavaScript);
        }

        #endregion Constructor

        #region Properties

        public CodeItem JavaScript { get; }

        #endregion Properties

        #region Methods

        public static List<EntityList> GetItems(IOrganizationService service, Guid callingUserId, bool onlyRetrieveItemsModifiedByMe, ref bool isLegacyPortal)
        {
            try
            {
                DataCollection<Entity> records;
                if (onlyRetrieveItemsModifiedByMe)
                {
                    records = service.RetrieveMultiple(new QueryExpression("adx_entitylist")
                    {
                        ColumnSet = new ColumnSet("adx_name", "adx_registerstartupscript", "adx_websiteid"),
                        Criteria = {
                            Conditions = {
                                new ConditionExpression("modifiedby", ConditionOperator.Equal, callingUserId)
                            }
                        },
                        Orders = { new OrderExpression("adx_name", OrderType.Ascending) }
                    }).Entities;
                }
                else
                {
                    records = service.RetrieveMultiple(new QueryExpression("adx_entitylist")
                    {
                        ColumnSet = new ColumnSet("adx_name", "adx_registerstartupscript", "adx_websiteid"),
                        Orders = { new OrderExpression("adx_name", OrderType.Ascending) }
                    }).Entities;
                }                    

                return records.Select(record => new EntityList(record)).ToList();
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                if (ex.Detail.ErrorCode == -2147217149)
                {
                    isLegacyPortal = true;

                    DataCollection<Entity> records;
                    if (onlyRetrieveItemsModifiedByMe)
                    {
                        records = service.RetrieveMultiple(new QueryExpression("adx_entitylist")
                        {
                            ColumnSet = new ColumnSet("adx_name", "adx_registerstartupscript"),
                            Criteria = {
                                Conditions = {
                                    new ConditionExpression("modifiedby", ConditionOperator.Equal, callingUserId)
                                }
                            },
                            Orders = { new OrderExpression("adx_name", OrderType.Ascending) }
                        }).Entities;
                    } 
                    else
                    {
                        records = service.RetrieveMultiple(new QueryExpression("adx_entitylist")
                        {
                            ColumnSet = new ColumnSet("adx_name", "adx_registerstartupscript"),
                            Orders = { new OrderExpression("adx_name", OrderType.Ascending) }
                        }).Entities;
                    }                        

                    return records.Select(record => new EntityList(record)).ToList();
                }

                throw;
            }
        }

        public override void Update(IOrganizationService service, bool forceUpdate = false)
        {
            innerRecord["adx_registerstartupscript"] = JavaScript.Content;

            var updateRequest = new UpdateRequest
            {
                ConcurrencyBehavior = forceUpdate ? ConcurrencyBehavior.AlwaysOverwrite : ConcurrencyBehavior.IfRowVersionMatches,
                Target = innerRecord
            };

            service.Execute(updateRequest);

            var updatedRecord = service.Retrieve(innerRecord.LogicalName, innerRecord.Id, new ColumnSet());
            innerRecord.RowVersion = updatedRecord.RowVersion;

            JavaScript.State = CodeItemState.None;
            HasPendingChanges = false;
        }

        public override string RefreshContent(CodeItem item, IOrganizationService service)
        {
            var record = service.Retrieve(innerRecord.LogicalName, innerRecord.Id,
                new ColumnSet("adx_registerstartupscript"));

            innerRecord.RowVersion = record.RowVersion;

            return record.GetAttributeValue<string>("adx_registerstartupscript");
        }
        /// <summary>
        /// Write the contents of the code object to disk
        /// </summary>
        /// <param name="path"></param>
        public override void WriteContent(string path, bool replaceExisting)
        {
            var filePath = Path.Combine(path, "JavaScript.js");

            JavaScript?.WriteCodeItem(filePath, replaceExisting);
        }
        #endregion Methods
    }
}