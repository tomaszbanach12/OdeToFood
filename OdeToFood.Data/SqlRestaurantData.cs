using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext _odeToFoodDbContext;

        public SqlRestaurantData(OdeToFoodDbContext odeToFoodDbContext)
        {
            _odeToFoodDbContext = odeToFoodDbContext;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            _odeToFoodDbContext.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return _odeToFoodDbContext.SaveChanges();
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);
            if (restaurant != null)
            {
                _odeToFoodDbContext.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int id)
        {
            return _odeToFoodDbContext.Restaurants.Find(id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var query = from r in _odeToFoodDbContext.Restaurants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;

            return query;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = _odeToFoodDbContext.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}