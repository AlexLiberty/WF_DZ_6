namespace HM6_ElectronicsStore
{
    partial class CustomerCartForm
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
            priceLabel = new Label();
            cartListBox = new ListBox();
            removeButton = new Button();
            orderButton = new Button();
            SuspendLayout();
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.ForeColor = Color.LightGoldenrodYellow;
            priceLabel.Location = new Point(8, 294);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(89, 21);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "До сплати: ";
            // 
            // cartListBox
            // 
            cartListBox.BackColor = Color.Ivory;
            cartListBox.BorderStyle = BorderStyle.FixedSingle;
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(8, 19);
            cartListBox.Margin = new Padding(2, 2, 2, 2);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(315, 257);
            cartListBox.TabIndex = 1;
            // 
            // removeButton
            // 
            removeButton.FlatStyle = FlatStyle.Popup;
            removeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.ForeColor = Color.Red;
            removeButton.Location = new Point(8, 334);
            removeButton.Margin = new Padding(2, 2, 2, 2);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(156, 45);
            removeButton.TabIndex = 2;
            removeButton.Text = "Видалити";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // orderButton
            // 
            orderButton.FlatStyle = FlatStyle.Popup;
            orderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = Color.Chartreuse;
            orderButton.Location = new Point(168, 334);
            orderButton.Margin = new Padding(2, 2, 2, 2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(156, 45);
            orderButton.TabIndex = 4;
            orderButton.Text = "Придбати";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // CustomerCartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(332, 394);
            Controls.Add(orderButton);
            Controls.Add(removeButton);
            Controls.Add(cartListBox);
            Controls.Add(priceLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "CustomerCartForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Your Cart";
            FormClosing += CustomerCartForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label priceLabel;
        private ListBox cartListBox;
        private Button removeButton;
        private Button orderButton;
    }
}