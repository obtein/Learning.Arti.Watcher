using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Model.DataModel.Types
{
    public class Channel
    {

        public int Index { get; set; } // 10 for card1, 20 for card2, 30 for card3
        public double Current { get; set; }
        public bool IsOpen { get; set; }
        public bool ShortCircuit { get; set; }
        public bool OverCurrent { get; set; }
        public bool VoltageError { get; set; }
        public bool CommunicationLost { get; set; }
    }
}
