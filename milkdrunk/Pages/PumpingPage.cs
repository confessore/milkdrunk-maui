using Microsoft.Maui.Controls;
using milkdrunk.Controls;
using CommunityToolkit.Maui.Markup;

namespace milkdrunk.Pages;

partial class PumpingPage
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
                        new Label() { Text = "pumping" }
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
                        new Button() { Text = "my pumpings" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_vm.MyPumpingsCommand))
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
