using AppMAUIGallery.Models;
using AppMAUIGallery.Repository;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();

        var categories = new CategoryRepository().GetCategories();
        foreach (Category category in categories)
        {
            var lblCategory = new Label();
            lblCategory.Text = category.Title;
            lblCategory.FontFamily = "OpenSansSemibold";
            lblCategory.Margin = new Thickness(0, 10, 0, 0);

            MenuContainer.Children.Add(lblCategory);

            foreach (var component in category.Components)
            {
                var tap = new TapGestureRecognizer();
                tap.Tapped += OnTapComponent;
                tap.CommandParameter = component.Page;
                var lblTitle = new Label();
                lblTitle.Text = component.Title;
                lblTitle.FontFamily = "OpenSansSemibold";
                lblTitle.Margin = new Thickness(20, 10, 0, 0);
                lblTitle.GestureRecognizers.Add(tap);

                var lblDescription = new Label();
                lblDescription.Text = component.Description;
                lblDescription.Margin = new Thickness(20, 0, 0, 0);
                MenuContainer.Children.Add(lblTitle);
                MenuContainer.Children.Add(lblDescription);
                lblDescription.GestureRecognizers.Add(tap);
            }
        }
    }

    private void OnTapComponent(object sender, EventArgs e)
    {
        Label label = (Label)sender;
        var tap = label.GestureRecognizers[0] as TapGestureRecognizer;
        var page = (Type)tap.CommandParameter;

        ((FlyoutMenu)App.Current.MainPage).Detail = new NavigationPage(Activator.CreateInstance(page) as Page);
        ((FlyoutMenu)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapBackMenu(object sender, TappedEventArgs e)
    {
        ((FlyoutMenu)App.Current.MainPage).Detail = new NavigationPage(new MainPage());
        ((FlyoutMenu)App.Current.MainPage).IsPresented = false;
    }
}