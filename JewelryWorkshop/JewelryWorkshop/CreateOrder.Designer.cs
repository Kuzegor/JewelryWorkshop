namespace JewelryWorkshopWinFormsUI
{
    partial class CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.headerLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.viewProductsButton = new System.Windows.Forms.Button();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.orderListLabel = new System.Windows.Forms.Label();
            this.removeSelectedOrdersButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.createNewClientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewSelectedProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(266, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Order Creator";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 115);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(94, 38);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Client:";
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(112, 112);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(440, 45);
            this.clientComboBox.TabIndex = 2;
            // 
            // viewProductsButton
            // 
            this.viewProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProductsButton.Location = new System.Drawing.Point(121, 187);
            this.viewProductsButton.Name = "viewProductsButton";
            this.viewProductsButton.Size = new System.Drawing.Size(329, 115);
            this.viewProductsButton.TabIndex = 9;
            this.viewProductsButton.Text = "View Existing Products And Create New";
            this.viewProductsButton.UseVisualStyleBackColor = true;
            this.viewProductsButton.Click += new System.EventHandler(this.viewProductsButton_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 37;
            this.productsListBox.Location = new System.Drawing.Point(571, 112);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.productsListBox.Size = new System.Drawing.Size(551, 374);
            this.productsListBox.TabIndex = 11;
            // 
            // orderListLabel
            // 
            this.orderListLabel.AutoSize = true;
            this.orderListLabel.Location = new System.Drawing.Point(571, 69);
            this.orderListLabel.Name = "orderListLabel";
            this.orderListLabel.Size = new System.Drawing.Size(144, 38);
            this.orderListLabel.TabIndex = 12;
            this.orderListLabel.Text = "Order List:";
            // 
            // removeSelectedOrdersButton
            // 
            this.removeSelectedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedOrdersButton.Location = new System.Drawing.Point(121, 377);
            this.removeSelectedOrdersButton.Name = "removeSelectedOrdersButton";
            this.removeSelectedOrdersButton.Size = new System.Drawing.Size(329, 63);
            this.removeSelectedOrdersButton.TabIndex = 13;
            this.removeSelectedOrdersButton.Text = "Remove Selected";
            this.removeSelectedOrdersButton.UseVisualStyleBackColor = true;
            this.removeSelectedOrdersButton.Click += new System.EventHandler(this.removeSelectedOrdersButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrderButton.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateOrderButton.Location = new System.Drawing.Point(398, 556);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(345, 103);
            this.CreateOrderButton.TabIndex = 14;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(571, 489);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(150, 38);
            this.totalPriceLabel.TabIndex = 15;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // createNewClientLinkLabel
            // 
            this.createNewClientLinkLabel.AutoSize = true;
            this.createNewClientLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewClientLinkLabel.Location = new System.Drawing.Point(440, 81);
            this.createNewClientLinkLabel.Name = "createNewClientLinkLabel";
            this.createNewClientLinkLabel.Size = new System.Drawing.Size(112, 28);
            this.createNewClientLinkLabel.TabIndex = 16;
            this.createNewClientLinkLabel.TabStop = true;
            this.createNewClientLinkLabel.Text = "Create New";
            this.createNewClientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewClientLinkLabel_LinkClicked);
            // 
            // viewSelectedProductButton
            // 
            this.viewSelectedProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedProductButton.Location = new System.Drawing.Point(121, 308);
            this.viewSelectedProductButton.Name = "viewSelectedProductButton";
            this.viewSelectedProductButton.Size = new System.Drawing.Size(329, 63);
            this.viewSelectedProductButton.TabIndex = 17;
            this.viewSelectedProductButton.Text = "View Selected";
            this.viewSelectedProductButton.UseVisualStyleBackColor = true;
            this.viewSelectedProductButton.Click += new System.EventHandler(this.viewSelectedProductButton_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 677);
            this.Controls.Add(this.viewSelectedProductButton);
            this.Controls.Add(this.createNewClientLinkLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.removeSelectedOrdersButton);
            this.Controls.Add(this.orderListLabel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.viewProductsButton);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label clientLabel;
        private ComboBox clientComboBox;
        private Button viewProductsButton;
        private ListBox productsListBox;
        private Label orderListLabel;
        private Button removeSelectedOrdersButton;
        private Button CreateOrderButton;
        private Label totalPriceLabel;
        private LinkLabel createNewClientLinkLabel;
        private Button viewSelectedProductButton;
    }
}