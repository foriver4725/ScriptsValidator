using System.Collections.Generic;
using Hnx8.ReadJEnc;

namespace foriver4725.ScriptsValidator
{
    /// <summary>
    /// Passes variables from the window layer to the logic layer.
    /// </summary>
    internal interface IValidateOptions : IValidateSearchOptions, IValidateConvertOptions
    {
    }

    internal interface IValidateSearchOptions
    {
        // Never null
        string Root { get; }

        // Search patterns (OR logic, not regex)
        // Never null
        IEnumerable<string> Patterns { get; }
    }

    internal interface IValidateConvertOptions
    {
        // Skip processing if null
        CharCode CharCode { get; }

        // Conversions: sequential regex-based replacements
        //              Skip if null
        // Name       : provides a name for the line ending type for logging
        //              Never null
        (IEnumerable<(string Pattern, string Replacement)> Conversions, string Name) Endline { get; }
    }
}
