using BindOpen.Bpm.Activities;
using BindOpen.Scoping.Script;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This class represents a DTO activity.
    /// </summary>
    public class BdoScriptword_Workflow : BdoScriptword_Sequence, ITBdoScriptword<IBdoWorkflow>
    {
        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoScriptword_Workflow class.
        /// </summary>
        public BdoScriptword_Workflow()
        {
        }

        #endregion
    }
}
