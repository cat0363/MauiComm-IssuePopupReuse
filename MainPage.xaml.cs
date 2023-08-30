using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupReuse;

public partial class MainPage : ContentPage
{
	PopupPage1 popup = new();

	public MainPage()
	{
		InitializeComponent();
	}

	async void btnShow_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.ShowPopupAsync(popup);
		await Shell.Current.ShowPopupAsync(popup);
	}
}

