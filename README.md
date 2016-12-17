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

