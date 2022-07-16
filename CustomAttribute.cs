using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MarkInfoAttribute : Attribute
    {
        public Pattern pattern { get; init; }
        public String description { get; init; }

        public MarkInfoAttribute()
        {

        }

        public MarkInfoAttribute(Pattern pattern, string description)
        {
            this.pattern = pattern;
            this.description = description;
        }
    }


    public enum Pattern
    {
        Creator,
        Behavior,
        @Struct,
        Paralle,
        ThreadPool
    }
}
