
namespace AlexJonesInventorySystem
{
    partial class AddProductScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.addProductLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.candidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(12, 18);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(120, 25);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.idTextBox.Location = new System.Drawing.Point(278, 180);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(255, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(202, 180);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(178, 220);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(278, 220);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(157, 265);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.inventoryLabel.TabIndex = 7;
            this.inventoryLabel.Text = "Inventory";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(278, 265);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(255, 22);
            this.inventoryTextBox.TabIndex = 8;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(151, 305);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(72, 17);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price/Cost";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(278, 305);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(255, 22);
            this.priceTextBox.TabIndex = 10;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(190, 351);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 17);
            this.maxLabel.TabIndex = 11;
            this.maxLabel.Text = "Max";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(278, 351);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(86, 22);
            this.maxTextBox.TabIndex = 12;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(389, 351);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 17);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(447, 351);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(86, 22);
            this.minTextBox.TabIndex = 14;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1059, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(255, 22);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.Text = "search by id";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(1097, 521);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(103, 29);
            this.addProductSaveButton.TabIndex = 17;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Location = new System.Drawing.Point(1211, 521);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(103, 29);
            this.addProductCancelButton.TabIndex = 18;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(928, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 32);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // candidatePartsDataGridView
            // 
            this.candidatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsDataGridView.Location = new System.Drawing.Point(745, 105);
            this.candidatePartsDataGridView.MultiSelect = false;
            this.candidatePartsDataGridView.Name = "candidatePartsDataGridView";
            this.candidatePartsDataGridView.ReadOnly = true;
            this.candidatePartsDataGridView.RowHeadersWidth = 51;
            this.candidatePartsDataGridView.RowTemplate.Height = 24;
            this.candidatePartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePartsDataGridView.Size = new System.Drawing.Size(569, 150);
            this.candidatePartsDataGridView.TabIndex = 20;
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(745, 317);
            this.associatedPartsDataGridView.MultiSelect = false;
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.ReadOnly = true;
            this.associatedPartsDataGridView.RowHeadersWidth = 51;
            this.associatedPartsDataGridView.RowTemplate.Height = 24;
            this.associatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(569, 150);
            this.associatedPartsDataGridView.TabIndex = 21;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(1211, 473);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(103, 28);
            this.deleteProductButton.TabIndex = 22;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // addPartsButton
            // 
            this.addPartsButton.Location = new System.Drawing.Point(1211, 262);
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.Size = new System.Drawing.Size(103, 28);
            this.addPartsButton.TabIndex = 23;
            this.addPartsButton.Text = "Add";
            this.addPartsButton.UseVisualStyleBackColor = true;
            this.addPartsButton.Click += new System.EventHandler(this.addPartsButton_Click);
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Location = new System.Drawing.Point(745, 70);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(128, 17);
            this.candidatePartsLabel.TabIndex = 24;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Location = new System.Drawing.Point(742, 287);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(221, 17);
            this.associatedPartsLabel.TabIndex = 25;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 560);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.addPartsButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.candidatePartsDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addProductCancelButton);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProductScreen";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView candidatePartsDataGridView;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addPartsButton;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Label associatedPartsLabel;
    }
}