﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models;

public class Category
{
    public int CategoryId { get; set; }
    [MaxLength(100)]
    [Required(ErrorMessage = "Category Name is a required field!")]
    public string CategoryName { get; set; } = string.Empty;
    [MaxLength(400)]
    [Required(ErrorMessage = "Category Description is a required field!")]
    public string Description { get; set; }=string.Empty;

    public ICollection<Product>? Products { get; set; }
}
