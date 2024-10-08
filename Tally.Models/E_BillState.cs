namespace Tally.Models;

public enum E_BillState
{
    /// <summary>
    ///     支付成功
    /// </summary>
    PaySuccessful = 0,

    /// <summary>
    ///     转账成功
    /// </summary>
    TransferSuccessful = 1,

    /// <summary>
    ///     退款成功
    /// </summary>
    RefundSuccessful = 2,

    /// <summary>
    ///     有错误
    /// </summary>
    Error = 5
}