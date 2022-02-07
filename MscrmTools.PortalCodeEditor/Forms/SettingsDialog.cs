using System;
using System.Drawing;
using System.Windows.Forms;

namespace MscrmTools.PortalCodeEditor.Forms
{
    public partial class SettingsDialog : Form
    {
        private readonly Settings mySettings;

        public SettingsDialog(Settings mySettings)
        {
            InitializeComponent();

            this.mySettings = mySettings;

            var tagColor = string.IsNullOrEmpty(mySettings.LiquidTagColor) ? "#FF0000" : mySettings.LiquidTagColor;
            var objectColor = string.IsNullOrEmpty(mySettings.LiquidObjectColor) ? "#FFA500" : mySettings.LiquidObjectColor;

            pnlLiquidTag.BackColor = Color.FromArgb(30, ColorTranslator.FromHtml(tagColor));
            pnlLiquidObject.BackColor = Color.FromArgb(30, ColorTranslator.FromHtml(objectColor));

            txtDefaultExportLocation.Text = mySettings.DefaultExportLocation;
            chkOnlyExportItemsModifiedByMe.Checked = mySettings.OnlyExportItemsModifiedByMe;
            chkDoNotPackageExportInWebsiteFolder.Checked = mySettings.DoNotPackageExportInWebsiteFolder;
            chkReplaceExistingFiles.Checked = mySettings.ReplaceExistingFiles;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            mySettings.ForceUpdate = chkForceUpdate.Checked;
            mySettings.ObfuscateJavascript = chkObfuscateJavaScript.Checked;
            mySettings.RemoveCssComments = chkStyleRemoveComments.Checked;
            mySettings.LiquidTagColor = ColorTranslator.ToHtml(pnlLiquidTag.BackColor);
            mySettings.LiquidObjectColor = ColorTranslator.ToHtml(pnlLiquidObject.BackColor);
            mySettings.DefaultExportLocation = txtDefaultExportLocation.Text;
            mySettings.DoNotPackageExportInWebsiteFolder = chkDoNotPackageExportInWebsiteFolder.Checked;
            mySettings.OnlyExportItemsModifiedByMe = chkOnlyExportItemsModifiedByMe.Checked;
            mySettings.ReplaceExistingFiles = chkReplaceExistingFiles.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            chkForceUpdate.Checked = mySettings.ForceUpdate;
            chkObfuscateJavaScript.Checked = mySettings.ObfuscateJavascript;
            chkStyleRemoveComments.Checked = mySettings.RemoveCssComments;
        }

        private void btnLiquidTag_Click(object sender, EventArgs e)
        {
            PickColor(pnlLiquidTag);
        }

        private void btnLiquidObject_Click(object sender, EventArgs e)
        {
            PickColor(pnlLiquidObject);
        }

        private void PickColor(Panel sourcePanel)
        {
            colorDialog.Color = sourcePanel.BackColor;

            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                sourcePanel.BackColor = Color.FromArgb(30, colorDialog.Color);
            }
        }

        private void btnChooseExportFolder_Click(object sender, EventArgs e)
        {
            if (fldrBrowser.ShowDialog(this) == DialogResult.OK)
            {
                txtDefaultExportLocation.Text = fldrBrowser.SelectedPath;
            }
        }
    }
}