using System;

namespace AccessModifiersDemoLibrary
{
    public class AccessModifiersDemo
    {
        public    static readonly string  publicField              = "public";
        private   static readonly string  privateField             = "private";
        internal  static readonly string  internalField            = "internal";
        protected static readonly string  protectedField           = "protected";
        protected static          string  protectedEditableField   = "protectedEditable";
    }
}
