using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4formpersonlab
{
    class PersonList
    {

        private List<Person> personList;

        public PersonList()
        {
            personList = new List<Person>();
        }


        public int count
        {
            get
            {
                return personList.Count;
            }

        }

        public void add(Person p)
        {
            personList.Add(p);
        }



        public Person this[string name]
        {
            get
            {
                foreach (Person p in personList)
                {
                    if (p.Lname == name)
                    { return p; }
                }
                return null;
            }
        }
    }
}
