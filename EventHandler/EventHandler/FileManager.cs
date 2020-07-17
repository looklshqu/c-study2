using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    class FileManager
    {
        //private Form1 form;
        //public FileManager(Form1 form)
        //{
        //    this.form = form;
        //}
        public event EventHandler<double> InProgress; // 이벤트 정의

        public void Copy(string srcfile, string destfile) // 파라미터: 입력 파일명, 출력 파일명
        {
            byte[] buffer = new byte[1024]; //1k
            int pos = 0;

            //파일 사이즈
            var fi = new FileInfo(srcfile);
            var filesize = fi.Length;

            //파일 복사
            using (BinaryReader rd = new BinaryReader(File.Open(srcfile, FileMode.Open)))
            using (BinaryWriter wr = new BinaryWriter(File.Open(destfile, FileMode.Create)))
            {
                while (pos < filesize)
                {
                    int count = rd.Read(buffer, 0, buffer.Length);
                    wr.Write(buffer, 0, count);
                    pos += count;

                    // progress bar 표시
                    double pct = (pos / (double)filesize) * 100;
                    if (InProgress != null)
                    {
                        InProgress(this, pct);
                    }
                    //form.progressBar1.Value = (int)pct;
                    //form.lblPct.Text = string.Format("{0} %", (int)pct);
                }
            }
        }
    }
}
