using BindOpen.Bpm.Jobs;
using BindOpen.Data.Meta;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class IBdoActivityRunneryExtensions
    {
        public static T WithActivity<T>(
            this T obj,
            IBdoActivity activity)
            where T : IBdoActivityRunner
        {
            if (obj != null)
            {
                obj.Activity = activity;
            }
            return obj;
        }

        public static T WithParent<T>(
            this T obj,
            IBdoJobRunner runner)
            where T : IBdoActivityRunner
        {
            if (obj != null)
            {
                obj.Parent = runner;
                runner?.Subscribe(obj);
            }
            return obj;
        }

        public static T WithInputs<T>(
            this T obj,
            IBdoMetaSet inputDetail)
            where T : IBdoActivityRunner
        {
            if (obj != null)
            {
                obj.InputDetail = inputDetail;
            }
            return obj;
        }
    }
}