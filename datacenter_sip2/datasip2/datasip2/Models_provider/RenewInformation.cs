using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckHybrid.Models.Sip2
{
    public class RenewInformation
    {
         [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string Duedate { get; set; } = "";
        [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string Title { get; set; } = "";
        [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string Message { get; set; } = "";
        [Required(ErrorMessage ="คุณยังไม่ได่้กรอก " , AllowEmptyStrings = false)]
        public string Status { get; set; } = "";
      
    }
}
