using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Components.Mains;
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
                            Page = typeof(GridLayoutPage)
                        },
                        new Component
                        {
                            Title = "AbsoluteLayout",
                            Description = "A layout that positions child elements at absolute positions.",
                            Page = typeof(AbsoluteLayoutPage)
                        },
                        new Component
                        {
                            Title = "FlexLayout",
                            Description = "A layout that arranges child elements in a flexible way, allowing them to grow and shrink.",
                            Page = typeof(FlexLayoutPage)
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
                },
                new Category
                {
                    Title = "Components",
                    Components = new List<Component>
                    {
                        new Component
                        {
                            Title = "BoxView",
                            Description = "A control that displays a rectangle of a specified color.",
                            Page = typeof(BoxViewPage)
                        },
                        //new Component
                        //{
                        //    Title = "ListView",
                        //    Description = "A control that displays a scrollable list of data items.",
                        //    //Page = new Views.Data.ListViewPage()
                        //},
                        //new Component
                        //{
                        //    Title = "CollectionView",
                        //    Description = "A control that displays a collection of data items in a flexible layout.",
                        //    //Page = new Views.Data.CollectionViewPage()
                        //}
                    }
                }
            };
        }
    }
}
