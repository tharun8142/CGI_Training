using GoldServices.Entities;

namespace GoldServices.Repository
{
    public class GoldRepository : IGoldRepository
    {
        private readonly GoldContext data;
        public GoldRepository(GoldContext data)
        {
            this.data = data;
         
        }

        public bool Delete(int id)
        {
            GoldOrnament found = data.GoldOrnaments.Find(id);
            if(found != null)
            {
                data.GoldOrnaments.Remove(found);
                data.SaveChanges(true);
                return true;
            }
            return false;
        }

        public List<GoldOrnament> GetAll()
        {
            return data.GoldOrnaments.ToList();
        }

        public void Insert(GoldOrnament go)
        {
            data.GoldOrnaments.Add(go);
            data.SaveChanges();
            
        }

        public bool Update(int id,GoldOrnament go)
        {
            GoldOrnament found = data.GoldOrnaments.Find(id);
            if(found != null)
            {
                found.Charat = go.Charat;
                found.Description= go.Description;
                data.SaveChanges(true);
                return true;
            }
            return false;
        }
    }
}
