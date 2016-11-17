﻿using Acme.Core.Domain.Identity;
using System.Collections.Generic;

namespace Acme.Core.Domain.Customer
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Could be refactored into a seperate `Address.cs` file also.
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<CustomerEmail> Emails { get; set; }
        public virtual ICollection<CustomerPhone> Phones { get; set; }
    }
}