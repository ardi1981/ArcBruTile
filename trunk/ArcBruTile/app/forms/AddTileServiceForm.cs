using System;
using System.Windows.Forms;

namespace BrutileArcGIS.forms
{
    public partial class AddTileServiceForm : Form
    {
        public string Url { get; set;  }
        public string LayerName { get; set; }

        public AddTileServiceForm()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Url = tbUrl.Text;
            LayerName = tbName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddTileServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void tbUrl_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbUrl.Text == String.Empty)
            {
                errorProvider1.SetError(tbUrl, "Please give url");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbUrl, "");
            }

        }

        private void tbName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbName.Text == String.Empty)
            {
                errorProvider1.SetError(tbName, "Please give name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, "");
            }

        }
    }
}
