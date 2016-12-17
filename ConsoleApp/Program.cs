using System;

namespace ConsoleApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            FeatureFlag.Repository.FeatureFlagRepositoryFake repo = new FeatureFlag.Repository.FeatureFlagRepositoryFake();            
            FeatureFlag.IConfiguration config = FeatureFlag.Features.GetConfiguration(repo);

            Console.WriteLine("Feature01: " + config.IsAvailable(MyFeatures.Feature01));
            Console.WriteLine("Feature02: " + config.IsAvailable(MyFeatures.Feature02));
            Console.WriteLine("Feature03: " + config.IsAvailable(MyFeatures.Feature03));
            Console.WriteLine("Feature04: " + config.IsAvailable(MyFeatures.Feature04));
            Console.WriteLine("Feature05: " + config.IsAvailable(MyFeatures.Feature05));

            if (config.IsAvailable(MyFeatures.Feature03))
            {
                FeatureFlag.IFeature feature = config.GetFeature(MyFeatures.Feature03);

                Console.WriteLine(feature.Name + ";" + feature.State.ToString() + ";" + feature.StartDate);
            }

            Console.ReadKey();
        }

        enum MyFeatures
        {
            Feature01,
            Feature02,
            Feature03,
            Feature04,
            Feature05
        }
    }
}
