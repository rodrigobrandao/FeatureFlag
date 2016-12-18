using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class ConfigService : IConfigService
    {
        public FeatureFlag.IConfiguration FeatureFlag { get; set; }

        public ConfigService()
        {
            this.FeatureFlag = global::FeatureFlag.Features.GetConfiguration();
        }
    }

    public interface IConfigService
    {
        FeatureFlag.IConfiguration FeatureFlag { get; set; }

        
    }
}