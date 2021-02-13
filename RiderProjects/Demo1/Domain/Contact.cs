using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Contact
    {
        public Guid Id { get; set; }
        [MaxLength(36)] public string ContactValue { get; set; } = default!;
        
        public Guid PersonId { get; set; }
        public Person Person { get; set; }= default!;
        
        public Guid ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }= default!;
    }
}