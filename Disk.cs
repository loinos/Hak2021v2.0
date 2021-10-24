using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hak2021v2._0
{
    class Disk
    {
        string path;

        int capacity;
        int pointer;
        Page[] pages;

        public Disk()
        {
        }
        public void New(string path, int capacity)
        { 
            FileInfo disk = new FileInfo(path);
            pages = new Page[capacity];
            pointer = 0;
        }
        /*
        private string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }
        */

        ulong Set(byte[] data)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Open)))
            {
                
            }
        }
        Page.Note Get()
        {

        }
        void Update()
        {

        }
    }
}
