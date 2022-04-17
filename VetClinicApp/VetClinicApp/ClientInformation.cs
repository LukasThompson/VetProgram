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
    public partial class ClientInformation : Form
    {
        public ClientInformation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            DisableEditing();
        }

        private void DisableEditing()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtCity.Enabled = false;
            cboState.Enabled = false;
            txtZipCode.Enabled = false;
            txtPhoneOne.Enabled = false;
            txtPhoneTwo.Enabled = false;
            txtPhoneThree.Enabled = false;
            txtAltPhoneOne.Enabled = false;
            txtAltPhoneTwo.Enabled = false;
            txtAltPhoneThree.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void EnableEditing()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtStreetAddress.Enabled = true;
            txtCity.Enabled = true;
            cboState.Enabled = true;
            txtZipCode.Enabled = true;
            txtPhoneOne.Enabled = true;
            txtPhoneTwo.Enabled = true;
            txtPhoneThree.Enabled = true;
            txtAltPhoneOne.Enabled = true;
            txtAltPhoneTwo.Enabled = true;
            txtAltPhoneThree.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShowAdminBox();
        }

        public void ShowAdminBox()
        {
            AdminDeleteMsg adminPanel = new AdminDeleteMsg();
            adminPanel.Show();
        }
    }
}
