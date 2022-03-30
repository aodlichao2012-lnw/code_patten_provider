using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacenter
{
    public class CheckOutInformation
    {
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Barcodebook", AllowEmptyStrings = false)]
        [RegularExpression(@"[0-9]$", ErrorMessage = "กรุณากรอกตัวเลข")]
        [MaxLength(50, ErrorMessage = "คุณป้อนตัวอักษรเกิน 50 อักขระ")]
        public string Barcodebook { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Status", AllowEmptyStrings = false)]
        public string Status { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก PatronID", AllowEmptyStrings = false)]
        public string PatronID { get; set; } = "";
      
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Title", AllowEmptyStrings = false)]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Duedate", AllowEmptyStrings = false)]
        public string Duedate { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Fee", AllowEmptyStrings = false)]
        public string Fee { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Message", AllowEmptyStrings = false)]
        public string Message { get; set; } = "";

        public override string ToString()
        {
            return $"{nameof(Barcodebook).ToString()}";
        }
    }
}