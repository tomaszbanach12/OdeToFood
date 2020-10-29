using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        public Restaurant Restaurant { get; set; }
        public DeleteModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restuarantId)
        {
            Restaurant = _restaurantData.GetById(restuarantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int restuarantId)
        {
            var restaurant = _restaurantData.Delete(restuarantId);
            _restaurantData.Commit();

            if(restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{restaurant.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}
