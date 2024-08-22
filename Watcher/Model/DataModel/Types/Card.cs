using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Model.DataModel.Types
{
    public class Card
    {
        public int Index { get; set; }
        public int ChannelCount { get; set; }
        public bool IsOpen { get; set; }
        public bool CommunicationLost { get; set; }
        public ushort Temperature { get; set; }
        public double Voltage { get; set; }
        public List<Channel> ChannelList { get; set; }
    }
}
