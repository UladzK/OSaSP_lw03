using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lw03
{
    /* implements consumer */
    class SequenceFinder
    {
        private const int thrdCount = 10;
        CustomMonitor cm;
        Form1 form;

        public SequenceFinder(CustomMonitor cm)
        {
            this.cm = cm;
            form = new Form1(); 
        }

        byte[] GetMD5(string file)
        {
            MD5 md5 = MD5.Create();
            try
            {
                FileStream stream = File.OpenRead(file);
                return md5.ComputeHash(stream);
            }
            catch(IOException)
            {
                return null;
            }
        }

        public int GetSeqCount(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                int seqCount = 0;
                while (!(sr.EndOfStream))
                {
                    string stringInFile = sr.ReadLine();
                    if (stringInFile.Contains("MZ"))
                        seqCount++;
                }
                return seqCount;
            }
            catch (IOException)
            {                
                return -1;
            }
        }
    
        public void Run()
        {
            string fileName;       
            do
            {
                fileName = cm.GetFilePath();
                if (fileName != null)
                {
                    int seqCount = GetSeqCount(fileName);
                    if (seqCount != -1)
                    {
                        string md5 = BitConverter.ToString(GetMD5(fileName)).Replace("-", "").ToLower();
                        //form.SetFileList(seqCount, fileName, md5);                    
                        cm.SetFileList(seqCount, fileName, md5);
                    }
                }
            } while (fileName != null);
        }
    }
}
