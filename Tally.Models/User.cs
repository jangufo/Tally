namespace Tally.Models;

/// <summary>
///     用户表
/// </summary>
public class User
{
    public int Id { get; set; }
    public string NickName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}