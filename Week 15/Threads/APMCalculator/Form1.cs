namespace APMCalculator
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;

    partial class Form1 : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        private int counter;

        private double apm;

        public Form1()
        {
            this.InitializeComponent();
            this.stopwatch.Start();
            this.CalculateApm();
        }

        private void Form1Click(object sender, EventArgs e)
        {
            lock (this)
            {
                this.counter++;
            }
        }

        [SuppressMessage("ReSharper", "FunctionNeverReturns")]
        private void CalculateApm()
        {
            var thread = new Thread(
                () =>
                    {
                        while (true)
                        {
                            lock (this)
                            {
                                this.apm = this.counter / ((double)this.stopwatch.ElapsedMilliseconds / 60000);
                            }

                            this.BeginInvoke((Action)this.CallBack);
                            Thread.Sleep(1000);
                        }
                    })
            { IsBackground = true };
            thread.Start();
        }

        private void CallBack()
        {
            lock (this)
            {
                this.label1.Text = string.Format("{0} clicks per minute!", this.apm.ToString("F2"));
            }
        }
    }
}
