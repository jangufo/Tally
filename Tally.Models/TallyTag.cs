using SqlSugar;

namespace Tally.Models;

public class TallyTag : ModelBase
{
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string Name { get; set; } = string.Empty;

    public int TallyUserId { get; set; }

    [Navigate(NavigateType.OneToOne, nameof(TallyUserId))]
    public TallyUser? NUser { get; set; }
}