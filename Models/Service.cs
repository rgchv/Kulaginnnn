using System.ComponentModel.DataAnnotations;
using BlazorApp12.Model;
using BlazorApp12.Pages;

namespace BlazorApp12.Model;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    
}