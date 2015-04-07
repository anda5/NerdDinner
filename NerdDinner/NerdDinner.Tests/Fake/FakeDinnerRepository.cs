using NerdDinner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdDinner.Tests.Controllers
{
  public  class FakeDinnerRepository:DinnerRepository
    {
        IList<Dinner> dinners;
        public FakeDinnerRepository()
        {
            dinners = new List<Dinner>();
            for (int i = 0; i <= 100; i++)
            {
                var dinner = new Dinner();
                dinner.Title = "dinner" + i;
                dinner.Longitude = 24.00;
                dinner.Latitude = 21;
                dinner.HostedBy = " Mrs Dinner";
                dinner.EventDate = DateTime.Now.AddDays(1);
                dinner.Description = "Something";
                dinner.ContactPhone = "555-555-222";
                dinner.Country = "Romania";

                dinners.Add(dinner);
            }

        }


        public IQueryable<Dinner> FindAllDinners()
        {
            return dinners.AsQueryable();

        }
        public Dinner GetDinner(int n)
        {
            return FindAllDinners().SingleOrDefault(x => x.DinnerId == n);
        }
        public void Add(Dinner dinner)
        {
            dinners.Add(dinner);
        }
        public void Update(Dinner dinner)
        {
            var ListDinner = GetDinner(dinner.DinnerId);
            Delete(ListDinner);
            Add(dinner);
        }
        public void Delete(Dinner dinner)
        {
            var listDinner = GetDinner(dinner.DinnerId);
            dinners.Remove(listDinner);
        }
    }
}
