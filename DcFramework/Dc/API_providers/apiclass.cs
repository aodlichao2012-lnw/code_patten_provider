using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
        public List<ModelViewModels> GetAll()
        {
            using(var models = new ModelDbContext())
            {
                var res = (from a in models.modelViewModels
                           select a).ToList();
                return res;
            }
           
        } 
        public ModelViewModels Get( string id)
        {
            using (var models = new ModelDbContext())
            {
                var res = (from a in models.modelViewModels
                           where a.Barcodebook.Equals(id)
                           select a).FirstOrDefault();
                return res;
            }
        } 
        public List<ModelViewModels> GetConditionplus(int num)
        {
            using (var models = new ModelDbContext())
            {
                var res = (from a in models.modelViewModels
                           where int.Parse(a.Fee) > num
                           select a).ToList();
                return res;
            }
        }   
        public List<ModelViewModels> GetConditionnative( int num)
        {
            using (var models = new ModelDbContext())
            {
                var res = (from a in models.modelViewModels
                           where int.Parse(a.Fee) > num
                           select a).ToList();
                return res;
            }
        }    
        public bool  PostInsert( ModelViewModels Body)
        {
            using (var models = new ModelDbContext())
            {
                models.modelViewModels.Add(Body);
                return true;
            }
        } 
        public ModelViewModels PostUpdate( ModelViewModels Body)
        {
            using (var models = new ModelDbContext())
            {
                var cs = models.modelViewModels.Where(a => a.Barcodebook == Body.Barcodebook).FirstOrDefault();

                if (cs != null)
                {
                    cs.Address = Body.Address;
                    cs.Callnumber = Body.Callnumber;
                    cs.Duedate = Body.Duedate;
                    cs.Fee = Body.Fee;
                    cs.Name = Body.Name;
                }
                return cs;
            }
        
        } 
        public bool PostDelete( ModelViewModels Body)
        {
            using (var models = new ModelDbContext())
            {
                models.modelViewModels.Remove(Body);
                return true;
            }
        }
    }
}
