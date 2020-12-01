using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab6
{
    public class AbstractHandler
    {
        private string _way;
        private string _filename;
        private string _way2;

        public AbstractHandler(){}

        public void constructor(string way, string filename)
        {
            this._way = way;
            this._filename = filename;
        }
        public void constructor(string way, string filename, string way2)
        {
            this._way = way;
            this._filename = filename;
            this._way2 = way2;
        }
        public void Open()
        {
            using (FileStream fs = File.Open($"{_way}\\{_filename}.docx", FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                Console.WriteLine($"Name: {fs.Name}, Type: {Path.GetExtension(fs.Name)}");
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }

            }
        }

        public void Create()
        {
            using (FileStream fs = File.Create($"{_way}\\{_filename}.doc"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("text");
                fs.Write(info, 0, info.Length);
            }
        }

        public void Delete()
        {
            File.Delete($"{_way}\\{_filename}.doc");
        }

        public void Move()
        {
            File.Move($"{_way}\\{_filename}.doc", _way2);
        }

    }
}
