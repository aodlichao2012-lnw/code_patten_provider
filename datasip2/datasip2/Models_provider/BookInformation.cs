using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SelfCheckHybrid.Models.Sip2
{
    public class BookInformation
    {
       [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Duedate", AllowEmptyStrings = false)]
        public string Duedate { get; set; } = "";

        [RegularExpression("^[0-9]*$", ErrorMessage = "กรุณากรอกตัวเลข")]
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Barcodebook")]
        [MaxLength(50, ErrorMessage = "คุณป้อนตัวอักษรเกิน 50 อักขระ")]
        public string Barcodebook { get; set; } = "";
       [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Title", AllowEmptyStrings = false)]
        public string Title { get; set; } = "";
       [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Owner", AllowEmptyStrings = false)]
        public string Owner { get; set; } = "";
       [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Fee", AllowEmptyStrings = false)]
        public string Fee { get; set; } = "";
       [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Location", AllowEmptyStrings = false)]
        public string Location { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Callnumber", AllowEmptyStrings = false)]
        [MaxLength(50,ErrorMessage = "คุณป้อนตัวอักษรเกิน 50")]
        public string Callnumber { get; set; } = "";
       [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Message", AllowEmptyStrings = false)]
        public string Message { get; set; } = "";

        public override string ToString()
        {
            return $"{nameof( Barcodebook).ToString()}";
        }
    }
}