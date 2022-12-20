using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel pizza { get; set; }
        public float pizzaPrice { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            pizzaPrice = pizza.basePrice;

            if (pizza.tomatoSauce)
            {
                pizzaPrice += 1;
            }
            if (pizza.cheese)
            {
                pizzaPrice += 1;
            }
            if (pizza.peperoni)
            {
                pizzaPrice += 1;
            }
            if (pizza.mushroom)
            {
                pizzaPrice += 1;
            }
            if (pizza.tuna)
            {
                pizzaPrice += 1;
            }
            if (pizza.pineapple)
            {
                pizzaPrice += 10;
            }
            if (pizza.ham)
            {
                pizzaPrice += 1;
            }
            if (pizza.beef)
            {
                pizzaPrice += 1;
            }

            return RedirectToPage("/Checkout/Checkout", new { pizza.pizzaName, pizzaPrice });
        }
    }
}
