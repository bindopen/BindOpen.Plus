namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class IBdoActivityExtensions
    {
        public static T WithKind<T>(
            this T obj,
            ActivityKinds kind)
            where T : IBdoActivity
        {
            if (obj != null)
            {
                obj.Kind = kind;
            }
            return obj;
        }

        public static T WithMaximumIndex<T>(
            this T obj,
            float index)
            where T : IBdoActivity
        {
            if (obj != null)
            {
                obj.MaximumIndex = index;
            }
            return obj;
        }
    }
}