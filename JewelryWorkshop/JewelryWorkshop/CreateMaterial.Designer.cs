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
            this.deleteSelectedMaterialButton.Location = new System.Drawing.Point(109, 396);
            this.deleteSelectedMaterialButton.Name = "deleteSelectedMaterialButton";
            this.deleteSelectedMaterialButton.Size = new System.Drawing.Size(254, 59);
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
            this.materialsDataGridView.Size = new System.Drawing.Size(513, 341);
            this.materialsDataGridView.TabIndex = 9;
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedButton.Location = new System.Drawing.Point(772, 62);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(214, 59);
            this.saveSelectedButton.TabIndex = 16;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click_1);
            // 
            // CreateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 476);
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
    }
}