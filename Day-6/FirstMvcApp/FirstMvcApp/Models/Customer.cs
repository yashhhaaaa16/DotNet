﻿namespace FirstMvcApp.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string ContactName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
}
