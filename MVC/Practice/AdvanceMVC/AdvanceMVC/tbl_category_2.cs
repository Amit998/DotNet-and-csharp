//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvanceMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_category_2
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name Is Required.")]
        [Display(Name = "Name---")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description Is Required.")]
        [Display(Name = "Description---")]
        public string Description { get; set; }
    }
}