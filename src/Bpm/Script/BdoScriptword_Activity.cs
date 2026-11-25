using BindOpen.Bpm.Activities;
using BindOpen.Scoping.Script;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This class represents a DTO activity.
    /// </summary>
    public class BdoScriptword_Activity : BdoScriptword
        , ITBdoScriptword<IBdoActivity>
    {
        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoScriptword_Activity class.
        /// </summary>
        public BdoScriptword_Activity()
        {
        }

        #endregion
    }
}
