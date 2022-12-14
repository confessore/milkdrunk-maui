using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using milkdrunk.Pages;

namespace milkdrunk.Shells;

public partial class DefaultShell
{
    void Build()
    {
        Resources.Add("BaseStyle", DefaultStyle());
        Resources.Add(TabBarStyle());
        Resources.Add(FlyoutItemStyle());
        Items.Add(DefaultTabBar());
    }

    static Style DefaultStyle()
    {
        var style = new Style(typeof(Element));
        style.Setters.Add(new()
        {
            Property = Shell.BackgroundColorProperty,
            Value = App.Current.Resources["Primary"] ?? default
        });
        style.Setters.Add(new()
        {
            Property = Shell.ForegroundColorProperty,
            Value = System.Drawing.Color.White
        });
        style.Setters.Add(new()
        {
            Property = Shell.TitleColorProperty,
            Value = System.Drawing.Color.White
        });
        style.Setters.Add(new()
        {
            Property = Shell.DisabledColorProperty,
            Value = Color.FromArgb("#B4FFFFFF")
        });
        style.Setters.Add(new()
        {
            Property = Shell.UnselectedColorProperty,
            Value = Color.FromArgb("#95FFFFFF")
        });
        style.Setters.Add(new()
        {
            Property = Shell.TabBarBackgroundColorProperty,
            Value = App.Current.Resources["Tertiary"] ?? default
        });
        style.Setters.Add(new()
        {
            Property = Shell.TabBarForegroundColorProperty,
            Value = System.Drawing.Color.White
        });
        style.Setters.Add(new()
        {
            Property = Shell.TabBarUnselectedColorProperty,
            Value = Color.FromArgb("#95FFFFFF")
        });
        style.Setters.Add(new()
        {
            Property = Shell.TabBarTitleColorProperty,
            Value = System.Drawing.Color.White
        });
        return style;
    }

    Style TabBarStyle()
    {
        var style = new Style(typeof(TabBar))
        {
            BasedOn = (Style)Resources["BaseStyle"] ?? default
        };
        return style;
    }

    Style FlyoutItemStyle()
    {
        var style = new Style(typeof(FlyoutItem))
        {
            BasedOn = (Style)Resources["BaseStyle"] ?? default
        };
        return style;
    }

    static ShellContent DefaultShellContent()
    {
        return new()
        {
            Content = DefaultTabBar()
        };
    }

    static TabBar DefaultTabBar()
    {
        return new()
        {
            Items =
            {
                HomeTab(),
                ChangingTab(),
                FeedingTab(),
                SleepingTab(),
                //PumpingTab()
            }
        };
    }

    static ShellContent HomeTab()
    {
        return new()
        {
            Title = "home",
            //Icon = "home.png",
            Route = "HomePage",
            ContentTemplate = new DataTemplate(typeof(HomePage)),
        };
    }

    static ShellContent ChangingTab()
    {
        return new()
        {
            Title = "changing",
            //Icon = "changing.png",
            Route = "ChangingPage",
            ContentTemplate = new DataTemplate(typeof(ChangingPage)),
        };
    }

    static ShellContent FeedingTab()
    {
        return new()
        {
            Title = "feeding",
            //Icon = "feeding.png",
            Route = "FeedingPage",
            ContentTemplate = new DataTemplate(typeof(FeedingPage)),
        };
    }

    static ShellContent SleepingTab()
    {
        return new()
        {
            Title = "sleeping",
            //Icon = "sleeping.png",
            Route = "SleepingPage",
            ContentTemplate = new DataTemplate(typeof(SleepingPage)),
        };
    }

    static ShellContent PumpingTab()
    {
        return new()
        {
            Title = "pumping",
            //Icon = "pumping.png",
            Route = "PumpingPage",
            ContentTemplate = new DataTemplate(typeof(PumpingPage)),
        };
    }
}
