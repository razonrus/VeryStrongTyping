using System;
using System.Reflection;

namespace Sst
{
    public class Item
    {
        private dynamic id;

        [StrongField("ItemId")]
        public dynamic Id
        {
            get { return id; }
            set
            {
                var currentMethod = MethodBase.GetCurrentMethod();
                var fieldName = currentMethod.DeclaringType.GetProperty(currentMethod.Name.Substring(4)).GetCustomAttribute<StrongFieldAttribute>().FieldName;
                id = ReflectionHelper.ValueForSet(value, fieldName);
            }
        }
    }

    static class ReflectionHelper
    {
        public static dynamic ValueForSet(dynamic value, string fieldName)
        {
            dynamic result;
            var strongValue = value as StrongFieldValue;
            if (strongValue != null)
            {
                if (strongValue.FieldName != fieldName)
                    throw new Exception("error");
                result = new StrongFieldValue()
                {
                    FieldName = fieldName,
                    Value = strongValue.Value
                };
            }
            else
                result = new StrongFieldValue()
                {
                    FieldName = fieldName,
                    Value = value
                };
            return result;
        }
    }

    public class User
    {
        private dynamic id;

        [StrongField("UserId")]
        public dynamic Id
        {
            get { return id; }
            set
            {
                var currentMethod = MethodBase.GetCurrentMethod();
                var fieldName = currentMethod.DeclaringType.GetProperty(currentMethod.Name.Substring(4)).GetCustomAttribute<StrongFieldAttribute>().FieldName;
                id = ReflectionHelper.ValueForSet(value, fieldName);
            }
        }
    }
}