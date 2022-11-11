
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
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchpartsbutton = new System.Windows.Forms.Button();
            this.searchparts = new System.Windows.Forms.TextBox();
            this.searchproducts = new System.Windows.Forms.TextBox();
            this.searchproductsbutton = new System.Windows.Forms.Button();
            this.addpartsbutton = new System.Windows.Forms.Button();
            this.modifypartsbutton = new System.Windows.Forms.Button();
            this.deletepartsbutton = new System.Windows.Forms.Button();
            this.deleteproductsbutton = new System.Windows.Forms.Button();
            this.modifyproductsbutton = new System.Windows.Forms.Button();
            this.addproductsbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.mainscreentitle = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.Location = new System.Drawing.Point(41, 64);
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.RowHeadersWidth = 51;
            this.PartsDataGridView.RowTemplate.Height = 24;
            this.PartsDataGridView.Size = new System.Drawing.Size(692, 348);
            this.PartsDataGridView.TabIndex = 0;
            this.PartsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellContentClick);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(792, 64);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.RowTemplate.Height = 24;
            this.ProductsDataGridView.Size = new System.Drawing.Size(692, 348);
            this.ProductsDataGridView.TabIndex = 1;
            // 
            // searchpartsbutton
            // 
            this.searchpartsbutton.Location = new System.Drawing.Point(380, 26);
            this.searchpartsbutton.Name = "searchpartsbutton";
            this.searchpartsbutton.Size = new System.Drawing.Size(84, 29);
            this.searchpartsbutton.TabIndex = 2;
            this.searchpartsbutton.Text = "Search";
            this.searchpartsbutton.UseVisualStyleBackColor = true;
            this.searchpartsbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchparts
            // 
            this.searchparts.Location = new System.Drawing.Point(470, 29);
            this.searchparts.Name = "searchparts";
            this.searchparts.Size = new System.Drawing.Size(263, 22);
            this.searchparts.TabIndex = 4;
            // 
            // searchproducts
            // 
            this.searchproducts.Location = new System.Drawing.Point(1221, 33);
            this.searchproducts.Name = "searchproducts";
            this.searchproducts.Size = new System.Drawing.Size(263, 22);
            this.searchproducts.TabIndex = 6;
            // 
            // searchproductsbutton
            // 
            this.searchproductsbutton.Location = new System.Drawing.Point(1131, 30);
            this.searchproductsbutton.Name = "searchproductsbutton";
            this.searchproductsbutton.Size = new System.Drawing.Size(84, 29);
            this.searchproductsbutton.TabIndex = 5;
            this.searchproductsbutton.Text = "Search";
            this.searchproductsbutton.UseVisualStyleBackColor = true;
            // 
            // addpartsbutton
            // 
            this.addpartsbutton.Location = new System.Drawing.Point(470, 429);
            this.addpartsbutton.Name = "addpartsbutton";
            this.addpartsbutton.Size = new System.Drawing.Size(75, 37);
            this.addpartsbutton.TabIndex = 7;
            this.addpartsbutton.Text = "Add";
            this.addpartsbutton.UseVisualStyleBackColor = true;
            this.addpartsbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modifypartsbutton
            // 
            this.modifypartsbutton.Location = new System.Drawing.Point(564, 429);
            this.modifypartsbutton.Name = "modifypartsbutton";
            this.modifypartsbutton.Size = new System.Drawing.Size(75, 37);
            this.modifypartsbutton.TabIndex = 8;
            this.modifypartsbutton.Text = "Modify";
            this.modifypartsbutton.UseVisualStyleBackColor = true;
            // 
            // deletepartsbutton
            // 
            this.deletepartsbutton.Location = new System.Drawing.Point(658, 429);
            this.deletepartsbutton.Name = "deletepartsbutton";
            this.deletepartsbutton.Size = new System.Drawing.Size(75, 37);
            this.deletepartsbutton.TabIndex = 9;
            this.deletepartsbutton.Text = "Delete";
            this.deletepartsbutton.UseVisualStyleBackColor = true;
            // 
            // deleteproductsbutton
            // 
            this.deleteproductsbutton.Location = new System.Drawing.Point(1409, 429);
            this.deleteproductsbutton.Name = "deleteproductsbutton";
            this.deleteproductsbutton.Size = new System.Drawing.Size(75, 37);
            this.deleteproductsbutton.TabIndex = 12;
            this.deleteproductsbutton.Text = "Delete";
            this.deleteproductsbutton.UseVisualStyleBackColor = true;
            // 
            // modifyproductsbutton
            // 
            this.modifyproductsbutton.Location = new System.Drawing.Point(1315, 429);
            this.modifyproductsbutton.Name = "modifyproductsbutton";
            this.modifyproductsbutton.Size = new System.Drawing.Size(75, 37);
            this.modifyproductsbutton.TabIndex = 11;
            this.modifyproductsbutton.Text = "Modify";
            this.modifyproductsbutton.UseVisualStyleBackColor = true;
            // 
            // addproductsbutton
            // 
            this.addproductsbutton.Location = new System.Drawing.Point(1221, 429);
            this.addproductsbutton.Name = "addproductsbutton";
            this.addproductsbutton.Size = new System.Drawing.Size(75, 37);
            this.addproductsbutton.TabIndex = 10;
            this.addproductsbutton.Text = "Add";
            this.addproductsbutton.UseVisualStyleBackColor = true;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1409, 484);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 37);
            this.exitbutton.TabIndex = 13;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // mainscreentitle
            // 
            this.mainscreentitle.AutoSize = true;
            this.mainscreentitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainscreentitle.Location = new System.Drawing.Point(12, 9);
            this.mainscreentitle.Name = "mainscreentitle";
            this.mainscreentitle.Size = new System.Drawing.Size(211, 18);
            this.mainscreentitle.TabIndex = 14;
            this.mainscreentitle.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(38, 43);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(43, 18);
            this.PartsLabel.TabIndex = 15;
            this.PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(789, 43);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(68, 18);
            this.ProductsLabel.TabIndex = 16;
            this.ProductsLabel.Text = "Products";
            this.ProductsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 528);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.mainscreentitle);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.deleteproductsbutton);
            this.Controls.Add(this.modifyproductsbutton);
            this.Controls.Add(this.addproductsbutton);
            this.Controls.Add(this.deletepartsbutton);
            this.Controls.Add(this.modifypartsbutton);
            this.Controls.Add(this.addpartsbutton);
            this.Controls.Add(this.searchproducts);
            this.Controls.Add(this.searchproductsbutton);
            this.Controls.Add(this.searchparts);
            this.Controls.Add(this.searchpartsbutton);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.PartsDataGridView);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button searchpartsbutton;
        private System.Windows.Forms.TextBox searchparts;
        private System.Windows.Forms.TextBox searchproducts;
        private System.Windows.Forms.Button searchproductsbutton;
        private System.Windows.Forms.Button addpartsbutton;
        private System.Windows.Forms.Button modifypartsbutton;
        private System.Windows.Forms.Button deletepartsbutton;
        private System.Windows.Forms.Button deleteproductsbutton;
        private System.Windows.Forms.Button modifyproductsbutton;
        private System.Windows.Forms.Button addproductsbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label mainscreentitle;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ProductsLabel;
    }
}