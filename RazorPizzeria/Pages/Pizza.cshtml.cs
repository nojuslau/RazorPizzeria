using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>
        {
            new PizzasModel()
            {
                imageTitle="Margerita",
                pizzaName="Margerita",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="Hawaiian",
                pizzaName="Hawaiian",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="Carbonara",
                pizzaName="Carbonara",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="MeatFeast",
                pizzaName="MeatFeast",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="Mushroom",
                pizzaName="Mushroom",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="Pepperoni",
                pizzaName="Pepperoni",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="Seafood",
                pizzaName="Seafood",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel()
            {
                imageTitle="Vegetarian",
                pizzaName="Vegetarian",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
        };
        public void OnGet()
        {
        }
    }
}
