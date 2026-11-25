using BindOpen.Data.Meta;

namespace BindOpen.Bpm.Services
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class IBdoRunnerExtensions
    {
        public static T WithVariableSet<T>(
            this T obj,
            IBdoMetaSet set)
            where T : IBdoRunner
        {
            if (obj != null)
            {
                obj.VariableSet = set;
            }
            return obj;
        }
    }
}