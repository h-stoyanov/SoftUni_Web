﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Listings
    {
        public  Listings()
        {
            this.Date=DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title  { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }

        public string Comments { get; set; }

    }
}