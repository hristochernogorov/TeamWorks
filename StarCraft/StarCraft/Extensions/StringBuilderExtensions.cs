namespace StarCraft.Extensions
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static bool IsEmpty(this StringBuilder str)
        {
            if (str.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
