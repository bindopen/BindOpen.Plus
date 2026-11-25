using BindOpen.Data;

namespace BindOpen.Databases
{
    /// <summary>
    /// This class represents a database model.
    /// </summary>
    public abstract partial class BdoDbModel : BdoObject, IBdoDbModel, IBdoDbModelBuilder
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        protected BdoDbModel()
        {
            OnCreating();
        }

        #endregion

        // ------------------------------------------
        // IBdoDbModel Implementation
        // ------------------------------------------

        #region IBdoDbModel

        /// <summary>
        /// 
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Key() => Identifier;

        #endregion

        // -----------------------------------------------
        // IBdoDbModelBuilder Implementation
        // -----------------------------------------------

        #region IBdoDbModel

        /// <summary>
        /// 
        /// </summary>
        public virtual void OnCreating()
        {
        }

        #endregion
    }
}
