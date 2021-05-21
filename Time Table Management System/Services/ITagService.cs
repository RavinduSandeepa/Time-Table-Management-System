﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ITagService
    {
        Boolean addTag(Tag tag);
        List<Tag> getAllTags();
        Tag GetTag(int id);
        Boolean deleteTagr(int id);
        Boolean updateTag(int id, Tag tag);
    }
}
