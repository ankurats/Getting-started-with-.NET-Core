using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/Restaurants")]
public class RestaurantController : Controller
    {
        [HttpGet]
        public JsonResult GetRestaurants()
        {
            return new JsonResult(new List<object>()
            {
                 new { Id =1, Title = "Mogli" },
                 new { Id =2, Title = "Yo China" },
                 new { Id =3, Title = "Pind Baluchi" }

            });

        }
    }