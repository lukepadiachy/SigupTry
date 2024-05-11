namespace SignUpTry.Views;

public partial class SignupView : ContentPage
{
	public SignupView( SignupView vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}