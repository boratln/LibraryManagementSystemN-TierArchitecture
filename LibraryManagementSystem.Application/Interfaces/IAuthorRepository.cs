﻿using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Interfaces
{
    public interface IAuthorRepository:IRepository<Author>
    {
        Author SearchAuthor(string word);
    }
}
