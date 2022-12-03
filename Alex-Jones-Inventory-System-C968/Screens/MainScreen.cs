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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            
            //set the data source
            productsDataGridView.DataSource = Inventory.Products;
            partsDataGridView.DataSource = Inventory.AllParts;

            //see a full row selection
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make grid read only and single select
            productsDataGridView.ReadOnly = true;
            productsDataGridView.MultiSelect = false;
            partsDataGridView.ReadOnly = true;
            partsDataGridView.MultiSelect = false;

            //remove bottom line
            productsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.AllowUserToAddRows = false;
        }

        private void AddPartsButton_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        private void ModifyPartsButton_Click(object sender, EventArgs e)
        {
            if(partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(AlexJonesInventorySystem.Classes.Inhouse))
            {
                Inhouse i = (Inhouse)partsDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartScreen(i).ShowDialog();
            }
            else
            {
                Outsourced o = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartScreen(o).ShowDialog();
            }
        }

        private void DeletePartsButton_Click(object sender, EventArgs e)
        {
            if (!partsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!.", "Please Make A Selection");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
                    {
                        partsDataGridView.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }
        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchPartsTextbox.Text))
            {
                MessageBox.Show("You Must enter a number to search for a Part");
                return;
            }
            int searchValue = int.Parse(searchPartsTextbox.Text);
            Part match = Inventory.LookupPart(int.Parse(searchPartsTextbox.Text));
            if(searchValue < 1)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in partsDataGridView.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if(part.PartID == match.PartID)
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
        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            new AddProductScreen().ShowDialog();
        }

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            if (!productsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!.", "Please Make A Selection");
                return;
            }
            Product p = (Product)productsDataGridView.CurrentRow.DataBoundItem ;
            int index = productsDataGridView.CurrentCell.RowIndex;
            new ModifyProductScreen(p).ShowDialog();

        }
        private void DeleteProductsButton_Click(object sender, EventArgs e)
        {
            if (!productsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!.", "Please Make A Selection");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
                    if (product.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                        return;
                    }
                    foreach (DataGridViewRow row in productsDataGridView.SelectedRows)
                    {
                        productsDataGridView.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }

        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchProductsTextbox.Text))
            {
                MessageBox.Show("You Must enter a number to search for a Part");
                return;
            }
            else
            {
                int searchValue = int.Parse(searchProductsTextbox.Text);
                Product match = Inventory.LookupProduct(int.Parse(searchProductsTextbox.Text));
                if (searchValue < 1)
                {
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in productsDataGridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        if (product.ProductId == match.ProductId)
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
        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear selection
            productsDataGridView.ClearSelection();
            partsDataGridView.ClearSelection();
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchPartsTextbox_TextChanged(object sender, EventArgs e)
        {
            searchPartsButton.Enabled = true;
        }

        private void searchProductsTextbox_TextChanged(object sender, EventArgs e)
        {
            searchProductsButton.Enabled = true;
        }
    }
}
