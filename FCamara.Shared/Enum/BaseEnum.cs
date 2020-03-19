using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace FCamara.Shared.Enum
{
    public static class BaseEnum
    {
        public static T GetEnumValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum)
                throw new ArgumentException("");
            FieldInfo[] fields = type.GetFields();

            var field = fields
                            .SelectMany(f => f.GetCustomAttributes(
                                typeof(DescriptionAttribute), false), (
                                    f, a) => new { Field = f, Att = a })
                            .FirstOrDefault(a => ((DescriptionAttribute)a.Att)?.Description == description);

            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }
        public static string GetDescriptionFromEnumValue(System.Enum value)
        {
            if (value == null)
                return "-";

            DescriptionAttribute attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
