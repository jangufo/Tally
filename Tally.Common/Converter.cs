using Tally.Models;

namespace Tally.Common;

public static class Converter
{
    public static E_BillState StringToE_BillState(string value)
    {
        var dict = new Dictionary<string, E_BillState>
        {
            { "支付成功", E_BillState.PaySuccessful },
            { "已全额退款", E_BillState.RefundSuccessful },
            { "已转账", E_BillState.TransferSuccessful },
            { "其他", E_BillState.Nothing }
        };
        return dict.GetValueOrDefault(value, E_BillState.Nothing);
    }

    public static E_BillType StringToE_BillType(string value)
    {
        var dict = new Dictionary<string, E_BillType>
        {
            { "支出", E_BillType.Expenditure },
            { "收入", E_BillType.Income },
            { "转账", E_BillType.Transfer },
            { "其他", E_BillType.Nothing }
        };
        return dict.GetValueOrDefault(value, E_BillType.Nothing);
    }
}