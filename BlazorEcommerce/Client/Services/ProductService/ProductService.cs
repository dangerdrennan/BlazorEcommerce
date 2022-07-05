﻿namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var res = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return res;
        }

        public async Task GetProducts()
        {
            var res = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (res != null && res.Data != null)
            {
                Products = res.Data;
            }
            
        }
    }
}
