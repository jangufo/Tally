namespace Tally.Models;

/// <summary>
///     账户表
/// </summary>
public class TallyAccount
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
}