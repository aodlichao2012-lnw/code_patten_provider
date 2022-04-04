using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacenter
{
  public  class ModelViewModels
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "กรุณากรอกตัวเลข")]
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Barcodebook")]
        [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "คุณป้อนตัวอักษรเกิน 50 อักขระ")]
        public string Barcodebook { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Duedate", AllowEmptyStrings = false)]
        public string Duedate { get; set; } = "";

        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Title", AllowEmptyStrings = false)]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Owner", AllowEmptyStrings = false)]
        public string Owner { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Fee", AllowEmptyStrings = false)]
        public string Fee { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Location", AllowEmptyStrings = false)]
        public string Location { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Callnumber", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "คุณป้อนตัวอักษรเกิน 50")]
        public string Callnumber { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Message", AllowEmptyStrings = false)]
        public string Message { get; set; } = "";

        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Status ", AllowEmptyStrings = false)]
        public string Status { get; set; } = "";

        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก PatronID", AllowEmptyStrings = false)]
        public string PatronID { get; set; } = "";


        public string Name { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก ValidPatronID", AllowEmptyStrings = false)]
        public string ValidPatronID { get; set; } = "";

        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Address", AllowEmptyStrings = false)]
        public string Address { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Email", AllowEmptyStrings = false)]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก Phonenumber", AllowEmptyStrings = false)]
        public string Phonenumber { get; set; } = "";

        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก itemTotal", AllowEmptyStrings = false)]
        public int itemTotal { get; set; }

        [Required(ErrorMessage = "คุณยังไม่ได่้กรอก ", AllowEmptyStrings = false)]

        public string PatronName { get; set; } = "";

        public static explicit operator List<object>(ModelViewModels v)
        {
            throw new NotImplementedException();
        }
    }
}
