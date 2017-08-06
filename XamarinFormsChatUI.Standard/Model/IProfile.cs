namespace XamarinFormsChatUI.Model
{
    public interface IProfile
    {
        string EmailAddress { get; }
        string ProfileName { get;  }
        bool Equals(object obj);
    }
}