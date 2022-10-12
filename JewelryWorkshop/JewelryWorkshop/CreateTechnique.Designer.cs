namespace JewelryWorkshopWinFormsUI
{
    partial class CreateTechnique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTechnique));
            this.techniquesDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteSelectedTechniqueButton = new System.Windows.Forms.Button();
            this.jewelryTechniquesLabel = new System.Windows.Forms.Label();
            this.newTechniquelGroupBox = new System.Windows.Forms.GroupBox();
            this.createTechniqueButton = new System.Windows.Forms.Button();
            this.techniqueUnitTextBox = new System.Windows.Forms.TextBox();
            this.techniquePriceTextBox = new System.Windows.Forms.TextBox();
            this.techniqueNameTextBox = new System.Windows.Forms.TextBox();
            this.techniqueUnitLabel = new System.Windows.Forms.Label();
            this.techniquePriceLabel = new System.Windows.Forms.Label();
            this.techniqueNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.saveSelectedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnsRadioButton = new System.Windows.Forms.RadioButton();
            this.rowsRadioButton = new System.Windows.Forms.RadioButton();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.techniquesDataGridView)).BeginInit();
            this.newTechniquelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // techniquesDataGridView
            // 
            this.techniquesDataGridView.AllowUserToAddRows = false;
            this.techniquesDataGridView.AllowUserToDeleteRows = false;
            this.techniquesDataGridView.AllowUserToOrderColumns = true;
            this.techniquesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.techniquesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.techniquesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.techniquesDataGridView.Location = new System.Drawing.Point(472, 124);
            this.techniquesDataGridView.Name = "techniquesDataGridView";
            this.techniquesDataGridView.RowHeadersWidth = 51;
            this.techniquesDataGridView.RowTemplate.Height = 29;
            this.techniquesDataGridView.Size = new System.Drawing.Size(800, 388);
            this.techniquesDataGridView.TabIndex = 14;
            // 
            // deleteSelectedTechniqueButton
            // 
            this.deleteSelectedTechniqueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTechniqueButton.Location = new System.Drawing.Point(110, 396);
            this.deleteSelectedTechniqueButton.Name = "deleteSelectedTechniqueButton";
            this.deleteSelectedTechniqueButton.Size = new System.Drawing.Size(254, 55);
            this.deleteSelectedTechniqueButton.TabIndex = 13;
            this.deleteSelectedTechniqueButton.Text = "Delete Selected";
            this.deleteSelectedTechniqueButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTechniqueButton.Click += new System.EventHandler(this.deleteSelectedTechniqueButton_Click);
            // 
            // jewelryTechniquesLabel
            // 
            this.jewelryTechniquesLabel.AutoSize = true;
            this.jewelryTechniquesLabel.Location = new System.Drawing.Point(472, 83);
            this.jewelryTechniquesLabel.Name = "jewelryTechniquesLabel";
            this.jewelryTechniquesLabel.Size = new System.Drawing.Size(261, 38);
            this.jewelryTechniquesLabel.TabIndex = 12;
            this.jewelryTechniquesLabel.Text = "Jewelry Techniques:";
            // 
            // newTechniquelGroupBox
            // 
            this.newTechniquelGroupBox.Controls.Add(this.createTechniqueButton);
            this.newTechniquelGroupBox.Controls.Add(this.techniqueUnitTextBox);
            this.newTechniquelGroupBox.Controls.Add(this.techniquePriceTextBox);
            this.newTechniquelGroupBox.Controls.Add(this.techniqueNameTextBox);
            this.newTechniquelGroupBox.Controls.Add(this.techniqueUnitLabel);
            this.newTechniquelGroupBox.Controls.Add(this.techniquePriceLabel);
            this.newTechniquelGroupBox.Controls.Add(this.techniqueNameLabel);
            this.newTechniquelGroupBox.Location = new System.Drawing.Point(12, 83);
            this.newTechniquelGroupBox.Name = "newTechniquelGroupBox";
            this.newTechniquelGroupBox.Size = new System.Drawing.Size(438, 298);
            this.newTechniquelGroupBox.TabIndex = 11;
            this.newTechniquelGroupBox.TabStop = false;
            this.newTechniquelGroupBox.Text = "New Technique";
            // 
            // createTechniqueButton
            // 
            this.createTechniqueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTechniqueButton.Location = new System.Drawing.Point(146, 216);
            this.createTechniqueButton.Name = "createTechniqueButton";
            this.createTechniqueButton.Size = new System.Drawing.Size(154, 59);
            this.createTechniqueButton.TabIndex = 6;
            this.createTechniqueButton.Text = "Create";
            this.createTechniqueButton.UseVisualStyleBackColor = true;
            this.createTechniqueButton.Click += new System.EventHandler(this.createTechniqueButton_Click);
            // 
            // techniqueUnitTextBox
            // 
            this.techniqueUnitTextBox.Location = new System.Drawing.Point(119, 154);
            this.techniqueUnitTextBox.Name = "techniqueUnitTextBox";
            this.techniqueUnitTextBox.Size = new System.Drawing.Size(299, 43);
            this.techniqueUnitTextBox.TabIndex = 5;
            // 
            // techniquePriceTextBox
            // 
            this.techniquePriceTextBox.Location = new System.Drawing.Point(119, 105);
            this.techniquePriceTextBox.Name = "techniquePriceTextBox";
            this.techniquePriceTextBox.Size = new System.Drawing.Size(299, 43);
            this.techniquePriceTextBox.TabIndex = 4;
            // 
            // techniqueNameTextBox
            // 
            this.techniqueNameTextBox.Location = new System.Drawing.Point(119, 56);
            this.techniqueNameTextBox.Name = "techniqueNameTextBox";
            this.techniqueNameTextBox.Size = new System.Drawing.Size(299, 43);
            this.techniqueNameTextBox.TabIndex = 3;
            // 
            // techniqueUnitLabel
            // 
            this.techniqueUnitLabel.AutoSize = true;
            this.techniqueUnitLabel.Location = new System.Drawing.Point(16, 157);
            this.techniqueUnitLabel.Name = "techniqueUnitLabel";
            this.techniqueUnitLabel.Size = new System.Drawing.Size(74, 38);
            this.techniqueUnitLabel.TabIndex = 2;
            this.techniqueUnitLabel.Text = "Unit:";
            // 
            // techniquePriceLabel
            // 
            this.techniquePriceLabel.AutoSize = true;
            this.techniquePriceLabel.Location = new System.Drawing.Point(16, 108);
            this.techniquePriceLabel.Name = "techniquePriceLabel";
            this.techniquePriceLabel.Size = new System.Drawing.Size(84, 38);
            this.techniquePriceLabel.TabIndex = 1;
            this.techniquePriceLabel.Text = "Price:";
            // 
            // techniqueNameLabel
            // 
            this.techniqueNameLabel.AutoSize = true;
            this.techniqueNameLabel.Location = new System.Drawing.Point(16, 59);
            this.techniqueNameLabel.Name = "techniqueNameLabel";
            this.techniqueNameLabel.Size = new System.Drawing.Size(97, 38);
            this.techniqueNameLabel.TabIndex = 0;
            this.techniqueNameLabel.Text = "Name:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(344, 54);
            this.headerLabel.TabIndex = 10;
            this.headerLabel.Text = "Technique Creator";
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedButton.Location = new System.Drawing.Point(110, 457);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(254, 55);
            this.saveSelectedButton.TabIndex = 15;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 13);
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
            this.columnsRadioButton.Location = new System.Drawing.Point(1130, 16);
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
            this.rowsRadioButton.Location = new System.Drawing.Point(1025, 16);
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
            this.showAllButton.Location = new System.Drawing.Point(1065, 78);
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
            this.searchButton.Location = new System.Drawing.Point(737, 78);
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
            this.searchBox.Location = new System.Drawing.Point(788, 78);
            this.searchBox.MaxLength = 20;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(271, 43);
            this.searchBox.TabIndex = 18;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortButton.Location = new System.Drawing.Point(1194, 78);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(78, 43);
            this.sortButton.TabIndex = 23;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // CreateTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 528);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnsRadioButton);
            this.Controls.Add(this.rowsRadioButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.saveSelectedButton);
            this.Controls.Add(this.techniquesDataGridView);
            this.Controls.Add(this.deleteSelectedTechniqueButton);
            this.Controls.Add(this.jewelryTechniquesLabel);
            this.Controls.Add(this.newTechniquelGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTechnique";
            this.Text = "CreateTechnique";
            ((System.ComponentModel.ISupportInitialize)(this.techniquesDataGridView)).EndInit();
            this.newTechniquelGroupBox.ResumeLayout(false);
            this.newTechniquelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView techniquesDataGridView;
        private Button deleteSelectedTechniqueButton;
        private Label jewelryTechniquesLabel;
        private GroupBox newTechniquelGroupBox;
        private Button createTechniqueButton;
        private TextBox techniqueUnitTextBox;
        private TextBox techniquePriceTextBox;
        private TextBox techniqueNameTextBox;
        private Label techniqueUnitLabel;
        private Label techniquePriceLabel;
        private Label techniqueNameLabel;
        private Label headerLabel;
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