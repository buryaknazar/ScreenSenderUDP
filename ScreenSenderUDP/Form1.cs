using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace ScreenSenderUDP
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = null;
        int interval = 0;
        int port = 0;
        string address = string.Empty;
        UdpClient sender = null;
        BinaryFormatter formatter = null;
        private bool isActive = false;

        public Form1()
        {
            InitializeComponent();

            formatter = new BinaryFormatter();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                port = Convert.ToInt32(this.tbPort.Text.Trim());
                address = this.tbAddress.Text.Trim();
                interval = Convert.ToInt32(this.tbInterval.Text.Trim());
                sender = new UdpClient();
                isActive = true;
                this.btnStart.Enabled = false;
                this.btnStop.Enabled = true;

                Thread thread = new Thread(StreamScreens);
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnStart_Click:" + ex.Message);
                isActive = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void StreamScreens()
        {
            try
            {
                while (isActive)
                {
                    bitmap = GetScreenshot();
                    if (bitmap == null) continue;

                    List<Part> parts = CreateParts();
                    //SendParts(parts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("StreamScreens:" + ex.Message);
            }
        }

        private List<Part> CreateParts()
        {
            List<Part> parts = new List<Part>();

            try
            {
                byte[] bytes = null;
                int length = 0;

                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    bytes = ms.ToArray();
                    length = bytes.Length;
                }

                long key = DateTime.Now.Ticks;
                int number = 0;
                int partSize = 64000;
                int total = length / partSize + 1;
                byte[] data = new byte[partSize];

                while (number < total)
                {
                    int count = number + 1 == total ? length - number * partSize : partSize;
                    Array.Copy(bytes, number * partSize, data, 0, count);

                    using (StreamWriter sw = new StreamWriter("log.txt", true))
                    {
                        sw.WriteLine(number + " - " + number * partSize + " - " + count + " - Bmp");
                    }

                    parts.Add(new Part(number, total, key, data));
                    number++;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateParts:" + ex.Message);
            }

            return parts;
        }

        private void SendParts(List<Part> parts)
        {
            foreach (Part item in parts)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        formatter.Serialize(ms, item);
                        byte[] bytes = ms.ToArray();
                        sender.Send(bytes, bytes.Length, new IPEndPoint(IPAddress.Parse(address), port));
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("SendParts:" + ex.Message);
                }
            }
        }

        private Bitmap GetScreenshot()
        {
            Bitmap bmp = null;

            try
            {
                Rectangle capture = Screen.AllScreens[0].Bounds;
                bmp = new Bitmap(capture.Width, capture.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(capture.X, capture.Y, 0, 0, capture.Size);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("GetScreenshot:" + ex.Message);
            }

            return bmp;
        }
    }
}