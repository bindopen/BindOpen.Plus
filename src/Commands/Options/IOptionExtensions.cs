using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Data.Objects;
using BindOpen.Logging;
using BindOpen.Scoping;
using System;

namespace BindOpen.Commands;

/// <summary>
/// 
/// </summary>
public static class IOptionExtensions
{
    public static T Execute<T>(
        this T option,
        Action action)
        where T : IOption
        => option.Execute(null, action);

    public static T Execute<T>(
        this T option,
        Predicate<IBdoMetaData> predicate,
        Action action)
        where T : IOption
    {
        if (option != null)
        {
            option.Executions ??= new();
            option.Executions.Add((predicate, action));
        }

        return option;
    }

    public static T Execute<T>(
        this T option,
        IBdoScope scope,
        IBdoExpression expression,
        Action action,
        IBdoMetaSet varSet = null,
        IBdoLog log = null)
        where T : IOption
    {
        if (option != null && expression != null)
        {
            option.Executions ??= [];
            option.Executions.Add(((IBdoMetaData param) =>
            {
                var localVarSet = BdoData.NewSet(varSet)
                    .Add(BdoData.__VarName_This, param);

                var invoke = scope.Interpreter.Evaluate<bool?>(expression, localVarSet, log);

                return invoke ?? false;
            }, action));
        }

        return option;
    }
}