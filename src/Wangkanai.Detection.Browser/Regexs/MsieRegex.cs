using System;
using System.Collections.Generic;
using System.Text;

namespace Wangkanai.Detection.Regexs
{
    internal class MsieRegex : AgentRegex
    {
        public MsieRegex(string agent) : base(agent) { }
    }

    internal class Ie11Regex : AgentRegex
    {
        public Ie11Regex(string agent) : base(agent) { }
    }

    internal class OperaRegex : AgentRegex
    {
        public OperaRegex(string agent) : base(agent) { }
    }

    internal class EdgeRegex : AgentRegex
    {
        public EdgeRegex(string agent) : base(agent) { }
    }
    internal class Safari : AgentRegex
    {
        public Safari(string agent) : base(agent) { }
    }

    internal class Chrome : AgentRegex
    {
        public Chrome(string agent) : base(agent) { }
    }
}
