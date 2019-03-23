using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dareurbody.Models
{
    public class Reservation
    {
        public int id { get; set; }

        [Required]
        [Display(Name="Employee ID")]
        public string emp_id { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d/M/yyyy HH:mm:ss}")]
        [Display(Name = "Start Date")]
        public DateTime start_date { get; set; }
        
       
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d/M/yyyy HH:mm:ss}")]
        [Display(Name = "End Time")]
        public DateTime end_time { get; set; }

        [Required]
        [Display(Name = "Duration")]
        [Range(1, 8, ErrorMessage = "Duration must be between 1 to 8 Hours")]
        public int Duration { get; set; }

        public DateTime Request_sub_time { get; set; }
   

    }
}