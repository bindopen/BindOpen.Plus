using BindOpen.Bpm.Activities;
using BindOpen.Data.Meta;
using BindOpen.Scoping.Script;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This class represents an activity factory.
    /// </summary>
    public static partial class BdoScript_Bpm
    {
        public static BdoScriptword_Activity Activity(this ITBdoScriptword<IBdoSequence> parent, string name)
        {
            return BdoScript.To<BdoScriptword_Activity>(parent.Func<BdoScriptword_Activity>("activity", name));
        }

        public static BdoScriptword_Sequence Sequence(this ITBdoScriptword<IBdoSequence> parent, string name)
        {
            return BdoScript.To<BdoScriptword_Sequence>(parent.Func<IBdoSequence>("sequence", name));
        }


        public static ITBdoScriptword<IBdoMetaData> Input(this ITBdoScriptword<IBdoActivity> parent, string name)
        {
            return parent.Func<IBdoMetaData>("input", name);
        }

        public static ITBdoScriptword<IBdoMetaData> Output(this ITBdoScriptword<IBdoActivity> parent, string name)
        {
            return parent.Func<IBdoMetaData>("output", name);
        }

        public static ITBdoScriptword<IBdoMetaData> Variable(this ITBdoScriptword<IBdoActivity> parent, string name)
        {
            return parent.Func<IBdoMetaData>("variable", name);
        }
    }
}
