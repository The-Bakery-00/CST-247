using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class OneAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var typeInfo = value.GetType();

            var propertyInfo = typeInfo.GetProperties();

            foreach (var property in propertyInfo)
            {
                if (null != property.GetValue(value, null))
                {
                    return true;
                }
            }

            return false;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class Numeric : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int x;
            if (value != null)
            {
                if (Int32.TryParse(value.ToString(), out x))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        } 
    }
}