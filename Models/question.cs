using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stepper.Models
{
    public class question
    {
        public static int counter = 0;
        public int id { get; set; }
        public question()
        {
            isAnswered = true;
            incrementId();
            isAnswered = false;
        }
        public void incrementId()
        {
            counter++;
        }
        public int getId()
        {
            return id;
        }
        public string que { get; set; }
        public List<option> options { get; set; }

        public string answer { get; set; }

        public bool isAnswered { get; set; }

        [Required(ErrorMessage = "Please Select Answer!!")]
        public string selectedOption { get; set; }
    }
}