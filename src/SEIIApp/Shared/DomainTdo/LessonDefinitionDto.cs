﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SEIIApp.Shared.DomainTdo
{
    public class LessonDefinitionDto
    {
       
        public int id { get; set; }
        public int lessonNumber { get; set; }
        public string lessonTitle { get; set; }
        public string videoUrl { get; set; }
        public string text { get; set; }

      


    }
}
