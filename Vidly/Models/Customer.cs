﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId{ get; set; }

        [Display(Name = "Membreship Type")]
        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime Birthdate { get; set; }
    }
}