using System;

namespace Git
{
    /// <summary>
    ///  Example methods 
    /// </summary>

    public static class Method
    {
        internal static Random Seed = new Random();

        public static int Random() => Seed.Next();
    }
}
