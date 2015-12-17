using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarCenter
{
    public partial class accountDialog : Form
    {
        public Owner owner;
        private Fuelstation fuelstation;
        public accountDialog()
        {
            AcceptButton = btnConfirm;
            KeyPreview = true;
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbBankNumber.Text != "" && tbName.Text != "" && tbPincode.Text != "" && tbCredit1.Text != "")
            {
                string startcredit = "";

                if (tbCredit2.Text != "")
                {
                    startcredit = tbCredit1.Text + "," + tbCredit2.Text;
                }
                else
                {
                    startcredit = tbCredit1.Text + ",0";
                }
                fuelstation = new Fuelstation();
                Bankaccount bankaccount = new Bankaccount(tbBankNumber.Text, tbPincode.Text, Convert.ToDecimal(startcredit));
                List<string> types = new List<string>();
                types.Add("accountNr");
                types.Add("pincode");
                types.Add("balance");

                List<string> values = new List<string>();
                values.Add(tbBankNumber.Text);
                values.Add(tbPincode.Text);
                values.Add(startcredit);

                fuelstation.SaveToDatabase("127.0.0.1", "fuelstation", "bankaccounts", types, values);


                owner = new Owner(tbName.Text, bankaccount);
                List<string> ownertypes = new List<string>();
                ownertypes.Add("name");
                ownertypes.Add("bankAccount");

                List<string> ownervalues = new List<string>();
                ownervalues.Add(tbName.Text);
                ownervalues.Add(tbBankNumber.Text);

                fuelstation.SaveToDatabase("127.0.0.1", "fuelstation", "owners", ownertypes, ownervalues);


                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Make sure you fill all the textboxes","error"); 
            }
        }
    }
}
