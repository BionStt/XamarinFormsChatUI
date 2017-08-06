using System;

namespace XamarinFormsChatUI.Model
{
    public interface IMessage : ITextModel
    {
        IProfile FromProfile { get; set; }
        DateTime MessageDate { get; set; }
    }
}