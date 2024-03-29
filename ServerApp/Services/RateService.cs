﻿using ServerApp.Models;

namespace ServerApp.Services
{
    public class RateService : IRateService
    {
        private static List<Rate> rates = new List<Rate>();
        public List<Rate> GetAll()
        {
          return rates;
        }

        public Rate Get(int id)
        {
            return rates.Find(x => x.Id == id);

        }

        public void Create(string name, int rating, string description, string time)
        {
            int id = 1;
            if(rates.Count != 0)
            {
                id = rates.Max(x => x.Id) + 1;
            }
            rates.Add(new Rate() { Rating = rating, Description = description, Name = name, Id = id, Time=time });
        }
        public void Edit(int id, string name, int rating, string description, string time)
        {
            Rate rate = Get(id);
            rate.Name = name;
            rate.Rating = rating;
            rate.Description = description;
            rate.Time = time;
        }
        public void Delete(int id)
        {
           
              rates.Remove(Get(id));
          
        }
    }
}
