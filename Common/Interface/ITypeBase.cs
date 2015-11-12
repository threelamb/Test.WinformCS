using Common.Concrete.Mapper;
using Common.Interface.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interface
{
    public abstract class ITypeBase
    {
        public ITypeMapper typeMapper = new TypeMapper();
    }
}
