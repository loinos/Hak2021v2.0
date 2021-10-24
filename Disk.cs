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
        ulong pointer;
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
        public void Initialize()
        {
            //
        }

        ulong Set(byte[] data)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Open)))
            {
                bw.Write(data.Length);
                bw.Write(data);
            }
            return pointer++;
        }
        void Return()
        {
            pointer = 0;
        }
        Page.Note Get(ulong id)
        {
            Page.Note note = new Page.Note;
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (ulong i = 0; i < id; ++id) br.ReadByte();
                int size = br.ReadInt32();
                note.data = new byte[size];
                for (ulong i = 0; i < id; ++id) note.data[i] = br.ReadByte();
            }
            return note;
        }
        void Update(ulong id, byte[] array)
        {
            Page.Note note = new Page.Note;
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (ulong i = 0; i < id; ++id) br.ReadByte();
                int size = br.ReadInt32();
                if (array.Length < size) return;
                using (BinaryWriter bw = new BinaryWriter(br.BaseStream))
                {
                    bw.Write(array);
                }
            }
        }
    }
}
