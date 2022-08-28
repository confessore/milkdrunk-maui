using Microsoft.Maui.Controls;
using milkdrunk.Models;

namespace milkdrunk.PageModels;

class EditChangingPageModel : BasePageModel
{
    readonly Changing _changing;

    public EditChangingPageModel(
        Changing changing)
    {
        _changing = changing;
        ConfirmCommand = new Command(Confirm);
    }

    public Command? ConfirmCommand { get; }

    void Confirm()
    {

    }
}
