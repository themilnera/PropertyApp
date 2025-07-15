using PropertyApp.ViewModel;

namespace PropertyApp.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Model.Property selectedProperty)
	{
		InitializeComponent();
		var viewModel = new DetailsViewModel() { SelectedProperty = selectedProperty };

		viewModel.PropertyImages = selectedProperty.Images.Take(2).ToList();
		viewModel.MoreItems = selectedProperty.Images.Count - 2;

		this.BindingContext = viewModel;
	}
}