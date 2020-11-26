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
            File.Open(_way + "/" + _filename, FileMode.Open);
        }

        public void Create()
        {
            File.Create(_way + "/" + _filename);
        }

        public void Delete()
        {
            File.Delete(_way + "/" + _filename);
        }

        public void Move()
        {
            File.Move(_way + "/" + _filename, _way2 + _filename);
        }

    }
}
