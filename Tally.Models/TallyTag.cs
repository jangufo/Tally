namespace Tally.Models;

public class TallyTag
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? ParentId { get; set; }
    public List<TallyTag>? Child { get; set; }
}