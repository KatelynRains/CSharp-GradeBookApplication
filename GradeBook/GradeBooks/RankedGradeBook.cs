﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook
    { public RankedGradeBook(string name) :base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {              
            
            return base.GetLetterGrade(averageGrade);
        }
    }
}
