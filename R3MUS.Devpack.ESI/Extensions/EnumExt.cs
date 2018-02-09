using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class EnumExt
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
