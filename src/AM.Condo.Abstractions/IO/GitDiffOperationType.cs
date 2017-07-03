// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffOperationType.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    /// <summary>
    /// Represents an enumeration of the available git diff patch types.
    /// </summary>
    public enum GitDiffOperationType
    {
        /// <summary>
        /// DEFAULT: No git diff type is specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// The git file or line was created.
        /// </summary>
        Created = 1,

        /// <summary>
        /// The git file or line was deleted.
        /// </summary>
        Deleted = 2,

        /// <summary>
        /// The git file or line was modified.
        /// </summary>
        Modified = 3
    }
}
