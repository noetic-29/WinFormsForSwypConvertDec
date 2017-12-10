using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zTimerObj;

namespace WinFormsForSwypConvert
{
    public partial class frmAllTimers : Form
    {
        //public String baseDirectory = "C:\\zTimer\\Data\\";
        public zAllTimers theAllTimers;
        public frmAllTimers()
        {
            InitializeComponent();
            theAllTimers = new zAllTimers();
        }

        static frmTimer theTimerForm = new frmTimer();

        private void btnReadJSONFile_Click(object sender, EventArgs e)
        {

            if (txtTimerSetID.Text == "" || txtTimerSetID.Text == null)
            {
                lblError.Text = "Must Enter TimerID";
                return;
            }

            if (theAllTimers == null)
            {
                theAllTimers = new zAllTimers();
            }

            string aFileName = BuildJSON.baseDirectory + txtTimerSetID.Text + ".txt";
            //string aFileName = baseDirectory + txtTimerSetID.Text + ".txt";
            theAllTimers.anyError = null;
            theAllTimers.readJsonFile(aFileName);
            if (theAllTimers.anyError != null)
            //if (theKonVertSet.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading:" + aFileName + ":" + theAllTimers.anyError.ToString();
                return;
            }

            loadForm();
            lblError.Text = "Read OK";
            //myParent.thezAllTimers = theAllTimers;

        }

        private void loadForm()
        {
            txtTimerSetID.Text = theAllTimers.allTimersID;
            txtDescription.Text = theAllTimers.allTimersDescription;
            txtRelease.Text = theAllTimers.allTimersRelease;
            txtGracePeriod.Text = theAllTimers.gracePeriodMills.ToString();
            txtVibrateIncrementMills.Text = theAllTimers.vibrateIncrementMills.ToString();

            cbAlwaysShowElapsedTime.Checked = theAllTimers.alwaysShowElapsedTime;
            cbFlashAtColorChange.Checked = theAllTimers.flashAtColorChange;
            cbShowDiagonalOnPause.Checked = theAllTimers.showDiagonalOnPause;
            cbSoundBellWhenOverGracePeriod.Checked = theAllTimers.soundBellWhenOverGracePeriod;
            cbVibrateAtColorChange.Checked = theAllTimers.vibrateAtColorChange;

            txtLastTimerID.Text = theAllTimers.lastTimerID;
            txtInitialTimerID.Text = theAllTimers.initialTimerID;

            lbTimerList.Items.Clear();
            foreach (zTimer aTimer in theAllTimers.allTimers)
            {
                lbTimerList.Items.Add(aTimer.timerID);
            }
        }
        
        private void btnWriteJSONFile_Click(object sender, EventArgs e)
        {
            readForm();

            string fileName = BuildJSON.baseDirectory + theAllTimers.allTimersID + ".txt";
            theAllTimers.anyError = null;
            theAllTimers.writeJsonFile(fileName);
            if (theAllTimers.anyError != null)
            {
                lblError.Text = "Error writing:" + fileName + ":" + theAllTimers.anyError.ToString();
            }
            else
            {
                lblError.Text = "Write OK";
            }
        }

        private void readForm()
        {
            if (theAllTimers == null) theAllTimers = new zAllTimers();

            theAllTimers.allTimersID = txtTimerSetID.Text;
            theAllTimers.allTimersDescription = txtDescription.Text;
            theAllTimers.allTimersRelease = txtRelease.Text;

            theAllTimers.gracePeriodMills = getATimerValue(txtGracePeriod);
            theAllTimers.vibrateIncrementMills = getATimerValue(txtVibrateIncrementMills);

            theAllTimers.alwaysShowElapsedTime = cbAlwaysShowElapsedTime.Checked;
            theAllTimers.showDiagonalOnPause = cbShowDiagonalOnPause.Checked;
            theAllTimers.soundBellWhenOverGracePeriod = cbSoundBellWhenOverGracePeriod.Checked;
            theAllTimers.flashAtColorChange = cbFlashAtColorChange.Checked;
            theAllTimers.vibrateAtColorChange = cbVibrateAtColorChange.Checked;

            theAllTimers.lastTimerID = txtLastTimerID.Text;
            theAllTimers.initialTimerID = txtInitialTimerID.Text;

        }

        private long getATimerValue(TextBox aTxtBox)
        {
            long retVal;
            try
            {
                retVal = Int64.Parse(aTxtBox.Text);
            }
            catch
            {
                retVal = 0;
            }
            return retVal;
        }

        private void txtTimerSetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTimerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            zTimer myZTimer = null;

            if (lbTimerList.SelectedIndex > -1)
            {
                string selTimeID = lbTimerList.SelectedItem.ToString();

                foreach (zTimer aZTimer in theAllTimers.allTimers)
                {
                    if (aZTimer.timerID == selTimeID)
                    {
                        myZTimer = aZTimer;
                        break;
                    }
                }
            }

            if (myZTimer != null)
            {
                theTimerForm.setTimer(myZTimer);
                //theTimerForm.baseDirectory = BuildJSON.baseDirectory;
                theTimerForm.MdiParent = this.MdiParent;
                theTimerForm.BringToFront();
                theTimerForm.Show();
            }
        }

        private void btnNewTimer_Click(object sender, EventArgs e)
        {
            zTimer myZTimer = new zTimer();
            myZTimer.timerID = txtTimerName.Text;
            //theTimerForm.baseDirectory = BuildJSON.baseDirectory;
            theTimerForm.setTimer(myZTimer);
            theTimerForm.MdiParent = this.MdiParent;
            theTimerForm.BringToFront();
            theTimerForm.Show();

        }

        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            if (txtTimerName.Text == "" || txtTimerName.Text == null)
            {
                lblError.Text = "Must Enter Group Name to Add";
                return;
            }

            zTimer myTimer = new zTimer();

            string aFileName = BuildJSON.baseDirectory + txtTimerName.Text + ".txt";
            myTimer.anyError = null;
            myTimer.readJsonFile(aFileName);
            if (myTimer.anyError != null)
            //if (myGroup.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading: " + aFileName + ": " + myTimer.anyError.ToString();
                return;
            }

            if (theAllTimers == null) theAllTimers = new zAllTimers();

            theAllTimers.add(myTimer);          // does the remove then add 

            lbTimerList.Items.Clear();
            foreach (zTimer aTimer in theAllTimers.allTimers)
            {
                lbTimerList.Items.Add(aTimer.timerID);
            }
            lblError.Text = "Add OK";
            txtTimerName.Text = "";
        }

        private void btnRemoveTimer_Click(object sender, EventArgs e)
        {
            if (txtTimerName.Text == "" || txtTimerName.Text == null)
            {
                lblError.Text = "Must Enter Group Name to Add";
                return;
            }

            zTimer myTimer = new zTimer();
            myTimer.timerID = txtTimerName.Text;
            theAllTimers.remove(myTimer);

            lbTimerList.Items.Clear();
            foreach (zTimer aTimer in theAllTimers.allTimers)
            {
                lbTimerList.Items.Add(aTimer.timerID);
            }
            lblError.Text = "Remove OK";
            txtTimerName.Text = "";
        }

        private void frmAllTimers_Load(object sender, EventArgs e)
        {
            lblBaseDir.Text = BuildJSON.baseDirectory;
        }

    }
}
