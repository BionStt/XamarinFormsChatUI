using System;

namespace XamarinFormsChatUI.Model
{
    public interface IMessage : ITextModel
    {
        IProfile FromProfile { get;  }
        DateTime MessageDate { get; }
    }
}