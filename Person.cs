using System;
using System.Collections.Generic;
using System.Text;

namespace DaoDB
{
    class Person : IStorageObject
    {
        private long id;
        private String name;
        private String surname;

        public long Id { get => id; set => id = value; }

        public void PrintMe()
        {
            Console.WriteLine("Person ID: {0} - {1} {2}", Id, surname, name);
        }
    }
}
