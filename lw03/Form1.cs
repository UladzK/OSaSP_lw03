using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw03
{
    public partial class Form1 : Form
    {
        CustomMonitor m;
        FileFinder ff;
        SequenceFinder sf;
        
        public Form1()
        {            
            InitializeComponent();            
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string path = pathBox.Text;            

            if (Directory.Exists(path))
            {
                m = new CustomMonitor();
                sf = new SequenceFinder(m);
                ff = new FileFinder(path, m);
                
                Thread producer = new Thread(ff.Run);
                producer.Name = "producer";
                producer.Start();
                Thread consumer = new Thread(sf.Run);
                consumer.Name = "consumer";
                consumer.Start();
                consumer.Join();
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Directory/File not found");
            }
        }
    }
}
