using Microsoft.AspNetCore.Mvc;
using Pizza.API.Percistence;

namespace Pizza.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController(PizzaRepository _pizzaRepository) : ControllerBase
    {
        [HttpPost]
        public Models.Pizza Create(Models.Pizza pizza)
        {
            _pizzaRepository.Add(pizza);
            return pizza;
        }

        [HttpGet]
        public List<Models.Pizza> GetAll()
        {
            return _pizzaRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Models.Pizza GetById(int id)
        {
            return _pizzaRepository.GetById(id);
        }
    }
}
