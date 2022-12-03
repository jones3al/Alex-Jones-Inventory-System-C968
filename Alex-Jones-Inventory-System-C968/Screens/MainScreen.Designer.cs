
namespace AlexJonesInventorySystem
{
    partial class MainScreen
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
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.searchPartsTextbox = new System.Windows.Forms.TextBox();
            this.searchProductsTextbox = new System.Windows.Forms.TextBox();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.modifyPartsButton = new System.Windows.Forms.Button();
            this.deletePartsButton = new System.Windows.Forms.Button();
            this.deleteProductsButton = new System.Windows.Forms.Button();
            this.modifyProductsButton = new System.Windows.Forms.Button();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.mainScreenTitle = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(41, 64);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersWidth = 51;
            this.partsDataGridView.RowTemplate.Height = 24;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(692, 348);
            this.partsDataGridView.TabIndex = 0;
            this.partsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingComplete);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(792, 64);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(692, 348);
            this.productsDataGridView.TabIndex = 1;
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Enabled = false;
            this.searchPartsButton.Location = new System.Drawing.Point(380, 26);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(84, 29);
            this.searchPartsButton.TabIndex = 2;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // searchPartsTextbox
            // 
            this.searchPartsTextbox.Location = new System.Drawing.Point(470, 29);
            this.searchPartsTextbox.Name = "searchPartsTextbox";
            this.searchPartsTextbox.Size = new System.Drawing.Size(263, 22);
            this.searchPartsTextbox.TabIndex = 4;
            this.searchPartsTextbox.Text = "search by id";
            this.searchPartsTextbox.TextChanged += new System.EventHandler(this.searchPartsTextbox_TextChanged);
            // 
            // searchProductsTextbox
            // 
            this.searchProductsTextbox.Location = new System.Drawing.Point(1221, 33);
            this.searchProductsTextbox.Name = "searchProductsTextbox";
            this.searchProductsTextbox.Size = new System.Drawing.Size(263, 22);
            this.searchProductsTextbox.TabIndex = 6;
            this.searchProductsTextbox.Text = "search by id";
            this.searchProductsTextbox.TextChanged += new System.EventHandler(this.searchProductsTextbox_TextChanged);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Enabled = false;
            this.searchProductsButton.Location = new System.Drawing.Point(1131, 30);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(84, 29);
            this.searchProductsButton.TabIndex = 5;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.SearchProductsButton_Click);
            // 
            // addPartsButton
            // 
            this.addPartsButton.Location = new System.Drawing.Point(470, 429);
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.Size = new System.Drawing.Size(75, 37);
            this.addPartsButton.TabIndex = 7;
            this.addPartsButton.Text = "Add";
            this.addPartsButton.UseVisualStyleBackColor = true;
            this.addPartsButton.Click += new System.EventHandler(this.AddPartsButton_Click);
            // 
            // modifyPartsButton
            // 
            this.modifyPartsButton.Location = new System.Drawing.Point(564, 429);
            this.modifyPartsButton.Name = "modifyPartsButton";
            this.modifyPartsButton.Size = new System.Drawing.Size(75, 37);
            this.modifyPartsButton.TabIndex = 8;
            this.modifyPartsButton.Text = "Modify";
            this.modifyPartsButton.UseVisualStyleBackColor = true;
            this.modifyPartsButton.Click += new System.EventHandler(this.ModifyPartsButton_Click);
            // 
            // deletePartsButton
            // 
            this.deletePartsButton.Location = new System.Drawing.Point(658, 429);
            this.deletePartsButton.Name = "deletePartsButton";
            this.deletePartsButton.Size = new System.Drawing.Size(75, 37);
            this.deletePartsButton.TabIndex = 9;
            this.deletePartsButton.Text = "Delete";
            this.deletePartsButton.UseVisualStyleBackColor = true;
            this.deletePartsButton.Click += new System.EventHandler(this.DeletePartsButton_Click);
            // 
            // deleteProductsButton
            // 
            this.deleteProductsButton.Location = new System.Drawing.Point(1409, 429);
            this.deleteProductsButton.Name = "deleteProductsButton";
            this.deleteProductsButton.Size = new System.Drawing.Size(75, 37);
            this.deleteProductsButton.TabIndex = 12;
            this.deleteProductsButton.Text = "Delete";
            this.deleteProductsButton.UseVisualStyleBackColor = true;
            this.deleteProductsButton.Click += new System.EventHandler(this.DeleteProductsButton_Click);
            // 
            // modifyProductsButton
            // 
            this.modifyProductsButton.Location = new System.Drawing.Point(1315, 429);
            this.modifyProductsButton.Name = "modifyProductsButton";
            this.modifyProductsButton.Size = new System.Drawing.Size(75, 37);
            this.modifyProductsButton.TabIndex = 11;
            this.modifyProductsButton.Text = "Modify";
            this.modifyProductsButton.UseVisualStyleBackColor = true;
            this.modifyProductsButton.Click += new System.EventHandler(this.ModifyProductsButton_Click);
            // 
            // addProductsButton
            // 
            this.addProductsButton.Location = new System.Drawing.Point(1221, 429);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(75, 37);
            this.addProductsButton.TabIndex = 10;
            this.addProductsButton.Text = "Add";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.AddProductsButton_Click);
            // 
            // exitAppButton
            // 
            this.exitAppButton.Location = new System.Drawing.Point(1409, 484);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(75, 37);
            this.exitAppButton.TabIndex = 13;
            this.exitAppButton.Text = "Exit";
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // mainScreenTitle
            // 
            this.mainScreenTitle.AutoSize = true;
            this.mainScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenTitle.Location = new System.Drawing.Point(12, 9);
            this.mainScreenTitle.Name = "mainScreenTitle";
            this.mainScreenTitle.Size = new System.Drawing.Size(211, 18);
            this.mainScreenTitle.TabIndex = 14;
            this.mainScreenTitle.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(38, 43);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(43, 18);
            this.partsLabel.TabIndex = 15;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(789, 43);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(68, 18);
            this.productsLabel.TabIndex = 16;
            this.productsLabel.Text = "Products";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 528);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.mainScreenTitle);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.deleteProductsButton);
            this.Controls.Add(this.modifyProductsButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.deletePartsButton);
            this.Controls.Add(this.modifyPartsButton);
            this.Controls.Add(this.addPartsButton);
            this.Controls.Add(this.searchProductsTextbox);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.searchPartsTextbox);
            this.Controls.Add(this.searchPartsButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView partsDataGridView;
        public System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.TextBox searchPartsTextbox;
        private System.Windows.Forms.TextBox searchProductsTextbox;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.Button addPartsButton;
        private System.Windows.Forms.Button modifyPartsButton;
        private System.Windows.Forms.Button deletePartsButton;
        private System.Windows.Forms.Button deleteProductsButton;
        private System.Windows.Forms.Button modifyProductsButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Label mainScreenTitle;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
    }
}