using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Logging;
using BindOpen.Logging.Loggers;
using BindOpen.Scoping;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace BindOpen.Bpm.Services
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public interface IBdoRunner : IBdoScoped, IHostedService, IReferenced, IIdentified, IBdoLoggerTracked
    {
        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        ProcessExecutionState State { get; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        IBdoMetaSet VariableSet { get; set; }

        #endregion

        // ------------------------------------------
        // METHODS
        // ------------------------------------------

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param key="status"></param>
        Task StopAsync(
            CancellationToken cancellationToken,
            ProcessExecutionStatus status = ProcessExecutionStatus.Completed);

        #endregion
    }
}
