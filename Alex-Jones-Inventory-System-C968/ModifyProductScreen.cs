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
    public partial class ModifyProductScreen : Form
    {
        public ModifyProductScreen()
        {
            InitializeComponent();
        }

        private void ModifyProductScreen_Load(object sender, EventArgs e)
        {

        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
