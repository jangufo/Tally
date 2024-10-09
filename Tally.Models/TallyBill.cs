using SqlSugar;

namespace Tally.Models;

public class TallyBill : ModelBase
{
    public int TallyUserId { get; set; }

    /// <summary>
    ///     收款商家
    /// </summary>
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string Business { get; set; } = string.Empty;

    /// <summary>
    ///     商品
    /// </summary>
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string Commodity { get; set; } = string.Empty;

    /// <summary>
    ///     账单类型 支出或收入
    /// </summary>
    public E_BillType EBillType { get; set; }

    /// <summary>
    ///     金额
    /// </summary>
    [SugarColumn(ColumnDataType = "DECIMAL(18, 2)")]
    public decimal Amount { get; set; }

    /// <summary>
    ///     支付账户来源 微信零钱 银行卡之类的
    /// </summary>
    public int TallyAccountId { get; set; }

    /// <summary>
    ///     账单状态
    /// </summary>
    public E_BillState BillState { get; set; }

    /// <summary>
    ///     微信交易单号
    /// </summary>
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string? WxTransactionTicketNumber { get; set; }

    /// <summary>
    ///     商户单号
    /// </summary>
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string? CommercialTenantsNumber { get; set; }

    /// <summary>
    ///     备注信息
    /// </summary>
    [SugarColumn(ColumnDataType = "nvarchar(100)")]
    public string? Remark { get; set; }

    #region 导航属性

    [Navigate(NavigateType.OneToOne, nameof(TallyUserId))]
    public TallyUser? NUser { get; set; }

    [Navigate(NavigateType.OneToOne, nameof(TallyAccountId))]
    public TallyAccount? NTallyAccount { get; set; }

    #endregion
}