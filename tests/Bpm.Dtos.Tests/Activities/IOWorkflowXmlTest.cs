using BindOpen.Bpm.Tests;
using BindOpen.Data;
using NUnit.Framework;
using System.IO;

namespace BindOpen.Bpm.Activities
{
    [TestFixture]
    public class IOWorkflowTest
    {
        private IBdoWorkflow _workflow = null;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _workflow = BdoWorkflowFaker.Fake();
        }

        [Test, Order(2)]
        public void SaveXmlTest()
        {
            //BdoSchema spec = BdoData.NewSpec("host", DataValueTypes.Text, BdoData.NewRef(BdoBpm._Workflow("this").Activity("sendmail").Output("host").Value()));
            //spec.ToDto().SaveXml(BdoWorkflowFaker.XmlFilePath);

            var isSaved = _workflow.ToDto().SaveXml(BdoWorkflowFaker.XmlFilePath);

            Assert.That(isSaved, "Workflow saving failed");
        }

        [Test, Order(3)]
        public void LoadXmlTest()
        {
            if (_workflow == null || !File.Exists(BdoWorkflowFaker.XmlFilePath))
            {
                SaveXmlTest();
            }

            var workflow = XmlHelper.LoadXml<WorkflowDto>(BdoWorkflowFaker.XmlFilePath).ToPoco();

            Assert.That(workflow != null, "Workflow loading failed");

            BdoWorkflowFaker.AssertFake(_workflow, workflow);
        }
    }
}
