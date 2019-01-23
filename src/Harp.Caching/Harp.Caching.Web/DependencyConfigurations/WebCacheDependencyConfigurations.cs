using Harp.Caching.DependencyConfigurations;
using Harp.Dependencies;

namespace Harp.Caching.Web.DependencyConfigurations
{
    public sealed class WebCacheDependencyConfigurations : CacheDependencyConfigurations
    {
        protected override void RegisterCacheContainer()
        {
            Container.RegisterType<ICache, WebCache>();
        }
    }
}
