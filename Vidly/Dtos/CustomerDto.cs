﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? Birthdate { get; set; }

        [Required]
        public bool IsSubscribedToNewsLetter { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}