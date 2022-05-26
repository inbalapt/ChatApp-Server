using ServerApp.Models;

namespace ServerApp.Services
{
    public interface IRateService
    {
        public List<Rate> GetAll();

        public Rate Get(int id);
        public void Create(string name, int rate, string description, string time);

        public void Edit(int id, string name, int rating, string description, string time);

        public void Delete(int id);

    }
}
