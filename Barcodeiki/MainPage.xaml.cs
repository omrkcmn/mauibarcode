using BarcodeScanning;

namespace Barcodeiki;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	

    async void CameraView_OnDetectionFinished(System.Object sender, BarcodeScanning.OnDetectionFinishedEventArg e)
    {
        var result = e.BarcodeResults;
		string okunanlar = "";
		if (result.Count() > 0 )
		{
            foreach (var item in result)
            {
                okunanlar += " " + item.BarcodeFormat + " " + item.DisplayValue + "\n";
            }

            await DisplayAlert("Barkod", okunanlar, "TAmam");
        }
		
        
        await Task.Delay(1500);
    }
}

