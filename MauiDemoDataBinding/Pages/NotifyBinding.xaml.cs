using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
    Product product = new Product();
    public NotifyBinding()
    {
        InitializeComponent();
        product = new Product
        {
            ProductName = "iPhone 5",
            Price = 800,
            Stock = 3,
        };

        BindingContext = product;
    }

    private async void btnUpdate_Clicked(object sender, EventArgs e)
    {
        product.ProductName = "Galaxy Samsung 10";
        product.Price = 1000;
        product.Stock = 5;

        await DisplayAlert("Product Updated", $"{product.ProductName} - {product.Price} - {product.Stock}", "Ok");
    }
}