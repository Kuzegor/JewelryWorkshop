namespace JewelryWorkshopWinFormsUI
{
    partial class CreateMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMaterial));
            this.headerLabel = new System.Windows.Forms.Label();
            this.newMaterialGroupBox = new System.Windows.Forms.GroupBox();
            this.createMaterialButton = new System.Windows.Forms.Button();
            this.materialUnitTextBox = new System.Windows.Forms.TextBox();
            this.materialPriceTextBox = new System.Windows.Forms.TextBox();
            this.materialNameTextBox = new System.Windows.Forms.TextBox();
            this.materialUnitLabel = new System.Windows.Forms.Label();
            this.materialPriceLabel = new System.Windows.Forms.Label();
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.materialsLabel = new System.Windows.Forms.Label();
            this.deleteSelectedMaterialButton = new System.Windows.Forms.Button();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveSelectedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnsRadioButton = new System.Windows.Forms.RadioButton();
            this.rowsRadioButton = new System.Windows.Forms.RadioButton();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.newMaterialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(309, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Material Creator";
            // 
            // newMaterialGroupBox
            // 
            this.newMaterialGroupBox.Controls.Add(this.createMaterialButton);
            this.newMaterialGroupBox.Controls.Add(this.materialUnitTextBox);
            this.newMaterialGroupBox.Controls.Add(this.materialPriceTextBox);
            this.newMaterialGroupBox.Controls.Add(this.materialNameTextBox);
            this.newMaterialGroupBox.Controls.Add(this.materialUnitLabel);
            this.newMaterialGroupBox.Controls.Add(this.materialPriceLabel);
            this.newMaterialGroupBox.Controls.Add(this.materialNameLabel);
            this.newMaterialGroupBox.Location = new System.Drawing.Point(12, 83);
            this.newMaterialGroupBox.Name = "newMaterialGroupBox";
            this.newMaterialGroupBox.Size = new System.Drawing.Size(438, 298);
            this.newMaterialGroupBox.TabIndex = 1;
            this.newMaterialGroupBox.TabStop = false;
            this.newMaterialGroupBox.Text = "New Material";
            // 
            // createMaterialButton
            // 
            this.createMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMaterialButton.Location = new System.Drawing.Point(146, 216);
            this.createMaterialButton.Name = "createMaterialButton";
            this.createMaterialButton.Size = new System.Drawing.Size(154, 59);
            this.createMaterialButton.TabIndex = 6;
            this.createMaterialButton.Text = "Create";
            this.createMaterialButton.UseVisualStyleBackColor = true;
            this.createMaterialButton.Click += new System.EventHandler(this.createMaterialButton_Click);
            // 
            // materialUnitTextBox
            // 
            this.materialUnitTextBox.Location = new System.Drawing.Point(119, 154);
            this.materialUnitTextBox.Name = "materialUnitTextBox";
            this.materialUnitTextBox.Size = new System.Drawing.Size(299, 43);
            this.materialUnitTextBox.TabIndex = 5;
            // 
            // materialPriceTextBox
            // 
            this.materialPriceTextBox.Location = new System.Drawing.Point(119, 105);
            this.materialPriceTextBox.Name = "materialPriceTextBox";
            this.materialPriceTextBox.Size = new System.Drawing.Size(299, 43);
            this.materialPriceTextBox.TabIndex = 4;
            // 
            // materialNameTextBox
            // 
            this.materialNameTextBox.Location = new System.Drawing.Point(119, 56);
            this.materialNameTextBox.Name = "materialNameTextBox";
            this.materialNameTextBox.Size = new System.Drawing.Size(299, 43);
            this.materialNameTextBox.TabIndex = 3;
            // 
            // materialUnitLabel
            // 
            this.materialUnitLabel.AutoSize = true;
            this.materialUnitLabel.Location = new System.Drawing.Point(16, 157);
            this.materialUnitLabel.Name = "materialUnitLabel";
            this.materialUnitLabel.Size = new System.Drawing.Size(74, 38);
            this.materialUnitLabel.TabIndex = 2;
            this.materialUnitLabel.Text = "Unit:";
            // 
            // materialPriceLabel
            // 
            this.materialPriceLabel.AutoSize = true;
            this.materialPriceLabel.Location = new System.Drawing.Point(16, 108);
            this.materialPriceLabel.Name = "materialPriceLabel";
            this.materialPriceLabel.Size = new System.Drawing.Size(84, 38);
            this.materialPriceLabel.TabIndex = 1;
            this.materialPriceLabel.Text = "Price:";
            // 
            // materialNameLabel
            // 
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Location = new System.Drawing.Point(16, 59);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(97, 38);
            this.materialNameLabel.TabIndex = 0;
            this.materialNameLabel.Text = "Name:";
            // 
            // materialsLabel
            // 
            this.materialsLabel.AutoSize = true;
            this.materialsLabel.Location = new System.Drawing.Point(472, 83);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(136, 38);
            this.materialsLabel.TabIndex = 3;
            this.materialsLabel.Text = "Materials:";
            // 
            // deleteSelectedMaterialButton
            // 
            this.deleteSelectedMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMaterialButton.Location = new System.Drawing.Point(109, 398);
            this.deleteSelectedMaterialButton.Name = "deleteSelectedMaterialButton";
            this.deleteSelectedMaterialButton.Size = new System.Drawing.Size(254, 57);
            this.deleteSelectedMaterialButton.TabIndex = 8;
            this.deleteSelectedMaterialButton.Text = "Delete Selected";
            this.deleteSelectedMaterialButton.UseVisualStyleBackColor = true;
            this.deleteSelectedMaterialButton.Click += new System.EventHandler(this.deleteSelectedMaterialButton_Click);
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AllowUserToAddRows = false;
            this.materialsDataGridView.AllowUserToDeleteRows = false;
            this.materialsDataGridView.AllowUserToOrderColumns = true;
            this.materialsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Location = new System.Drawing.Point(472, 124);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersWidth = 51;
            this.materialsDataGridView.RowTemplate.Height = 29;
            this.materialsDataGridView.Size = new System.Drawing.Size(680, 402);
            this.materialsDataGridView.TabIndex = 9;
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedButton.Location = new System.Drawing.Point(109, 461);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(254, 57);
            this.saveSelectedButton.TabIndex = 16;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selection Mode:";
            // 
            // columnsRadioButton
            // 
            this.columnsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.columnsRadioButton.AutoSize = true;
            this.columnsRadioButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.columnsRadioButton.Location = new System.Drawing.Point(1008, 16);
            this.columnsRadioButton.Name = "columnsRadioButton";
            this.columnsRadioButton.Size = new System.Drawing.Size(124, 35);
            this.columnsRadioButton.TabIndex = 22;
            this.columnsRadioButton.TabStop = true;
            this.columnsRadioButton.Text = "Columns";
            this.columnsRadioButton.UseVisualStyleBackColor = true;
            this.columnsRadioButton.CheckedChanged += new System.EventHandler(this.columnsRadioButton_CheckedChanged);
            // 
            // rowsRadioButton
            // 
            this.rowsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rowsRadioButton.AutoSize = true;
            this.rowsRadioButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowsRadioButton.Location = new System.Drawing.Point(903, 16);
            this.rowsRadioButton.Name = "rowsRadioButton";
            this.rowsRadioButton.Size = new System.Drawing.Size(88, 35);
            this.rowsRadioButton.TabIndex = 21;
            this.rowsRadioButton.TabStop = true;
            this.rowsRadioButton.Text = "Rows";
            this.rowsRadioButton.UseVisualStyleBackColor = true;
            this.rowsRadioButton.CheckedChanged += new System.EventHandler(this.rowsRadioButton_CheckedChanged);
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAllButton.Location = new System.Drawing.Point(945, 78);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(123, 43);
            this.showAllButton.TabIndex = 20;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(615, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 43);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(666, 78);
            this.searchBox.MaxLength = 20;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(273, 43);
            this.searchBox.TabIndex = 18;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortButton.Location = new System.Drawing.Point(1074, 78);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(78, 43);
            this.sortButton.TabIndex = 23;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // CreateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 537);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnsRadioButton);
            this.Controls.Add(this.rowsRadioButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.saveSelectedButton);
            this.Controls.Add(this.materialsDataGridView);
            this.Controls.Add(this.deleteSelectedMaterialButton);
            this.Controls.Add(this.materialsLabel);
            this.Controls.Add(this.newMaterialGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateMaterial";
            this.Text = "CreateMaterial";
            this.newMaterialGroupBox.ResumeLayout(false);
            this.newMaterialGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private GroupBox newMaterialGroupBox;
        private Label materialUnitLabel;
        private Label materialPriceLabel;
        private Label materialNameLabel;
        private Button createMaterialButton;
        private TextBox materialUnitTextBox;
        private TextBox materialPriceTextBox;
        private TextBox materialNameTextBox;
        private Label materialsLabel;
        private Button deleteSelectedMaterialButton;
        private DataGridView materialsDataGridView;
        private Button saveSelectedButton;
        private Label label1;
        private RadioButton columnsRadioButton;
        private RadioButton rowsRadioButton;
        private Button showAllButton;
        private Button searchButton;
        private TextBox searchBox;
        private Button sortButton;
    }
}