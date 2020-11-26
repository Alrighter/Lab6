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
        

        public AbstractHandler(){}

        public void constructor(string way, string filename)
        {
            this._way = way;
            this._filename = filename;
        }

        public void Open()
        {
            File.Open(_way + _filename, FileMode.Open);
        }

        public void Create()
        {
            File.Create(_way + _filename);
        }

        public void Edit()
        {
            
        }

    }
}
