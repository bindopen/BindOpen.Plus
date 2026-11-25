using BindOpen.Data;
using BindOpen.Logging;
using BindOpen.Logging.Loggers;
using BindOpen.Bpm.Activities;
using BindOpen.Bpm.Jobs;
using BindOpen.Bpm.Services;
using BindOpen.Bpm.Tests;
using NUnit.Framework;
using System.Threading;

namespace BindOpen.Bpm.Activities
{
    [TestFixture]
    public class WorkflowTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartJob()
        {
            var workflow = BdoWorkflowFaker.Fake();

            var inputs = BdoData.NewSet()
                .Add(BdoData.NewMeta("input1", 4))
                .Add(BdoData.NewMeta("input2", "value2"));

            var job = BdoBpm.NewJob()
                .WithActivity(workflow)
                .WithInputs(inputs);

            var varSet = BdoData.NewSet();
            var logger = BdoLogging.NewLogger<BdoConsoleLogger>();

            IBdoRunner runner = SystemData.Scope.NewRunner(job)
                .WithVariableSet(varSet)
                .WithLoggers(logger);

            var cancellationTokenSource = new CancellationTokenSource();
            runner.StartAsync(cancellationTokenSource.Token).Wait();
        }

        [Test]
        public void ResumeJob()
        {
        }
    }
}
