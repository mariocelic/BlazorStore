﻿using BlazorStore.Shared;
using System.Net.Http.Json;

namespace BlazorStore.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public event Action ProductsChanged;
        
        public ProductService(HttpClient client)
        {
            _client = client;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");

            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _client.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _client.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }
    }
}
