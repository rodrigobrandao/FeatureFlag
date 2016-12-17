using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlag.Repository
{
    public class FeatureFlagRepositoryFake: IFeatureFlagRepository
    {
        public IList<IFeature> GetFeatures()
        {
            IList<IFeature> features = new List<IFeature>();
            features.Add(new Feature("Feature01", EnumState.Enabled));
            features.Add(new Feature("Feature02", EnumState.Disabled));
            features.Add(new Feature("Feature03", EnumState.Previewable, new DateTime(2016, 12, 16, 23, 37, 00)));
            features.Add(new Feature("Feature04", EnumState.Disabled));
            features.Add(new Feature("Feature05", EnumState.Enabled));

            return features;
        }
    }
}
