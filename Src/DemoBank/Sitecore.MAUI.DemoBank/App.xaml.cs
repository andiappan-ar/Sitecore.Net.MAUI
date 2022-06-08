using Sitecore.MAUI.DemoBank.Pages;

namespace Sitecore.MAUI.DemoBank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IndexPage();
        }
    }
}