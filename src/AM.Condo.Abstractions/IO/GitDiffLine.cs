// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffLine.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    /// <summary>
    /// Represents a single line of a patch within a git-diff.
    /// </summary>
    public class GitDiffLine
    {
        #region Properties and Indexers
        /// <summary>
        /// Gets the source line number of the patch.
        /// </summary>
        public int SourceLine { get; set; }

        /// <summary>
        /// Gets the destination line number of the patch.
        /// </summary>
        public int DestinationLine { get; set; }

        /// <summary>
        /// Gets the operation type of the patch.
        /// </summary>
        public GitDiffOperationType Operation { get; set; }

        /// <summary>
        /// Gets the content of the line.
        /// </summary>
        public string Content { get; set; }
        #endregion
    }
}
