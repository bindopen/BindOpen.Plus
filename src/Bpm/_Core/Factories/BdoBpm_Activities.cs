using BindOpen.Bpm.Activities;
using BindOpen.Data;
using BindOpen.Scoping;
using BindOpen.Scoping.Script;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This class represents an activity factory.
    /// </summary>
    public static partial class BdoBpm
    {
        public static BdoScriptword_Workflow Workflow(string name)
        {
            var word = BdoScript.To<BdoScriptword_Workflow>(BdoScript.Func<IBdoWorkflow>("workflow", name));

            return word;
        }

        public static IBdoWorkflow NewWorkflow(string name, params IBdoActivity[] activities)
        {
            var workflow = BdoData.New<BdoWorkflow>()
                .WithName(name)
                .WithActivities(activities);

            return workflow;
        }

        /// <summary>
        /// News a new workflow.
        /// </summary>
        public static IBdoWorkflow NewWorkflow(params IBdoActivity[] activities)
            => NewWorkflow(null, activities);

        /// <summary>
        /// News a new sequence activity.
        /// </summary>
        public static IBdoSequence NewSequence(string name, params IBdoActivity[] activities)
        {
            var sequence = BdoData.New<BdoSequence>()
                .WithName(name)
                .WithActivities(activities);

            return sequence;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="activities"></param>
        /// <returns></returns>
        public static IBdoSequence NewSequence(params IBdoActivity[] activities)
            => NewSequence(null, activities);

        /// <summary>
        /// News a new task activity.
        /// </summary>
        public static IBdoTaskActivity NewTaskActivity(string name = null, string definitionUniqueName = null)
        {
            var task = BdoData.New<BdoTaskActivity>()
                .WithName(name)
                .WithDataType(BdoExtensionKinds.Task, definitionUniqueName);

            return task;
        }

        /// <summary>
        /// News a new task activity.
        /// </summary>
        public static IBdoActivity NewActivity(ActivityKinds kind, string name = null)
        {
            IBdoActivity activity = null;

            switch (kind)
            {
                case ActivityKinds.Sequence:
                    return NewSequence(name);
                case ActivityKinds.Task:
                    return NewTaskActivity(name);
                case ActivityKinds.Workflow:
                    return NewWorkflow(name);
                case ActivityKinds.None:
                case ActivityKinds.Any:
                    break;
            }

            return activity;
        }
    }
}
