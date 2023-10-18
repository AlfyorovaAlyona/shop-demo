using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new();
        private List<Item> shoppingCartList = new List<Item>();
        BindingSource itemsBinding = new();
        BindingSource cartBinding = new();
        BindingSource vendorsBinding = new();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(item => item.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartList;
            cartListBox.DataSource = cartBinding;
            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";

            vendorsListBox.DataSource = vendorsBinding;
            vendorsBinding.DataSource = store.Vendors;
            vendorsListBox.DisplayMember = "Display";
            vendorsListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Name = "New Store";

            store.Vendors.Add(new Vendor
            {
                FirstName = "Test Name",
                LastName = "Test Lastname"
            });
            store.Items.Add(new Item
            {
                Title = "Book",
                Description = "Some description",
                Price = 4.50M, // Represents money => Decimal, not double 
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Another Book",
                Description = "Book description",
                Price = 3.87M, // Represents money => Decimal, not double 
                Owner = store.Vendors[0]
            });
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            // Add selected items to shopping cart
            // selectedItem can be null (nullable variable)
            if (itemsListBox.SelectedItem is Item seletedItem)
            {
                MessageBox.Show(seletedItem.Title + " added to cart!");
                shoppingCartList.Add(seletedItem);
                cartBinding.ResetBindings(false);
            }

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            // Sell items, add due payment to the vendor, and clear the cart

            foreach (var item in shoppingCartList)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.ComissionRate * item.Price;
                store.Profit += (1 - (decimal)item.Owner.ComissionRate) * item.Price;
            }
            itemsBinding.DataSource = store.Items.Where(item => item.Sold == false).ToList();

            shoppingCartList.Clear();

            storeProfitValueLabel.Text = string.Format("${0}", store.Profit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}