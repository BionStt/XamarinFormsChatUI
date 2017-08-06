using System;
using XamarinFormsChatUI.Model;

namespace XamarinFormsChatUISample.Model
{
    public class Message : TextModelBase, IMessage
    {
        private DateTime _MessageDate;
        private IProfile _FromProfile;

        public DateTime MessageDate
        {
            get => _MessageDate; set
            {
                _MessageDate = value;
                RaisePropertyChanged();
            }
        }

        public IProfile FromProfile
        {
            get => _FromProfile;
            set
            {
                _FromProfile = value;
                RaisePropertyChanged();
            }
        }
    }
}
