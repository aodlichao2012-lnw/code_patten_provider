using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacenter
{
   public  class Valid_provider
    {
        string[] propertyName = new string[50];
        private Valid_provider ()
        {

        }

        public static Valid_provider Instance = null;
        public static Valid_provider Instances
        {
            get { 
                if(Instance == null)
                Instance = new Valid_provider();
                return Instance; }
        }

        public string isvaild(object model , object  values ,  ref string message )
        {
            foreach(var values_item in values.GetType().GetProperties())
            {
                
                if (!model.GetType().GetProperties().Any(x => x.PropertyType == values_item.PropertyType))
                {
                    return "type ไม่ตรง";
                }
                else
                    message = "ok";

            }
         

            return message;
        
        }
    }
}
