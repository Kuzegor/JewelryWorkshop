namespace JewelryWorkshopWinFormsUI
{
    partial class EditData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditData));
            this.clientsButton = new System.Windows.Forms.Button();
            this.materialsButton = new System.Windows.Forms.Button();
            this.techniquesButton = new System.Windows.Forms.Button();
            this.productTypesButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientsButton
            // 
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Location = new System.Drawing.Point(12, 79);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(149, 54);
            this.clientsButton.TabIndex = 0;
            this.clientsButton.Text = "Clients";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // materialsButton
            // 
            this.materialsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialsButton.Location = new System.Drawing.Point(337, 79);
            this.materialsButton.Name = "materialsButton";
            this.materialsButton.Size = new System.Drawing.Size(175, 54);
            this.materialsButton.TabIndex = 1;
            this.materialsButton.Text = "Materials";
            this.materialsButton.UseVisualStyleBackColor = true;
            this.materialsButton.Click += new System.EventHandler(this.materialsButton_Click);
            // 
            // techniquesButton
            // 
            this.techniquesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techniquesButton.Location = new System.Drawing.Point(12, 139);
            this.techniquesButton.Name = "techniquesButton";
            this.techniquesButton.Size = new System.Drawing.Size(282, 54);
            this.techniquesButton.TabIndex = 2;
            this.techniquesButton.Text = "Jewelry Techniques";
            this.techniquesButton.UseVisualStyleBackColor = true;
            this.techniquesButton.Click += new System.EventHandler(this.techniquesButton_Click);
            // 
            // productTypesButton
            // 
            this.productTypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productTypesButton.Location = new System.Drawing.Point(300, 139);
            this.productTypesButton.Name = "productTypesButton";
            this.productTypesButton.Size = new System.Drawing.Size(212, 54);
            this.productTypesButton.TabIndex = 3;
            this.productTypesButton.Text = "Product Types";
            this.productTypesButton.UseVisualStyleBackColor = true;
            this.productTypesButton.Click += new System.EventHandler(this.productTypesButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Location = new System.Drawing.Point(167, 79);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(164, 54);
            this.productsButton.TabIndex = 4;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Viewer";
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.productTypesButton);
            this.Controls.Add(this.techniquesButton);
            this.Controls.Add(this.materialsButton);
            this.Controls.Add(this.clientsButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditData";
            this.Text = "EditData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clientsButton;
        private Button materialsButton;
        private Button techniquesButton;
        private Button productTypesButton;
        private Button productsButton;
        private Label label1;
    }
}