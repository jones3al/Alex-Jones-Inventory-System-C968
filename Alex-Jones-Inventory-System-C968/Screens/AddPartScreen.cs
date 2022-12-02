using AlexJonesInventorySystem.Classes;
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

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Company Name";
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Machine ID";
        }

        private void AddPartSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int instock;
            decimal price;
            int id = Inventory.AllParts.Count + 1;
            string name = nameTextBox.Text;

            //ensures numeric values not strings
            try
            {
                min = int.Parse(minTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                instock = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(minTextBox.Text);

            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
            }
            min = int.Parse(minTextBox.Text);
            max = int.Parse(maxTextBox.Text);
            instock = int.Parse(inventoryTextBox.Text);
            price = decimal.Parse(priceTextBox.Text);

            //prevents min larger than max
            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max.");
                return;
            }

            //ensures inventory is between min and max
            if (instock > max || instock < min)
            {
                MessageBox.Show("Error: Inventory must be between min and max.");
                return;
            }

            //create new part and add
            if (inHouseRadioButton.Checked)
            {
                Inhouse part = new Inhouse
                {
                    PartID = id,
                    Name = name,
                    InStock = instock,
                    Price = price,
                    Max = max,
                    Min = min,
                    MachineId = int.Parse(conditionalTextBox.Text)
                };
                Inventory.AddPart(part);
            }
            else
            {
                Outsourced part = new Outsourced
                {
                    PartID = id,
                    Name = name,
                    InStock = instock,
                    Price = price,
                    Max = max,
                    Min = min,
                    CompanyName = conditionalTextBox.Text
                };
                Inventory.AddPart(part);
            }
            Close();
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
