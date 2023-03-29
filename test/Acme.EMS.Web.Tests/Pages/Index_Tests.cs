﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.EMS.Pages;

public class Index_Tests : EMSWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
