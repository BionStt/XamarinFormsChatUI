namespace XamarinFormsChatUI.Model
{
    public interface IProfile
    {
        string EmailAddress { get; set; }
        string ProfileName { get; set; }

        bool Equals(object obj);
    }
}