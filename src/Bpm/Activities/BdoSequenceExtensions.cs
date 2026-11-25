using BindOpen.Data;
using BindOpen.Data.Schema;
using System.Linq;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class BdoSequenceExtensions
    {
        // Activities

        public static T WithActivities<T>(
            this T activity,
            params IBdoActivity[] activities)
            where T : IBdoSequence
        {
            if (activity == null) return default;

            activity._Children = BdoData.NewItemSet([.. activities.Select(q => q as IBdoSchema)]);

            return activity;
        }

        public static T AddActivities<T>(
            this T activity,
            params IBdoActivity[] activities)
            where T : class, IBdoSequence
        {
            if (activity == null) return default;

            activity?._Children.AddItems([.. activities.Select(q => q as IBdoSchema)]);

            return activity;
        }
    }
}