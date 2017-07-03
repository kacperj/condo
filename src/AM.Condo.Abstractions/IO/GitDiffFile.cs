// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffFile.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a file containing patches as part of a git-diff.
    /// </summary>
    public class GitDiffFile
    {
        #region Properties and Indexers
        /// <summary>
        /// Gets or sets the source path relative to the root of the repository from which the diff patch is referenced.
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// Gets or sets the destination path relative to the root of the repository to which the diff patch is applied.
        /// </summary>
        public string DestinationPath { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the file was created within the git-diff.
        /// </summary>
        public bool Created => this.OperationType == GitDiffOperationType.Created;

        /// <summary>
        /// Gets a value indicating whether or not the file was deleted within the git-diff.
        /// </summary>
        public bool Deleted => this.OperationType == GitDiffOperationType.Deleted;

        /// <summary>
        /// Gets or sets the type of the operation applied within the git-diff.
        /// </summary>
        public GitDiffOperationType OperationType { get; set; }

        /// <summary>
        /// Gets the collection of hunks associated with the git-diff file.
        /// </summary>
        public IEnumerable<GitDiffHunk> Hunks { get; } = new HashSet<GitDiffHunk>();
        #endregion
    }
}
