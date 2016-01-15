namespace Network_Recieve_Buffer
{
    using System;
    using System.ComponentModel;
    using System.Text;

    /// <summary>
    /// Packet generator class.
    /// </summary>
    public class PacketGenerator
    {
        /// <summary>
        /// Contains the encoded message.
        /// </summary>
        private byte[] encoded;

        /// <summary>
        /// Initializes a new instance of the PacketGenerator class.
        /// </summary>
        /// <param name="message">Message to encode.</param>
        public PacketGenerator(string message)
        {
            this.EncodedMessage += this.PacketGeneratorEncodedMessage;
            this.Encoded = UTF8Encoding.UTF8.GetBytes(message);
        }

        /// <summary>
        /// Listens if message is changed.
        /// </summary>
        public event PropertyChangedEventHandler EncodedMessage;

        /// <summary>
        /// Gets or sets packet property.
        /// </summary>
        public byte[] Encoded
        {
            get
            {
                return this.encoded;
            }

            set
            {
                if (this.EncodedMessage != null)
                {
                    this.EncodedMessage(this, new PropertyChangedEventArgs("Encoded"));
                }

                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.encoded = value;
            }
        }

        /// <summary>
        /// Prints property arguments property name.
        /// </summary>
        /// <param name="sender">Invoker of the event.</param>
        /// <param name="e">Arguments of the property changed event.</param>
        private void PacketGeneratorEncodedMessage(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }
    }
}
