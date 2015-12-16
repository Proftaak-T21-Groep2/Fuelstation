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

        public accountDialog()
        {
            AcceptButton = btnConfirm;
            KeyPreview = true;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbBankNumber.Text != "" && tbName.Text != "" && tbPincode.Text != "" && tbCredit1.Text != "" && tbCredit2.Text != "" )
            {
                string startcredit = tbCredit1.Text + "," + tbCredit2.Text;
                Bankaccount bankaccount = new Bankaccount(tbBankNumber.Text, tbPincode.Text, Convert.ToDecimal(startcredit));
                owner = new Owner(tbName.Text, bankaccount);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Make sure you fill all the textboxes","error"); 
            }

        }


    }
}
