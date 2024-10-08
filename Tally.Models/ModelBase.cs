using SqlSugar;

namespace Tally.Models;

public class ModelBase
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    /// <summary>
    ///     创建时间
    /// </summary>
    public DateTime CreatDateTime { get; set; }

    /// <summary>
    ///     最后一次修改时间
    /// </summary>
    public DateTime LastModifiedDateTime { get; set; }
}