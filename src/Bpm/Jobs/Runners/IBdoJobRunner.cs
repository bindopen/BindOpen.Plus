using BindOpen.Bpm.Activities;
using BindOpen.Bpm.Services;
using System.Threading;
using System.Threading.Tasks;

namespace BindOpen.Bpm.Jobs
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public interface IBdoJobRunner : IBdoRunner
    {
        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        /// <summary>
        /// The description of this instance.
        /// </summary>
        IBdoJob Job { get; set; }

        #endregion

        // ------------------------------------------
        // METHODS
        // ------------------------------------------

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        Task RestartAsync(CancellationToken cancellationToken);

        /// <summary>
        /// 
        /// </summary>
        Task ResumeAsync();

        /// <summary>
        /// 
        /// </summary>
        Task PauseAsync();

        #endregion

        void Subscribe(IBdoActivityRunner runner);

        void Unsubscribe(IBdoActivityRunner runner);

        void ClearSubscriptions();

    }
}
