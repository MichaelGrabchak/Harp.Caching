using Harp.Caching.Configurations;
using Harp.Dependencies;
using Harp.Dependencies.Configurations;

namespace Harp.Caching.DependencyConfigurations
{
    public class CacheDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterCacheConfig();
            RegisterCacheContainer();
        }

        protected virtual void RegisterCacheConfig()
        {
            Container.RegisterType<ICacheConfiguration, CacheConfiguration>();
        }

        protected virtual void RegisterCacheContainer()
        {
            Container.RegisterType<ICache, NoCache>();
        }
    }
}
