﻿using Tally.Service.BillParse;

namespace Tally.Service.Test.BillParse;

public class WxBillParse_Test
{
    [Fact]
    public void Parse_Test_Return_261()
    {
        var wxBillParse = new WxBillParse();

        string parseString = File.ReadAllText("D:\\wxfile261.csv");
        int val = wxBillParse.Parse(parseString).Count;

        Assert.Equal(261, val);
    }

    [Fact]
    public void Parse_Test_Return_29()
    {
        var wxBillParse = new WxBillParse();

        string parseString = File.ReadAllText("D:\\wxfile29.csv");
        int val = wxBillParse.Parse(parseString).Count;

        Assert.Equal(29, val);
    }
}