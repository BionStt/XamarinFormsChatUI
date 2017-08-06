
using sample = XamarinFormsChatUISample;

namespace XamarinFormsChatUI.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var app = new sample.App();

            LoadApplication(app);
        }
    }
}
