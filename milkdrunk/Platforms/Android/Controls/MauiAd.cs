using Android.Content;
using AndroidX.CoordinatorLayout.Widget;
using Java.Lang;
using Microsoft.Maui;
using milkdrunk.Controls;

namespace milkdrunk.Platforms.Android.Controls;

public class MauiAd : CoordinatorLayout
{
    public MauiAd(Context context, Ad ad) : base(context)
    {

    }

    /*AdView CreateAdView()
    {
        return new(Context);
    }*/
}
