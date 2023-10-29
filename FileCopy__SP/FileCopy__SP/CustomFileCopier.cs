using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopy__SP
{
    public delegate void ProgressChangeDelegate(double Percentage, ref bool Cancel);
    public delegate void Completedelegate();
    

    class CustomFileCopier
    {
        public CustomFileCopier(string Source, string Dest,ref ProgressBar progressBar)
        {
            this.SourceFilePath = Source;
            this.DestFilePath = Dest;
            this.progressBar = progressBar;

            OnProgressChanged += delegate { };
            OnComplete += delegate { };
        }

        public void Copy()
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            bool cancelFlag = false;

            using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long fileLength = source.Length;
                using (FileStream dest = new FileStream(DestFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytes += currentBlockSize;
                        double percentage = (double)totalBytes * 100.0 / fileLength;
                        progressBar.Value = Convert.ToInt32(percentage);

                        dest.Write(buffer, 0, currentBlockSize);

                        cancelFlag = false;
                        OnProgressChanged(percentage, ref cancelFlag);

                        if (cancelFlag == true)
                        {
                            break;
                        }
                        Thread.Sleep(100);
                    }
                }
            }

            OnComplete();
        }

        public string SourceFilePath { get; set; }
        public string DestFilePath { get; set; }

        private ProgressBar progressBar;

        public event ProgressChangeDelegate OnProgressChanged;
        public event Completedelegate OnComplete;
    }
}
