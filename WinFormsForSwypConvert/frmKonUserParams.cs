using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

//using KonVert;
using KonVertObjs;

namespace WinFormsForSwypConvert
{
    public partial class frmKonUserParams : Form
    {
        //private KonFuncs theFuncs = new KonFuncs();
        private KonVertUserParams theUserParams = new KonVertUserParams(BuildJSON.theKonVertSet);
        //private string baseDirectory = @"C:\ZwypConvert\Data\";

        public frmKonUserParams()
        {
            InitializeComponent();

            loadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theUserParams = new KonVertUserParams(BuildJSON.theKonVertSet);
            KonVersion myKonVersion;

            myKonVersion = setKonVertParams(tbGroup1, tbLeftID1, tbRightID1, tbLeftVal1, tbRightVal1);
            if (myKonVersion != null) theUserParams.previousKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroup2, tbLeftID2, tbRightID2, tbLeftVal2, tbRightVal2);
            if (myKonVersion != null) theUserParams.previousKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroup3, tbLeftID3, tbRightID3, tbLeftVal3, tbRightVal3);
            if (myKonVersion != null) theUserParams.previousKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroup4, tbLeftID4, tbRightID4, tbLeftVal4, tbRightVal4);
            if (myKonVersion != null) theUserParams.previousKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroup5, tbLeftID5, tbRightID5, tbLeftVal5, tbRightVal5);
            if (myKonVersion != null) theUserParams.previousKonversions.Add(myKonVersion);

            myKonVersion = setKonVertParams(tbGroupID6, tbLeftID6, tbRightID6, tbLeftVal6, tbRightVal6);
            if (myKonVersion != null) theUserParams.userGroupKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroupID7, tbLeftID7, tbRightID7, tbLeftVal7, tbRightVal7);
            if (myKonVersion != null) theUserParams.userGroupKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroupID8, tbLeftID8, tbRightID8, tbLeftVal8, tbRightVal8);
            if (myKonVersion != null) theUserParams.userGroupKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroupID9, tbLeftID9, tbRightID9, tbLeftVal9, tbRightVal9);
            if (myKonVersion != null) theUserParams.userGroupKonversions.Add(myKonVersion);
            myKonVersion = setKonVertParams(tbGroupID10, tbLeftID10, tbRightID10, tbLeftVal10, tbRightVal10);
            if (myKonVersion != null) theUserParams.userGroupKonversions.Add(myKonVersion);

            //theUserParams.writeJsonFile(fileName);
            BuildJSON.writeJSONObjectToFile("KonVertUserParams.txt", theUserParams);
        }

        private KonVersion setKonVertParams(TextBox aGroupID, TextBox aLeftID, TextBox aRightID, TextBox aLeftNum, TextBox aRightNum)
        {
            Decimal tmpNumb;

            if (aGroupID.Text == "") return null;

            KonVersion myKonv = new KonVersion(BuildJSON.theKonVertSet);

            myKonv.myVersionGroupID = aGroupID.Text;
            myKonv.myVertUnitLeftID = aLeftID.Text;
            myKonv.myVertUnitRightID = aRightID.Text;
            tmpNumb = (decimal)KonFuncs.getNum(aLeftNum.Text);
            myKonv.myLeftNumber = tmpNumb;

            tmpNumb = (decimal)KonFuncs.getNum(aRightNum.Text);
            myKonv.myRightNumber = tmpNumb;
            return myKonv;
        }

        private void loadForm()
        {
            KonVersion myKonv;

            theUserParams = new KonVertUserParams(BuildJSON.theKonVertSet);
            string fileName = BuildJSON.baseDirectory + "KonVertUserParams.txt";
            theUserParams.anyError = null;
            //NJtheUserParams.readJsonFile(fileName);
            if (theUserParams.anyError == null)
            //if (theUserParams.readJsonFile(fileName) == true)
            {
                if (theUserParams != null && theUserParams.previousKonversions != null)
                {
                    int theCount = theUserParams.previousKonversions.Count;
                    if (theCount > 0)
                    {
                        myKonv = theUserParams.previousKonversions.ElementAt<KonVersion>(0);
                        setKonvText(myKonv, tbGroup1, tbLeftID1, tbRightID1, tbLeftVal1, tbRightVal1);
                        if (theCount > 1)
                        {
                            myKonv = theUserParams.previousKonversions.ElementAt<KonVersion>(1);
                            setKonvText(myKonv, tbGroup2, tbLeftID2, tbRightID2, tbLeftVal2, tbRightVal2);
                            if (theCount > 2)
                            {
                                myKonv = theUserParams.previousKonversions.ElementAt<KonVersion>(2);
                                setKonvText(myKonv, tbGroup3, tbLeftID3, tbRightID3, tbLeftVal3, tbRightVal3);
                                if (theCount > 3)
                                {
                                    myKonv = theUserParams.previousKonversions.ElementAt<KonVersion>(3);
                                    setKonvText(myKonv, tbGroup4, tbLeftID4, tbRightID4, tbLeftVal4, tbRightVal4);
                                    if (theCount > 4)
                                    {
                                        myKonv = theUserParams.previousKonversions.ElementAt<KonVersion>(4);
                                        setKonvText(myKonv, tbGroup5, tbLeftID5, tbRightID5, tbLeftVal5, tbRightVal5);
                                    }
                                }
                            }
                        }
                    }
                }

                if (theUserParams != null && theUserParams.userGroupKonversions != null)
                {
                    for (int i = 0; i < theUserParams.userGroupKonversions.Count; i++)
                    {
                        if (i == 0)
                        {
                            myKonv = theUserParams.userGroupKonversions.ElementAt<KonVersion>(0);
                            setKonvText(myKonv, tbGroupID6, tbLeftID6, tbRightID6, tbLeftVal6, tbRightVal6);
                        }
                        if (i == 1)
                        {
                            myKonv = theUserParams.userGroupKonversions.ElementAt<KonVersion>(1);
                            setKonvText(myKonv, tbGroupID7, tbLeftID7, tbRightID7, tbLeftVal7, tbRightVal7);
                        }
                        if (i == 2)
                        {
                            myKonv = theUserParams.userGroupKonversions.ElementAt<KonVersion>(2);
                            setKonvText(myKonv, tbGroupID8, tbLeftID8, tbRightID8, tbLeftVal8, tbRightVal8);
                        }
                        if (i == 3)
                        {
                            myKonv = theUserParams.userGroupKonversions.ElementAt<KonVersion>(3);
                            setKonvText(myKonv, tbGroupID9, tbLeftID9, tbRightID9, tbLeftVal9, tbRightVal9);
                        }
                        if (i == 4)
                        {
                            myKonv = theUserParams.userGroupKonversions.ElementAt<KonVersion>(4);
                            setKonvText(myKonv, tbGroupID10, tbLeftID10, tbRightID10, tbLeftVal10, tbRightVal10);
                        }
                    }
                }
            }

        }

        private void setKonvText(KonVersion aKonv, TextBox aGroupID, TextBox aLeftID, TextBox aRightID, TextBox aLeftNum, TextBox aRightNum)
        {
            if (aKonv == null) return;

            aGroupID.Text = aKonv.myVersionGroupID;
            aLeftID.Text = aKonv.myVertUnitLeftID;
            aRightID.Text = aKonv.myVertUnitRightID;
            aLeftNum.Text = aKonv.myLeftNumber.ToString();
            aRightNum.Text = aKonv.myRightNumber.ToString();
        }
    }
}
