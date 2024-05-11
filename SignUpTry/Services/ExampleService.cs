using SignUpTry.Interfaces;
using SignUpTry.Models;


namespace SignUpTry.Services
{
    public class ExampleService : IExampleService
    {
        private IAlertDialogService _dialogService;

        public ExampleService(IAlertDialogService dialogService)
        {
            _dialogService = dialogService;

        }

        public async void ExampleSave(Signup signup)
        {
            await _dialogService.ShowAlertAsync("Save", $"{signup.Name} Saved", "Ok");

        }
    }
}
