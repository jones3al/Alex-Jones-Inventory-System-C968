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
    public partial class ModifyProductScreen : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainScreen Mainscreen = (MainScreen)Application.OpenForms["MainScreen"];
        public ModifyProductScreen(Product p)
        {
            InitializeComponent();

            //product fields with selected product populated
            idTextBox.Text = p.ProductId.ToString();
            nameTextBox.Text = p.Name;
            inventoryTextBox.Text = p.InStock.ToString();
            priceTextBox.Text = p.Price.ToString();
            maxTextBox.Text = p.Max.ToString();
            minTextBox.Text = p.Min.ToString();

            //populate table with all products
            candidatePartsDataGridView.DataSource = Inventory.AllParts;

            //populate associated parts table
            foreach (Part part in p.AssociatedParts)
            {
                addedParts.Add(part);
            }

            associatedPartsDataGridView.DataSource = addedParts;


        }

        private void ModifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyProductSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;
            string name = nameTextBox.Text;
            int id = int.Parse(idTextBox.Text);

            //ensures numeric values not strings
            try
            {
                min = int.Parse(minTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                inventory = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(minTextBox.Text);

            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }
            min = int.Parse(minTextBox.Text);
            max = int.Parse(maxTextBox.Text);
            inventory = int.Parse(inventoryTextBox.Text);
            price = decimal.Parse(priceTextBox.Text);

            //prevents min larger than max
            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max.");
                return;
            }

            //ensures inventory is between min and max
            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between min and max.");
                return;
            }

            //create new product and add
            Product product = new Product 
            { 
                ProductId = id, 
                Name = name, 
                InStock = inventory, 
                Price = price, 
                Max = max, 
                Min = min 
            };
            foreach (Part p in addedParts)
            {
                product.AddAssociatedPart(p);
            }
            Inventory.UpdateProduct(id, product);
            Close();

            Mainscreen.productsDataGridView.Update();
            Mainscreen.productsDataGridView.Refresh();
        }

        private void ModifyProductAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)candidatePartsDataGridView.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox == null)
            {
                MessageBox.Show("Error: Enter a value.");
                return;
            }
            else
            {
                int partId = int.Parse(searchTextBox.Text);
                Part match = Inventory.LookupPart(partId);
                foreach (DataGridViewRow row in candidatePartsDataGridView.Rows)
                {
                    Part p = (Part)row.DataBoundItem;
                    if (p.PartID == match.PartID)
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product p = (Product)associatedPartsDataGridView.CurrentRow.DataBoundItem;
                int id = int.Parse(idTextBox.Text);

                Product prod = Inventory.LookupProduct(id);
                prod.RemoveAssociatedPart(p.ProductId);

                foreach (DataGridViewRow row in associatedPartsDataGridView.SelectedRows)
                {
                    associatedPartsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear selection
            candidatePartsDataGridView.ClearSelection();
            associatedPartsDataGridView.ClearSelection();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
        }
    }
}
