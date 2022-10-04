namespace JewelryWorkshopWinFormsUI
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
            this.deleteSelectedClientButton.Location = new System.Drawing.Point(158, 463);
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
            this.clientsDataGridView.Size = new System.Drawing.Size(644, 409);
            this.clientsDataGridView.TabIndex = 11;
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedButton.Location = new System.Drawing.Point(1005, 58);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(214, 59);
            this.saveSelectedButton.TabIndex = 12;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click);
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 544);
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
    }
}