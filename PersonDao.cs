using System;
using System.Collections.Generic;
using System.Text;

namespace DaoDB
{
    class PersonDao : IDao<Person>
    {
        private Queue<Person> queueOfPerson;

        public PersonDao()
        {
            this.queueOfPerson = new Queue<Person>();
        }

        public void Delete(Person obj)
        {
            queueOfPerson.Dequeue();
        }

        public Person Get(long id)
        {
            return queueOfPerson.Dequeue();
        }

        public IList<Person> GetAll()
        {
            return new List<Person>(queueOfPerson.ToArray());
        }

        public void Save(Person obj)
        {
            queueOfPerson.Enqueue(obj);
        }

        public void Update(Person old, Person actual)
        {
            queueOfPerson.Dequeue();
            queueOfPerson.Enqueue(actual);
        }
    }
}
