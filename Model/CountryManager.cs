using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Model
{
    internal class CountryManager
    {        
        // получение списка всех стран
        public List<Country> ListAll()
        {
            using(ApplicationDbContext db = new())
            {
                return db.Countries.ToList();
            }
        }
        // получение страны по id
        public Country FindById(int id)
        {
            using (ApplicationDbContext db = new())
            {
                return db.Countries.FirstOrDefault(c => c.Id == id);
            }
        }
        // добавить запись о новой стране
        public void Register(Country country)
        {
            using (ApplicationDbContext db = new())
            {
                db.Countries.Add(country);
                db.SaveChanges();
            }
        }
        // получение страны по спецификации(spec) и значению кода(code)
        public Country FindByCode(string code, CodeSpec spec)
        {
            using (ApplicationDbContext db = new())
            {
                return db.Countries.FirstOrDefault(
                    c => c.Alpha2Code == code || c.Alpha3Code == code || c.NumericCode == code);
            }
        }
        // удаление страны по id
        public void DeleteById(int id)
        {
            Country country = FindById(id);
            if (country != null)
            {
                using (ApplicationDbContext db = new())
                {
                    db.Countries.Remove(country);
                    db.SaveChanges();
                }
            }
        }
        // обновление по id
        public void UpdateById(Country country)
        {
            using (ApplicationDbContext db = new())
            {
                Country updateCountry = db.Countries.FirstOrDefault(c => c.Id == country.Id);
                if(updateCountry != null)
                {
                    updateCountry.ShortName = country.ShortName;
                    updateCountry.FullName = country.FullName;
                    updateCountry.Alpha2Code = country.Alpha2Code;
                    updateCountry.Alpha3Code = country.Alpha3Code;
                    updateCountry.NumericCode = country.NumericCode;
                    updateCountry.Population = country.Population;
                    updateCountry.Area = country.Area;
                    db.SaveChanges();
                }
            }
        }
        // получение отсортированного списка стран по указанному полю orderBy        
        public List<Country> ListOrderBy(OrderBy orderBy)
        {
            using (ApplicationDbContext db = new())
            {
                switch (orderBy)
                {
                    case OrderBy.OrderByIdAsc:
                        return db.Countries.ToList();
                    case OrderBy.OrderByIdDesc:
                        return db.Countries.OrderByDescending(c => c.Id).ToList();
                    case OrderBy.OrderByShortNameAsc:
                        return db.Countries.OrderBy(c => c.ShortName).ToList();
                    case OrderBy.OrderByShortNameDesc:
                        return db.Countries.OrderByDescending(c => c.ShortName).ToList();
                    case OrderBy.OrderByFullNameAsc:
                        return db.Countries.OrderBy(c => c.FullName).ToList();
                    case OrderBy.OrderByFullNameDesc:
                        return db.Countries.OrderByDescending(c => c.FullName).ToList();
                    case OrderBy.OrderByAlpha2CodeAsc:
                        return db.Countries.OrderBy(c => c.Alpha2Code).ToList();
                    case OrderBy.OrderByAlpha2CodeDesc:
                        return db.Countries.OrderByDescending(c => c.Alpha2Code).ToList();
                    case OrderBy.OrderByAlpha3CodeAsc:
                        return db.Countries.OrderBy(c => c.Alpha3Code).ToList();
                    case OrderBy.OrderByAlpha3CodeDesc:
                        return db.Countries.OrderByDescending(c => c.Alpha3Code).ToList();
                    case OrderBy.OrderByNumericCodeAsc:
                        return db.Countries.OrderBy(c => c.NumericCode).ToList();
                    case OrderBy.OrderByNumericCodeDesc:
                        return db.Countries.OrderByDescending(c => c.NumericCode).ToList();
                    case OrderBy.OrderByPopulationAsc:
                        return db.Countries.OrderBy(c => c.Population).ToList();
                    case OrderBy.OrderByPopulationDesc:
                        return db.Countries.OrderByDescending(c => c.Population).ToList();
                    case OrderBy.OrderByAreaAsc:
                        return db.Countries.OrderBy(c => c.Area).ToList();
                    case OrderBy.OrderByAreaDesc:
                        return db.Countries.OrderByDescending(c => c.Area).ToList();
                    default:
                        throw new Exception("invalid order by value");
                }
            }
        }
    }
}
