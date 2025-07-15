using PropertyApp.ViewModel;

namespace PropertyApp.View;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
		this.BindingContext = new LandingViewModel();
		(SectionList.Children[0] as RadioButton).IsChecked = true;
	}
}