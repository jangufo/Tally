using SqlSugar;

namespace Tally.Models;

public class TallyTag : ModelBase
{
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string Name { get; set; } = string.Empty;

    public int? ParentId { get; set; }

    [SugarColumn(IsIgnore = true)]
    public List<TallyTag>? Child { get; set; }
}