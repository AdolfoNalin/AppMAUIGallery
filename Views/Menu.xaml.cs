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
                var lblTitle = new Label();
                lblTitle.Text = component.Title;
                lblTitle.FontFamily = "OpenSansSemibold";
                lblTitle.Margin = new Thickness(20, 10, 0, 0);
                var lblDescription = new Label();
                lblDescription.Text = component.Description;
                lblDescription.Margin = new Thickness(20, 0, 0, 0);
                MenuContainer.Children.Add(lblTitle);
                MenuContainer.Children.Add(lblDescription);
            }
        }

    }
}