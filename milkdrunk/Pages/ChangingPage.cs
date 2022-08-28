using milkdrunk.Controls;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;

namespace milkdrunk.Pages;

partial class ChangingPage
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
                        new Label() { Text = "changing" }
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
                        new Button() { Text = "my changings" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_pm.MyChangingsCommand))
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
