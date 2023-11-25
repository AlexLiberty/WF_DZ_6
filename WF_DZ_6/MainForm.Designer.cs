namespace HM6_ElectronicsStore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productListBox = new ListBox();
            categoryComboBox = new ComboBox();
            addToCartButton = new Button();
            detailsButton = new Button();
            priceLabel = new Label();
            openCartButton = new Button();
            SuspendLayout();
            // 
            // productListBox
            // 
            productListBox.BackColor = Color.Ivory;
            productListBox.BorderStyle = BorderStyle.FixedSingle;
            productListBox.FormattingEnabled = true;
            productListBox.ItemHeight = 15;
            productListBox.Location = new Point(305, 31);
            productListBox.Margin = new Padding(2);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(347, 377);
            productListBox.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.Ivory;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(8, 31);
            categoryComboBox.Margin = new Padding(2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(293, 23);
            categoryComboBox.TabIndex = 1;
            // 
            // addToCartButton
            // 
            addToCartButton.FlatStyle = FlatStyle.Popup;
            addToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addToCartButton.ForeColor = Color.Ivory;
            addToCartButton.Location = new Point(305, 416);
            addToCartButton.Margin = new Padding(2);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(136, 32);
            addToCartButton.TabIndex = 3;
            addToCartButton.Text = "Додати";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // detailsButton
            // 
            detailsButton.FlatStyle = FlatStyle.Popup;
            detailsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            detailsButton.ForeColor = Color.Ivory;
            detailsButton.Location = new Point(541, 416);
            detailsButton.Margin = new Padding(2);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(111, 32);
            detailsButton.TabIndex = 4;
            detailsButton.Text = "Деталі";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.ForeColor = Color.PaleGoldenrod;
            priceLabel.Location = new Point(122, 419);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(17, 25);
            priceLabel.TabIndex = 6;
            priceLabel.Text = " ";
            // 
            // openCartButton
            // 
            openCartButton.FlatStyle = FlatStyle.Popup;
            openCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            openCartButton.ForeColor = Color.Ivory;
            openCartButton.Location = new Point(11, 416);
            openCartButton.Margin = new Padding(2);
            openCartButton.Name = "openCartButton";
            openCartButton.Size = new Size(86, 32);
            openCartButton.TabIndex = 7;
            openCartButton.Text = "Корзина";
            openCartButton.UseVisualStyleBackColor = true;
            openCartButton.Click += openCartButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Gray;
            ClientSize = new Size(660, 461);
            Controls.Add(openCartButton);
            Controls.Add(priceLabel);
            Controls.Add(detailsButton);
            Controls.Add(addToCartButton);
            Controls.Add(categoryComboBox);
            Controls.Add(productListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox productListBox;
        private ComboBox categoryComboBox;
        private Button addToCartButton;
        private Button detailsButton;
        private Label priceLabel;
        private Button openCartButton;
    }
}