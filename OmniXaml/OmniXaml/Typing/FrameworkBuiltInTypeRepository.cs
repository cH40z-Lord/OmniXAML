namespace OmniXaml.Typing
{
    using System;
    using System.Reflection;

    public class FrameworkBuiltInTypeRepository : IXamlTypeRepository
    {
        public XamlType Get(Type type)
        {
            throw new NotImplementedException();
        }

        public XamlType GetByPrefix(string prefix, string typeName)
        {
            throw new NotImplementedException();
        }

        public XamlType GetWithFullAddress(XamlTypeName xamlTypeName)
        {
            throw new NotImplementedException();
        }

        public XamlMember GetMember(PropertyInfo propertyInfo)
        {
            throw new NotImplementedException();
        }
    }
}