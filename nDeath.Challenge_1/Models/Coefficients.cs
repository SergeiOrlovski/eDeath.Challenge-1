using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nDeath.Challenge_1.Models
{
    public class Coefficients
    {  
        [Range(Double.MinValue, double.MaxValue, ErrorMessage = "Please enter a numerical value for the сoefficient")]
        public double A { get; set; }

        [Range(Double.MinValue, double.MaxValue, ErrorMessage = "Please enter a numerical value for the сoefficient")]
        public double B { get; set; }

        [Range(Double.MinValue, double.MaxValue, ErrorMessage = "Please enter a numerical value for the сoefficient")]
        public double C { get; set; }

        [Required(ErrorMessage = "Please enter field values Step")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive value for the Step")]
        public double S { get; set; }

        [Required(ErrorMessage = "Please enter the coefficient 'min', not exceeding the value 'max'")]
        public double Min { get; set; }

        [Required(ErrorMessage = "Please enter the coefficient 'max'")]
        public double Max { get; set; }

    }
}