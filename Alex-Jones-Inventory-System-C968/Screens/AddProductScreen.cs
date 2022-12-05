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
    public partial class AddProductScreen : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            candidatePartsDataGridView.DataSource = Inventory.AllParts;
            associatedPartsDataGridView.DataSource = addedParts;
            
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            if (!candidatePartsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!.", "Please Make A Candidate Part Selection");
                return;
            }
            else
            {
                Part part = (Part)candidatePartsDataGridView.CurrentRow.DataBoundItem;
                addedParts.Add(part);
            }
            
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (!associatedPartsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!.", "Please Make An Associated Part Selection");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in associatedPartsDataGridView.SelectedRows)
                    {
                        associatedPartsDataGridView.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(searchTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in candidatePartsDataGridView.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
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

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            int instock;
            int min;
            int max;
            decimal price;

            //check for special characters
            if (Inventory.HasSpecial(minTextBox.Text, maxTextBox.Text, inventoryTextBox.Text, priceTextBox.Text))
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min cannot contain special characters. Please use numeric values.");
                return;
            }

            try
            {
                min = int.Parse(minTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                instock = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = nameTextBox.Text;
            instock = int.Parse(inventoryTextBox.Text);
            price = decimal.Parse(priceTextBox.Text);
            min = int.Parse(minTextBox.Text);
            max = int.Parse(maxTextBox.Text);

            //prevents user from having higher min than max.
            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max");
                return;
            }

            if (instock > max || instock < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }
            //creates new Product and adds it to inventory
            Product product = new Product
            {
                ProductId = Inventory.Products.Count + 1,
                Name = name,
                InStock = instock,
                Price = price,
                Max = max,
                Min = min
            };
            Inventory.AddProduct(product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear selection
            candidatePartsDataGridView.ClearSelection();
            associatedPartsDataGridView.ClearSelection();
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
