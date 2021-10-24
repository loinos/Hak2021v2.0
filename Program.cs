using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hak2021v2._0
{
    class Program
    {
        public static string generateControllsumForList(byte[] list)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(list);
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            return result;
        }
        public static byte[] bitArrayConvertor(BitArray input_bits)
        {
            BitArray a = new BitArray(input_bits.Length + (input_bits.Length & 8));
            for (int i = 0; i < input_bits.Length; i++)
            {
                a[i] = input_bits[i];
            }
            byte[] bytes = new byte[a.Length / 8];
            a.CopyTo(bytes, 0);
            return bytes;
        }
        public static byte[] generateXOR(byte[] list1,byte[] list2)
        {
            BitArray list1_bits = new BitArray(list1);
            BitArray list2_bits = new BitArray(list2);
            BitArray ans_bits = new BitArray(list2_bits.Length);

            for(int i = 0; i < ans_bits.Length; i++)
            {
                ans_bits[i] = list1_bits[i] ^ list2_bits[i];
            }
            return bitArrayConvertor(ans_bits);
        }
        public static byte[] recovery (byte[]duollist,byte[] xorlist)
        {
            BitArray duollist_bits = new BitArray(duollist);
            BitArray xor_bits = new BitArray(xorlist);
            BitArray ans_bits = new BitArray(xor_bits.Length);
            for(int i =0; i< ans_bits.Length; i++)
            {
                if (xor_bits[i])
                {
                    ans_bits[i] = !duollist_bits[i];
                }
                else
                {
                    ans_bits[i] = duollist_bits[i];
                }
            }
            return bitArrayConvertor(ans_bits);
        }

        static void Main(string[] args)
        {
            byte[] byt = new byte[] { 12, 8, 7, 111 };
            Console.WriteLine(generateControllsumForList(byt));
        }
    }
}
