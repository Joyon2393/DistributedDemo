﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Person
    {
        public Guid Id { get; set; }
        [MaxLength(64)]
        public string FirstName { get; set; }= default!;
        [MaxLength(64)]
        public string LastName { get; set; }= default!;

        public ICollection<Contact>? Contacts { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}