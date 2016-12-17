using System;
using System.Collections.Generic;

namespace FeatureFlag
{
    public interface IConfiguration
    {
        IList<IFeature> Features { get; }

        IFeature GetFeature(Enum feature);
        IFeature GetFeature(string feature);

        bool IsAvailable(Enum feature);
        bool IsAvailable(string feature);
    }
}
