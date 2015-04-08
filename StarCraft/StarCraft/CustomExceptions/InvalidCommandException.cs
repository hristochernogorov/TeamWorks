namespace StarCraft.CustomExceptions
{
    using System;

    class InvalidCommandException : ApplicationException
    {
        public InvalidCommandException(string msg, Exception causeException)
            : base(msg, causeException)
        {

        }

        public InvalidCommandException(string msg)
            : this(msg, null)
        {

        }
    }
}
