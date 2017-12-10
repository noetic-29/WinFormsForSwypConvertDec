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
    public partial class frmKonVertUnit : Form
    {
        //private string baseDirectory = @"C:\ZwypConvert\Data\";
        //private KonFuncs extensions = new KonFuncs();
        public KonVertUnit theKonVertUnit;

        public frmKonVertUnit()
        {
            InitializeComponent();
        }

        public event EventHandler OnUpdate;

        private void frmKonVertUnit_Load(object sender, EventArgs e)
        {
        }

        public void setUnit(KonVertUnit aUnit)
        {
            theKonVertUnit = aUnit;
            fillInForm();
        }
        
        private void btnWriteJSONFile_Click(object sender, EventArgs e)
        {
            loadFromForm();

            string fileName = BuildJSON.baseDirectory + theKonVertUnit.myVersionUnitID + ".txt";
            theKonVertUnit.anyError = null;
            //theKonVertUnit.writeJsonFile(fileName);
            BuildJSON.writeJSONObjectToFile(fileName, theKonVertUnit);

            if (theKonVertUnit.anyError != null)
            //if (theKonVertUnit.writeJsonFile(fileName) == false)
            {
                lblError.Text = "Error writing:" + theKonVertUnit.anyError.ToString();
            }
            else
            {
                lblError.Text = "Write OK";
            }
        }

        private void btnReadJSONFile_Click(object sender, EventArgs e)
        {
            if (txtUnitID.Text == "" || txtUnitID.Text == null)
            {
                lblError.Text = "Must Enter UnitID";
                return;
            }

            if (theKonVertUnit == null)
            {
                theKonVertUnit = new KonVertUnit(BuildJSON.theKonVertSet);
            }

            string aFileName = BuildJSON.baseDirectory + txtUnitID.Text + ".txt";
            theKonVertUnit.anyError = null;
            //theKonVertUnit.readJsonFile(aFileName);
            theKonVertUnit = JsonConvert.DeserializeObject<KonVertUnit>(BuildJSON.readJSONObjectFromFile(aFileName));
            if (theKonVertUnit.anyError != null)
            //if (theKonVertUnit.readJsonFile(aFileName) == false)
            {
                lblError.Text = "Error Reading:" + aFileName + ":" + theKonVertUnit.anyError.ToString();
                return;
            }

            fillInForm();
            lblError.Text = "Read OK";
        }
        
        public void fillInForm()
        {
            lblError.Text = "";

            txtUnitID.Text = theKonVertUnit.myVersionUnitID;
            txtLongDisplay.Text = theKonVertUnit.myDisplayTextLong;
            txtPluralLongDisplay.Text = theKonVertUnit.myDisplayTextLongPlural;
            txtShortDisplay.Text = theKonVertUnit.myDisplayTextShort;
            cbShortInFront.Checked = theKonVertUnit.myDisplayTextShortFront;
            //cbMinusAllowed.Checked = theKonVertUnit.myMinusAllowed;
            txtMinNumber.Text = theKonVertUnit.minNumber.ToString();

            txtToolTip.Text = theKonVertUnit.myToolTip;
            txtSystem.Text = theKonVertUnit.mySystem;
            txtBaseSystem.Text = theKonVertUnit.myBaseUnitSystem;
            txtUnitListOrder.Text = theKonVertUnit.myUnitListOrder.ToString();
            txtUnitPrecision.Text = theKonVertUnit.myUnitPrecision.ToString();
            txtNextSmaller.Text = theKonVertUnit.myNextSmaller;
            //if (theKonVertUnit.myDoDecimal == null) theKonVertUnit.myDoDecimal = true;
            cbDoDecimal.Checked = theKonVertUnit.myDoDecimal;

            if (theKonVertUnit.myInSystemParams != null)
            {
                txtInSysMulti.Text = theKonVertUnit.myInSystemParams.myMultiplier.ToString();
                txtInSysAddr.Text = theKonVertUnit.myInSystemParams.myAdder.ToString();
                cbInSysAddFirst.Checked = theKonVertUnit.myInSystemParams.myAddFirst;
                txtInSysDivider.Text = theKonVertUnit.myInSystemParams.myDivider.ToString();
            }
            else
            {
                txtInSysMulti.Text = 0.ToString();
                txtInSysAddr.Text = 0.ToString();
                cbInSysAddFirst.Checked = false;
                txtInSysDivider.Text = 0.ToString();
            }

            if (theKonVertUnit.mySystem != theKonVertUnit.myBaseUnitSystem)
            {       // only need cross sytem when this unit is NOT in the same system as the conversion base unit
                if (theKonVertUnit.myCrossSystemParams != null)
                {
                    txtXSysMulti.Text = theKonVertUnit.myCrossSystemParams.myMultiplier.ToString();
                    txtXSysAddr.Text = theKonVertUnit.myCrossSystemParams.myAdder.ToString();
                    cbXSysAddFirst.Checked = theKonVertUnit.myCrossSystemParams.myAddFirst;
                    txtXSysDivider.Text = theKonVertUnit.myCrossSystemParams.myDivider.ToString();
                }
                else
                {
                    txtXSysMulti.Text = 0.ToString();
                    txtXSysAddr.Text = 0.ToString();
                    cbXSysAddFirst.Checked = false;
                    txtXSysDivider.Text = 0.ToString();
                }
            }
            else
            {
                txtXSysMulti.Text = "";
                txtXSysAddr.Text = "";
                cbXSysAddFirst.Checked = false;
                txtXSysDivider.Text = "";
            }
        }

        private void loadFromForm()
        {
            if (theKonVertUnit == null)
            {
                theKonVertUnit = new KonVertUnit(BuildJSON.theKonVertSet);
            }
            theKonVertUnit.myVersionUnitID = txtUnitID.Text;
            theKonVertUnit.myDisplayTextLong = txtLongDisplay.Text;
            theKonVertUnit.myDisplayTextLongPlural = txtPluralLongDisplay.Text;
            theKonVertUnit.myDisplayTextShort = txtShortDisplay.Text;
            theKonVertUnit.myDisplayTextShortFront = cbShortInFront.Checked;
            //theKonVertUnit.myMinusAllowed = cbMinusAllowed.Checked;
            theKonVertUnit.minNumber = double.Parse(txtMinNumber.Text);

            theKonVertUnit.myToolTip = txtToolTip.Text;
            theKonVertUnit.mySystem = txtSystem.Text;
            theKonVertUnit.myBaseUnitSystem = txtBaseSystem.Text;
            theKonVertUnit.myUnitListOrder = int.Parse(txtUnitListOrder.Text);
            theKonVertUnit.myUnitPrecision = int.Parse(txtUnitPrecision.Text);
            theKonVertUnit.myNextSmaller = txtNextSmaller.Text;
            theKonVertUnit.myDoDecimal = cbDoDecimal.Checked;

            theKonVertUnit.myInSystemParams = new KonVertParams(BuildJSON.theKonVertSet);
            //myKonVertUnit.myInSystemParams.myfromMultiplier = double.Parse(txtInSysFromMulti.Text);
            theKonVertUnit.myInSystemParams.myMultiplier = (long)KonFuncs.getNum(txtInSysMulti.Text);
            theKonVertUnit.myInSystemParams.myAdder = (decimal)KonFuncs.getNum(txtInSysAddr.Text);
            theKonVertUnit.myInSystemParams.myAddFirst = cbInSysAddFirst.Checked;
            theKonVertUnit.myInSystemParams.myDivider = (long)KonFuncs.getNum(txtInSysDivider.Text);

            if (theKonVertUnit.mySystem != theKonVertUnit.myBaseUnitSystem)
            {       // only need cross sytem when this unit is NOT in the same system as the conversion base unit
                theKonVertUnit.myCrossSystemParams = new KonVertParams(BuildJSON.theKonVertSet);
                theKonVertUnit.myCrossSystemParams.myMultiplier = (long)KonFuncs.getNum(txtXSysMulti.Text);
                theKonVertUnit.myCrossSystemParams.myAdder = (decimal)KonFuncs.getNum(txtXSysAddr.Text);
                theKonVertUnit.myCrossSystemParams.myAddFirst = cbXSysAddFirst.Checked;
                theKonVertUnit.myCrossSystemParams.myDivider = (long)KonFuncs.getNum(txtXSysDivider.Text);
            }
            else
            {
                theKonVertUnit.myCrossSystemParams = null;
            }
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            loadFromForm();
            OnUpdate(this, EventArgs.Empty);
        }

        private void btnClearUnit_Click(object sender, EventArgs e)
        {
            theKonVertUnit = new KonVertUnit(BuildJSON.theKonVertSet);
            fillInForm();
        }
    }
}
