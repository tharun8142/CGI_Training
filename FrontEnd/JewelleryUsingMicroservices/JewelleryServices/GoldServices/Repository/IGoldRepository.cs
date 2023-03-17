using GoldServices.Entities;

namespace GoldServices.Repository
{
    public interface IGoldRepository
    {
        bool Delete(int id);
        List<GoldOrnament> GetAll();
        void Insert(GoldOrnament go);
        
        bool Update(int id,GoldOrnament go);
       
        
    }
}