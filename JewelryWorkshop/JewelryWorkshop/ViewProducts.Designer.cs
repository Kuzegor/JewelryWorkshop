namespace JewelryWorkshopWinFormsUI
{
    partial class ViewProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            this.headerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addSelectedToOrderListButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.viewSelectedButton = new System.Windows.Forms.Button();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.createNewProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(526, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Products Viewer / Catalogue";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 86);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(81, 38);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(99, 83);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(368, 45);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // addSelectedToOrderListButton
            // 
            this.addSelectedToOrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedToOrderListButton.Location = new System.Drawing.Point(99, 402);
            this.addSelectedToOrderListButton.Name = "addSelectedToOrderListButton";
            this.addSelectedToOrderListButton.Size = new System.Drawing.Size(272, 97);
            this.addSelectedToOrderListButton.TabIndex = 3;
            this.addSelectedToOrderListButton.Text = "Add Selected To Order List";
            this.addSelectedToOrderListButton.UseVisualStyleBackColor = true;
            this.addSelectedToOrderListButton.Click += new System.EventHandler(this.addSelectedToOrderListButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Location = new System.Drawing.Point(99, 235);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(272, 58);
            this.deleteSelectedButton.TabIndex = 4;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // viewSelectedButton
            // 
            this.viewSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedButton.Location = new System.Drawing.Point(99, 171);
            this.viewSelectedButton.Name = "viewSelectedButton";
            this.viewSelectedButton.Size = new System.Drawing.Size(272, 58);
            this.viewSelectedButton.TabIndex = 5;
            this.viewSelectedButton.Text = "View Selected";
            this.viewSelectedButton.UseVisualStyleBackColor = true;
            this.viewSelectedButton.Click += new System.EventHandler(this.viewSelectedButton_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 37;
            this.productsListBox.Location = new System.Drawing.Point(484, 83);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.productsListBox.Size = new System.Drawing.Size(569, 522);
            this.productsListBox.TabIndex = 6;
            // 
            // createNewProductButton
            // 
            this.createNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewProductButton.Location = new System.Drawing.Point(99, 299);
            this.createNewProductButton.Name = "createNewProductButton";
            this.createNewProductButton.Size = new System.Drawing.Size(272, 97);
            this.createNewProductButton.TabIndex = 11;
            this.createNewProductButton.Text = "Create New Product";
            this.createNewProductButton.UseVisualStyleBackColor = true;
            this.createNewProductButton.Click += new System.EventHandler(this.createNewProductButton_Click);
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 624);
            this.Controls.Add(this.createNewProductButton);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.viewSelectedButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.addSelectedToOrderListButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ViewProducts";
            this.Text = "ViewProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private Button addSelectedToOrderListButton;
        private Button deleteSelectedButton;
        private Button viewSelectedButton;
        private ListBox productsListBox;
        private Button createNewProductButton;
    }
}