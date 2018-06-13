namespace Common.IoC
{
    static class InstanceResolverDefaultBuilders
    {
        public static TContract Builder<TContract>()
        {
            throw new InstanceNotResolvedException(typeof(TContract));
        }
    }
}
