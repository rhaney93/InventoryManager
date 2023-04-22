using System.Data;
using AAJGen;
using BarcodeLib;


namespace InventoryManager
{
    public partial class InventoryManager : Form
    {
        DataTable inventory = new DataTable();
        RandomGen random = new RandomGen(Option.IncludeCapital);
        public static string skuTextValue = "";
        public static string partNumberTextValue = "";

        public InventoryManager()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = random.Gen(10);
            nomenTextBox.Text = "";
            partNumberTextBox.Text = "";
            locationTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            skuTextValue = skuTextBox.Text;
            string nomen = nomenTextBox.Text;
            partNumberTextValue = partNumberTextBox.Text;
            string location = locationTextBox.Text;
            string quantity = quantityTextBox.Text;
            string price = priceTextBox.Text;

            inventory.Rows.Add(skuTextValue, nomen, partNumberTextValue, location, quantity, price);

            BarcodeViewWindow barcodeViewWindow = new BarcodeViewWindow();
            barcodeViewWindow.Show();

            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }

        }
        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nomenTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                partNumberTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                locationTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }
        }
        private void InventoryManager_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Nomenclature");
            inventory.Columns.Add("Part Number");
            inventory.Columns.Add("Location");
            inventory.Columns.Add("Quantity");
            inventory.Columns.Add("Price");

            inventoryGridView.DataSource = inventory;
        }



    }
}