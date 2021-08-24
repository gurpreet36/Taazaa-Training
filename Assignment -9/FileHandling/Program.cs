using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args) 
        {
            FileStream ObjF = new FileStream("test.dat", FileMode.OpenOrCreate, 
            FileAccess.ReadWrite);
         
            for (int i = 1; i <= 20; i++) 
            {
            ObjF.WriteByte((byte)i);
            }
            ObjF.Position = 0;
            for (int i = 0; i <= 22; i++) 
            {
                Console.Write(ObjF.ReadByte() + " ");
            }
            ObjF.Close();
        }
    }
}
