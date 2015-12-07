using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class StrategyModel
    {
        public string ID;
        public string Name;
        public string Description;
        public string ShortKey;
        List<CommandModel> ListCommand;
    }
}
