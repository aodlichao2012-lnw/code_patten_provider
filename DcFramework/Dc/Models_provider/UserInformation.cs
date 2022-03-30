
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacenter
{
    public class UserInformation
    {
       [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string PatronID { get; set; } = "";
       [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string PatronName { get; set; } = "";
       [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string Fee { get; set; } = "";


        public override string ToString()
        {
            return $"{nameof(PatronID).ToString()}";
        }
    }
}