using milkdrunk.Models;
using milkdrunk.Resources;
using milkdrunk.Controls;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace milkdrunk.Pages;

partial class MyChangingsPage
{
    void Build()
    {
        Content = DefaultStackLayout();
    }

    ToolbarItem NewChangingToolbarItem()
    {
        return new ToolbarItem()
        {
            Text = AppResources.add_new
        }
        .Bind(ToolbarItem.CommandProperty, nameof(_pm.NewChangingCommand));
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
                        new Label() { Text = "changings" }
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
                            .Bind(CollectionView.SelectedItemProperty, nameof(_pm.SelectedChanging))
                            .Bind(CollectionView.ItemsSourceProperty, nameof(_pm.Changings))
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
        collectionView.SelectionChanged += _pm.OnChangingSelectionChanged;
        return collectionView;
    }

    DataTemplate DefaultDataTemplate()
    {
        return new DataTemplate(() =>
            new Frame()
            {
                BorderColor = (Color)(App.Current.Resources["Primary"] ?? System.Drawing.Color.Red),
                Content =
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Label.TextProperty, nameof(Changing.Time)),
                            new Label()
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Label.TextProperty, nameof(Changing.ChangingType))
                        }
                    }
            });
    }
}
