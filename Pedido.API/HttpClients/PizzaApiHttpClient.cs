﻿using System.ComponentModel.DataAnnotations;

namespace Pedidos.API.HttpClients
{
    public class PizzaApiHttpClient
    {
        // 1. Criar o cliente http
        public sealed class Client(HttpClient httpClient)
        {
            public async Task<Estoque?> GetEstoque(int pizzaId)
            {
                return await httpClient.GetFromJsonAsync<Estoque>($"/estoque/pizza/{pizzaId}");
            }

            public async Task UpdateEstoque(int pizzaId, int quantidade)
            {
                var response = await httpClient.PutAsync($"/estoque/pizza/{pizzaId}/{quantidade}", null);
                // garante que da errado se der errado
                response.EnsureSuccessStatusCode();
            }
        }
        // 2. Criar uma classe de retorno
        public class Estoque
        {
            public int Id { get; set; }
            public int PizzaId { get; set; }
            public int Quantidade { get; set; }
        }
    }
}
