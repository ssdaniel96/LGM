﻿using LGM.Domain.Entities.Base;
using LGM.Domain.Validators.Entities.Lectures;

namespace LGM.Domain.Entities.Readings
{
    public sealed class Progression : Entity
    {
        public int Chapter { get; private set; }
        public int PageNumber { get; private set; }
        public int Paragraph { get; private set; }

        //Navigation
        public ReadingPlan ReadingPlan { get; private set; }
        private Progression() { }
        public Progression(int chapter, int pageNumber, int paragraph)
        {
            ProgressionValidator.Validate(pageNumber, chapter, paragraph);
            Chapter = chapter;
            PageNumber = pageNumber;
            Paragraph = paragraph;
        }
    }
}
