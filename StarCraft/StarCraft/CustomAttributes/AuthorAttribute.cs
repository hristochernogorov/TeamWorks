
namespace StarCraft.CustomAttributes
{
    using System;
    using System.Runtime.InteropServices;

    [AttributeUsage(AttributeTargets.Struct |
      AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor,
      AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}


