// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffOperationType.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System;

    /// <summary>
    /// Represents an enumeration of the available git diff patch types.
    /// </summary>
    [Flags]
    public enum GitDiffOperationType
    {
        /// <summary>
        /// DEFAULT: No git diff type is specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// The git file or line was created.
        /// </summary>
        Created = 0x01,

        /// <summary>
        /// The git file or line was deleted.
        /// </summary>
        Deleted = 0x02,

        /// <summary>
        /// The git file or line was modified.
        /// </summary>
        Modified = 0x04,

        /// <summary>
        /// The git file was renamed.
        /// </summary>
        Renamed = 0x08
    }
}
