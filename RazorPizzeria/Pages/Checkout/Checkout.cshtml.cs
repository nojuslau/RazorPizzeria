using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder PizzaOrder = new PizzaOrder();
            PizzaOrder.PizzaName = PizzaName;
            PizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(PizzaOrder);
            _context.SaveChanges();
        }
    }
}
