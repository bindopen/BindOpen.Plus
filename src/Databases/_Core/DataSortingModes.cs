namespace BindOpen.Databases;

/// <summary>
/// Specifies the sorting direction modes for data queries.
/// </summary>
public enum DataSortingModes
{
    /// <summary>
    /// No sorting is applied.
    /// </summary>
    None,

    /// <summary>
    /// Sorts data in ascending order (from lowest to highest).
    /// </summary>
    Ascending,

    /// <summary>
    /// Sorts data in descending order (from highest to lowest).
    /// </summary>
    Descending,

    /// <summary>
    /// Random.
    /// </summary>
    Random
}