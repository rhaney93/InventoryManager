namespace InventoryManager
{
    partial class InventoryManager
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
            label1 = new Label();
            inventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            locationTextBox = new TextBox();
            quantityTextBox = new TextBox();
            skuTextBox = new TextBox();
            priceTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nomenTextBox = new TextBox();
            partNumberTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            barCodeGenButton = new Button();
            skuGenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(2208, 147);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management Suite";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inventoryGridView
            // 
            inventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGridView.BackgroundColor = SystemColors.Control;
            inventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGridView.Location = new Point(12, 520);
            inventoryGridView.Name = "inventoryGridView";
            inventoryGridView.RowHeadersWidth = 102;
            inventoryGridView.RowTemplate.Height = 49;
            inventoryGridView.Size = new Size(2208, 884);
            inventoryGridView.TabIndex = 1;
            // 
            // newButton
            // 
            newButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(12, 434);
            newButton.Name = "newButton";
            newButton.Size = new Size(687, 68);
            newButton.TabIndex = 2;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(772, 434);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(687, 68);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(1532, 434);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(687, 68);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // locationTextBox
            // 
            locationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locationTextBox.Location = new Point(12, 340);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(687, 61);
            locationTextBox.TabIndex = 5;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTextBox.Location = new Point(772, 340);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(687, 61);
            quantityTextBox.TabIndex = 6;
            // 
            // skuTextBox
            // 
            skuTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            skuTextBox.Location = new Point(12, 211);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(687, 61);
            skuTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(1532, 340);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(687, 61);
            priceTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(85, 39);
            label2.TabIndex = 9;
            label2.Text = "SKU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 287);
            label3.Name = "label3";
            label3.Size = new Size(149, 39);
            label3.TabIndex = 10;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(772, 156);
            label4.Name = "label4";
            label4.Size = new Size(231, 39);
            label4.TabIndex = 11;
            label4.Text = "Nomenclature:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(772, 287);
            label5.Name = "label5";
            label5.Size = new Size(146, 39);
            label5.TabIndex = 12;
            label5.Text = "Quantity:";
            // 
            // nomenTextBox
            // 
            nomenTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nomenTextBox.Location = new Point(772, 211);
            nomenTextBox.Name = "nomenTextBox";
            nomenTextBox.Size = new Size(687, 61);
            nomenTextBox.TabIndex = 13;
            // 
            // partNumberTextBox
            // 
            partNumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partNumberTextBox.Location = new Point(1532, 211);
            partNumberTextBox.Name = "partNumberTextBox";
            partNumberTextBox.Size = new Size(687, 61);
            partNumberTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1532, 156);
            label6.Name = "label6";
            label6.Size = new Size(211, 39);
            label6.TabIndex = 15;
            label6.Text = "Part Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1532, 287);
            label7.Name = "label7";
            label7.Size = new Size(98, 39);
            label7.TabIndex = 16;
            label7.Text = "Price:";
            // 
            // InventoryManager
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(2232, 1496);
            Controls.Add(skuGenButton);
            Controls.Add(barCodeGenButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(partNumberTextBox);
            Controls.Add(nomenTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priceTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(quantityTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(inventoryGridView);
            Controls.Add(label1);
            Name = "InventoryManager";
            Text = "Inventory Manager";
            Load += InventoryManager_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView inventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private TextBox locationTextBox;
        private TextBox quantityTextBox;
        private TextBox skuTextBox;
        private TextBox priceTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nomenTextBox;
        private TextBox partNumberTextBox;
        private Label label6;
        private Label label7;
        private Button barCodeGenButton;
        private Button skuGenButton;
    }
}