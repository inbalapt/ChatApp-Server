using ServerApp.Models;

namespace ServerApp.Services
{
    public interface IRateService
    {
        public List<Rate> GetAll();

        public Rate Get(int id);
        public void Create(string name, int rate, string description);

        public void Edit(int id, string name, int rating, string description);

        public void Delete(int id);

    }
}
