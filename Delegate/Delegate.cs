namespace Bocasay.Delegate
{
    using Bocasay.BAL;
    public class Delegate
    {
        public delegate IHandler ServiceResolver(string key);
    }
}
