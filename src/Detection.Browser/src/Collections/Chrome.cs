// Copyright (c) 2019 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using Wangkanai.Detection;

namespace Wangkanai.Detection.Collections
{
    public class Chrome : Browser
    {
        private readonly string _agent;

        public Chrome(string agent)
        {
            _agent = agent.ToLower();
            var chrome = BrowserType.Chrome.ToString().ToLower();

            if (_agent.Contains(chrome))
            {
                var first = _agent.IndexOf(chrome);
                var cut = _agent.Substring(first + chrome.Length + 1);
                var version = cut.Substring(0, cut.Contains(" ") ? cut.IndexOf(' ') : cut.Length);
                Version = version.ToVersion();                
                Type = BrowserType.Chrome;
            }
        }
    }
}
