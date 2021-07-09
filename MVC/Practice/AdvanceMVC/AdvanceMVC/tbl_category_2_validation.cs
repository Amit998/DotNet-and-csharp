using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvanceMVC
{
    public class tbl_category_2_validation
    {


        [Required(ErrorMessage = "Name Is Required.")]
        [Display(Name ="Name---")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description Is Required.")]
        [Display(Name = "Name---")]
        public string Description { get; set; }
    }


    [MetadataType(typeof(tbl_category_2))]
    public partial class tbl_category_2
    {
       
    }
}