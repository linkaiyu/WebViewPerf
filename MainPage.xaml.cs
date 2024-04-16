namespace WebViewPerf
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			webView.Source = "https://bing.com";
		}
	}

}
