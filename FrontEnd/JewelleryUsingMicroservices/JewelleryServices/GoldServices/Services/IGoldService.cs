using GoldServices.Entities;
namespace GoldServices.Services
{
    public interface IGoldService
    {
       
        bool Modify(int id, GoldOrnament item);
        bool Remove(int id);
        List<GoldOrnament> GetAll();
        void Add(GoldOrnament go);
    }
}