# FeatureFlag
==============

Simple Another Feature Flag (Feature Toggle / Feature Switch) for .NET - Connecting DataBase or inMemory

Now you can start toggling features;

      var features = FeatureFlag.Feature.GetConfiguration();
      if (features.IsAvailable("Feature01"))
      {
          // Do something
          var feature = features.GetFeature("Feature01");
          Console.WriteLine(feature.Name + ";" + feature.State.ToString() + ";" + feature.StartDate);            
      }


You can connection on database to access your features or use in memory

      FeatureFlag.Repository.FeatureFlagRepositoryDB repo = new FeatureFlag.Repository.FeatureFlagRepositoryDB();            
      FeatureFlag.IConfiguration features = FeatureFlag.Features.GetConfiguration(repo);

      FeatureFlag.Repository.FeatureFlagRepositoryFake repo = new FeatureFlag.Repository.FeatureFlagRepositoryFake();            
      FeatureFlag.IConfiguration features = FeatureFlag.Features.GetConfiguration(repo);

Please check your database connection in app.config
