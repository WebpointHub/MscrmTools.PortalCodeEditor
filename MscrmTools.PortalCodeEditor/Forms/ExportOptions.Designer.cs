namespace MscrmTools.PortalCodeEditor.Forms
{
    partial class ExportOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelExportOptions = new System.Windows.Forms.Panel();
            this.labelExportOptsDetails = new System.Windows.Forms.Label();
            this.labelExportOptions = new System.Windows.Forms.Label();
            this.panelExportOptionsButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pnlSearchOptions = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.chkSearchInContent = new System.Windows.Forms.CheckBox();
            this.panelExportFolder = new System.Windows.Forms.Panel();
            this.txtExportFolder = new System.Windows.Forms.TextBox();
            this.lnkChooseExportFolder = new System.Windows.Forms.LinkLabel();
            this.fldrBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.chkClearItems = new System.Windows.Forms.CheckBox();
            this.chkOnlyExportItemsModifiedByMe = new System.Windows.Forms.CheckBox();
            this.chkDoNotPackageItemsInWebsiteFolder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkReplaceExistingFiles = new System.Windows.Forms.CheckBox();
            this.panelExportOptions.SuspendLayout();
            this.panelExportOptionsButtons.SuspendLayout();
            this.pnlSearchOptions.SuspendLayout();
            this.panelExportFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExportOptions
            // 
            this.panelExportOptions.BackColor = System.Drawing.Color.White;
            this.panelExportOptions.Controls.Add(this.labelExportOptsDetails);
            this.panelExportOptions.Controls.Add(this.labelExportOptions);
            this.panelExportOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExportOptions.Location = new System.Drawing.Point(0, 0);
            this.panelExportOptions.Name = "panelExportOptions";
            this.panelExportOptions.Size = new System.Drawing.Size(569, 66);
            this.panelExportOptions.TabIndex = 11;
            // 
            // labelExportOptsDetails
            // 
            this.labelExportOptsDetails.Location = new System.Drawing.Point(16, 32);
            this.labelExportOptsDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExportOptsDetails.Name = "labelExportOptsDetails";
            this.labelExportOptsDetails.Size = new System.Drawing.Size(394, 29);
            this.labelExportOptsDetails.TabIndex = 1;
            this.labelExportOptsDetails.Text = "The export folder structure will match the structure in the treeview.  Only items" +
    " with Content will be exported.";
            // 
            // labelExportOptions
            // 
            this.labelExportOptions.AutoSize = true;
            this.labelExportOptions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportOptions.Location = new System.Drawing.Point(12, 3);
            this.labelExportOptions.Name = "labelExportOptions";
            this.labelExportOptions.Size = new System.Drawing.Size(219, 25);
            this.labelExportOptions.TabIndex = 0;
            this.labelExportOptions.Text = "Export Portal Code Items";
            // 
            // panelExportOptionsButtons
            // 
            this.panelExportOptionsButtons.Controls.Add(this.btnCancel);
            this.panelExportOptionsButtons.Controls.Add(this.btnValidate);
            this.panelExportOptionsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExportOptionsButtons.Location = new System.Drawing.Point(0, 242);
            this.panelExportOptionsButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelExportOptionsButtons.Name = "panelExportOptionsButtons";
            this.panelExportOptionsButtons.Size = new System.Drawing.Size(569, 40);
            this.panelExportOptionsButtons.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(488, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(405, 6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "OK";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // pnlSearchOptions
            // 
            this.pnlSearchOptions.Controls.Add(this.txtSearch);
            this.pnlSearchOptions.Controls.Add(this.lblSearch);
            this.pnlSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchOptions.Location = new System.Drawing.Point(0, 117);
            this.pnlSearchOptions.Name = "pnlSearchOptions";
            this.pnlSearchOptions.Size = new System.Drawing.Size(569, 21);
            this.pnlSearchOptions.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(79, 1);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(488, 20);
            this.txtSearch.TabIndex = 95;
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblSearch.Size = new System.Drawing.Size(73, 21);
            this.lblSearch.TabIndex = 93;
            this.lblSearch.Text = "Search Text";
            // 
            // chkSearchInContent
            // 
            this.chkSearchInContent.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkSearchInContent.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.chkSearchInContent.Location = new System.Drawing.Point(8, 142);
            this.chkSearchInContent.Name = "chkSearchInContent";
            this.chkSearchInContent.Size = new System.Drawing.Size(147, 27);
            this.chkSearchInContent.TabIndex = 94;
            this.chkSearchInContent.Text = "Search In Content";
            // 
            // panelExportFolder
            // 
            this.panelExportFolder.Controls.Add(this.txtExportFolder);
            this.panelExportFolder.Controls.Add(this.lnkChooseExportFolder);
            this.panelExportFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExportFolder.Location = new System.Drawing.Point(0, 66);
            this.panelExportFolder.Margin = new System.Windows.Forms.Padding(2);
            this.panelExportFolder.Name = "panelExportFolder";
            this.panelExportFolder.Size = new System.Drawing.Size(569, 51);
            this.panelExportFolder.TabIndex = 18;
            // 
            // txtExportFolder
            // 
            this.txtExportFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExportFolder.Location = new System.Drawing.Point(122, 11);
            this.txtExportFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtExportFolder.Multiline = true;
            this.txtExportFolder.Name = "txtExportFolder";
            this.txtExportFolder.ReadOnly = true;
            this.txtExportFolder.Size = new System.Drawing.Size(300, 35);
            this.txtExportFolder.TabIndex = 2;
            // 
            // lnkChooseExportFolder
            // 
            this.lnkChooseExportFolder.AutoSize = true;
            this.lnkChooseExportFolder.Location = new System.Drawing.Point(8, 11);
            this.lnkChooseExportFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkChooseExportFolder.Name = "lnkChooseExportFolder";
            this.lnkChooseExportFolder.Size = new System.Drawing.Size(108, 13);
            this.lnkChooseExportFolder.TabIndex = 1;
            this.lnkChooseExportFolder.TabStop = true;
            this.lnkChooseExportFolder.Text = "Choose Export Folder";
            this.lnkChooseExportFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChooseExportFolder_LinkClicked);
            // 
            // chkClearItems
            // 
            this.chkClearItems.Location = new System.Drawing.Point(8, 165);
            this.chkClearItems.Margin = new System.Windows.Forms.Padding(2);
            this.chkClearItems.Name = "chkClearItems";
            this.chkClearItems.Size = new System.Drawing.Size(194, 27);
            this.chkClearItems.TabIndex = 19;
            this.chkClearItems.Text = "Clear Export Folder before Export?";
            this.chkClearItems.UseVisualStyleBackColor = true;
            // 
            // chkOnlyExportItemsModifiedByMe
            // 
            this.chkOnlyExportItemsModifiedByMe.Location = new System.Drawing.Point(212, 142);
            this.chkOnlyExportItemsModifiedByMe.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnlyExportItemsModifiedByMe.Name = "chkOnlyExportItemsModifiedByMe";
            this.chkOnlyExportItemsModifiedByMe.Size = new System.Drawing.Size(194, 27);
            this.chkOnlyExportItemsModifiedByMe.TabIndex = 95;
            this.chkOnlyExportItemsModifiedByMe.Text = "Only Export Items Modified by Me";
            this.chkOnlyExportItemsModifiedByMe.UseVisualStyleBackColor = true;
            // 
            // chkDoNotPackageItemsInWebsiteFolder
            // 
            this.chkDoNotPackageItemsInWebsiteFolder.Location = new System.Drawing.Point(212, 165);
            this.chkDoNotPackageItemsInWebsiteFolder.Margin = new System.Windows.Forms.Padding(2);
            this.chkDoNotPackageItemsInWebsiteFolder.Name = "chkDoNotPackageItemsInWebsiteFolder";
            this.chkDoNotPackageItemsInWebsiteFolder.Size = new System.Drawing.Size(214, 27);
            this.chkDoNotPackageItemsInWebsiteFolder.TabIndex = 96;
            this.chkDoNotPackageItemsInWebsiteFolder.Text = "Do not Packge Items in Website Folder";
            this.chkDoNotPackageItemsInWebsiteFolder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "(Only use this setting when targeted environment has 1 website)";
            // 
            // chkReplaceExistingFiles
            // 
            this.chkReplaceExistingFiles.Location = new System.Drawing.Point(212, 209);
            this.chkReplaceExistingFiles.Margin = new System.Windows.Forms.Padding(2);
            this.chkReplaceExistingFiles.Name = "chkReplaceExistingFiles";
            this.chkReplaceExistingFiles.Size = new System.Drawing.Size(214, 27);
            this.chkReplaceExistingFiles.TabIndex = 98;
            this.chkReplaceExistingFiles.Text = "Replace Existing Files";
            this.chkReplaceExistingFiles.UseVisualStyleBackColor = true;
            // 
            // ExportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.chkReplaceExistingFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkDoNotPackageItemsInWebsiteFolder);
            this.Controls.Add(this.chkOnlyExportItemsModifiedByMe);
            this.Controls.Add(this.chkSearchInContent);
            this.Controls.Add(this.chkClearItems);
            this.Controls.Add(this.pnlSearchOptions);
            this.Controls.Add(this.panelExportOptionsButtons);
            this.Controls.Add(this.panelExportFolder);
            this.Controls.Add(this.panelExportOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExportOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelExportOptions.ResumeLayout(false);
            this.panelExportOptions.PerformLayout();
            this.panelExportOptionsButtons.ResumeLayout(false);
            this.pnlSearchOptions.ResumeLayout(false);
            this.pnlSearchOptions.PerformLayout();
            this.panelExportFolder.ResumeLayout(false);
            this.panelExportFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelExportOptions;
        private System.Windows.Forms.Label labelExportOptions;
        private System.Windows.Forms.Panel panelExportOptionsButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Panel pnlSearchOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkSearchInContent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelExportFolder;
        private System.Windows.Forms.LinkLabel lnkChooseExportFolder;
        private System.Windows.Forms.FolderBrowserDialog fldrBrowser;
        private System.Windows.Forms.CheckBox chkClearItems;
        private System.Windows.Forms.TextBox txtExportFolder;
        private System.Windows.Forms.Label labelExportOptsDetails;
        private System.Windows.Forms.CheckBox chkOnlyExportItemsModifiedByMe;
        private System.Windows.Forms.CheckBox chkDoNotPackageItemsInWebsiteFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkReplaceExistingFiles;
    }
}