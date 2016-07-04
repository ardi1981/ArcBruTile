using System;
using System.Windows.Forms;

namespace BrutileArcGIS.forms
{
    public partial class AddTileServiceForm : Form
    {
        public string Url { get; set;  }
        public string Domains { get; set; }
        public string Name { get; set; }

        public AddTileServiceForm()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Url = tbUrl.Text;
            Domains = tbDomains.Text;
            Name = tbName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddTileServiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
