using System;

namespace FeatureFlag
{
    public interface IFeature
    {
        string Name { get; }

        EnumState State { get; }

        DateTime StartDate { get; }
    }
}
