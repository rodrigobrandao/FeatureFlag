using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlag.Repository
{
    public interface IFeatureFlagRepository
    {
        IList<IFeature> GetFeatures();
    }
}
