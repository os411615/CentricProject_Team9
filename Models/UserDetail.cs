using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CentricProject_Team9.Models
{
    public class userDetail
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "First Name")] public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")] public string lastName { get; set; }
        [Display(Name = "Primary Phone")]
        [Phone]
        public string phone { get; set; }
        [Display(Name = "Office")]
        public string Office { get; set; }
        [Display(Name = "Current position")] public string Position { get; set; }
        [Display(Name = "Employee Since")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)] public DateTime employeeSince { get; set; }
        public string photo { get; set; }
    }

}