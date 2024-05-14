using SignUpTry.ViewModels;

namespace SignUpTry.Views;

public partial class SignupView : ContentPage
{
    SignupViewModel _signupView;
	public SignupView(SignupViewModel vm)
	{
		_signupView = vm;
		InitializeComponent();
		BindingContext = _signupView;
	}
}