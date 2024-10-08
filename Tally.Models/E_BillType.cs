namespace Tally.Models;

public enum E_BillType
{
    /// <summary>
    ///     支出
    /// </summary>
    Expenditure = 0,

    /// <summary>
    ///     收入
    /// </summary>
    Income = 1,

    /// <summary>
    ///     转账
    /// </summary>
    Transfer = 2,

    /// <summary>
    ///     未归类的其他
    /// </summary>
    Nothing = 3
}