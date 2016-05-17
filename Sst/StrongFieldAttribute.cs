using System;

namespace Sst
{
    public class StrongFieldAttribute : Attribute
    {
        public readonly string FieldName;

        public StrongFieldAttribute(string fieldName)
        {
            this.FieldName = fieldName;
        }
    }
}