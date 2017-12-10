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
#endif

namespace WinFormsForSwypConvert
{
    public partial class frmKonVersionGroup : Form
    {
        //private string baseDirectory = @"C:\ZwypConvert\Data\";
        //private KonFuncs myFuncs = new KonFuncs();
        public KonVersionGroup theKonVersionGroup;
        static frmKonVertUnit theUnitForm;

        public event EventHandler OnUpdate;

        public frmKonVersionGroup(frmKonVertUnit aUnitForm)
        {
            InitializeComponent();
            theUnitForm = aUnitForm;

            theUnitForm.OnUpdate += new EventHandler(UnitUpdate);
        }

        public void setGroup(KonVersionGroup aGroup)
        {
            theKonVersionGroup = aGroup;
            fillInForm();
        }

        private void UnitUpdate(object sender, EventArgs e)
        {
            KonVertUnit myUnit = null;
            int grpIndex = -1;

            myUnit = theUnitForm.theKonVertUnit;
            foreach (KonVertUnit aUnit in theKonVersionGroup.konVertUnits)
            {
                if (aUnit.myVersionUnitID == myUnit.myVersionUnitID)
                {
                    grpIndex = theKonVersionGroup.konVertUnits.IndexOf(aUnit);
                    theKonVersionGroup.konVertUnits.Remove(aUnit);
                    break;
                }
            }
            if (grpIndex == -1)
            {
                theKonVersionGroup.konVertUnits.Add(myUnit);
            }
            else
            {
                theKonVersionGroup.konVertUnits.Insert(grpIndex, myUnit);
            }
        }

        private void btnWriteJSONFile_Click(object sender, EventArgs e)
        {
            loadFromForm();

            string fileName = BuildJSON.baseDirectory + theKonVersionGroup.myVersionGroupID + ".txt";
            theKonVersionGroup.anyError = null;
            //theKonVersionGroup.writeJsonFile(fileName);
            BuildJSON.writeJSONObjectToFile(fileName, theKonVersionGroup);

            if (theKonVersionGroup.anyError != null)
            //if (theKonVersionGroup.writeJsonFile(fileName) == false)
            {
                lblError.Text = "Error writing " + fileName + ":" + theKonVersionGroup.anyError.ToString();
            }
            else
            {
                lblError.Text = "Write OK";
            }
        }

        private void btnReadJSONFile_Click(object sender, EventArgs e)
        {

            if (txtGroupID.Text == "" || txtGroupID.Text == null)
            {
                lblError.Text = "Must Enter GroupID";
                return;
            }

            if (theKonVersionGroup == null)
            {
                theKonVersionGroup = new KonVersionGroup(BuildJSON.theKonVertSet);
            }

            string aFileName = BuildJSON.baseDirectory + txtGroupID.Text + ".txt";
            theKonVersionGroup.anyError = null;
            theKonVersionGroup = JsonConvert.DeserializeObject<KonVersionGroup>(BuildJSON.readJSONObjectFromFile(aFileName));
            //theKonVersionGroup.readJsonFile(aFileName);
            if (theKonVersionGroup.anyError != null)
            //if (theKonVersionGroup.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading:" + aFileName + ":" + theKonVersionGroup.anyError.ToString();
                return;
            }

            fillInForm();
            
            lblError.Text = "Read OK";
        }

        private void fillInForm()
        {
            lblError.Text = "";

            txtGroupID.Text = theKonVersionGroup.myVersionGroupID;
            txtLongDisplay.Text = theKonVersionGroup.myDisplayText;
            txtShortDisplay.Text = theKonVersionGroup.myDisplayTextShort;
            txtToolTip.Text = theKonVersionGroup.myToolTip;
            txtDefaultLeftUnitID.Text = theKonVersionGroup.myDefaultUnitLeftID;
            txtDefaultRightUnitID.Text = theKonVersionGroup.myDefaultUnitRightID;
            txtBaseUnitID.Text = theKonVersionGroup.myBaseUnitID;
            txtGroupListOrder.Text = theKonVersionGroup.myGroupListOrder.ToString();
            txtMaxDigits.Text = theKonVersionGroup.myMaxDigits.ToString();
            txtMaxDecPlace.Text = theKonVersionGroup.myDecimals.ToString();
            cbDoPrettyPrint.Checked = theKonVersionGroup.myDoPrettyPrint;
            txtValueEntryPrompt.Text = theKonVersionGroup.ValueEntryPrompt;
            txtUnitEntryPrompt.Text = theKonVersionGroup.UnitEntryPrompt;
            // 2014-10-28 EIO add appApply
            String bldStr = null;
            foreach (String anAppType in theKonVersionGroup.AppApplys)
            {
                switch (anAppType.ToLower())
                {
                    case "free":
                        cbFree.Checked = true;
                        break;
                    case "paid":
                        cbPaid.Checked = true;
                        break;
                    case "traveler":
                        cbTraveler.Checked = true;
                        break;
                    case "travelerpro":
                        cbTravelerPro.Checked = true;
                        break;
                    default:
                        cbFree.Checked = true;
                        break;
                }
                //if (bldStr != null) bldStr = bldStr + ",";
                //bldStr = bldStr + anAppType;
            }
            //txtAppApply.Text = bldStr;

            if (theKonVersionGroup.myLastKonVersion != null)
            {
                txtKonverionsLeftID.Text = theKonVersionGroup.myLastKonVersion.myVertUnitLeftID;
                txtKonversionRightID.Text = theKonVersionGroup.myLastKonVersion.myVertUnitRightID;
                txtLeftKonversionNum.Text = theKonVersionGroup.myLastKonVersion.myLeftNumber.ToString();
                txtRightKonversionNum.Text = theKonVersionGroup.myLastKonVersion.myRightNumber.ToString();
            }
            else
            {
                txtKonverionsLeftID.Text = "";
                txtKonversionRightID.Text = "";
                txtLeftKonversionNum.Text = 0.ToString();
                txtRightKonversionNum.Text = 0.ToString();
            }

            lbUnits.Items.Clear();
            foreach (KonVertUnit aUnit in theKonVersionGroup.konVertUnits)
            {
                lbUnits.Items.Add(aUnit.myVersionUnitID);
            }
            if (theKonVersionGroup.GroupDynamics != null)
            {
                tbLastFile.Text = theKonVersionGroup.GroupDynamics.DynamicLastFile;
                tbSourceLocation.Text = theKonVersionGroup.GroupDynamics.DynamicSourceLoc;
                tbSourceName.Text = theKonVersionGroup.GroupDynamics.DynamicType;
                tbSourceType.Text = theKonVersionGroup.GroupDynamics.SourceType;
                tbUpdateDate.Text = theKonVersionGroup.GroupDynamics.UpdateDate.ToLongDateString();
            }
            else
            {
                tbLastFile.Text = "";
                tbSourceLocation.Text = "";
                tbSourceName.Text = "";
                tbSourceType.Text = "";
                tbUpdateDate.Text = "";
            }
        }

        private void loadFromForm()
        {
            Decimal tmpNumb;

            if (theKonVersionGroup == null)
            {
                theKonVersionGroup = new KonVersionGroup(BuildJSON.theKonVertSet);
            }

            theKonVersionGroup.myVersionGroupID = txtGroupID.Text;
            theKonVersionGroup.myDisplayText = txtLongDisplay.Text;
            theKonVersionGroup.myDisplayTextShort = txtShortDisplay.Text;

            theKonVersionGroup.myToolTip = txtToolTip.Text;
            theKonVersionGroup.myDefaultUnitLeftID = txtDefaultLeftUnitID.Text;
            theKonVersionGroup.myDefaultUnitRightID = txtDefaultRightUnitID.Text;
            theKonVersionGroup.myBaseUnitID = txtBaseUnitID.Text;
            theKonVersionGroup.myGroupListOrder = int.Parse(txtGroupListOrder.Text);
            theKonVersionGroup.myMaxDigits = int.Parse(txtMaxDigits.Text);
            theKonVersionGroup.myDecimals = int.Parse(txtMaxDecPlace.Text);
            theKonVersionGroup.myDoPrettyPrint = cbDoPrettyPrint.Checked;
            theKonVersionGroup.ValueEntryPrompt = txtValueEntryPrompt.Text;
            theKonVersionGroup.UnitEntryPrompt = txtUnitEntryPrompt.Text;

            List<String> myAppApplys = new List<String>();
            if (cbFree.Checked) myAppApplys.Add("free");
            if (cbPaid.Checked) myAppApplys.Add("paid");
            if (cbTraveler.Checked) myAppApplys.Add("traveler");
            if (cbTravelerPro.Checked) myAppApplys.Add("travelerpro");
            if (myAppApplys.Count == 0) myAppApplys.Add("free");
/*
            if (txtAppApply.Text == "") {
                myAppApplys.Add("free");
            } else {
                String bldStr = txtAppApply.Text;
                int i = bldStr.IndexOf(",");
                while (i >= 0) {
                    String str = bldStr.Substring(0, i);
                    myAppApplys.Add(str);
                    if (i + 1 < bldStr.Length) {
                        bldStr = bldStr.Substring(i + 1);
                        i = bldStr.IndexOf(",");
                    } else {
                        i = -1;
                        bldStr = "";
                    }
                }
                if (bldStr != "") myAppApplys.Add(bldStr);
            }
*/
            theKonVersionGroup.AppApplys = myAppApplys;

            if (txtKonverionsLeftID.Text == "")
            {
                theKonVersionGroup.myLastKonVersion = null;
            }
            else
            {
                KonVersion myLastKonversion = new KonVersion(BuildJSON.theKonVertSet);
                myLastKonversion.myVersionGroupID = theKonVersionGroup.myVersionGroupID;
                myLastKonversion.myVertUnitLeftID = txtKonverionsLeftID.Text;
                myLastKonversion.myVertUnitRightID = txtKonversionRightID.Text;
                tmpNumb = decimal.Parse(txtLeftKonversionNum.Text);
                myLastKonversion.myLeftNumber = tmpNumb;
                tmpNumb = decimal.Parse(txtRightKonversionNum.Text);
                myLastKonversion.myRightNumber = tmpNumb;

                theKonVersionGroup.myLastKonVersion = myLastKonversion;
            }

            if (tbSourceName.Text != "")
            {
                KonVersionGroupDynamic myGroupDynamic = new KonVersionGroupDynamic(BuildJSON.theKonVertSet);
                myGroupDynamic.DynamicLastFile = tbLastFile.Text;
                myGroupDynamic.DynamicSourceLoc = tbSourceLocation.Text;
                myGroupDynamic.DynamicType = tbSourceName.Text;
                myGroupDynamic.SourceType = tbSourceType.Text;
                myGroupDynamic.UpdateDate = DateTime.Parse(tbUpdateDate.Text);
                theKonVersionGroup.GroupDynamics = myGroupDynamic;
            }
        }

        private void lbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            KonVertUnit myKonVertUnit = null;

            foreach (KonVertUnit aUnit in theKonVersionGroup.konVertUnits)
            {
                if (aUnit.myVersionUnitID == (string)lbUnits.SelectedItem)
                {
                    myKonVertUnit = aUnit;
                    break;
                }
            }

            if (myKonVertUnit != null)
            {
                theUnitForm.setUnit(myKonVertUnit);
                theUnitForm.MdiParent = this.MdiParent;
                theUnitForm.BringToFront();
                theUnitForm.Show();
            }
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            loadFromForm();
            OnUpdate(this, EventArgs.Empty);
        }

        private void btnClearGroup_Click(object sender, EventArgs e)
        {
            theKonVersionGroup = new KonVersionGroup(BuildJSON.theKonVertSet);

            fillInForm();
        }

        private void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            if (txtRemoveName.Text == "" || txtRemoveName.Text == null)
            {
                lblError.Text = "Must Enter Conversion Unit to Remove";
                return;
            }

            KonVertUnit myUnit = theKonVersionGroup.getUnit(txtRemoveName.Text);
            if (myUnit != null)
            {
                theKonVersionGroup.removeUnit(myUnit);
            }

            lbUnits.Items.Clear();
            foreach (KonVertUnit aUnit in theKonVersionGroup.konVertUnits)
            {
                lbUnits.Items.Add(aUnit.myVersionUnitID);
                //lbGroupList.Items.Add(aGroup.myVersionGroupID + ":" + aGroup.myDisplayText);
            }
            lblError.Text = "Read OK";
            txtRemoveName.Text = "";
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "" || txtAddName.Text == null)
            {
                lblError.Text = "Must Enter Conversion Unit Name";
                return;
            }

            KonVertUnit myUnit = new KonVertUnit(BuildJSON.theKonVertSet);

            string aFileName = BuildJSON.baseDirectory + txtAddName.Text + ".txt";
            myUnit.anyError = null;
            //myUnit.readJsonFile(aFileName);
            myUnit = JsonConvert.DeserializeObject<KonVertUnit>(BuildJSON.readJSONObjectFromFile(aFileName));
            if (myUnit.anyError != null)
            //if (myUnit.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading:" + aFileName;
                if (theKonVersionGroup.anyError != null)
                {
                    lblError.Text = lblError.Text + ":" + theKonVersionGroup.anyError.ToString();
                }
                return;
            }

            if (theKonVersionGroup.containsUnit(myUnit))
            {
                theKonVersionGroup.removeUnit(myUnit);
            }

            theKonVersionGroup.konVertUnits.Add(myUnit);

            lbUnits.Items.Clear();
            foreach (KonVertUnit aUnit in theKonVersionGroup.konVertUnits)
            {
                lbUnits.Items.Add(aUnit.myVersionUnitID);
                //lbGroupList.Items.Add(aGroup.myVersionGroupID + ":" + aGroup.myDisplayText);
            }
            lblError.Text = "Read OK";
            txtAddName.Text = "";

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }

}
