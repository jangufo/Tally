using System.Text.RegularExpressions;
using Tally.IService.BillParse;

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
        @"^(?<DATE>\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}),.*?,(?<BUSINESS>.*?),(?<COMMODITY>.*?),(?<E_BILL_TYPE>.*?),¥(?<AMOUNT>\d+\.\d{2}),(?<PAY_TYPE>.*?),(?<BILL_STATE>.*?),(?<WX_TRANSACTION_TICKET_NUMBER>\d+)\s+,(?<WX_COMMERCIAL_TENANTS_NUMBER>.*?)\s+,(?<REMARK>.*?)$")]
    private static partial Regex RegexGenerated();

    public int Parse(string billString)
    {
        var matches = WxBillParseRegex.Matches(billString);
        return matches.Count;

        // foreach (var match in matches)
        // {
        //     string date = match.Groups["DATE"].Value;
        //     string business = match.Groups["BUSINESS"].Value;
        //     string commodity = match.Groups["COMMODITY"].Value;
        //     string E_BILL_TYPE = match.Groups["E_BILL_TYPE"].Value;
        //     string amount = match.Groups["AMOUNT"].Value;
        //     string payType = match.Groups["PAY_TYPE"].Value;
        //     string billState = match.Groups["BILL_STATE"].Value;
        //     string WX_TRANSACTION_TICKET_NUMBER = match.Groups["WX_TRANSACTION_TICKET_NUMBER"].Value;
        //     string WX_COMMERCIAL_TENANTS_NUMBER = match.Groups["WX_COMMERCIAL_TENANTS_NUMBER"].Value;
        //     Console.WriteLine("____________________________________________");
        //     Console.WriteLine("DATE: {0}", date);
        //     Console.WriteLine("BUSINESS: {0}", business);
        //     Console.WriteLine("COMMODITY: {0}", commodity);
        //     Console.WriteLine("E_BILL_TYPE: {0}", E_BILL_TYPE);
        //     Console.WriteLine("AMOUNT: {0}", amount);
        //     Console.WriteLine("PAY_TYPE: {0}", payType);
        //     Console.WriteLine("BILL_STATE: {0}", billState);
        //     Console.WriteLine("WX_TRANSACTION_TICKET_NUMBER: {0}", WX_TRANSACTION_TICKET_NUMBER);
        //     Console.WriteLine("WX_COMMERCIAL_TENANTS_NUMBER: {0}", WX_COMMERCIAL_TENANTS_NUMBER);
        //     Console.WriteLine();
        // }
    }
}