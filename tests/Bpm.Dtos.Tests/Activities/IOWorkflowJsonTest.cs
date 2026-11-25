using BindOpen.Bpm.Tests;
using BindOpen.Data;
using NUnit.Framework;
using System.IO;

namespace BindOpen.Bpm.Activities
{
    [TestFixture]
    public class IOWorkflowJsonTest
    {
        private IBdoWorkflow _workflow = null;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _workflow = BdoWorkflowFaker.Fake();
        }

        [Test, Order(1)]
        public void SaveJsonTest()
        {
            var isSaved = _workflow.ToDto().SaveJson(BdoWorkflowFaker.JsonFilePath);

            Assert.That(isSaved, "Workflow saving failed");
        }

        [Test, Order(2)]
        public void LoadJsonTest()
        {
            if (_workflow == null || !File.Exists(BdoWorkflowFaker.JsonFilePath))
            {
                SaveJsonTest();
            }

            var workflow = JsonHelper.LoadJson<WorkflowDto>(BdoWorkflowFaker.JsonFilePath).ToPoco();

            Assert.That(workflow != null, "Workflow loading failed");

            BdoWorkflowFaker.AssertFake(_workflow, workflow);
        }
    }
}
