using GoldServices.Entities;
using GoldServices.Repository;

namespace GoldServices.Services
{
    public class GoldService : IGoldService
    {
        private readonly IGoldRepository repository;
        public GoldService(IGoldRepository repository)
        {
            this.repository = repository;
        }
        public void Add(GoldOrnament item)
        {
            this.repository.Insert(item);
        }
        public List<GoldOrnament> GetAll()
        {
            return this.repository.GetAll();
        }

        public bool Modify(int id, GoldOrnament item)
        {
            return this.repository.Update(id, item);
        }

        public bool Remove(int id)
        {
            return this.repository.Delete(id);
        }
    }
}
