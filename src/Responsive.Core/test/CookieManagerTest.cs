// Copyright (c) 2019 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.Detection;
using Xunit;

namespace Wangkanai.Responsive.Test.Core
{
    public class CookieManagerTest : ResponsiveTestAbstract
    {
        [Fact]
        public void SetAble()
        {
            var service = CreateService("test");
            var manager = new CookieManager(service.Context, null);

            manager.Set(DeviceType.Mobile);

            // Assert.Equal(DeviceType.Mobile, manager.Get());
            // How to get cookie working for HttpContext in Unit Test?
        }
    }
}
