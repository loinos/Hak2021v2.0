using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hak2021v2._0
{
    class Page
    {
        public struct Note
        {
            public byte[] data;
        }
        public Note[] notes;
        int pointer;
        string hash;
        public Page(int count)
        {
            notes = new Note[count];
            pointer = 0;
        }

        public void Update()
        {

        }
        public Note GetLast()
        {
            return notes[pointer--];
        }
    }
}
