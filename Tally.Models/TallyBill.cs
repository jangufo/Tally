namespace Tally.Models;

public class TallyBill
{
    public int Id { get; set; }
    public int UserId { get; set; }

    /// <summary>
    ///     交易时间
    /// </summary>
    public DateTime CreatDateTime { get; set; }

    /// <summary>
    ///     最后一次修改时间
    /// </summary>
    public DateTime LastModifiedDateTime { get; set; }

    /// <summary>
    ///     收款商家id
    /// </summary>
    public int BusinessId { get; set; }

    /// <summary>
    ///     商品
    /// </summary>
    public string Commodity { get; set; } = string.Empty;

    /// <summary>
    ///     账单类型 支出或收入
    /// </summary>
    public E_BillType EBillType { get; set; }

    /// <summary>
    ///     金额
    /// </summary>
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
    public string? WxTransactionTicketNumber { get; set; }

    /// <summary>
    ///     商户单号
    /// </summary>
    public string? CommercialTenantsNumber { get; set; }

    /// <summary>
    ///     备注信息
    /// </summary>
    public string? Remark { get; set; }
}