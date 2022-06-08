using Sitecore.MAUI.DemoBank.Model.ViewModel;

namespace Sitecore.MAUI.DemoBank.Pages;

public partial class IndexPage : ContentPage
{
    IndexViewModel vm => BindingContext as IndexViewModel;

    public IndexPage()
	{
		InitializeComponent();
        BindingContext = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        //await vm.InitializeAsync();

        List<string> myList = new List<string>()
        {
            "main","header","footer"
        };

        myListView.ItemsSource = myList;
    }
}