using System;


namespace FeatureFlag
{
    internal class Feature : IFeature
    {
        public Feature(string name, EnumState state)
        {
            Name = name;
            State = state;
        }

        public Feature(string name, EnumState state, DateTime startDate)
        {
            Name = name;
            State = state;
            StartDate = startDate;
        }

        public string Name
        {
            get;
        }

        public EnumState State
        {
            get;
        }

        public DateTime StartDate { get; }
    }
}
