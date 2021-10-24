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
            int m_size;
            byte[] data;
        }
        Note[] notes;
        string hash;
        Page(int count)
        {
            notes = new Note[count];
        }
        void Update()
        {

        }
    }
}
