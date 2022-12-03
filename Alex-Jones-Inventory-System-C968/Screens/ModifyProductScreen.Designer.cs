
namespace AlexJonesInventorySystem
{
    partial class ModifyProductScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
            private void InitializeComponent()
            {
            this.modifyProductLabel = new System.Windows.Forms.Label();
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
            this.modifyProductSaveButton = new System.Windows.Forms.Button();
            this.modifyProductCancelButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.candidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductAddButton = new System.Windows.Forms.Button();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(12, 18);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(142, 25);
            this.modifyProductLabel.TabIndex = 0;
            this.modifyProductLabel.Text = "Modify Product";
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
            // modifyProductSaveButton
            // 
            this.modifyProductSaveButton.Location = new System.Drawing.Point(1097, 521);
            this.modifyProductSaveButton.Name = "modifyProductSaveButton";
            this.modifyProductSaveButton.Size = new System.Drawing.Size(103, 29);
            this.modifyProductSaveButton.TabIndex = 17;
            this.modifyProductSaveButton.Text = "Save";
            this.modifyProductSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductSaveButton.Click += new System.EventHandler(this.ModifyProductSaveButton_Click);
            // 
            // modifyProductCancelButton
            // 
            this.modifyProductCancelButton.Location = new System.Drawing.Point(1211, 521);
            this.modifyProductCancelButton.Name = "modifyProductCancelButton";
            this.modifyProductCancelButton.Size = new System.Drawing.Size(103, 29);
            this.modifyProductCancelButton.TabIndex = 18;
            this.modifyProductCancelButton.Text = "Cancel";
            this.modifyProductCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductCancelButton.Click += new System.EventHandler(this.ModifyProductCancelButton_Click);
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
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // modifyProductAddButton
            // 
            this.modifyProductAddButton.Location = new System.Drawing.Point(1211, 262);
            this.modifyProductAddButton.Name = "modifyProductAddButton";
            this.modifyProductAddButton.Size = new System.Drawing.Size(103, 28);
            this.modifyProductAddButton.TabIndex = 23;
            this.modifyProductAddButton.Text = "Add";
            this.modifyProductAddButton.UseVisualStyleBackColor = true;
            this.modifyProductAddButton.Click += new System.EventHandler(this.ModifyProductAddButton_Click);
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Location = new System.Drawing.Point(742, 76);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(128, 17);
            this.candidatePartsLabel.TabIndex = 24;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Location = new System.Drawing.Point(742, 286);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(221, 17);
            this.associatedPartsLabel.TabIndex = 25;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 560);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.modifyProductAddButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.candidatePartsDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modifyProductCancelButton);
            this.Controls.Add(this.modifyProductSaveButton);
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
            this.Controls.Add(this.modifyProductLabel);
            this.Name = "ModifyProductScreen";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }


        private System.Windows.Forms.Label modifyProductLabel;
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
        private System.Windows.Forms.Button modifyProductSaveButton;
        private System.Windows.Forms.Button modifyProductCancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView candidatePartsDataGridView;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductAddButton;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Label associatedPartsLabel;
    }

        #endregion
}
