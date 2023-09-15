// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var setting = new AppSetting();

        setting.Description = "biju";

        Assert.True(setting.Description == "biju");
    }
}
