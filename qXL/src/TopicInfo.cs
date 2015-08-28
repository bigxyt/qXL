﻿// 
// Copyright (c) 2011-2015 Exxeleron GmbH
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

#region

using ExcelDna.Integration.Rtd;

#endregion

namespace qXL
{
    public class TopicInfo
    {
        public TopicInfo(ExcelRtdServer.Topic topic, string alias, string tab, string sym, string col, string hist)
        {
            Topic = topic;
            Alias = alias;
            Table = tab;
            Symbol = sym;
            Column = col;
            History = hist;
        }

        public ExcelRtdServer.Topic Topic { get; private set; }

        public string Symbol { get; private set; }

// ReSharper disable UnusedAutoPropertyAccessor.Local
        private string Alias { get; set; }
// ReSharper restore UnusedAutoPropertyAccessor.Local

        public string Table { get; private set; }

        public string Column { get; private set; }

        public string History { get; private set; }
    }
}