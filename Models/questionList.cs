using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stepper.Models
{
    public class questionList
    {
        public List<question> questionsList = new List<question>()
        {
            new question()
            {
                que = "What is National  animal",
                options = new List<option>()
                {
                    new option()
                    {
                        text = "Tiger",
                        value = "tiger"
                    },
                    new option()
                    {
                        text = "Lion",
                        value = "lion"
                    },
                    new option()
                    {
                        text = "dog",
                        value = "dog"
                    }
                },
                answer = "tiger",
                id = 1
            },
            new question()
            {
                que = "Are we indian??",
                options = new List<option>()
                {
                    new option()
                    {
                        text = "Yes",
                        value = "Yes"
                    },
                    new option()
                    {
                        text = "No",
                        value = "No"
                    }
                },
                answer = "Yes",
                id = 2
            },
            new question()
            {
                que = "Am I From Ahmedabad??",
                options = new List<option>()
                {
                    new option()
                    {
                        text = "Yes",
                        value = "Yes"
                    },
                    new option()
                    {
                        text = "No",
                        value = "No"
                    }
                },
                answer = "No",
                id = 3
            }
        };
    }
}