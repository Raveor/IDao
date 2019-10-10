using System;
using System.Collections.Generic;
using System.Text;

namespace DaoDB
{
    class Book : IStorageObject
    {
        private long id;
        private String name;

        public Book(long id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        public long Id { get => id; set => id = value; }

        public void PrintMe()
        {
            Console.WriteLine("Book ID: {0} - {1}", id, name);
        }
    }
}
