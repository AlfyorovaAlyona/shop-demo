namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            itemsListBox = new ListBox();
            addToCartButton = new Button();
            consignmentShopLabel = new Label();
            storeItemsLabel = new Label();
            cartItemsLable = new Label();
            cartListBox = new ListBox();
            purchaseButton = new Button();
            SuspendLayout();
            // 
            // itemsListBox
            // 
            itemsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 28;
            itemsListBox.Location = new Point(48, 113);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(321, 312);
            itemsListBox.TabIndex = 0;
            // 
            // addToCartButton
            // 
            addToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addToCartButton.Location = new Point(416, 253);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(187, 73);
            addToCartButton.TabIndex = 1;
            addToCartButton.Text = "Add To Cart ->";
            addToCartButton.UseVisualStyleBackColor = true;
            // 
            // consignmentShopLabel
            // 
            consignmentShopLabel.AutoSize = true;
            consignmentShopLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            consignmentShopLabel.Location = new Point(48, 9);
            consignmentShopLabel.Name = "consignmentShopLabel";
            consignmentShopLabel.Size = new Size(427, 46);
            consignmentShopLabel.TabIndex = 2;
            consignmentShopLabel.Text = "Consignment Shop Demo";
            // 
            // storeItemsLabel
            // 
            storeItemsLabel.AutoSize = true;
            storeItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            storeItemsLabel.Location = new Point(48, 82);
            storeItemsLabel.Name = "storeItemsLabel";
            storeItemsLabel.Size = new Size(120, 28);
            storeItemsLabel.TabIndex = 3;
            storeItemsLabel.Text = "Store Items";
            // 
            // cartItemsLable
            // 
            cartItemsLable.AutoSize = true;
            cartItemsLable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cartItemsLable.Location = new Point(644, 82);
            cartItemsLable.Name = "cartItemsLable";
            cartItemsLable.Size = new Size(205, 28);
            cartItemsLable.TabIndex = 5;
            cartItemsLable.Text = "Shopping Cart Items";
            // 
            // cartListBox
            // 
            cartListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 28;
            cartListBox.Location = new Point(644, 113);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(321, 312);
            cartListBox.TabIndex = 4;
            // 
            // purchaseButton
            // 
            purchaseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            purchaseButton.Location = new Point(823, 431);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(142, 63);
            purchaseButton.TabIndex = 6;
            purchaseButton.Text = "Purchase";
            purchaseButton.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 535);
            Controls.Add(purchaseButton);
            Controls.Add(cartItemsLable);
            Controls.Add(cartListBox);
            Controls.Add(storeItemsLabel);
            Controls.Add(consignmentShopLabel);
            Controls.Add(addToCartButton);
            Controls.Add(itemsListBox);
            Name = "ConsignmentShop";
            Text = "Consignment Shop Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox itemsListBox;
        private Button addToCartButton;
        private Label consignmentShopLabel;
        private Label storeItemsLabel;
        private Label cartItemsLable;
        private ListBox cartListBox;
        private Button purchaseButton;
    }
}