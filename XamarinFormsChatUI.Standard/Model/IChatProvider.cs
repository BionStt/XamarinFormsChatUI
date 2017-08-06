using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace XamarinFormsChatUI.Model
{
    public interface IChatProvider : IEnumerable<ITextModel>, INotifyCollectionChanged
    {
        Task LoadAllAsync();
        IProfile CurrentProfile { get; }
        void SendMessage(IMessage message);
    }
}
