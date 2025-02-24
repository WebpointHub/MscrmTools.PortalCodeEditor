﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace MscrmTools.PortalCodeEditor.AppCode
{
    public class WebFile : EditablePortalItem
    {
        #region Constants

        public const string NODEKEY = "WebFile";
        public const string NODENAME = "Web Files";

        #endregion Constants

        #region Variables

        private readonly Entity innerRecord;

        #endregion Variables

        #region Constructor

        public WebFile(Entity record)
        {
            var ext = record.GetAttributeValue<string>("filename").ToLower().Split('.').Last();

            Id = record.Id;
            Code = new CodeItem(record.GetAttributeValue<string>("documentbody"), ext == "js" ? CodeItemType.JavaScript : CodeItemType.Style, true, this);
            Name = record.GetAttributeValue<AliasedValue>("webfile.adx_name")?.Value.ToString() ?? record.GetAttributeValue<string>("filename");
            WebsiteReference = (EntityReference)record.GetAttributeValue<AliasedValue>("webfile.adx_websiteid")?.Value ?? new EntityReference("adx_website", Guid.Empty);

            innerRecord = record;

            Items.Add(Code);
        }

        #endregion Constructor

        #region Properties

        public CodeItem Code { get; }

        #endregion Properties

        #region Methods

        public static List<WebFile> GetItems(IOrganizationService service, Guid callingUserId, bool onlyRetrieveItemsModifiedByMe)
        {
            DataCollection<Entity> records;
            if (onlyRetrieveItemsModifiedByMe)
            {
                records = service.RetrieveMultiple(new QueryExpression("annotation")
                {
                    ColumnSet = new ColumnSet("filename", "documentbody", "objectid", "modifiedon"),
                    LinkEntities =
                    {
                        new LinkEntity
                        {
                            EntityAlias = "webfile",
                            LinkFromEntityName = "annotation",
                            LinkFromAttributeName = "objectid",
                            LinkToAttributeName = "adx_webfileid",
                            LinkToEntityName = "adx_webfile",
                            Columns = new ColumnSet("adx_websiteid", "adx_name"),
                            Orders = {new OrderExpression("adx_name", OrderType.Ascending)}
                        }
                    },
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("documentbody", ConditionOperator.NotNull),
                            new ConditionExpression("modifiedby", ConditionOperator.Equal, callingUserId)
                        },
                        Filters =
                        {
                            new FilterExpression(LogicalOperator.Or)
                            {
                                Conditions =
                                {
                                    new ConditionExpression("filename", ConditionOperator.EndsWith, "js"),
                                    new ConditionExpression("filename", ConditionOperator.EndsWith, "css")
                                }
                            }
                        }
                    }
                }).Entities;
            }
            else
            {
                records = service.RetrieveMultiple(new QueryExpression("annotation")
                {
                    ColumnSet = new ColumnSet("filename", "documentbody", "objectid", "modifiedon"),
                    LinkEntities =
                    {
                        new LinkEntity
                        {
                            EntityAlias = "webfile",
                            LinkFromEntityName = "annotation",
                            LinkFromAttributeName = "objectid",
                            LinkToAttributeName = "adx_webfileid",
                            LinkToEntityName = "adx_webfile",
                            Columns = new ColumnSet("adx_websiteid", "adx_name"),
                            Orders = {new OrderExpression("adx_name", OrderType.Ascending)}
                        }
                    },
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("documentbody", ConditionOperator.NotNull),
                        },
                            Filters =
                        {
                            new FilterExpression(LogicalOperator.Or)
                            {
                                Conditions =
                                {
                                    new ConditionExpression("filename", ConditionOperator.EndsWith, "js"),
                                    new ConditionExpression("filename", ConditionOperator.EndsWith, "css")
                                }
                            }
                        }
                    }
                }).Entities;
            }
            

            return records.Select(record => new WebFile(record))
                .ToList()
                .OrderByDescending(e => e.innerRecord.GetAttributeValue<DateTime>("modifiedon")).ToList()
                .GroupBy(e => e.innerRecord.GetAttributeValue<EntityReference>("objectid").Id.ToString()).ToList()
                .Select(g => g.First())
                .ToList();
        }

        public override string RefreshContent(CodeItem item, IOrganizationService service)
        {
            var record = service.Retrieve(innerRecord.LogicalName, innerRecord.Id,
               new ColumnSet("documentbody"));

            innerRecord.RowVersion = record.RowVersion;

            var data = Encoding.UTF8.GetString(Convert.FromBase64String(record.GetAttributeValue<string>("documentbody")));

            return data;
        }

        public override void Update(IOrganizationService service, bool forceUpdate = false)
        {
            innerRecord["documentbody"] = Code.EncodedContent;

            var recordToUpdate = new Entity(innerRecord.LogicalName)
            {
                Id = innerRecord.Id,
                RowVersion = innerRecord.RowVersion
            };
            recordToUpdate["documentbody"] = innerRecord["documentbody"];

            if (Code.Type == CodeItemType.Style)
            {
                recordToUpdate["mimetype"] = "text/css";
            }
            else if (Code.Type == CodeItemType.JavaScript)
            {
                recordToUpdate["mimetype"] = "application/javascript";
            }

            var updateRequest = new UpdateRequest
            {
                ConcurrencyBehavior = forceUpdate ? ConcurrencyBehavior.AlwaysOverwrite : ConcurrencyBehavior.IfRowVersionMatches,
                Target = recordToUpdate
            };

            service.Execute(updateRequest);

            var updatedRecord = service.Retrieve(innerRecord.LogicalName, innerRecord.Id, new ColumnSet());
            innerRecord.RowVersion = updatedRecord.RowVersion;

            Code.State = CodeItemState.None;
            HasPendingChanges = false;
        }

        /// <summary>
        /// Write the contents of the code object to disk
        /// </summary>
        /// <param name="path"></param>
        public override void WriteContent(string path, bool replaceExisting)
        {
            var filePath = Path.Combine(path, Name);

            Code?.WriteCodeItem(filePath, replaceExisting);
        }

        #endregion Methods
    }
}