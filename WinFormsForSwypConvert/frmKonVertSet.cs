/**
 * KONVERT Namespace objects
 * Copyright 2014 Noetic-29  All rights reserved
*/

//#define WINDOWSPHONE
#define WINDOWS

#if WINDOWSPHONE
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Xml;
using KonVert;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Windows.Storage;
using System.Threading.Tasks;
#elif WINDOWS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
//using KonVert;
using KonVertObjs;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using zTimerObj;
#endif


namespace WinFormsForSwypConvert
{
    public partial class frmKonVertSet : Form
    {
        public KonVertSet theKonVertSet;

        public BuildJSON myParent { get; set; }

        //public string baseDirectory = @"C:\ZwypConvertTraveler\Data\";
        //private KonFuncs myFuncs = new KonFuncs();
        static frmKonVersionGroup theGroupForm;
        static frmKonVertUnit theUnitForm;

        public frmKonVertSet(frmKonVersionGroup aGroupForm, frmKonVertUnit aUnitForm)
        {
            InitializeComponent();
            theGroupForm = aGroupForm;
            theUnitForm = aUnitForm;

            theGroupForm.OnUpdate += new EventHandler(GroupUpdate);
            //myParent = (BuildJSON)this.MdiParent;
            lblBaseDir.Text = BuildJSON.baseDirectory;

        }

        private void GroupUpdate(object sender, EventArgs e)
        {
            KonVersionGroup myGroup = null;
            int grpIndex = -1;

            myGroup = theGroupForm.theKonVersionGroup;
            foreach (KonVersionGroup aGroup in theKonVertSet.KonVersionGroups)
            {
                if (aGroup.myVersionGroupID == myGroup.myVersionGroupID)
                {
                    grpIndex = theKonVertSet.KonVersionGroups.IndexOf(aGroup);
                    theKonVertSet.KonVersionGroups.Remove(aGroup);
                    break;
                }
            }
            if (grpIndex == -1)
	        {
		        theKonVertSet.KonVersionGroups.Add(myGroup);
	        } else 
            {
                theKonVertSet.KonVersionGroups.Insert(grpIndex, myGroup);
            }
        }

        private void btnWriteJSONFile_Click(object sender, EventArgs e)
        {
            if (theKonVertSet == null) theKonVertSet = new KonVertSet(null);
            theKonVertSet.theSet = theKonVertSet;       // this is recursive but necesssary

            theKonVertSet.myZwypConvertName = txtSwypConvertName.Text;
            theKonVertSet.myZwypConvertRelease = txtRelease.Text;

            string fileName = theKonVertSet.myZwypConvertName + ".txt";
            theKonVertSet.anyError = null;
            //theKonVertSet.writeJsonFile(fileName);
            BuildJSON.writeJSONObjectToFile(fileName, theKonVertSet);

            if (theKonVertSet.anyError != null)
            //if (theKonVertSet.writeJsonFile(fileName) == false)
            {
                lblError.Text = "Error writing:" + fileName + ":" + theKonVertSet.anyError.ToString();
            }
            else
            {
                lblError.Text = "Write OK";
            }
        }

        private void btnReadJSONFile_Click(object sender, EventArgs e)
        {

            if (txtSwypConvertName.Text == "" || txtSwypConvertName.Text == null)
            {
                lblError.Text = "Must Enter UnitID";
                return;
            }

            if (theKonVertSet == null)
            {
                theKonVertSet = new KonVertSet(null);
                theKonVertSet.theSet = theKonVertSet;
            }

            string aFileName = BuildJSON.baseDirectory + txtSwypConvertName.Text + ".txt";
            theKonVertSet.anyError = null;
            //theKonVertSet.readJsonFile(aFileName);
            theKonVertSet = JsonConvert.DeserializeObject<KonVertSet>(BuildJSON.readJSONObjectFromFile(aFileName));
            if (theKonVertSet.anyError != null)
            //if (theKonVertSet.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading:" + aFileName + ":" + theKonVertSet.anyError.ToString();
                return;
            }

            // 2017-12-08 EIO make sure everyone knows the KonVertSet
            theKonVertSet.theSet = theKonVertSet;
            theKonVertSet.fixReferences();

            txtSwypConvertName.Text = theKonVertSet.myZwypConvertName;
            txtRelease.Text = theKonVertSet.myZwypConvertRelease;

            //NJtheKonVertSet.loadDynamicUserParams(BuildJSON.baseDirectory + "KonVertUserParams.txt");

            lbGroupList.Items.Clear();
            lbGroupKonversions.Items.Clear();
            foreach (KonVersionGroup aGroup in theKonVertSet.KonVersionGroups)
            {
                lbGroupList.Items.Add(aGroup.myVersionGroupID);
                if (aGroup.myLastKonVersion != null)
                {
                    lbGroupKonversions.Items.Add(aGroup.myLastKonVersion);
                }
                //lbGroupList.Items.Add(aGroup.myVersionGroupID + ":" + aGroup.myDisplayText);
            }

            lbPrevKonversions.Items.Clear();
            if (theKonVertSet.myKonVertUserParams != null)
            {
                foreach (KonVersion aKonv in theKonVertSet.myKonVertUserParams.previousKonversions)
                {
                    lbPrevKonversions.Items.Add(aKonv);
                }
            }
            lblError.Text = "Read OK";
            BuildJSON.theKonVertSet = theKonVertSet;

        }
        
        private void lbGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            KonVersionGroup myGroup = null;

            string selGroupID = lbGroupList.SelectedItem.ToString();

            foreach (KonVersionGroup aGroup in theKonVertSet.KonVersionGroups)
	        {
                if (aGroup.myVersionGroupID == selGroupID)
                {
                    myGroup = aGroup;
                    break;
                }
	        }

            if (myGroup != null)
            {
                // 2017-12-07 EIO take care of X of form
                theGroupForm = new frmKonVersionGroup(theUnitForm);
                theGroupForm.OnUpdate += new EventHandler(GroupUpdate);

                theGroupForm.setGroup(myGroup);
                theGroupForm.MdiParent = this.MdiParent;
                theGroupForm.BringToFront();
                theGroupForm.Show();
            } 
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "" || txtGroupName.Text == null)
            {
                lblError.Text = "Must Enter Group Name to Add";
                return;
            }

            KonVersionGroup myGroup = new KonVersionGroup(theKonVertSet.theSet);

            string aFileName = BuildJSON.baseDirectory + txtGroupName.Text + ".txt";
            myGroup.anyError = null;
            //myGroup.readJsonFile(aFileName);
            myGroup = JsonConvert.DeserializeObject<KonVersionGroup>(BuildJSON.readJSONObjectFromFile(aFileName));
            if (myGroup.anyError != null)
            //if (myGroup.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading: " + aFileName + ": " + myGroup.anyError.ToString();
                return;
            }

            if (theKonVertSet.contains(myGroup))
            {
                theKonVertSet.remove(myGroup);
            }

            theKonVertSet.KonVersionGroups.Add(myGroup);

            lbGroupList.Items.Clear();
            foreach (KonVersionGroup aGroup in theKonVertSet.KonVersionGroups)
            {
                lbGroupList.Items.Add(aGroup.myVersionGroupID);
                //lbGroupList.Items.Add(aGroup.myVersionGroupID + ":" + aGroup.myDisplayText);
            }
            lblError.Text = "Read OK";
            BuildJSON.theKonVertSet = theKonVertSet;

            //NJtheKonVertSet.loadDynamicUserParams(BuildJSON.baseDirectory + "KonVertUserParams.txt");
            txtGroupName.Text = "";

        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "" || txtGroupName.Text == null)
            {
                lblError.Text = "Must Enter Group Name to Remove";
                return;
            }

            KonVersionGroup myGroup = theKonVertSet.getKonVersionGroup(txtGroupName.Text);
            if (myGroup != null)
            {
                theKonVertSet.remove(myGroup);
            }

            lbGroupList.Items.Clear();
            foreach (KonVersionGroup aGroup in theKonVertSet.KonVersionGroups)
            {
                lbGroupList.Items.Add(aGroup.myVersionGroupID);
                //lbGroupList.Items.Add(aGroup.myVersionGroupID + ":" + aGroup.myDisplayText);
            }
            lblError.Text = "Read OK";
            BuildJSON.theKonVertSet = theKonVertSet;

            //NJtheKonVertSet.loadDynamicUserParams(BuildJSON.baseDirectory + "KonVertUserParams.txt");
            txtGroupName.Text = "";
        }

        private void btnReadUserParams_Click(object sender, EventArgs e)
        {
            KonVertUserParams myUParams = new KonVertUserParams(theKonVertSet.theSet);

            //NJmyUParams.readJsonFile(BuildJSON.baseDirectory + "KonVertUserParams.txt");
        }

        private void frmKonVertSet_Shown_1(object sender, EventArgs e)
        {
            lblBaseDir.Text = BuildJSON.baseDirectory;
        }

    }
}
