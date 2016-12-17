using FeatureFlag.Repository;

namespace FeatureFlag
{
    public class Features
    {
        public static IConfiguration GetConfiguration(IFeatureFlagRepository repository = null)
        {
            //default
            if (repository == null)
                repository = new FeatureFlagRepositoryDB();
            
            return new Configuration(repository);
        }
    }
}
