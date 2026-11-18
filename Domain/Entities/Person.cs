using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Entities
{
    public class Person
    {
        public Account account { get; set; }
        public int Age { get; set; }
        public string NationalCode { get; set; }
        public string City { get; set; }
        public RelationStatus Relationstatus { get; set; }
        public Relation relation { get; set; }
        public History history { get; set; }
        public string PhoneNumber { get; set; }
        //public File Picture { get; set; }
    }


}
