using AppMAUIGallery.Views;
using AppMAUIGallery.Views.Layouts;
using Microsoft.Extensions.DependencyInjection;

namespace AppMAUIGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new FlyoutMenu());
        } 
    }
}