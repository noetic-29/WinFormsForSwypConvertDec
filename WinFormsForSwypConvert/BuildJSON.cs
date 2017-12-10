using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KonVertObjs;
using Newtonsoft;
using Newtonsoft.Json;

namespace WinFormsForSwypConvert
{
    public partial class BuildJSON : Form
    {
        private int childFormNumber = 0;
        static frmKonVertUnit theFrmKonVertUnit = new frmKonVertUnit();
        static frmKonVersionGroup theFrmKonVersionGroup = new frmKonVersionGroup(theFrmKonVertUnit);
        public static frmKonVertSet theFrmKonVertSet = new frmKonVertSet(theFrmKonVersionGroup, theFrmKonVertUnit);
        static frmKonUserParams theFrmKonUserParams = new frmKonUserParams();
        static frmTestKonversion theFrmTestKonversion = new frmTestKonversion();
        static frmTimer theFrmTimer = new frmTimer();
        static frmAllTimers theFrmAllTimers = new frmAllTimers();

        public static int aStaticVal;

        public static String baseDirectory { get; set; }
        public static KonVertSet theKonVertSet { get; set; }
        public zTimerObj.zAllTimers thezAllTimers { get; set; }

        public BuildJSON()
        {
            InitializeComponent();
        }

        public static bool writeJSONObjectToFile(string aFileName, Object aKonVertObj)
        {
            try
            {
                string aStr = JsonConvert.SerializeObject(aKonVertObj, new JsonSerializerSettings()
                    {ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore }).ToString();
                string fullPath = baseDirectory + aFileName;
                File.WriteAllText(fullPath, aStr);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static string readJSONObjectFromFile(string aFileName)
        {
            try
            {
                return File.ReadAllText(aFileName);

            } catch (Exception e)
            {
                return "";
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            // Determine the active child form.
            Form activeChild = this.ActiveMdiChild;

            // If there is an active child form, find the active control, which
            // in this example should be a RichTextBox.
            if (activeChild != null)
            {
                try
                {
                    TextBox theBox = (TextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Put the selected text on the Clipboard.
                        Clipboard.SetDataObject(theBox.SelectedText);
                        theBox.SelectedText = "";
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            // Determine the active child form.
            Form activeChild = this.ActiveMdiChild;

            // If there is an active child form, find the active control, which
            // in this example should be a RichTextBox.
            if (activeChild != null)
            {
                try
                {
                    TextBox theBox = (TextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Put the selected text on the Clipboard.
                        Clipboard.SetDataObject(theBox.SelectedText);
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine the active child form.
            Form activeChild = this.ActiveMdiChild;

            // If there is an active child form, find the active control, which
            // in this example should be a RichTextBox.
            if (activeChild != null)
            {
                try
                {
                    TextBox theBox = (TextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectedText = Clipboard.GetText();
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void konVertUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theFrmKonVertUnit == null) theFrmKonVertUnit = new frmKonVertUnit();
            theFrmKonVertUnit.MdiParent = this;
            //myFrmKonVertUnit.Text = "Window " + childFormNumber++;
            theFrmKonVertUnit.Show();
            theFrmKonVertUnit.BringToFront();
        }

        private void konVersionGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (theFrmKonVersionGroup == null) theFrmKonVersionGroup = new frmKonVersionGroup();
            if (baseDirectory == null) setBaseDirectoryToolStripMenuItem_Click(sender, e);
            theFrmKonVersionGroup.MdiParent = this;
            //myFrmKonVersionGroup.Text = "Window " + childFormNumber++;
            theFrmKonVersionGroup.Show();
            theFrmKonVersionGroup.BringToFront();
        }

        private void konVertSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (theFrmKonVertSet == null) theFrmKonVertSet = new frmKonVertSet();
            if (baseDirectory == null) setBaseDirectoryToolStripMenuItem_Click(sender, e);
            theFrmKonVertSet.MdiParent = this;
            theFrmKonVertSet.myParent = this;
            //theFrmKonVertSet.Text = "Window " + childFormNumber++;
            theFrmKonVertSet.Show();
            theFrmKonVertSet.BringToFront();
        }

        private void konUserParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void konVertUserParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baseDirectory == null) setBaseDirectoryToolStripMenuItem_Click(sender, e);
            theFrmKonUserParams.MdiParent = this;
            theFrmKonUserParams.Show();
            theFrmKonUserParams.BringToFront();

        }

        private void testKonversionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baseDirectory == null) setBaseDirectoryToolStripMenuItem_Click(sender, e);
            theFrmTestKonversion.MdiParent = this;
            theFrmTestKonversion.Show();
            theFrmTestKonversion.BringToFront();
            theFrmTestKonversion.theKonVertSet = theKonVertSet;

        }

        private void timerValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baseDirectory == null) setBaseDirectoryToolStripMenuItem_Click(sender, e);
            theFrmAllTimers.MdiParent = this;
            theFrmAllTimers.Show();
            theFrmAllTimers.BringToFront();
        }

        private void setBaseDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgDir = new FolderBrowserDialog();
            DialogResult result = dlgDir.ShowDialog();
            baseDirectory = dlgDir.SelectedPath + "\\";
        }
    }
}
