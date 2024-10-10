using System.Text.RegularExpressions;
using Tally.Common;
using Tally.IService.BillParse;
using Tally.Models;

namespace Tally.Service.BillParse;

public partial class WxBillParse : IWxBillParse
{
    private readonly Regex WxBillParseRegex = RegexGenerated();

    /// <summary>
    ///     编译期生成正则表达式，它用来匹配微信账单的数据
    ///     包括： 交易时间,交易类型,交易对方,商品,收/支,金额(元),支付方式,当前状态,交易单号,商户单号,备注
    /// </summary>
    /// <returns></returns>
    [GeneratedRegex(
        @"(?<DATE>\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}),.*?,(?<BUSINESS>.*?),(?<COMMODITY>.*?),(?<E_BILL_TYPE>.*?),¥(?<AMOUNT>\d+\.\d{2}),(?<PAY_TYPE>.*?),(?<BILL_STATE>.*?),(?<WX_TRANSACTION_TICKET_NUMBER>\d+)\s+,(?<WX_COMMERCIAL_TENANTS_NUMBER>.*?)\s+,(?<REMARK>.*?)")]
    private static partial Regex RegexGenerated();

    public List<TallyBill> Parse(string billString)
    {
        return WxBillParseRegex
            .Matches(billString)
            .Select(m => new TallyBill
            {
                CreatDateTime = DateTime.Parse(m.Groups["DATE"].Value),
                LastModifiedDateTime = DateTime.Now,
                Business = m.Groups["BUSINESS"].Value.Trim(),
                Commodity = m.Groups["COMMODITY"].Value.Trim(),
                EBillType = Converter.StringToE_BillType(m.Groups["E_BILL_TYPE"].Value.Trim()),
                Amount = decimal.Parse(m.Groups["AMOUNT"].Value),
                WxPayType = m.Groups["WX_PAY_TYPE"].Value.Trim(),
                BillState = Converter.StringToE_BillState(m.Groups["BILL_STATE"].Value.Trim()),
                WxCommercialTenantsNumber = m.Groups["WX_COMMERCIAL_TENANTS_NUMBER"].Value,
                WxTransactionTicketNumber = m.Groups["WX_TRANSACTION_TICKET_NUMBER"].Value,
                Remark = m.Groups["REMARK"].Value.Trim(),
            }).ToList();
    }
}