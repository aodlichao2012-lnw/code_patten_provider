using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace datacenter.API_providers
{
   public class apiclass 
    {
        private apiclass()
        {

        }

        private static apiclass UrlHelpClasss = null;

        public apiclass Instance
        {
            get
            {
                if (UrlHelpClasss == null)
                {
                    return UrlHelpClasss = new apiclass();
                }
                return UrlHelpClasss;
            }
        }
        public ICollection<object> GetAll(object models)
        {
            var model = models as ICollection<object>;
            var res = (from a in model
                      select a).ToList();
            return res;
        } 
        public ICollection<object> Get(object models , string id)
        {
            var model = models as ICollection<object>;
            var res = (from a in model
                       where a.Equals(id)
                      select a).ToList();
            return res;
        } 
        public ICollection<object> GetConditionplus(object models , string Propertiesname , int num)
        {
            var model = models as ICollection<object>;
            var res = (from a in model
                       where int.Parse( a.GetType().GetProperty(Propertiesname).GetValue(a).ToString() ) > num
                      select a).ToList();
            return res;
        }   
        public ICollection<object> GetConditionnative(object models , string Propertiesname , int num)
        {
            var model = models as ICollection<object>;
            var res = (from a in model
                       where int.Parse( a.GetType().GetProperty(Propertiesname).GetValue(a).ToString() ) < num
                      select a).ToList();
            return res;
        }    
        public ICollection<object> PostInsert(object models , string Propertiesname , object Body)
        {
            var model = models as ICollection<object>;
            var Db = Body as ICollection<object>;
            model.Add(Db);
            return model;
        } 
        public ICollection<object> PostUpdate(object models , string Propertiesname , object Body)
        {
            var model = models as ICollection<object>;
            var Db = Body as ICollection<object>;
            model.GetType().GetProperty(Propertiesname).SetValue(model, Db);
            return model;
        } 
        public ICollection<object> PostDelete(object models , string Propertiesname , object Body)
        {
            var model = models as ICollection<object>;
            var Db = Body as ICollection<object>;
            model.Remove(Db);
            return model;
        }
    }
}
