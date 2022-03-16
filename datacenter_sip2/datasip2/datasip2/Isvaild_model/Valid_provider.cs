using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datasip2.Isvaild_model
{
   public  class Valid_provider
    {
        private Valid_provider ()
        {

        }

        public static Valid_provider? Instance = null;
        public static Valid_provider Instances
        {
            get { 
                if(Instance == null)
                Instance = new Valid_provider();
                return Instance; }
        }

        public string isvaild(object model , object  values ,  ref string message)
        {
            
            ValidationContext context = new ValidationContext(model, null, null)
            {
                MemberName = "Barcodebook"
            };
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateProperty(values, context, results );
            if (!isValid)
            {
                foreach (ValidationResult? result in results)
                    message = result.ErrorMessage.ToString();
            }
            else
                return "ok";
            return message;
        }
    }
}
