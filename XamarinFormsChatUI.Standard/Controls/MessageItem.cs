using XamarinFormsChatUI.Model;
using Xamarin.Forms;

namespace XamarinFormsChatUI.Controls
{
    public class MessageItem : StackLayout
    {
        public static Color HyperlinkColour = Color.FromRgb(102, 153, 253);

        private Label _ProfileLabel;
        private Label _TextLabel;
        private Label _DateTimeLabel;

        public MessageItem()
        {
            BackgroundColor = Color.White;
            Margin = new Thickness(4);

            Orientation = StackOrientation.Vertical;

            _ProfileLabel = new Label();
            _ProfileLabel.SetBinding(Label.TextProperty, new Binding("FromProfile.ProfileName"));
            _ProfileLabel.TextColor = HyperlinkColour;
            _ProfileLabel.HorizontalTextAlignment = TextAlignment.Start;
            Children.Add(_ProfileLabel);

            _TextLabel = new Label();
            _TextLabel.SetBinding(Label.TextProperty, new Binding(nameof(IMessage.Text)));
            _TextLabel.HorizontalTextAlignment = TextAlignment.Start;
            _TextLabel.MinimumWidthRequest = 300;
            _TextLabel.TextColor = Color.Black;
            Children.Add(_TextLabel);

            _DateTimeLabel = new Label();
            _DateTimeLabel.SetBinding(Label.TextProperty, new Binding(nameof(IMessage.MessageDate)));
            _DateTimeLabel.HorizontalTextAlignment = TextAlignment.End;
            _DateTimeLabel.TextColor = Color.Black;
            Children.Add(_DateTimeLabel);
        }
    }
}
