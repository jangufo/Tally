using SqlSugar;

namespace Tally.Models;

/// <summary>
///     账户表
/// </summary>
public class TallyAccount : ModelBase
{
    public int UserId { get; set; }

    [SugarColumn(ColumnDataType = "nvarchar(20)")]
    public string Name { get; set; } = string.Empty;

    [SugarColumn(ColumnDataType = "DECIMAL(18, 2)")]
    public decimal Balance { get; set; }
}