using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestInMemory
    {
        [TestMethod]
        public void FeatureFlag_Is_Avaliable()
        {
            FeatureFlag.Repository.FeatureFlagRepositoryFake repo = new FeatureFlag.Repository.FeatureFlagRepositoryFake();

            FeatureFlag.IConfiguration config = FeatureFlag.Features.GetConfiguration(repo);
            bool isAvailable = config.IsAvailable("Feature01");

            Assert.IsTrue(isAvailable);
        }

        [TestMethod]
        public void FeatureFlag_Is_Not_Avaliable()
        {
            FeatureFlag.Repository.FeatureFlagRepositoryFake repo = new FeatureFlag.Repository.FeatureFlagRepositoryFake();

            FeatureFlag.IConfiguration config = FeatureFlag.Features.GetConfiguration(repo);
            Assert.IsFalse(config.IsAvailable("Feature02"));
        }

        [TestMethod]
        public void FeatureFlag_Is_Previewable()
        {
            FeatureFlag.Repository.FeatureFlagRepositoryFake repo = new FeatureFlag.Repository.FeatureFlagRepositoryFake();

            FeatureFlag.IConfiguration config = FeatureFlag.Features.GetConfiguration(repo);
            Assert.IsTrue(config.IsAvailable("Feature03"));
            Assert.IsTrue(config.GetFeature("Feature03").State == FeatureFlag.EnumState.Previewable);
        }
    }
}
