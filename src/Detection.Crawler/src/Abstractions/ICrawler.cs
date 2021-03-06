﻿// Copyright (c) 2019 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

namespace Wangkanai.Detection
{
    public interface ICrawler
    {
        string Name { get; set; }
        CrawlerType Type { get; set; }
        Version Version { get; set; }
    }
}
