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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyPartsButton_Click(object sender, EventArgs e)
        {
            new ModifyPartScreen().ShowDialog();
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            new AddProductScreen().ShowDialog();
        }

        private void modifyProductsButton_Click(object sender, EventArgs e)
        {
            new ModifyProductScreen().ShowDialog();
        }
    }
}
