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
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.expensiveFirstRadioButton = new System.Windows.Forms.RadioButton();
            this.cheapFirstRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(482, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Products Viewer / Catalog";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 123);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(81, 38);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(99, 120);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(368, 45);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // addSelectedToOrderListButton
            // 
            this.addSelectedToOrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedToOrderListButton.Location = new System.Drawing.Point(99, 475);
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
            this.deleteSelectedButton.Location = new System.Drawing.Point(99, 308);
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
            this.viewSelectedButton.Location = new System.Drawing.Point(99, 244);
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
            this.productsListBox.Location = new System.Drawing.Point(484, 120);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.productsListBox.Size = new System.Drawing.Size(539, 485);
            this.productsListBox.TabIndex = 6;
            // 
            // createNewProductButton
            // 
            this.createNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewProductButton.Location = new System.Drawing.Point(99, 372);
            this.createNewProductButton.Name = "createNewProductButton";
            this.createNewProductButton.Size = new System.Drawing.Size(272, 97);
            this.createNewProductButton.TabIndex = 11;
            this.createNewProductButton.Text = "Create New Product";
            this.createNewProductButton.UseVisualStyleBackColor = true;
            this.createNewProductButton.Click += new System.EventHandler(this.createNewProductButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAllButton.Location = new System.Drawing.Point(899, 71);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(123, 43);
            this.showAllButton.TabIndex = 23;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(485, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 43);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(536, 71);
            this.searchBox.MaxLength = 20;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(357, 43);
            this.searchBox.TabIndex = 21;
            // 
            // expensiveFirstRadioButton
            // 
            this.expensiveFirstRadioButton.AutoSize = true;
            this.expensiveFirstRadioButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expensiveFirstRadioButton.Location = new System.Drawing.Point(265, 182);
            this.expensiveFirstRadioButton.Name = "expensiveFirstRadioButton";
            this.expensiveFirstRadioButton.Size = new System.Drawing.Size(185, 35);
            this.expensiveFirstRadioButton.TabIndex = 26;
            this.expensiveFirstRadioButton.TabStop = true;
            this.expensiveFirstRadioButton.Text = "Expensive First";
            this.expensiveFirstRadioButton.UseVisualStyleBackColor = true;
            this.expensiveFirstRadioButton.CheckedChanged += new System.EventHandler(this.expensiveFirstRadioButton_CheckedChanged);
            // 
            // cheapFirstRadioButton
            // 
            this.cheapFirstRadioButton.AutoSize = true;
            this.cheapFirstRadioButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cheapFirstRadioButton.Location = new System.Drawing.Point(99, 182);
            this.cheapFirstRadioButton.Name = "cheapFirstRadioButton";
            this.cheapFirstRadioButton.Size = new System.Drawing.Size(149, 35);
            this.cheapFirstRadioButton.TabIndex = 25;
            this.cheapFirstRadioButton.TabStop = true;
            this.cheapFirstRadioButton.Text = "Cheap First";
            this.cheapFirstRadioButton.UseVisualStyleBackColor = true;
            this.cheapFirstRadioButton.CheckedChanged += new System.EventHandler(this.cheapFirstRadioButton_CheckedChanged);
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 645);
            this.Controls.Add(this.expensiveFirstRadioButton);
            this.Controls.Add(this.cheapFirstRadioButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
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
        private Button showAllButton;
        private Button searchButton;
        private TextBox searchBox;
        private RadioButton expensiveFirstRadioButton;
        private RadioButton cheapFirstRadioButton;
    }
}