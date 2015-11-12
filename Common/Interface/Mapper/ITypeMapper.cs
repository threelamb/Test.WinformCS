using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interface.Mapper
{
    public interface ITypeMapper
    {
        Target Map<Source, Target>(Source source)
            where Source : class, new()
            where Target : class, new();
    }
}
