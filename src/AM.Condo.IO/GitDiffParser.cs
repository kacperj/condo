// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffParser.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a parser used to parse the output of git-diff operations.
    /// </summary>
    public class GitDiffParser : IGitDiffParser
    {
        #region Methods
        /// <inheritdoc />
        public GitDiffChangeset Parse(IEnumerable<string> lines)
        {
            var diff = new GitDiffChangeset();

            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }

            return diff;
        }
        #endregion
    }
}
