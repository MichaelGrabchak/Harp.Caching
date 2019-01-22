using System.Configuration;

using Harp.Common.Extensions;

namespace Harp.Caching.Configurations
{
    public class CacheConfiguration : ICacheConfiguration
    {
        public int? CacheExpiration { get; }

        public CacheConfiguration()
        {
            CacheExpiration = ConfigurationManager.AppSettings[Constants.ConfigurationKeys.CacheExpirationKey].To<int?>();
        }
    }
}
