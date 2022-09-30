namespace JewelryWorkshopWinFormsUI
{
    partial class ViewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrder));
            this.headerLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.markAsCompleteCheckBox = new System.Windows.Forms.CheckBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.orderListLabel = new System.Windows.Forms.Label();
            this.viewSelectedButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(256, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Order Viewer";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 135);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(50, 38);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 188);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(94, 38);
            this.clientLabel.TabIndex = 2;
            this.clientLabel.Text = "Client:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(12, 244);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(146, 38);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // markAsCompleteCheckBox
            // 
            this.markAsCompleteCheckBox.AutoSize = true;
            this.markAsCompleteCheckBox.Location = new System.Drawing.Point(21, 81);
            this.markAsCompleteCheckBox.Name = "markAsCompleteCheckBox";
            this.markAsCompleteCheckBox.Size = new System.Drawing.Size(267, 42);
            this.markAsCompleteCheckBox.TabIndex = 4;
            this.markAsCompleteCheckBox.Text = "Mark As Complete";
            this.markAsCompleteCheckBox.UseVisualStyleBackColor = true;
            this.markAsCompleteCheckBox.CheckedChanged += new System.EventHandler(this.markAsCompleteCheckBox_CheckedChanged);
            // 
            // productsListBox
            // 
            this.productsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 37;
            this.productsListBox.Location = new System.Drawing.Point(18, 398);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(556, 226);
            this.productsListBox.TabIndex = 5;
            // 
            // orderListLabel
            // 
            this.orderListLabel.AutoSize = true;
            this.orderListLabel.Location = new System.Drawing.Point(18, 357);
            this.orderListLabel.Name = "orderListLabel";
            this.orderListLabel.Size = new System.Drawing.Size(144, 38);
            this.orderListLabel.TabIndex = 6;
            this.orderListLabel.Text = "Order List:";
            // 
            // viewSelectedButton
            // 
            this.viewSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedButton.Location = new System.Drawing.Point(595, 461);
            this.viewSelectedButton.Name = "viewSelectedButton";
            this.viewSelectedButton.Size = new System.Drawing.Size(148, 104);
            this.viewSelectedButton.TabIndex = 7;
            this.viewSelectedButton.Text = "View Selected";
            this.viewSelectedButton.UseVisualStyleBackColor = true;
            this.viewSelectedButton.Click += new System.EventHandler(this.viewSelectedButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(12, 302);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(150, 38);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 645);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.viewSelectedButton);
            this.Controls.Add(this.orderListLabel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.markAsCompleteCheckBox);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label idLabel;
        private Label clientLabel;
        private Label startDateLabel;
        private CheckBox markAsCompleteCheckBox;
        private ListBox productsListBox;
        private Label orderListLabel;
        private Button viewSelectedButton;
        private Label totalPriceLabel;
    }
}