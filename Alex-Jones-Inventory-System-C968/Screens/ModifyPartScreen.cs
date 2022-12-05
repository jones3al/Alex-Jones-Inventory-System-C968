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
    public partial class ModifyPartScreen : Form
    {
        MainScreen Mainscreen = (MainScreen)Application.OpenForms["MainScreen"];
        public ModifyPartScreen(Inhouse inhousePart)
        {
            InitializeComponent();
            idTextBox.Text = inhousePart.PartID.ToString();
            nameTextBox.Text = inhousePart.Name.ToString();
            inventoryTextBox.Text = inhousePart.InStock.ToString();
            priceTextBox.Text = inhousePart.Price.ToString();
            minTextBox.Text = inhousePart.Min.ToString();
            maxTextBox.Text = inhousePart.Max.ToString();
            conditionalTextBox.Text = inhousePart.MachineId.ToString();
            inHouseRadioButton.Checked = true;
        }

        public ModifyPartScreen(Outsourced outsourcedPart)
        {
            InitializeComponent();
            idTextBox.Text = outsourcedPart.PartID.ToString();
            nameTextBox.Text = outsourcedPart.Name.ToString();
            inventoryTextBox.Text = outsourcedPart.InStock.ToString();
            priceTextBox.Text = outsourcedPart.Price.ToString();
            minTextBox.Text = outsourcedPart.Min.ToString();
            maxTextBox.Text = outsourcedPart.Max.ToString();
            conditionalTextBox.Text = outsourcedPart.CompanyName.ToString();
            outsourcedRadioButton.Checked = true;
            
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Company Name";
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Machine ID";
        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //update selected part with new data
        private void ModifyPartSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int instock;
            decimal price;
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;

            //check for special characters
            if (Inventory.HasSpecial(minTextBox.Text, maxTextBox.Text, inventoryTextBox.Text, priceTextBox.Text))
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min cannot contain special characters. Please use numeric values.");
                return;
            }

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
                return;
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
                Inventory.AddPart(id, part);
                inHouseRadioButton.Checked = true;
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
                Inventory.AddPart(id, part);
                outsourcedRadioButton.Checked = true;
            }
            Close();

            Mainscreen.partsDataGridView.Update();
            Mainscreen.partsDataGridView.Refresh();
        }
    }
}
