using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalityAnalysis.Models
{
    public class PersonalityQuestion
    {
        [Required(ErrorMessage ="أدخل أسمك لو سمحت!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int BestFeeling { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int WalkWay { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int SpeakingWithOther { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int Relaxing { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int SmilingWay { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int EnteringWay { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int ReactionWay { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int BestColor { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int SleepingWay { get; set; }

        [Required(ErrorMessage = "أدخل أجابتك لو سمحت!")]
        public int RepeatDream { get; set; }
       
    }
}