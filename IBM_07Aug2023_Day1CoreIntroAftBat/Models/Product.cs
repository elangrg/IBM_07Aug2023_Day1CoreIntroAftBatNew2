using System;
using System.Collections.Generic;

namespace IBM_07Aug2023_Day1CoreIntroAftBat.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
