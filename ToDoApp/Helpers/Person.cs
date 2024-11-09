using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ToDoApp.Helpers
{
    public class Person
    {
        // Task 9: ints are a non-null type. Did you mean non-zero?
        [Required] [NotZero]
        public int ID { get; set; }

        [Required] [NotZero]
        public int Age { get; set; }

        [Required] [StringLength(50, MinimumLength = 3)] 
        public string FirstName { get; set; }

        [Required] [StringLength(50, MinimumLength = 3)] 
        public string LastName { get; set; }

        [Required] [StringLength(100)] [EmailAddress] 
        public string Email { get; set; }
    }
    public class Student : Person
    {
        [StringLength(250)]
        public string University { get; set; }
    }

    public class NotZeroAttribute : ValidationAttribute
    {
        public NotZeroAttribute() : base("The value cannot be zero.") { }

        public override bool IsValid(object value)
        {
            if (value is int intValue)
            {
                return intValue != 0;
            }
            return false;
        }
    }
}