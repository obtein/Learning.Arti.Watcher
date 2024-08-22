using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Model.CommunicationModel.Types
{
    public class SerialCom
    {
        public SerialCom(string port, int baudRate, Parity par, int databit, StopBits sb, Handshake hs, int readTO, int writeTO) 
        {
        }
    }
}
