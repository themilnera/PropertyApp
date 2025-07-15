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

		SetViewPositions();

		Loaded += (s, e) =>
		{
			FadeAndScale(detailsBtn);
			RotateView(detailsBtn);
			FadeAndTranslate(imagesView);

			Task.Delay(500);

			FadeAndTranslate(popView, 1000, 1000);
			FadeAndTranslate(addressView, 1000, 1000);
			FadeAndScale(buyBtn, 1000, 1000);
		};
	}
	private void SetViewPositions()
	{
		detailsBtn.Opacity = 0;
		detailsBtn.Scale = 0.2;
		detailsBtn.Rotation = 300;

		imagesView.TranslationX = 300;
		imagesView.Opacity = 0;

		addressView.TranslationX = addressView.TranslationY = -30;
		addressView.Opacity = 0;

		buyBtn.Opacity = 0;
		buyBtn.Scale = 0.2;

		popView.TranslationY = 300;
		popView.Opacity = 0.6;
	}

	private void FadeAndTranslate(VisualElement view, uint fadeLength = 1000, uint translateLength = 1500)
	{
		view.FadeTo(1, fadeLength, Easing.SinInOut);
		view.TranslateTo(0, 0, translateLength, Easing.SinInOut);
	}

	private void FadeAndScale(VisualElement view, uint fadeLength = 1000, uint scaleLength = 1500)
	{
		view.FadeTo(1, fadeLength, Easing.SinInOut);
		view.ScaleTo(1, scaleLength, Easing.SinInOut);
	}

	private void RotateView(VisualElement view) => view.RotateTo(0, 1500, Easing.SinInOut);
}