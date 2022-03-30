using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacenter
{
    public class PatronInformation
    {
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก PatronID", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "คุณป้อนตัวอักษรเกิน 50 อักขระ")]
        public string PatronID { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Name", AllowEmptyStrings = false)]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก ValidPatronID", AllowEmptyStrings = false)]
        public string ValidPatronID { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก VaildPatronPassword", AllowEmptyStrings = false)]
        public string VaildPatronPassword { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Fee", AllowEmptyStrings = false)]
        public string Fee { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Address", AllowEmptyStrings = false)]
        public string Address { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Email", AllowEmptyStrings = false)]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Phonenumber", AllowEmptyStrings = false)]
        public string Phonenumber { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Message", AllowEmptyStrings = false)]
        public string Message { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก itemTotal", AllowEmptyStrings = false)]
        public int itemTotal { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}";
        }
    }
}