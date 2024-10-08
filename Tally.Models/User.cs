using SqlSugar;

namespace Tally.Models;

/// <summary>
///     用户表
/// </summary>
public class User : ModelBase
{
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string NickName { get; set; } = string.Empty;

    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string Password { get; set; } = string.Empty;

    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string Name { get; set; } = string.Empty;
}