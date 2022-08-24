﻿using BlazorStore.Shared;

namespace BlazorStore.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
