using Tally.Service.BillParse;

namespace Tally.Service.Test.BillParse;

public class WxBillParse_Test
{
    [Fact]
    public void Parse_Test_Return_261()
    {
        var wxBillParse = new WxBillParse();

        string parseString = File.ReadAllText("D:\\wxfile.csv");
        int val = wxBillParse.Parse(parseString);
        
        Assert.Equal(261, val);
    }
}