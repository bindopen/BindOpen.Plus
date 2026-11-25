namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class IBdoSequenceExtensions
    {
        public static T WithParent<T>(
            this T seq,
            IBdoSequence parent)
            where T : IBdoSequence
        {
            if (seq != null)
            {
                seq.Parent = parent;
            }

            return seq;
        }
    }
}