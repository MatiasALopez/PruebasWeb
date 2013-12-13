using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Website.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class CUITAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return false;
        }
    }
}