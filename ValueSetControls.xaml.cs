namespace MauiControls;

public partial class ValueSetControls : ContentPage
{
	public ValueSetControls()
	{
		InitializeComponent();
	}

	private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		int labelText = Convert.ToInt32(slider.Value);

		label.Text = labelText.ToString();
	}

	private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        int stepperText = Convert.ToInt32(stepper.Value);

		if (stepper is not null)
		{
            label.Text = stepperText.ToString();
        }


    }
}