using WebApi.Controllers.Entities;

namespace WebApi.Controllers.Repository
{
    public interface IGoldRepository
    {
        void Add(GoldOrnament goldOrnament);
        List<GoldOrnament> display();
        bool update(int id, GoldOrnament goldOrnament);
        bool Delete(int id);
        GoldOrnament GetById(int id);

    }
}