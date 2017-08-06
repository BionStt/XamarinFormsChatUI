using System;

namespace XamarinFormsChatUI.Model
{
    public interface IMessage : ITextModel
    {
        Profile FromProfile { get; set; }
        DateTime MessageDate { get; set; }
    }
}