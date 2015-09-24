﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Model
{
    class Member
    {
        [Range(0, int.MaxValue, ErrorMessage = "Members id is out of range.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Members name is required.")]
        [StringLength(30, ErrorMessage = "Member name must not exceed 30 chars.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Members personal number is required.")]
        [RegularExpression(@"^[0-9]{6}-[0-9]{4}$*", ErrorMessage = "Personal number must be in the following format: YYMMDD-NNNN")]
        public string PersonalNumber { get; set; }
    }
}