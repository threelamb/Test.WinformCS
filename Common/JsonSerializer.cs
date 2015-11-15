using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Common
{
    class JsonSerializer
    {
        public string ToJson(Object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}
