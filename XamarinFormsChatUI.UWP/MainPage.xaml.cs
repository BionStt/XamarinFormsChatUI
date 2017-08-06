
using samples = XamarinFormsChatUI.Sample;
using Adapt.Presentation.UWP;

namespace XamarinFormsChatUI.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            samples.MainPage.Permissions = new Permissions();

            var app = new samples.App();

            LoadApplication(app);
        }
    }
}
