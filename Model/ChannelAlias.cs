﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class ChannelAliasModel
    {
        public string ChannelName;
        public string Alias { get; set; }
    }
}
