namespace JewelryWorkshop
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.headerLabel = new System.Windows.Forms.Label();
            this.incompleteOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.createNewOrderButton = new System.Windows.Forms.Button();
            this.ViewSelectedButton = new System.Windows.Forms.Button();
            this.editDataButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(273, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Orders Viewer";
            // 
            // incompleteOnlyCheckBox
            // 
            this.incompleteOnlyCheckBox.AutoSize = true;
            this.incompleteOnlyCheckBox.Location = new System.Drawing.Point(69, 78);
            this.incompleteOnlyCheckBox.Name = "incompleteOnlyCheckBox";
            this.incompleteOnlyCheckBox.Size = new System.Drawing.Size(243, 42);
            this.incompleteOnlyCheckBox.TabIndex = 2;
            this.incompleteOnlyCheckBox.Text = "Incomplete Only";
            this.incompleteOnlyCheckBox.UseVisualStyleBackColor = true;
            this.incompleteOnlyCheckBox.CheckedChanged += new System.EventHandler(this.incompleteOnlyCheckBox_CheckedChanged);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Location = new System.Drawing.Point(22, 250);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(290, 51);
            this.deleteSelectedButton.TabIndex = 4;
            this.deleteSelectedButton.Text = "Delete Selected ";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // createNewOrderButton
            // 
            this.createNewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewOrderButton.Location = new System.Drawing.Point(22, 136);
            this.createNewOrderButton.Name = "createNewOrderButton";
            this.createNewOrderButton.Size = new System.Drawing.Size(290, 51);
            this.createNewOrderButton.TabIndex = 5;
            this.createNewOrderButton.Text = "Create New Order";
            this.createNewOrderButton.UseVisualStyleBackColor = true;
            this.createNewOrderButton.Click += new System.EventHandler(this.createNewOrderButton_Click);
            // 
            // ViewSelectedButton
            // 
            this.ViewSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSelectedButton.Location = new System.Drawing.Point(22, 193);
            this.ViewSelectedButton.Name = "ViewSelectedButton";
            this.ViewSelectedButton.Size = new System.Drawing.Size(290, 51);
            this.ViewSelectedButton.TabIndex = 6;
            this.ViewSelectedButton.Text = "View Selected";
            this.ViewSelectedButton.UseVisualStyleBackColor = true;
            this.ViewSelectedButton.Click += new System.EventHandler(this.ViewSelectedButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDataButton.Location = new System.Drawing.Point(22, 586);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(290, 51);
            this.editDataButton.TabIndex = 7;
            this.editDataButton.Text = "View And Edit Data";
            this.editDataButton.UseVisualStyleBackColor = true;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToOrderColumns = true;
            this.ordersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(335, 78);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 29;
            this.ordersDataGridView.Size = new System.Drawing.Size(708, 559);
            this.ordersDataGridView.TabIndex = 8;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 656);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.ViewSelectedButton);
            this.Controls.Add(this.createNewOrderButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.incompleteOnlyCheckBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private CheckBox incompleteOnlyCheckBox;
        private Button deleteSelectedButton;
        private Button createNewOrderButton;
        private Button ViewSelectedButton;
        private Button editDataButton;
        private DataGridView ordersDataGridView;
    }
}