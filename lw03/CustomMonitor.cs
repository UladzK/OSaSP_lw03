using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lw03
{
    //two states of producer:
    enum Status { Ready, Loading};
    /* Implements Monitor for Producer-Consumer problem solving*/

    class CustomMonitor
    {
        public const int bufferSize = 25;             
        private List<string> buffer;
        public Status ProducerStatus { get; set; }
        //ResetEvent for producer and consumer signals
        public ManualResetEvent MyEvent { get; set; }

        public CustomMonitor(){
            buffer = new List<string>(bufferSize);            
            ProducerStatus = Status.Loading;
            MyEvent = new ManualResetEvent(false);
        }

        public void Add(string item) {
            while (buffer.Count == bufferSize) {
                //wait for consumer to process files in buffer
                MyEvent.WaitOne();
            }        

            buffer.Add(item);            
 
            if (buffer.Count == 1) {
                //set event to consumer that buffer is not empty
                MyEvent.Set();
            }
        }

        public string GetFilePath() {
            if (buffer.Count == 0 && ProducerStatus == Status.Ready)
                return null;
            while (buffer.Count == 0)
            {
                //wait for producer to load files into buffer
                MyEvent.WaitOne();
            }

            string item = buffer.First<string>();
            buffer.Remove(item);
            
            if (buffer.Count == bufferSize - 1)
            {
                //set event to producer that buffer is not full
                MyEvent.Set();
            }

            return item;            
        }

        public void SetMonitorList(string path)
        {            
            Console.WriteLine("Path: " + path);
        }

        public void SetFileList(int seqCount, string path, string md5)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("MZ's: " + seqCount.ToString());
            Console.WriteLine("Path: " + path);
            Console.WriteLine("MD5: " + md5);
            Console.WriteLine("-------------");
        }
    }
}
