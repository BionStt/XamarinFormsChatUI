using Adapt.Presentation;
using Xamarin.Forms.Xaml;
using XamarinFormsChatUISample.Model;
using XamarinFormsChatUISample.Pages;

namespace XamarinFormsChatUISample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public static IPermissions Permissions;

        public MainPage()
        {
            InitializeComponent();

            var currentProfile = new Profile { EmailAddress = "Christian_findlay@hotmail.com", ProfileName = "Christian Findlay" };

            var chatPage = new ChatPage();
            chatPage.ChatProvider = new DummyChatProvider(currentProfile);

            MainNavigationPage.PushAsync(chatPage);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}