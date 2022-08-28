using Microsoft.Maui.Controls;
using milkdrunk.Controls;
using CommunityToolkit.Maui.Markup;

namespace milkdrunk.Pages;

partial class HomePage
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
                        new Label() { Text = "home" }
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
                            .Bind(Label.TextProperty, nameof(_pm.Greeting)),
                        new Button() { Text = "my babies" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_pm.MyBabiesCommand)),
                        new Button() { Text = "my caregroup", IsEnabled = false}
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5),
                        new Button() { Text = "caregiver settings" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
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
