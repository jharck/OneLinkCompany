using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneLinkCompany.Models
{

    public enum TypeDoc
    {
        DUI, NIT, Passport
    }
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        [Display(Name = "Type Of Document")]
        public TypeDoc? TypeDoc { get; set; }

        [Display(Name = "Document #")]
        public string Document { get; set; }

        public ICollection<Area> Areas { get; set; }

        public string AreaName { get; set; }
        
    }
}