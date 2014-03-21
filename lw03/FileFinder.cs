using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw03
{
    /* implements producer */
    class FileFinder
    {
        string rootPath;
        CustomMonitor cm;

        public FileFinder(string rootPath, CustomMonitor cm)
        {
            this.rootPath = rootPath;
            this.cm = cm;
        }

        public void Run()
        {
            //using stack to store subdirectories paths
            var dirs = new Stack<string>();
            cm.ProducerStatus = Status.Loading;

            dirs.Push(rootPath);

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs = { };
                string[] files = { };

                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }
                catch (UnauthorizedAccessException) { }
                catch (DirectoryNotFoundException) { }

                foreach (var dir in subDirs)
                {
                    dirs.Push(dir);
                }

                try
                {
                    files = Directory.GetFiles(currentDir);
                }
                catch (DirectoryNotFoundException) { }

                foreach (var file in files)
                {
                    cm.Add(file);
                    cm.SetMonitorList(file);
                }
            }            
            cm.ProducerStatus = Status.Ready;
        }
    }
}
