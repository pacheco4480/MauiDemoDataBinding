using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void CounterBtn_Clicked(object sender, EventArgs e)
        //{
        //    var product = new Product
        //    {
        //        ProductName = "iPhone 5",
        //        Price = 1000.00m,
        //        Stock = 5
        //    };

        //    //Binding productBinding = new Binding();
        //    //productBinding.Source = product;
        //    //productBinding.Path = "ProductName";

        //    //lblName.SetBinding(Label.TextProperty, productBinding);

        //    Binding nameBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "ProductName",
        //        StringFormat = "Product: {0}"
        //    };

        //    lblName.SetBinding(Label.TextProperty, nameBinding);

        //    Binding priceBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Price",
        //        StringFormat = "Price: {0}"
        //    };

        //    lblPrice.SetBinding(Label.TextProperty, priceBinding);

        //    Binding stockBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Stock",
        //        StringFormat = "Stock: {0}"
        //    };

        //    lblStock.SetBinding(Label.TextProperty, stockBinding);
        //}
    }

}