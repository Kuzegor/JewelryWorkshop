namespace JewelryWorkshopWinFormsUI
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            this.headerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.processingLabel = new System.Windows.Forms.Label();
            this.compositionLabel = new System.Windows.Forms.Label();
            this.compositionDataGridView = new System.Windows.Forms.DataGridView();
            this.processingDataGridView = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.compositionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(291, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Product Viewer";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 85);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 38);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 134);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(81, 38);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 184);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(84, 38);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price:";
            // 
            // processingLabel
            // 
            this.processingLabel.AutoSize = true;
            this.processingLabel.Location = new System.Drawing.Point(12, 264);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(156, 38);
            this.processingLabel.TabIndex = 6;
            this.processingLabel.Text = "Processing:";
            // 
            // compositionLabel
            // 
            this.compositionLabel.AutoSize = true;
            this.compositionLabel.Location = new System.Drawing.Point(545, 264);
            this.compositionLabel.Name = "compositionLabel";
            this.compositionLabel.Size = new System.Drawing.Size(179, 38);
            this.compositionLabel.TabIndex = 7;
            this.compositionLabel.Text = "Composition:";
            // 
            // compositionDataGridView
            // 
            this.compositionDataGridView.AllowUserToAddRows = false;
            this.compositionDataGridView.AllowUserToDeleteRows = false;
            this.compositionDataGridView.AllowUserToOrderColumns = true;
            this.compositionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.compositionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.compositionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compositionDataGridView.Location = new System.Drawing.Point(545, 305);
            this.compositionDataGridView.Name = "compositionDataGridView";
            this.compositionDataGridView.ReadOnly = true;
            this.compositionDataGridView.RowHeadersWidth = 51;
            this.compositionDataGridView.RowTemplate.Height = 29;
            this.compositionDataGridView.Size = new System.Drawing.Size(511, 263);
            this.compositionDataGridView.TabIndex = 8;
            // 
            // processingDataGridView
            // 
            this.processingDataGridView.AllowUserToAddRows = false;
            this.processingDataGridView.AllowUserToDeleteRows = false;
            this.processingDataGridView.AllowUserToOrderColumns = true;
            this.processingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.processingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processingDataGridView.Location = new System.Drawing.Point(12, 305);
            this.processingDataGridView.Name = "processingDataGridView";
            this.processingDataGridView.ReadOnly = true;
            this.processingDataGridView.RowHeadersWidth = 51;
            this.processingDataGridView.RowTemplate.Height = 29;
            this.processingDataGridView.Size = new System.Drawing.Size(512, 263);
            this.processingDataGridView.TabIndex = 9;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(837, 16);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(219, 49);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit Product";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 581);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.processingDataGridView);
            this.Controls.Add(this.compositionDataGridView);
            this.Controls.Add(this.compositionLabel);
            this.Controls.Add(this.processingLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.compositionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label nameLabel;
        private Label typeLabel;
        private Label priceLabel;
        private Label processingLabel;
        private Label compositionLabel;
        private DataGridView compositionDataGridView;
        private DataGridView processingDataGridView;
        private Button editButton;
    }
}