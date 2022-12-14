using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.Resources;
using milkdrunk.Controls;

namespace milkdrunk.Pages;

partial class MyPumpingsPage
{
    void Build()
    {
        Content = DefaultStackLayout();
    }

    ToolbarItem NewPumpingToolbarItem()
    {
        return new ToolbarItem()
        {
            Text = AppResources.add_new
        }
        .Bind(ToolbarItem.CommandProperty, nameof(_pm.NewPumpingCommand));
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
                        new Label() { Text = "my pumpings" }
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
                        DefaultCollectionView()
                            //.Bind(CollectionView.SelectedItemProperty, nameof(_vm.SelectedPumping))
                            .Bind(CollectionView.ItemsSourceProperty, nameof(_pm.Pumpings))
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

    CollectionView DefaultCollectionView()
    {
        var collectionView = new CollectionView()
        {
            SelectionMode = SelectionMode.Single,
            ItemTemplate = DefaultDataTemplate()
        };
        //collectionView.SelectionChanged += _vm.OnPumpingSelectionChanged;
        return collectionView;
    }

    DataTemplate DefaultDataTemplate()
    {
        return new DataTemplate(() =>
            new StackLayout()
            {
                Children =
                {
                    new Label()
                        .Bind(Label.TextProperty, nameof(Pumping.Time)),
                    new Label()
                        .Bind(Label.TextProperty, nameof(Pumping.FluidOunces))
                }
            });
    }
}
