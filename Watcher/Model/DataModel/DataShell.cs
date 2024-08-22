using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher.Model.DataModel.Types;

namespace Watcher.Model.DataModel
{
    public class DataShell
    {
        public List<Card> CardList { get; set; }


        public List<Card> GetCardList ()
        {
            return CardList;
        }
        public Card GetCard (int index)
        {
            return CardList[index];
        }
        public List<Channel> GetChannelList (int index)
        {
            return CardList [index].ChannelList;
        }
        public Channel GetChannel ( int cardIndex, int channelIndex )
        {
            return CardList [cardIndex].ChannelList[channelIndex];
        }
    }
}
