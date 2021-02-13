using System;
using System.Collections.Generic;

namespace Domain
{
    public class ContactType
    {
        

        public Guid Id { get; set; }
        
        public ICollection<Contact>? Contacts { get; set; }
        
    }
}