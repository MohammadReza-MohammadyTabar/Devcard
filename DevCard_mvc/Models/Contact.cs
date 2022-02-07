using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Models
{
    public class Contact
    {
        [Required (ErrorMessage ="این فیلد حتما باید پر شود!")]
        [MinLength(3,ErrorMessage ="نباید کمتر از 3 کاراکتر باشد ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد حتما باید پر شود!")]
        [EmailAddress(ErrorMessage ="فرم ایمل را صحیح وارد کنید ")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }

    }
}
