using milkdrunk.Controls;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;

namespace milkdrunk.Pages;

partial class BabyDetailPage
{
    void Build()
    {
        Content = DefaultStackLayout();
    }

    StackLayout DefaultStackLayout()
    {
        return new StackLayout()
        {
            Children = {
                new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children =
                    {
                        new Label() { Text = "baby detail" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .CenterHorizontal()
                    }
                },
                new StackLayout()
                {
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Children =
                    {
                        new Label()
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .CenterHorizontal()
                            .Bind(Label.TextProperty, nameof(_pm.Name)),
                       new Label()
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .CenterHorizontal()
                            .Bind(Label.TextProperty, nameof(_pm.BirthDate)),
                        new Button() { Text = "edit" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_pm.EditBabyCommand)),
                        new Button() { Text = "set default" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_pm.SetDefaultBabyCommand))
                    }
                },
                new StackLayout()
                {
                    VerticalOptions = LayoutOptions.End,
                    Children =
                    {
                        new Ad()
                            .Height(60)
                    }
                }
            }
        };
    }
}
