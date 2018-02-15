﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
    {
        RankedGradeBook(string name) :base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
