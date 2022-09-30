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
            this.techniquesDataGridView.ReadOnly = true;
            this.techniquesDataGridView.RowHeadersWidth = 51;
            this.techniquesDataGridView.RowTemplate.Height = 29;
            this.techniquesDataGridView.Size = new System.Drawing.Size(513, 341);
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
            // CreateTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 481);
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
    }
}