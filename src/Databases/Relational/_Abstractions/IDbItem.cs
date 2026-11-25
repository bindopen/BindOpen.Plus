using BindOpen.Data;
using BindOpen.Data.Objects;

namespace BindOpen.Databases.Relational
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDbObject : IBdoObject
    {
        IBdoExpression Expression { get; set; }

        string ToString();
    }
}