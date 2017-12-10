using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using KonVert;
using KonVertObjs;

namespace WinFormsForSwypConvert
{
    public partial class frmTestKonversion : Form
    {
        private KonVertSet _theKonVertSet;
        public KonVertSet theKonVertSet 
        { 
            get
            {
                return _theKonVertSet;
            }
            
            set
            {
                _theKonVertSet = value;
                if (theKonVertSet != null)
                {
                    foreach (KonVersionGroup kg in theKonVertSet.KonVersionGroups)
                    {
                        lbGroup.Items.Add(kg);
                    }
                    this.lbGroup.SelectedItem = lbGroup.Items[0];
                }
            }
        }

        public frmTestKonversion()
        {
            InitializeComponent();
        }

        private void frmTestKonversion_Load(object sender, EventArgs e)
        {
            if (theKonVertSet != null)
            {
                lbGroup.Items.Clear();
                foreach (KonVersionGroup kg in theKonVertSet.KonVersionGroups)
                {
                    lbGroup.Items.Add(kg);
                }
            }
        }

        private void lbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            KonVersionGroup myKg = (KonVersionGroup)this.lbGroup.SelectedItem;
            lbLeftUnit.Items.Clear();
            lbRightUnit.Items.Clear();
            foreach (KonVertUnit kvu in myKg.konVertUnits)
            {
                lbLeftUnit.Items.Add(kvu);
                lbRightUnit.Items.Add(kvu);
            }
            lbLeftUnit.SelectedItem = lbLeftUnit.Items[0];
            lbRightUnit.SelectedItem = lbRightUnit.Items[0];
        }

        private void btnConvertLeftToRight_Click(object sender, EventArgs e)
        {
            doButtonKonvert(decimal.Parse(txtNum.Text), true);
        }

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            doButtonKonvert(decimal.Parse(txtNum.Text), false);
        }

        private void doButtonKonvert(decimal aNum, bool doLeftToRight)
        {
            KonVertUnit leftKonVert = (KonVertUnit)this.lbLeftUnit.SelectedItem;
            KonVertUnit rightKonVert = (KonVertUnit)this.lbRightUnit.SelectedItem;
            string myGroupID = ((KonVersionGroup)this.lbGroup.SelectedItem).myVersionGroupID;

            KonVersion myKonVersion = new KonVersion(myGroupID, BuildJSON.theKonVertSet);

            myKonVersion.myVertUnitLeftID = leftKonVert.myVersionUnitID;
            myKonVersion.myVertUnitRightID = rightKonVert.myVersionUnitID;

            myKonVersion.myVersionGroupID = myGroupID;
            if (doLeftToRight)
            {
                myKonVersion.myLeftNumber = aNum;
            }
            else
            {
                myKonVersion.myRightNumber = aNum;
            }

            bool result = myKonVersion.performKonversion(doLeftToRight);

            if (result)
            {
                BuildJSON.aStaticVal = 4;

                this.lblResult.Text = myKonVersion.ToString();
            }
            else
            {
                this.lblResult.Text = "SafeCheck Error";
            }
        }
    }
}
