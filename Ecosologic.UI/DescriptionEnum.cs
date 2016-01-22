using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecosologic
{
    public class DescriptionEnum
    {
        public string GetDescription(object enumValue)
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
            string defDesc = "";

            if (null != fi)
            {
                object[] attrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return defDesc;

        }
    }
}
