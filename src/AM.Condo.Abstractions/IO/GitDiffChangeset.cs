// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffChangeset.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a diff between two commits within a git log.
    /// </summary>
    public class GitDiffChangeset
    {
        #region Properties and Indexers
        /// <summary>
        /// Gets the collection of files that were created within the git-diff.
        /// </summary>
        public IEnumerable<GitDiffFile> Created => this.Files.Where(file => file.Created);

        /// <summary>
        /// Gets the collection of files that were deleted within the git-diff.
        /// </summary>
        public IEnumerable<GitDiffFile> Deleted => this.Files.Where(file => file.Deleted);

        /// <summary>
        /// Gets the collection of files that were modified within the git-diff.
        /// </summary>
        public IEnumerable<GitDiffFile> Modified => this.Files.Where(file => file.Modified);

        /// <summary>
        /// Gets the collection of files that were renamed within the git-diff.
        /// </summary>
        public IEnumerable<GitDiffFile> Renamed => this.Files.Where(file => file.Renamed);

        /// <summary>
        /// Gets the collection of files associated with the git-diff.
        /// </summary>
        public ICollection<GitDiffFile> Files { get; } = new HashSet<GitDiffFile>();
        #endregion
    }
}
