using Microsoft.Maui.Controls;
using milkdrunk.ShellModels;

namespace milkdrunk.Shells;

public partial class DefaultShell : Shell
{
    DefaultShellModel _sm;

    public DefaultShell()
    {
        BindingContext = _sm = new DefaultShellModel();
        Build();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}
