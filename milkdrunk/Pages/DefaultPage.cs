using Microsoft.Maui.Controls;

namespace milkdrunk.Pages;

partial class DefaultPage
{
    void Build()
    {
        Content = new StackLayout
        {
            Children = {
                new Label() { Text = "loading..." }
            }
        };
    }
}
