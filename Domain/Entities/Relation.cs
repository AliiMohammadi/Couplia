using System;
using Enums;

namespace Entities
{
    public class Relation
    {
        public Guid Id { get; set; }
        public Person MalePerson { get; set; }
        public Person FemalePerson { get; set; }
        public RelationStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CutReasons CutReason { get; set; }
        public AccessType Type { get; set; }
        public string FingerPrint { get; set; }
        public string Discription { get; set; }
        //picutre
    }


}
