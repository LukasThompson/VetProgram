using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicApp
{
    public partial class AdminDeleteMsg : Form
    {
        public AdminDeleteMsg()
        {
            InitializeComponent();
            DisableDeleteBtn();
        }

        private void AdminDeleteMsg_Load(object sender, EventArgs e)
        {

        }

        public void DisableDeleteBtn()
        {
            btnDelete.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
