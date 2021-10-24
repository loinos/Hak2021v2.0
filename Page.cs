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
        Note[] notes;
        int pointer;
        string hash;
        Page(int count)
        {
            notes = new Note[count];
            pointer = 0;
        }
        
        void Update()
        {

        }
        public Note GetLast()
        {
            return notes[pointer--];
        }
    }
}
