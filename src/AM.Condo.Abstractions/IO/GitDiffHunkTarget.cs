// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffHunkTarget.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    /// <summary>
    /// Represents a target of a git hunk, which is either the source or destination.
    /// </summary>
    public class GitDiffHunkTarget
    {
        #region Properties and Indexers
        /// <summary>
        /// Gets or sets the starting line number of the hunk target.
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Gets or sets the number of lines within the hunk target.
        /// </summary>
        public int Count { get; set; }
        #endregion
    }
}
