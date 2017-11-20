using BrutileArcGIS.lib;
using System;
using System.Windows.Forms;

namespace BrutileArcGIS.forms
{
    public partial class AddStravaForm : Form
    {
        public StravaColor StravaColor { get; set; }
        public StravaActivityType StravaActivityType;

        public AddStravaForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private StravaColor GetColorOption(RadioButton radio)
        {

            Enum.TryParse(radio.Tag.ToString(), out StravaColor stravaColor);
            return stravaColor;
        }

        private StravaActivityType GetActivityTypeOption(RadioButton radio)
        {
            Enum.TryParse(radio.Tag.ToString(), out StravaActivityType stravaActivityType);
            return stravaActivityType;
        }

        private void rdbColorChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                StravaColor = GetColorOption(rdb);
            }
        }

        private void rdbActivityTypeChanged(object sender, EventArgs e)
        {
            var rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                StravaActivityType = GetActivityTypeOption(rdb);
            }

        }
    }
}
