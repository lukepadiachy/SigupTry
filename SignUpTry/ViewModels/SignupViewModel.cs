using SignUpTry.Interfaces;
using SignUpTry.Models;
using CommunityToolkit.Mvvm.Input;
using SignUpTry.ViewModels;



namespace SignUpTry.ViewModels
{
    public partial class SignupViewModel : BaseViewModel
    {
        private IExampleService _exampleService;

        private string _name;

        public string Name
        {
            get { return _name;}
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private bool isNameValid;

        public bool IsNameValid
        {
            get { return isNameValid; }
            set
            {
                isNameValid = value;
                OnPropertyChanged();
            }

        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        private bool isSurnameValid;
        public bool IsSurnameValid
        {
            get { return isSurnameValid; }
            set
            {
                isSurnameValid = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private bool isEmailValid;
        public bool IsEmailValid
        {
            get { return isEmailValid; }
            set
            {
                isEmailValid = value;
                OnPropertyChanged();
            }
        }

        private string _confirmPassword;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }

        private bool isConfirmPasswordValid;
        public bool IsConfirmPasswordValid
        {
            get { return isConfirmPasswordValid; }
            set
            {
                isConfirmPasswordValid = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        private bool isPasswordValid;
        public bool IsPasswordValid
        {
            get { return isPasswordValid; }
            set
            {
                isPasswordValid = value;
                OnPropertyChanged();
            }
        }

        public SignupViewModel(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [RelayCommand]
        public void Save()
        {
            if (IsConfirmPasswordValid && IsEmailValid && IsNameValid && IsPasswordValid && IsSurnameValid)
            {
                var signup = new Signup()
                {
                    Name = this.Name,
                    Surname = this.Surname,
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
                _exampleService.ExampleSave(signup);
            }
        }








    }
}
