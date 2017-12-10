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
    public partial class frmTimer : Form
    {
        public zTimer theTimer;
        //public String baseDirectory { get; set; }

        public frmTimer()
        {
            InitializeComponent();
        }

        public void setTimer(zTimer aTimer)
        {
            theTimer = aTimer;
            if (theTimer == null) theTimer = new zTimer();
            loadTimerValues(theTimer);
        }

        private void loadTimerValues(zTimer aTimer)
        {
            txtTimerID.Text = aTimer.timerID;
            txtDescription.Text = aTimer.timerDescription;

            txtInterval.Text = aTimer.timerInterval.ToString();
            txtTotalTime.Text = aTimer.totalMills.ToString();
            txtBodyTime.Text = aTimer.bodyMills.ToString();
            txtCloseTime.Text = aTimer.closeMills.ToString();
            txtFinalTime.Text = aTimer.finalMills.ToString();
            txtStopTime.Text = aTimer.stopMills.ToString();
        }

        private void clearTimerValues()
        {
            txtTimerID.Text = "";
            txtDescription.Text = "";
            txtInterval.Text = "";
            txtTotalTime.Text = "";
            txtBodyTime.Text = "";
            txtCloseTime.Text = "";
            txtFinalTime.Text = "";
            txtStopTime.Text = "";
        }

        private void getTimerValues()
        {
            if (theTimer == null) theTimer = new zTimer();

            theTimer.timerID = txtTimerID.Text;
            theTimer.timerDescription = txtDescription.Text;
            theTimer.timerInterval = getATimerValue(txtInterval);
            theTimer.totalMills = getATimerValue(txtTotalTime);
            theTimer.bodyMills = getATimerValue(txtBodyTime);
            theTimer.closeMills = getATimerValue(txtCloseTime);
            theTimer.finalMills = getATimerValue(txtFinalTime);
            theTimer.stopMills = getATimerValue(txtStopTime);
        }

        private long getATimerValue(TextBox aTxtBox) {
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

        private void btnWriteJSONFile_Click(object sender, EventArgs e)
        {
            getTimerValues();

            string fileName = BuildJSON.baseDirectory + theTimer.timerID + ".txt";
            theTimer.anyError = null;
            theTimer.writeJsonFile(fileName);
            if (theTimer.anyError != null)
            //if (theKonVertSet.writeJsonFile(fileName) == false)
            {
                lblError.Text = "Error writing:" + fileName + ":" + theTimer.anyError.ToString();
            }
            else
            {
                lblError.Text = "Write OK";
            }
        }

        public void btnReadJSONFile_Click(object sender, EventArgs e)
        {
            if (txtTimerID.Text == "" || txtTimerID.Text == null)
            {
                lblError.Text = "Must Enter TimerID";
                return;
            }

            if (theTimer == null)
            {
                theTimer = new zTimer();
            }

            string aFileName = BuildJSON.baseDirectory + txtTimerID.Text + ".txt";
            theTimer.anyError = null;
            theTimer.readJsonFile(aFileName);
            if (theTimer.anyError != null)
            //if (theKonVertSet.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading:" + aFileName + ":" + theTimer.anyError.ToString();
                return;
            }
            loadTimerValues(theTimer);
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            //lblBaseDir.Text = BuildJSON.baseDirectory;
        }

    }
}
