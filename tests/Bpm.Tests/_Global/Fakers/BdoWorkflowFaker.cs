using BindOpen.Bpm.Activities;
using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Data.Schema;
using BindOpen.Scoping.Script;
using DeepEqual.Syntax;
using NUnit.Framework;

namespace BindOpen.Bpm.Tests
{
    public static class BdoWorkflowFaker
    {
        public static readonly string XmlFilePath = SystemData.WorkingFolder + "Workflow.xml";
        public static readonly string JsonFilePath = SystemData.WorkingFolder + "Workflow.json";

        public static IBdoWorkflow Fake()
        {
            var workflow =
                BdoBpm.NewWorkflow(
                    BdoBpm.NewTaskActivity("task").WithDataType("bindopen.labs.bpm$sendEmail"),
                    BdoBpm.NewSequence(
                        //SequenceKinds.Parallel
                        BdoBpm.NewSequence(
                            BdoBpm.NewTaskActivity()
                                .WithInputs(
                                    ("host", DataValueTypes.Text, BdoData.NewRef(BdoBpm.Workflow("this").Activity("sendmail").Output("host")._Value()))
                                )
                        ),
                        BdoBpm.NewSequence(
                        ),
                        BdoBpm.NewSequence(
                        )
                    )
                )
                .WithInputs(
                    ("input1", DataValueTypes.Text, 3),
                    ("input2", DataValueTypes.Text, "value2"))
                .WithDescription(("en", "This is a workflow"));

            return workflow;
        }

        public static void AssertFake(IBdoWorkflow task, IBdoWorkflow reference)
        {
            Assert.That(task?.IsDeepEqual(reference) == true, "Bad workflow");
        }
    }
}
