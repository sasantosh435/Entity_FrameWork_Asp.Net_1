﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      //  public int Age { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Email> EmailAddress { get; set; } = new List<Email>();

    }
}
