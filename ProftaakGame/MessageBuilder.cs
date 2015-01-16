using System;
using System.Text;

namespace ProftaakGame
{
    /// <summary>
    ///     This class can be used to buffer text data.
    ///     The buffered data makes up messages which can be retrieved
    ///     by using the NextMessage method.
    ///     The delimiters for the messages are define by the constructor.
    /// </summary>
    public class MessageBuilder
    {
        /// <summary>
        ///     Marker that marks the start of a message.
        /// </summary>
        private readonly char messageBeginMarker;

        /// <summary>
        ///     Marker that marks the mark the end of a message.
        /// </summary>
        private readonly char messageEndMarker;

        /// <summary>
        ///     Buffer to store text strings.
        /// </summary>
        private StringBuilder bufferedData;

        /// <summary>
        ///     Create a MessageBuilder instance.
        /// </summary>
        /// <param name="messageBeginMarker">
        ///     Marker that is used to find the start of a message when trying to find messages in the buffered data.
        /// </param>
        /// <param name="messageEndMarker">
        ///     Marker that is used to find the end of a message when trying to find messages in the buffered data.
        /// </param>
        public MessageBuilder(char messageBeginMarker, char messageEndMarker)
        {
            this.messageBeginMarker = messageBeginMarker;
            this.messageEndMarker = messageEndMarker;

            bufferedData = new StringBuilder();
        }

        /// <summary>
        ///     Add the data to the end of the buffered data.
        /// </summary>
        /// <param name="data">
        ///     The data to add to the builder for later parsing.
        ///     If data == null, nothing is added.
        /// </param>
        public void Append(String data)
        {
            if (data != null)
            {
                bufferedData.Append(data);
            }
        }

        /// <summary>
        ///     Find and remove the next (complete) message
        ///     from the buffered data (including delimiters).
        ///     The beginning and the end of the message are marked
        ///     by 'messageBeginMarker' and 'messageEndMarker'
        ///     (see member variables of this class).
        /// </summary>
        /// <returns>
        ///     The next (complete) message (including markers),
        ///     or null if no message was found.
        /// </returns>
        public String NextMessage()
        {
            string data = bufferedData.ToString();
            int beginIndex = data.IndexOf(messageBeginMarker);
            if (beginIndex != -1)
            {
                int endIndex = data.IndexOf(messageEndMarker, beginIndex);
                if (endIndex != -1)
                {
                    String foundMessage = data.Substring(beginIndex, (endIndex - beginIndex) + 1);
                    bufferedData.Remove(0, endIndex);
                    return foundMessage;
                }
            }
            return null;
        }

        /// <summary>
        ///     Clear all buffered data
        /// </summary>
        public void Clear()
        {
            bufferedData = new StringBuilder();
        }
    }
}