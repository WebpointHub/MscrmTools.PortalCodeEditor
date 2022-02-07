﻿using System.Windows.Forms;

namespace MscrmTools.PortalCodeEditor.Forms
{
    public partial class ExportOptions : Form
    {
        private Settings defaultSettings;

        public ExportOptions(Settings settings)
        {
            InitializeComponent();

            defaultSettings = settings;

            //set default settings for export
            ExportFolder = settings.DefaultExportLocation;
            chkOnlyExportItemsModifiedByMe.Checked = settings.OnlyExportItemsModifiedByMe;
            chkDoNotPackageItemsInWebsiteFolder.Checked = settings.DoNotPackageExportInWebsiteFolder;
            chkReplaceExistingFiles.Checked = settings.ReplaceExistingFiles;
        }

        public bool ClearFolderBeforeExport { get => chkClearItems.Checked; set => chkClearItems.Checked = value; }

        public string ExportFolder
        {
            get => txtExportFolder.Text;
            set
            {
                txtExportFolder.Text = value;
                fldrBrowser.SelectedPath = value;
                btnValidate.Enabled = !(string.IsNullOrEmpty(ExportFolder));
            }
        }

        public bool OnlyExportItemsModifiedByMe { get => chkOnlyExportItemsModifiedByMe.Checked; }
        public bool DoNotPackageItemsInWebsiteFolder { get => chkDoNotPackageItemsInWebsiteFolder.Checked; }
        public bool ReplaceExistingFiles { get => chkReplaceExistingFiles.Checked; }
        public bool SearchContents { get => chkSearchInContent.Checked; set => chkSearchInContent.Checked = value; }
        public string SearchText { get => txtSearch.Text; set => txtSearch.Text = value; }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnValidate_Click(object sender, System.EventArgs e)
        {
            if (chkClearItems.Checked)
            {
                if (DialogResult.Yes != MessageBox.Show(this,
                    "You have selected 'Clear Export Folder before Export'. " +
                    "This will delete all contents within the selected folder.  Are you sure you would like to delete all files and folders?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lnkChooseExportFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fldrBrowser.ShowDialog(this) == DialogResult.OK)
            {
                ExportFolder = fldrBrowser.SelectedPath;
            }
        }
    }
}