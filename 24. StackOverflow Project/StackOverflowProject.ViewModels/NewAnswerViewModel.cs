﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflowProject.ViewModels
{
    public class NewAnswerViewModel
    {
        [Required]
        public string AnswerText { get; set; }

        [Required]
        public DateTime AnswerDateAndTime { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int QuestionID { get; set; }

        [Required]
        public int VotesCount { get; set; }
    }
}


