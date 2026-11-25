namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a sequence activity design.
    /// </summary>
    public interface IBdoSequence : IBdoActivity
    {
        SequenceKinds SequenceKind { get; set; }
    }
}
