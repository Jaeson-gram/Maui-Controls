namespace MauiControls;

public partial class EventsControls : ContentPage
{
	public EventsControls()
	{
		InitializeComponent();
	}

	private void testButton1_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Demo", "This is a demo to test stuff", "Ok");
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
        DisplayAlert("Demo", "This is another demo to test the ImageButton", "Ok");

    }

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		pageBackground.BackgroundColor = Microsoft.Maui.Graphics.Colors.Blue;
	}

	private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
	{
		pageBackground.BackgroundColor = Colors.Blue;
	}

	private void RadioButton_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
	{
		pageBackground.BackgroundColor = Colors.Aquamarine;
	}

    private void RadioButton_CheckedChanged_21(object sender, CheckedChangedEventArgs e)
    {
        pageBackground.BackgroundColor = Colors.AliceBlue;
    }

    private void RadioButton_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
	{
		pageBackground.BackgroundColor = Colors.Firebrick;
	}

	private void RadioButton_CheckedChanged_4(object sender, CheckedChangedEventArgs e)
	{
        pageBackground.BackgroundColor = Colors.Orange;
    }

	private void RadioButton_CheckedChanged_5(object sender, CheckedChangedEventArgs e)
	{
        pageBackground.BackgroundColor = Colors.PeachPuff;
    }

	private void searchBar_SearchButtonPressed(object sender, EventArgs e)
	{
		DisplayAlert("Searching", $"Fetching data for {searchBar.Text}...", "Ok");
	}

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Star Item", "Item added to starbox :)", "OK");
	}

	private void SwipeItem_Invoked_1(object sender, EventArgs e)
	{
        DisplayAlert("Delete Item", "Item added to trash", "OK");
    }
}