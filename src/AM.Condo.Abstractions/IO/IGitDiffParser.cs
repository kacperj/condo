// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGitDiffParser.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the properties and methods required to implement a parser for git diff logs.
    /// </summary>
    public interface IGitDiffParser
    {
        #region Methods
        /// <summary>
        /// Parses the specified <paramref name="lines"/> as a git-diff.
        /// </summary>
        /// <param name="lines">
        /// The raw lines representing the output from a git-diff.
        /// </param>
        /// <returns>
        /// The changeset resulting from the output of a git-diff.
        /// </returns>
        GitDiffChangeset Parse(IEnumerable<string> lines);
        #endregion
    }
}
