namespace SnackMentor.Application.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ParentId { get; set; }
    public string Path { get; set; }
}