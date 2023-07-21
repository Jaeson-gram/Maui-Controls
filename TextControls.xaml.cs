using Android.OS;
using AndroidX.ConstraintLayout.Motion.Widget;
using JetBrains.Annotations;
using System.Diagnostics;

namespace MauiControls;

public partial class TextControls : ContentPage
{
	public TextControls()
	{
		InitializeComponent();
	}

	private void EntryCtrltxt_TextChanged(object sender, TextChangedEventArgs e)
	{
	}

	private void EntryCtrltxt_Completed(object sender, EventArgs e)
	{
    }
}