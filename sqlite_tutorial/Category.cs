using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
	[Key]
	public int CategoryId {get; set;}
	[Required]
	[StringLength(15)]
	public string CategoryName {get; set;} = null!;
	[Column(TypeName = "ntext")]
	public string? Description {get; set;}
	public ICollection<Product> Products {get; set;}
	
	public Category()
	{
		Products = new HashSet<Product>();
	}
}