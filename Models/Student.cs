using System.ComponentModel.DataAnnotations;
using BlazorApp12.Model;
using BlazorApp12.Pages;

namespace BlazorApp12.Model;

public class Student

{
    [Key]
    public int IdStudent { get; set; }
    public string Family { get; set; }
    public string Name { get; set; }
    public string? MiddleName { get; set; }
    public string Data { get; set; }
    public string Pol { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}