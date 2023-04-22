using System;
using System.Drawing.Printing;
using BarcodeLib;

namespace InventoryManager
{
    public partial class BarcodeViewWindow : Form
    {
        public BarcodeViewWindow()
        {
            InitializeComponent();
        }

        private void BarcodeViewWindow_Load(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            Image img = barcode.Encode(TYPE.CODE128, $"{InventoryManager.skuTextValue}{InventoryManager.partNumberTextValue}",
                foreColor, backColor, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = img;
        }

        private void saveBarCodeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(saveFileDialog.FileName);
            }
        }

        private void printBarCodeButton_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += myPrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void myPrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }


    }
}
