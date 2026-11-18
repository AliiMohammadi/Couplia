using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class History
    {
        public List<Relation> Relations { get; set; }
        public List<Person> Persons
        {
            get;
        }
        public int Count()
        {
            return 0;
        }
    }
}
