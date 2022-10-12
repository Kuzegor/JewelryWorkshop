namespace JewelryWorkshop
{
    partial class CreateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProduct));
            this.headerLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.materialAmountTextBox = new System.Windows.Forms.TextBox();
            this.materialUnitLabel = new System.Windows.Forms.Label();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialAmountLabel = new System.Windows.Forms.Label();
            this.removeMaterialsButton = new System.Windows.Forms.Button();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.newMaterialLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newTechniqueLinkLabel = new System.Windows.Forms.LinkLabel();
            this.removeTechniquesButton = new System.Windows.Forms.Button();
            this.techniqueAmountLabel = new System.Windows.Forms.Label();
            this.techniqueLabel = new System.Windows.Forms.Label();
            this.addTechniqueButton = new System.Windows.Forms.Button();
            this.techniqueUnitLabel = new System.Windows.Forms.Label();
            this.techniqueAmountTextBox = new System.Windows.Forms.TextBox();
            this.techniqueComboBox = new System.Windows.Forms.ComboBox();
            this.newProductTypeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createProductButton = new System.Windows.Forms.Button();
            this.addedMaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.addedTechniquesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.addedMaterialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedTechniquesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(301, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Product Creator";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(12, 78);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(97, 38);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Name:";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Location = new System.Drawing.Point(12, 166);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(81, 38);
            this.productTypeLabel.TabIndex = 2;
            this.productTypeLabel.Text = "Type:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(115, 78);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(349, 43);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Location = new System.Drawing.Point(115, 163);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(349, 45);
            this.productTypeComboBox.TabIndex = 4;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(164, 265);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(300, 45);
            this.materialComboBox.TabIndex = 6;
            this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // materialAmountTextBox
            // 
            this.materialAmountTextBox.Location = new System.Drawing.Point(164, 363);
            this.materialAmountTextBox.Name = "materialAmountTextBox";
            this.materialAmountTextBox.Size = new System.Drawing.Size(300, 43);
            this.materialAmountTextBox.TabIndex = 7;
            // 
            // materialUnitLabel
            // 
            this.materialUnitLabel.AutoSize = true;
            this.materialUnitLabel.Location = new System.Drawing.Point(12, 316);
            this.materialUnitLabel.Name = "materialUnitLabel";
            this.materialUnitLabel.Size = new System.Drawing.Size(74, 38);
            this.materialUnitLabel.TabIndex = 8;
            this.materialUnitLabel.Text = "Unit:";
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMaterialButton.Location = new System.Drawing.Point(164, 421);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(133, 49);
            this.addMaterialButton.TabIndex = 9;
            this.addMaterialButton.Text = "Add ";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(12, 268);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(124, 38);
            this.materialLabel.TabIndex = 15;
            this.materialLabel.Text = "Material:";
            // 
            // materialAmountLabel
            // 
            this.materialAmountLabel.AutoSize = true;
            this.materialAmountLabel.Location = new System.Drawing.Point(12, 366);
            this.materialAmountLabel.Name = "materialAmountLabel";
            this.materialAmountLabel.Size = new System.Drawing.Size(122, 38);
            this.materialAmountLabel.TabIndex = 16;
            this.materialAmountLabel.Text = "Amount:";
            // 
            // removeMaterialsButton
            // 
            this.removeMaterialsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeMaterialsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMaterialsButton.Location = new System.Drawing.Point(1016, 316);
            this.removeMaterialsButton.Name = "removeMaterialsButton";
            this.removeMaterialsButton.Size = new System.Drawing.Size(146, 102);
            this.removeMaterialsButton.TabIndex = 17;
            this.removeMaterialsButton.Text = "Remove Selected";
            this.removeMaterialsButton.UseVisualStyleBackColor = true;
            this.removeMaterialsButton.Click += new System.EventHandler(this.removeMaterialsButton_Click);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(480, 170);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(188, 38);
            this.productPriceLabel.TabIndex = 18;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // newMaterialLinkLabel
            // 
            this.newMaterialLinkLabel.AutoSize = true;
            this.newMaterialLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMaterialLinkLabel.Location = new System.Drawing.Point(352, 234);
            this.newMaterialLinkLabel.Name = "newMaterialLinkLabel";
            this.newMaterialLinkLabel.Size = new System.Drawing.Size(112, 28);
            this.newMaterialLinkLabel.TabIndex = 27;
            this.newMaterialLinkLabel.TabStop = true;
            this.newMaterialLinkLabel.Text = "Create New";
            this.newMaterialLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newMaterialLinkLabel_LinkClicked);
            // 
            // newTechniqueLinkLabel
            // 
            this.newTechniqueLinkLabel.AutoSize = true;
            this.newTechniqueLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newTechniqueLinkLabel.Location = new System.Drawing.Point(352, 509);
            this.newTechniqueLinkLabel.Name = "newTechniqueLinkLabel";
            this.newTechniqueLinkLabel.Size = new System.Drawing.Size(112, 28);
            this.newTechniqueLinkLabel.TabIndex = 36;
            this.newTechniqueLinkLabel.TabStop = true;
            this.newTechniqueLinkLabel.Text = "Create New";
            this.newTechniqueLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newTechniqueLinkLabel_LinkClicked);
            // 
            // removeTechniquesButton
            // 
            this.removeTechniquesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeTechniquesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTechniquesButton.Location = new System.Drawing.Point(1016, 591);
            this.removeTechniquesButton.Name = "removeTechniquesButton";
            this.removeTechniquesButton.Size = new System.Drawing.Size(146, 102);
            this.removeTechniquesButton.TabIndex = 35;
            this.removeTechniquesButton.Text = "Remove Selected";
            this.removeTechniquesButton.UseVisualStyleBackColor = true;
            this.removeTechniquesButton.Click += new System.EventHandler(this.removeTechniquesButton_Click);
            // 
            // techniqueAmountLabel
            // 
            this.techniqueAmountLabel.AutoSize = true;
            this.techniqueAmountLabel.Location = new System.Drawing.Point(12, 641);
            this.techniqueAmountLabel.Name = "techniqueAmountLabel";
            this.techniqueAmountLabel.Size = new System.Drawing.Size(122, 38);
            this.techniqueAmountLabel.TabIndex = 34;
            this.techniqueAmountLabel.Text = "Amount:";
            // 
            // techniqueLabel
            // 
            this.techniqueLabel.AutoSize = true;
            this.techniqueLabel.Location = new System.Drawing.Point(12, 543);
            this.techniqueLabel.Name = "techniqueLabel";
            this.techniqueLabel.Size = new System.Drawing.Size(149, 38);
            this.techniqueLabel.TabIndex = 33;
            this.techniqueLabel.Text = "Technique:";
            // 
            // addTechniqueButton
            // 
            this.addTechniqueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTechniqueButton.Location = new System.Drawing.Point(164, 696);
            this.addTechniqueButton.Name = "addTechniqueButton";
            this.addTechniqueButton.Size = new System.Drawing.Size(133, 49);
            this.addTechniqueButton.TabIndex = 31;
            this.addTechniqueButton.Text = "Add ";
            this.addTechniqueButton.UseVisualStyleBackColor = true;
            this.addTechniqueButton.Click += new System.EventHandler(this.addTechniqueButton_Click);
            // 
            // techniqueUnitLabel
            // 
            this.techniqueUnitLabel.AutoSize = true;
            this.techniqueUnitLabel.Location = new System.Drawing.Point(12, 591);
            this.techniqueUnitLabel.Name = "techniqueUnitLabel";
            this.techniqueUnitLabel.Size = new System.Drawing.Size(74, 38);
            this.techniqueUnitLabel.TabIndex = 30;
            this.techniqueUnitLabel.Text = "Unit:";
            // 
            // techniqueAmountTextBox
            // 
            this.techniqueAmountTextBox.Location = new System.Drawing.Point(164, 638);
            this.techniqueAmountTextBox.Name = "techniqueAmountTextBox";
            this.techniqueAmountTextBox.Size = new System.Drawing.Size(300, 43);
            this.techniqueAmountTextBox.TabIndex = 29;
            // 
            // techniqueComboBox
            // 
            this.techniqueComboBox.FormattingEnabled = true;
            this.techniqueComboBox.Location = new System.Drawing.Point(164, 540);
            this.techniqueComboBox.Name = "techniqueComboBox";
            this.techniqueComboBox.Size = new System.Drawing.Size(300, 45);
            this.techniqueComboBox.TabIndex = 28;
            this.techniqueComboBox.SelectedIndexChanged += new System.EventHandler(this.techniqueComboBox_SelectedIndexChanged);
            // 
            // newProductTypeLinkLabel
            // 
            this.newProductTypeLinkLabel.AutoSize = true;
            this.newProductTypeLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newProductTypeLinkLabel.Location = new System.Drawing.Point(352, 132);
            this.newProductTypeLinkLabel.Name = "newProductTypeLinkLabel";
            this.newProductTypeLinkLabel.Size = new System.Drawing.Size(112, 28);
            this.newProductTypeLinkLabel.TabIndex = 37;
            this.newProductTypeLinkLabel.TabStop = true;
            this.newProductTypeLinkLabel.Text = "Create New";
            this.newProductTypeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newProductTypeLinkLabel_LinkClicked);
            // 
            // createProductButton
            // 
            this.createProductButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProductButton.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createProductButton.Location = new System.Drawing.Point(419, 769);
            this.createProductButton.Name = "createProductButton";
            this.createProductButton.Size = new System.Drawing.Size(339, 90);
            this.createProductButton.TabIndex = 38;
            this.createProductButton.Text = "Create Product";
            this.createProductButton.UseVisualStyleBackColor = true;
            this.createProductButton.Click += new System.EventHandler(this.createProductButton_Click);
            // 
            // addedMaterialsDataGridView
            // 
            this.addedMaterialsDataGridView.AllowUserToAddRows = false;
            this.addedMaterialsDataGridView.AllowUserToDeleteRows = false;
            this.addedMaterialsDataGridView.AllowUserToOrderColumns = true;
            this.addedMaterialsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addedMaterialsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.addedMaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedMaterialsDataGridView.Location = new System.Drawing.Point(480, 234);
            this.addedMaterialsDataGridView.Name = "addedMaterialsDataGridView";
            this.addedMaterialsDataGridView.ReadOnly = true;
            this.addedMaterialsDataGridView.RowHeadersWidth = 51;
            this.addedMaterialsDataGridView.RowTemplate.Height = 29;
            this.addedMaterialsDataGridView.Size = new System.Drawing.Size(517, 236);
            this.addedMaterialsDataGridView.TabIndex = 39;
            // 
            // addedTechniquesDataGridView
            // 
            this.addedTechniquesDataGridView.AllowUserToAddRows = false;
            this.addedTechniquesDataGridView.AllowUserToDeleteRows = false;
            this.addedTechniquesDataGridView.AllowUserToOrderColumns = true;
            this.addedTechniquesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addedTechniquesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.addedTechniquesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedTechniquesDataGridView.Location = new System.Drawing.Point(480, 509);
            this.addedTechniquesDataGridView.Name = "addedTechniquesDataGridView";
            this.addedTechniquesDataGridView.ReadOnly = true;
            this.addedTechniquesDataGridView.RowHeadersWidth = 51;
            this.addedTechniquesDataGridView.RowTemplate.Height = 29;
            this.addedTechniquesDataGridView.Size = new System.Drawing.Size(517, 236);
            this.addedTechniquesDataGridView.TabIndex = 40;
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 880);
            this.Controls.Add(this.addedTechniquesDataGridView);
            this.Controls.Add(this.addedMaterialsDataGridView);
            this.Controls.Add(this.createProductButton);
            this.Controls.Add(this.newProductTypeLinkLabel);
            this.Controls.Add(this.newTechniqueLinkLabel);
            this.Controls.Add(this.removeTechniquesButton);
            this.Controls.Add(this.techniqueAmountLabel);
            this.Controls.Add(this.techniqueLabel);
            this.Controls.Add(this.addTechniqueButton);
            this.Controls.Add(this.techniqueUnitLabel);
            this.Controls.Add(this.techniqueAmountTextBox);
            this.Controls.Add(this.techniqueComboBox);
            this.Controls.Add(this.newMaterialLinkLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.removeMaterialsButton);
            this.Controls.Add(this.materialAmountLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.materialUnitLabel);
            this.Controls.Add(this.materialAmountTextBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.productTypeComboBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productTypeLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateProduct";
            this.Text = "CreateProduct";
            ((System.ComponentModel.ISupportInitialize)(this.addedMaterialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedTechniquesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label productNameLabel;
        private Label productTypeLabel;
        private TextBox productNameTextBox;
        private ComboBox productTypeComboBox;
        private ComboBox materialComboBox;
        private TextBox materialAmountTextBox;
        private Label materialUnitLabel;
        private Button addMaterialButton;
        private Label materialLabel;
        private Label materialAmountLabel;
        private Button removeMaterialsButton;
        private Label productPriceLabel;
        private LinkLabel newMaterialLinkLabel;
        private LinkLabel newTechniqueLinkLabel;
        private Button removeTechniquesButton;
        private Label techniqueAmountLabel;
        private Label techniqueLabel;
        private Button addTechniqueButton;
        private Label techniqueUnitLabel;
        private TextBox techniqueAmountTextBox;
        private ComboBox techniqueComboBox;
        private LinkLabel newProductTypeLinkLabel;
        private Button createProductButton;
        private DataGridView addedMaterialsDataGridView;
        private DataGridView addedTechniquesDataGridView;
    }
}