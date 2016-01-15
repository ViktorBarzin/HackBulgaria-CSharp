namespace Network_Recieve_Buffer
{
    using System.ComponentModel;
    using System.Text;

    /// <summary>
    /// Receiver class.
    /// </summary>
    public class ReceiveBuffer
    {
        /// <summary>
        /// Length of the received message.
        /// </summary>
        private readonly int len = -1;

        /// <summary>
        /// Contains the decoded message.
        /// </summary>
        private string decodedMessage;

        /// <summary>
        /// Current byte decoded.
        /// </summary>
        private byte[] currentBytes;

        /// <summary>
        /// Event listening for changing the message.
        /// </summary>
        public event PropertyChangedEventHandler MessageReceived;

        /// <summary>
        /// Gets or sets the decoded message.
        /// </summary>
        private string DecodedMessage
        {
            get
            {
                return this.decodedMessage;
            }

            set
            {
                if (this.MessageReceived != null)
                {
                    this.MessageReceived(this, new PropertyChangedEventArgs("Message decoded"));
                }

                this.decodedMessage = value;
            }
        }

        /// <summary>
        /// Decodes incoming byte.
        /// </summary>
        /// <param name="data">Data to decode.</param>
        public void BytesReceived(byte[] data)
        {
            // UTF8Encoding utf8 = new UTF8Encoding();
            // this.decodedMessage = utf8.GetString(message);
            // Console.WriteLine(this.decodedMessage);
            if (data.Length == 2)
            {
                this.currentBytes = new byte[data[1]];
            }
            else
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                this.DecodedMessage = utf8.GetString(data);
            }
        }
    }
}
