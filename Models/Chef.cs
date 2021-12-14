using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required(ErrorMessage ="First Name is required")]
        public string FirstName {get;set;}

        [Required(ErrorMessage ="Last Name is required")]
        public string LastName {get;set;}

        [Required(ErrorMessage ="Date of Birth is required")]
        // [MinLength(18, ErrorMessage = "Minimum age is 18 years old")]
        public DateTime DOB {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List <Dish> MyDishes {get;set;}


    }
}