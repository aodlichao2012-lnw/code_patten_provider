using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace datacenter
{
   public class apiclass 
    {
        private apiclass()
        {

        }

        private static apiclass UrlHelpClasss = null;

        public static apiclass Instance
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
        public ICollection<ModelViewModels> GetAll(ModelViewModels models)
        {
            var model = models as ICollection<ModelViewModels>;
            var res = (from a in model
                      select a).ToList();
            return res;
        } 
        public ICollection<ModelViewModels> Get(ModelViewModels models , string id)
        {
            var model = models as ICollection<ModelViewModels>;
            var res = (from a in model
                       where a.Equals(id)
                      select a).ToList();
            return res;
        } 
        public ICollection<ModelViewModels> GetConditionplus(ModelViewModels models , string Propertiesname , int num)
        {
            var model = models as ICollection<ModelViewModels>;
            var res = (from a in model
                       where int.Parse( a.GetType().GetProperty(Propertiesname).GetValue(a).ToString() ) > num
                      select a).ToList();
            return res;
        }   
        public ICollection<ModelViewModels> GetConditionnative(ModelViewModels models , string Propertiesname , int num)
        {
            var model = models as ICollection<ModelViewModels>;
            var res = (from a in model
                       where int.Parse( a.GetType().GetProperty(Propertiesname).GetValue(a).ToString() ) < num
                      select a).ToList();
            return res;
        }    
        public ICollection<ModelViewModels> PostInsert(ModelViewModels models , string Propertiesname , ModelViewModels Body)
        {
            var model = models as ICollection<ModelViewModels>;
            model.Add(Body);
            return model;
        } 
        public ModelViewModels PostUpdate(ModelViewModels models , ModelViewModels Body)
        {
            models = Body;
            return models;
        } 
        public IList< ModelViewModels> PostDelete(ModelViewModels models , string Propertiesname , ModelViewModels Body)
        {
            IList<ModelViewModels> models1 = models as IList<ModelViewModels>;
            models1.Remove(Body);
            return models1;
        }
    }
}
