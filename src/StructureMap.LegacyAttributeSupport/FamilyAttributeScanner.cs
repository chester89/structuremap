using System;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace StructureMap.LegacyAttributeSupport
{
    public class FamilyAttributeScanner : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            throw new NotImplementedException("do something else");
        }
    }
}