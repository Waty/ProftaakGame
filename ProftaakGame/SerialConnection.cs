using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Ports;
using System.Linq;

namespace ProftaakGame
{
    public class SerialConnection
    {
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public enum MessageType
        {
            pre_Game,
            in_Game,
            menu,
            win_Game,
            set_coins,
            set_lifes
        }

        private const int BaudRate = 9600;
        private const char MessageBeginToken = '<';
        private const char MessageValuesSeperator = ';';
        private const char MessageEndToken = '>';
        private readonly MessageBuilder messageBuilder = new MessageBuilder(MessageBeginToken, MessageEndToken);
        private readonly SerialPort serialPort;

        public SerialConnection(string portName)
        {
            serialPort = new SerialPort(portName, BaudRate);
            serialPort.Open();
        }

        ~SerialConnection()
        {
            serialPort.Close();
        }

        public SerialData ReadAvailableData()
        {
            if (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                messageBuilder.Append(serialPort.ReadExisting());
            }

            return NextData();
        }

        private SerialData NextData()
        {
            string message = messageBuilder.NextMessage();
            if (message != null)
            {
                string[] data = message.Substring(1, message.Length - 2).Split(MessageValuesSeperator);
                return new SerialData
                {
                    Type = (MessageType) Enum.Parse(typeof (MessageType), data[0]),
                    Parameters = data.Skip(1).ToArray()
                };
            }

            return null;
        }

        public void WriteData(MessageType type, object[] data = null)
        {
            string msg = new SerialData {Type = type, Parameters = data}.ToString();
            Debug.WriteLine("Sending " + msg);
            serialPort.WriteLine(' ' + msg);
        }

        public void Dispose()
        {
            serialPort.Dispose();
        }

        public class SerialData
        {
            public object[] Parameters;
            public MessageType Type;

            public override string ToString()
            {
                string paramStr = "";
                if (Parameters != null)
                {
                    foreach (object parameter in Parameters)
                    {
                        paramStr += (MessageValuesSeperator + parameter.ToString());
                    }
                }

                return MessageBeginToken + Type.ToString() + paramStr + MessageEndToken;
            }
        }
    }
}