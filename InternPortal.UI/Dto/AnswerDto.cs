﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class AnswerDto
    {
        public int AnswerId { get; set; } // AnswerId (Primary key)
        public int ApplicationId { get; set; } // ApplicationId
        public int QuestionId { get; set; } // QuestionId
        public int? OptionId { get; set; } // OptionId
        public string AnswerValue { get; set; } // AnswerValue
        public bool OptionValue { get; set; } // OptionValue    
    }
}