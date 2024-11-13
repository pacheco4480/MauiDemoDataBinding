using MauiDemoDataBinding.Pages;

namespace MauiDemoDataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NotifyBinding());
        }
    }
}
