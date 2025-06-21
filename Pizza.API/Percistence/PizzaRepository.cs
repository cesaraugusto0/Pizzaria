using Pizza.API.Models;

namespace Pizza.API.Percistence
{
    public class PizzaRepository
    {
        private static List<Models.Pizza> _pizzas = [];

        public List<Models.Pizza> GetAll()
        {
            return _pizzas;
        }

        public Models.Pizza Add(Models.Pizza pizza)
        {
            var id = _pizzas.Any() ? _pizzas.Max(p => p.Id) + 1 : 1;
            pizza.Id = id;
            _pizzas.Add(pizza);
            return pizza;
        }

        internal Models.Pizza GetById(int id)
        {
            var pizza = _pizzas.FirstOrDefault(p => p.Id == id);

            if (pizza is null)
            {
                throw new NaoEncontradoException("Não tem pizza com este id");
            }
            return pizza;
        }
    }
}
