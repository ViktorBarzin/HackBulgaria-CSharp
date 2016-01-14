namespace Network_Recieve_Buffer
{
    using System;
    using System.Text;

    public class Application
    {
        /// <summary>
        /// Main method.
        /// </summary>
        static void Main()
        {
            // Check functionality ?
            // decode message one byt at the time or entire byte[] message
            // byte[2] ?

            string message = "zzr 2";
            var packetGen = new PacketGenerator(message);

            ReceiveBuffer buffer = new ReceiveBuffer();
            buffer.MessageReceived += BufferMessageReceived;
            
            buffer.BytesReceived(packetGen.Encoded);

        }

        /// <summary>
        /// Action to do when a message is decoded.
        /// </summary>
        /// <param name="sender">Invoker of the event.</param>
        /// <param name="e">Event arguments.</param>
        private static void BufferMessageReceived(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }
    }
}
