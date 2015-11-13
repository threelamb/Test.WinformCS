using Common.Interface.Mapper;
using EmitMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Concrete.Mapper
{
    public class TypeMapper : ITypeMapper
    {
        public Target Map<Source, Target>(Source source)
            where Source : new()
            where Target : new()
        {
            if (source == null) return new Target();
            var mapper = ObjectMapperManager.DefaultInstance.GetMapper<Source, Target>();
            return mapper.Map(source);
        }
    }
}
