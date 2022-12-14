using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.Shells;
using System;

namespace milkdrunk.PageModels
{
    class WelcomePageModel : BasePageModel
    {
        public WelcomePageModel()
        {
            ConfirmCommand = new Command(ConfirmAsync);
        }

        string? name;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public Command? ConfirmCommand { get; }

        async void ConfirmAsync()
        {
            IsBusy = true;
            var caregiver = new Caregiver()
            {
                Id = Guid.NewGuid().ToString(),
                CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                Name = Name
            };
            await _caregiverDBService.UpsertAsync(caregiver);
            //await _localStorageService.WriteToFileAsync(caregiver, "caregiver");
            App.Current.MainPage = new DefaultShell();
            IsBusy = false;
        }
    }
}
