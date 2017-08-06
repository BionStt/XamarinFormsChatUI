namespace XamarinFormsChatUI.Model
{
    public class TextModelBase : ModelBase, ITextModel
    {
        private string _Text;

        public string Text
        {
            get => _Text;
            set
            {
                _Text = value;
                RaisePropertyChanged();
            }
        }
    }
}
