﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dtos.AuthorDtos
{
    public class ResultAuthorDto
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string ShortDesc { get; set; }
        public string AuthorImageBase64 { get; set; }
    }
}
