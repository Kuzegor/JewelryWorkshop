﻿namespace JewelryWorkshopWinFormsUI
{
    partial class CreateClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClient));
            this.newClientGroupBox = new System.Windows.Forms.GroupBox();
            this.createClientButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.deleteSelectedClientButton = new System.Windows.Forms.Button();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveSelectedButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.rowsRadioButton = new System.Windows.Forms.RadioButton();
            this.columnsRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.newClientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newClientGroupBox
            // 
            this.newClientGroupBox.Controls.Add(this.createClientButton);
            this.newClientGroupBox.Controls.Add(this.firstNameTextBox);
            this.newClientGroupBox.Controls.Add(this.middleNameTextBox);
            this.newClientGroupBox.Controls.Add(this.phoneTextBox);
            this.newClientGroupBox.Controls.Add(this.lastNameTextBox);
            this.newClientGroupBox.Controls.Add(this.firstNameLabel);
            this.newClientGroupBox.Controls.Add(this.middleNameLabel);
            this.newClientGroupBox.Controls.Add(this.phoneLabel);
            this.newClientGroupBox.Controls.Add(this.lastNameLabel);
            this.newClientGroupBox.Location = new System.Drawing.Point(12, 82);
            this.newClientGroupBox.Name = "newClientGroupBox";
            this.newClientGroupBox.Size = new System.Drawing.Size(543, 358);
            this.newClientGroupBox.TabIndex = 4;
            this.newClientGroupBox.TabStop = false;
            this.newClientGroupBox.Text = "New Client";
            // 
            // createClientButton
            // 
            this.createClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createClientButton.Location = new System.Drawing.Point(163, 271);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(214, 59);
            this.createClientButton.TabIndex = 8;
            this.createClientButton.Text = "Create Client";
            this.createClientButton.UseVisualStyleBackColor = true;
            this.createClientButton.Click += new System.EventHandler(this.createClientButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(213, 103);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(309, 43);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(213, 152);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(309, 43);
            this.middleNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(213, 201);
            this.phoneTextBox.MaxLength = 20;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(309, 43);
            this.phoneTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(213, 54);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(309, 43);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 106);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(157, 38);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(16, 155);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(191, 38);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "Middle Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(16, 204);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(102, 38);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 57);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(153, 38);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(267, 54);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Client Creator";
            // 
            // deleteSelectedClientButton
            // 
            this.deleteSelectedClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedClientButton.Location = new System.Drawing.Point(158, 526);
            this.deleteSelectedClientButton.Name = "deleteSelectedClientButton";
            this.deleteSelectedClientButton.Size = new System.Drawing.Size(254, 59);
            this.deleteSelectedClientButton.TabIndex = 9;
            this.deleteSelectedClientButton.Text = "Delete Selected";
            this.deleteSelectedClientButton.UseVisualStyleBackColor = true;
            this.deleteSelectedClientButton.Click += new System.EventHandler(this.deleteSelectedClientButton_Click);
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(575, 82);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(106, 38);
            this.clientsLabel.TabIndex = 10;
            this.clientsLabel.Text = "Clients:";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AllowUserToOrderColumns = true;
            this.clientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(575, 123);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 29;
            this.clientsDataGridView.Size = new System.Drawing.Size(670, 465);
            this.clientsDataGridView.TabIndex = 11;
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedButton.Location = new System.Drawing.Point(158, 461);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(254, 59);
            this.saveSelectedButton.TabIndex = 12;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(753, 77);
            this.searchBox.MaxLength = 20;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(279, 43);
            this.searchBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(702, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 43);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAllButton.Location = new System.Drawing.Point(1038, 77);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(123, 43);
            this.showAllButton.TabIndex = 14;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // rowsRadioButton
            // 
            this.rowsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rowsRadioButton.AutoSize = true;
            this.rowsRadioButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowsRadioButton.Location = new System.Drawing.Point(996, 15);
            this.rowsRadioButton.Name = "rowsRadioButton";
            this.rowsRadioButton.Size = new System.Drawing.Size(88, 35);
            this.rowsRadioButton.TabIndex = 15;
            this.rowsRadioButton.TabStop = true;
            this.rowsRadioButton.Text = "Rows";
            this.rowsRadioButton.UseVisualStyleBackColor = true;
            this.rowsRadioButton.CheckedChanged += new System.EventHandler(this.rowsRadioButton_CheckedChanged);
            // 
            // columnsRadioButton
            // 
            this.columnsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.columnsRadioButton.AutoSize = true;
            this.columnsRadioButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.columnsRadioButton.Location = new System.Drawing.Point(1101, 15);
            this.columnsRadioButton.Name = "columnsRadioButton";
            this.columnsRadioButton.Size = new System.Drawing.Size(124, 35);
            this.columnsRadioButton.TabIndex = 16;
            this.columnsRadioButton.TabStop = true;
            this.columnsRadioButton.Text = "Columns";
            this.columnsRadioButton.UseVisualStyleBackColor = true;
            this.columnsRadioButton.CheckedChanged += new System.EventHandler(this.columnsRadioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selection Mode:";
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortButton.Location = new System.Drawing.Point(1167, 77);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(78, 43);
            this.sortButton.TabIndex = 17;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 600);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnsRadioButton);
            this.Controls.Add(this.rowsRadioButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.saveSelectedButton);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.deleteSelectedClientButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.newClientGroupBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateClient";
            this.Text = "CreateClient";
            this.newClientGroupBox.ResumeLayout(false);
            this.newClientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox newClientGroupBox;
        private Button createClientButton;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox phoneTextBox;
        private TextBox lastNameTextBox;
        private Label firstNameLabel;
        private Label middleNameLabel;
        private Label phoneLabel;
        private Label lastNameLabel;
        private Label headerLabel;
        private Button deleteSelectedClientButton;
        private Label clientsLabel;
        private DataGridView clientsDataGridView;
        private Button saveSelectedButton;
        private TextBox searchBox;
        private Button searchButton;
        private Button showAllButton;
        private RadioButton rowsRadioButton;
        private RadioButton columnsRadioButton;
        private Label label1;
        private Button sortButton;
    }
}