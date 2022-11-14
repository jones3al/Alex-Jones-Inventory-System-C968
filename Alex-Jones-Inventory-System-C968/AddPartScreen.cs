using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexJonesInventorySystem
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Company Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Machine ID";
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
