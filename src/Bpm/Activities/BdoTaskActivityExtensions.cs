using BindOpen.Data;
using BindOpen.Scoping;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class BdoTaskActivityExtensions
    {
        public static T WithDataType<T>(this T dataTyped, string definitionUniqueName) where T : IBdoTaskActivity
        {
            if (dataTyped != null)
            {
                dataTyped.DataType = BdoData.NewDataType(BdoExtensionKinds.Task, definitionUniqueName);
            }

            return dataTyped;
        }

    }
}