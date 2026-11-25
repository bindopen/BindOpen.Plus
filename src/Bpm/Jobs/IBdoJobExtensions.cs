using BindOpen.Bpm.Activities;
using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Logging;

namespace BindOpen.Bpm.Jobs
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class IBdoJobExtensions
    {
        public static T WithPriority<T>(
            this T obj,
            ActionPriorities priority)
            where T : IBdoJob
        {
            if (obj != null)
            {
                obj.Priority = priority;
            }
            return obj;
        }

        public static T WithActivity<T>(
            this T obj,
            IBdoActivity activity)
            where T : IBdoJob
        {
            if (obj != null)
            {
                obj.Activity = activity;
            }
            return obj;
        }

        public static T WithActivityReference<T>(
            this T obj,
            IBdoReference reference)
            where T : IBdoJob
        {
            if (obj != null)
            {
                obj.ActivityReference = reference;
            }
            return obj;
        }

        public static T WithLog<T>(
            this T obj,
            IBdoLog log)
            where T : IBdoJob
        {
            if (obj != null)
            {
                obj.Log = log;
            }
            return obj;
        }

        public static T WithLogReference<T>(
            this T obj,
            IBdoReference reference)
            where T : IBdoJob
        {
            if (obj != null)
            {
                obj.LogReference = reference;
            }
            return obj;
        }

        public static T WithInputs<T>(
            this T obj,
            IBdoMetaSet inputDetail)
            where T : IBdoJob
        {
            if (obj != null)
            {
                obj.InputDetail = inputDetail;
            }
            return obj;
        }

    }
}