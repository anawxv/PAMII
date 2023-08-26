using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class LoginView : ContentPage
{
	UsuarioViewModel ViewModel;
	public LoginView()
	{
		InitializeComponent();

		ViewModel = new UsuarioViewModel();
		BindingContext = ViewModel;
	}
}