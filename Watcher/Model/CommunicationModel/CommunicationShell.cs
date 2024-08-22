using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher.Model.CommunicationModel.Types;

namespace Watcher.Model.CommunicationModel
{
    public class CommunicationShell
    {
        public void CreateSerialCom ( string port, int baudRate, Parity par, int databit, StopBits sb, Handshake hs, int readTO, int writeTO )
        {
            SerialCom secom = new SerialCom( port, baudRate, par, databit, sb, hs, readTO, writeTO );
        }

        public void CreateEthernetCom ()
        {

        }
    }
}
