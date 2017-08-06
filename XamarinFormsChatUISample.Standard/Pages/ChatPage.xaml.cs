using XamarinFormsChatUI.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsChatUISample.Model;

namespace XamarinFormsChatUISample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public IChatProvider ChatProvider
        {
            get
            {
                return TheChatBox.ChatProvider;
            }
            set
            {
                TheChatBox.ChatProvider = value;
            }
        }

        public ChatPage()
        {
            InitializeComponent();
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            TheChatBox.ChatProvider.SendMessage(new Message { FromProfile = ChatProvider.CurrentProfile, MessageDate = DateTime.Now, Text = TheEditor.Text });
            TheEditor.Text = string.Empty;
        }

        private void TheEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            SendButton.IsEnabled = TheEditor.Text != string.Empty;
        }
    }
}