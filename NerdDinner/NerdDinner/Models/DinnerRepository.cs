using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class DinnerRepository:IDinnerRepository
    {

        private DinnerDbContext db = null;

        public DinnerRepository()
        {
            this.db = new DinnerDbContext();
        }

        public DinnerRepository(DinnerDbContext context)
        {
            this.db = context;
        }
        public IQueryable<Dinner> FindAllDinners()
        {
            return db.Dinners;
        }
        public Dinner GetDinner(int n)
        {
            return db.Dinners.SingleOrDefault(x => x.DinnerId == n);
        }
        public void Add(Dinner dinner)
        {
            db.Dinners.Add(dinner);
        }
        public void Update(Dinner dinner)
        {
            db.Entry(dinner).State = EntityState.Modified;
        }
        public void Delete(Dinner dinner)
        {
            db.Dinners.Remove(dinner);
        }
    }
}