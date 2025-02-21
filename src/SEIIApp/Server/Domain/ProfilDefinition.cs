﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEIIApp.Server.Domain
{
    public class ProfilDefinition
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string UrlImage { get; set; }
        public DateTime CreateProfile { get; set; }

        public List<LessonProfilDefinition> LessonProfilDefinition { get; set; }
    }
}