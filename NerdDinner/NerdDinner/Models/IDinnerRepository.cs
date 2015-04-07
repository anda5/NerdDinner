using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public interface IDinnerRepository
    {
        IQueryable<Dinner> FindAllDinners();
        Dinner GetDinner(int n);
        void Add(Dinner dinner);
        void Update(Dinner dinser);
        void Delete(Dinner dinner);
    }
}