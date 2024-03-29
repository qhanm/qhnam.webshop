﻿namespace qhnam.Data.Model.ViewModels
{
    public class WholePriceViewModel
    {
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }
        public ProductViewModel Product { get; set; }
    }
}