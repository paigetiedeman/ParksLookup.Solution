using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    [Required]
    public int ParkId { get; set; }
    [Required]
    public string ParkName { get; set; }
    public string State { get; set; }
  [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
    public string Rating { get; set; }
    public string Highlight { get; set; }
    public bool Visited { get; set; }

  }
}