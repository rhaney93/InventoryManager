namespace InventoryManager
{
    partial class BarcodeViewWindow
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
            pictureBox1 = new PictureBox();
            printBarCodeButton = new Button();
            saveBarCodeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(30, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1051, 626);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // printBarCodeButton
            // 
            printBarCodeButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            printBarCodeButton.Location = new Point(30, 687);
            printBarCodeButton.Name = "printBarCodeButton";
            printBarCodeButton.Size = new Size(468, 58);
            printBarCodeButton.TabIndex = 1;
            printBarCodeButton.Text = "Print";
            printBarCodeButton.UseVisualStyleBackColor = true;
            printBarCodeButton.Click += printBarCodeButton_Click;
            // 
            // saveBarCodeButton
            // 
            saveBarCodeButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveBarCodeButton.Location = new Point(613, 687);
            saveBarCodeButton.Name = "saveBarCodeButton";
            saveBarCodeButton.Size = new Size(468, 58);
            saveBarCodeButton.TabIndex = 2;
            saveBarCodeButton.Text = "Save";
            saveBarCodeButton.UseVisualStyleBackColor = true;
            saveBarCodeButton.Click += saveBarCodeButton_Click;
            // 
            // BarcodeViewWindow
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1115, 782);
            Controls.Add(saveBarCodeButton);
            Controls.Add(printBarCodeButton);
            Controls.Add(pictureBox1);
            Name = "BarcodeViewWindow";
            Text = "BarcodeViewWindow";
            Load += BarcodeViewWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button printBarCodeButton;
        private Button saveBarCodeButton;
    }
}