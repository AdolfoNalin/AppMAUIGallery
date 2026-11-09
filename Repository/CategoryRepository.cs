using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Layouts;

namespace AppMAUIGallery.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category
                {
                    Title = "Layouts",
                    Components = new List<Component>
                    {
                        new Component
                        {
                            Title = "StackLayout",
                            Description = "A layout that positions child elements in a single line, either horizontally or vertically.",
                            Page = typeof(StackLayoutPage)
                        },
                        new Component
                        {
                            Title = "Grid",
                            Description = "A layout that organizes child elements in a tabular structure of rows and columns.",
                            //Page = new Views.Layouts.GridPage()
                        }
                    }
                },
                new Category
                {
                    Title = "Controls",
                    Components = new List<Component>
                    {
                        new Component
                        {
                            Title = "Button",
                            Description = "A control that can be clicked to perform an action.",
                            //Page = new Views.Controls.ButtonPage()
                        },
                        new Component
                        {
                            Title = "Label",
                            Description = "A control that displays text.",
                            //Page = new Views.Controls.LabelPage()
                        }
                    }
                }
            };
        }
    }
}
