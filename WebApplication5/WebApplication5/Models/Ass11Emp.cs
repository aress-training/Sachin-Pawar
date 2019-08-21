//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static WebApplication5.Common.RemoteClientServer;

    public partial class Ass11Emp
    {
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 5)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RemoteClientServer("IsEmailAvailable", "Assignment11", ErrorMessage = "Email already in use.")]
        public string Email { get; set; }

        [Range(1, 100)]
        [Required(ErrorMessage = "Age is required")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Hire Date is required")]
        [Display(Name = "Hire Date")]        
        [Range(typeof(DateTime), "01/01/2000", "01/01/2010")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> HireDate { get; set; }
    }
}