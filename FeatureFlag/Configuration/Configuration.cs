using System;
using System.Collections.Generic;
using FeatureFlag.Repository;

namespace FeatureFlag
{
    public class Configuration : IConfiguration
    {
        public IList<IFeature> Features { get; }

        public Configuration(IFeatureFlagRepository repository)
        {
            if (repository == null) return;

            this.Features = repository.GetFeatures();
        }

        #region GetFeature

        public IFeature GetFeature(Enum feature)
        {
            return GetFeature(feature.ToString());
        }

        public IFeature GetFeature(string feature)
        {
            IFeature ifeature = null;
            if (this.Features == null) return null;

            foreach (var f in this.Features)
            {
                if (f.Name.Equals(feature)) ifeature = f;
            }

            return ifeature;
        }

        #endregion
        
        #region IsAvailable

        public bool IsAvailable(Enum feature)
        {
            return this.IsAvailable(feature.ToString());
        }

        public bool IsAvailable(string feature)
        {
            if (this.Features == null) return false;

            foreach (var f in this.Features)
            {
                if (f.Name.Equals(feature)) return (f.State == EnumState.Enabled || f.State == EnumState.Previewable) && f.StartDate < DateTime.Now;
            }

            return false;
        }

        #endregion

    }
}
