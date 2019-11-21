﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "datos.txt";

            FileStream stream = new FileStream(fileName,
                FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            Console.Write(reader.ReadString());
            Console.Write(reader.ReadString());
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[{0}]", reader.ReadDouble());
                }
                Console.Write(reader.ReadString());
            }
            reader.Close();
            stream.Close();
            Console.ReadKey();
        }
    }
}
