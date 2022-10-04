namespace JewelryWorkshopWinFormsUI
{
    partial class CreateType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateType));
            this.headerLabel = new System.Windows.Forms.Label();
            this.productTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.createTypeButton = new System.Windows.Forms.Button();
            this.newProductTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.deleteSelectedTypeButton = new System.Windows.Forms.Button();
            this.saveSelectedButton = new System.Windows.Forms.Button();
            this.productTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.newProductTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(247, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Type Creator";
            // 
            // productTypeNameTextBox
            // 
            this.productTypeNameTextBox.Location = new System.Drawing.Point(19, 56);
            this.productTypeNameTextBox.Name = "productTypeNameTextBox";
            this.productTypeNameTextBox.Size = new System.Drawing.Size(369, 43);
            this.productTypeNameTextBox.TabIndex = 2;
            // 
            // createTypeButton
            // 
            this.createTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTypeButton.Location = new System.Drawing.Point(139, 115);
            this.createTypeButton.Name = "createTypeButton";
            this.createTypeButton.Size = new System.Drawing.Size(133, 55);
            this.createTypeButton.TabIndex = 3;
            this.createTypeButton.Text = "Create";
            this.createTypeButton.UseVisualStyleBackColor = true;
            this.createTypeButton.Click += new System.EventHandler(this.createTypeButton_Click);
            // 
            // newProductTypeGroupBox
            // 
            this.newProductTypeGroupBox.Controls.Add(this.productTypeNameTextBox);
            this.newProductTypeGroupBox.Controls.Add(this.createTypeButton);
            this.newProductTypeGroupBox.Location = new System.Drawing.Point(12, 80);
            this.newProductTypeGroupBox.Name = "newProductTypeGroupBox";
            this.newProductTypeGroupBox.Size = new System.Drawing.Size(410, 191);
            this.newProductTypeGroupBox.TabIndex = 4;
            this.newProductTypeGroupBox.TabStop = false;
            this.newProductTypeGroupBox.Text = "New Product Type";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Location = new System.Drawing.Point(438, 80);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(197, 38);
            this.productTypeLabel.TabIndex = 6;
            this.productTypeLabel.Text = "Product Types:";
            // 
            // deleteSelectedTypeButton
            // 
            this.deleteSelectedTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTypeButton.Location = new System.Drawing.Point(87, 287);
            this.deleteSelectedTypeButton.Name = "deleteSelectedTypeButton";
            this.deleteSelectedTypeButton.Size = new System.Drawing.Size(254, 55);
            this.deleteSelectedTypeButton.TabIndex = 7;
            this.deleteSelectedTypeButton.Text = "Delete Selected";
            this.deleteSelectedTypeButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTypeButton.Click += new System.EventHandler(this.deleteSelectedTypeButton_Click);
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedButton.Location = new System.Drawing.Point(726, 56);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(214, 59);
            this.saveSelectedButton.TabIndex = 13;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click);
            // 
            // productTypesDataGridView
            // 
            this.productTypesDataGridView.AllowUserToAddRows = false;
            this.productTypesDataGridView.AllowUserToDeleteRows = false;
            this.productTypesDataGridView.AllowUserToOrderColumns = true;
            this.productTypesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productTypesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypesDataGridView.Location = new System.Drawing.Point(438, 121);
            this.productTypesDataGridView.Name = "productTypesDataGridView";
            this.productTypesDataGridView.RowHeadersWidth = 51;
            this.productTypesDataGridView.RowTemplate.Height = 29;
            this.productTypesDataGridView.Size = new System.Drawing.Size(506, 234);
            this.productTypesDataGridView.TabIndex = 14;
            // 
            // CreateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 367);
            this.Controls.Add(this.productTypesDataGridView);
            this.Controls.Add(this.saveSelectedButton);
            this.Controls.Add(this.deleteSelectedTypeButton);
            this.Controls.Add(this.productTypeLabel);
            this.Controls.Add(this.newProductTypeGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateType";
            this.Text = "CreateType";
            this.newProductTypeGroupBox.ResumeLayout(false);
            this.newProductTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox productTypeNameTextBox;
        private Button createTypeButton;
        private GroupBox newProductTypeGroupBox;
        private Label productTypeLabel;
        private Button deleteSelectedTypeButton;
        private Button saveSelectedButton;
        private DataGridView productTypesDataGridView;
    }
}