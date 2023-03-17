using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApi.Controllers.Entities;

namespace WebApi.Controllers.Repository
{
    public class GoldRepository : IGoldRepository
    {
        JewelleryContext context;
        public GoldRepository(JewelleryContext context)
        {
            this.context = context;
        }
        public void Add(GoldOrnament go)
        {
            try
            {

                context.GoldOrnament.Add(go);//stores object to dbset
                context.SaveChanges();//generate sql insert command and sends to db
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
       
        public bool Delete(int id)
        {
            GoldOrnament toDelete = context.GoldOrnament.Find(id);
            //select * from goldornament where id=id
            if (toDelete != null)
            {
                context.GoldOrnament.Remove(toDelete);
                context.SaveChanges(true);
                return true;

            }
            return false;
        }
        public List<GoldOrnament> display()
        {
            return context.GoldOrnament.ToList();
        }
        public bool update(int id,GoldOrnament goldOrnament)
        {
            GoldOrnament found = context.GoldOrnament.Find(id);
            if (found != null)
            {
                found.Charat=goldOrnament.Charat;
                found.Description = goldOrnament.Description;
                context.SaveChanges(true);
                return true;
            }
            return false;
        }
        public GoldOrnament GetById(int id)
        {
            return context.GoldOrnament.Find(id);//select * from Goldornament where id=id
        }

    }
}
