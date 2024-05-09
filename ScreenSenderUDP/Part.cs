using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSenderUDP
{
    public class Part
    {
        private int number;
        private int total;
        private long key;
        private byte[] data;

        public int Number { get => number; set => number = value; }
        public int Total { get => total; set => total = value; }
        public long Key { get => key; set => key = value; }
        public byte[] Data { get => data; set => data = value; }

        public Part(int number, int total, long key, byte[] data)
        {
            this.number = number;
            this.total = total;
            this.key = key;
            this.data = data;
        }

        public Part()
        {
            this.number = 0;
            this.total = 0;
            this.key = 0;
            this.data = null;
        }


    }
}
