using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
        }

        private void consignmentShopDemo_Load(object sender, EventArgs e)
        {

        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Test Name", 
                                           LastName = "Test Lastname"});
            store.Items.Add(new Item { Title = "Book", 
                                       Description = "Some description", 
                                       Price = 4.50M, // Decimal, not double 
                                       Owner = store.Vendors[0] });

        }
    }
}