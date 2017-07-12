// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffParserTest.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Xunit;

    [Priority(2)]
    [Purpose(PurposeType.Unit)]
    public class GitDiffParserTest
    {
        private static readonly string ResourcePath = Path.Combine("Resources", "GitDiff");

        [Fact]
        public void Parse_WhenLinesNull_Throws()
        {
            // arrange
            var lines = default(IEnumerable<string>);

            var target = new GitDiffParser();

            // act
            Action act = () => target.Parse(lines);

            // assert
            Assert.Throws<ArgumentNullException>(nameof(lines), act);
        }

        [Fact]
        public void Parse_WhenLinesEmpty_ReturnsEmptyChangeset()
        {
            // arrange
            var lines = new HashSet<string>();

            var target = new GitDiffParser();

            // act
            var actual = target.Parse(lines);

            // assert
            Assert.NotNull(actual);
            Assert.Empty(actual.Files);
        }

        [Fact]
        public void Parse_WithSimpleDiff_ReturnsChangeset()
        {
            // arrange
            var path = Path.Combine(ResourcePath, "simple-diff.txt");
            var content = File.ReadAllText(path);

            var lines = content.Split('\n');

            var expected = new GitDiffChangeset
            {
                Files =
                {
                    new GitDiffFile
                    {
                        Source = "file",
                        Destination = "file",
                        Operation = GitDiffOperationType.Modified,
                        Hunks =
                        {
                            new GitDiffHunk
                            {
                                Content = "@@ -1,2 +1,2 @@",
                                Lines =
                                {
                                    new GitDiffLine
                                    {
                                        Operation = GitDiffOperationType.Deleted,
                                        Content = "- line1"
                                    },
                                    new GitDiffLine
                                    {
                                        Operation = GitDiffOperationType.Created,
                                        Content = "+ line2"
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var target = new GitDiffParser();

            // act
            var actual = target.Parse(lines);

            // assert
            AssertChangeset(expected, actual);
        }

        [Fact]
        public void Parse_WithDeletedFileMode_ReturnsChangeset()
        {
            // arrange
            var path = Path.Combine(ResourcePath, "deleted-file-mode.txt");
            var content = File.ReadAllText(path);

            var lines = content.Split('\n');

            var expected = new GitDiffChangeset
            {
                Files =
                {
                    new GitDiffFile
                    {
                        Source = "file",
                        Destination = "file",
                        Operation = GitDiffOperationType.Modified,
                        Hunks =
                        {
                            new GitDiffHunk
                            {
                                Content = "@@ -1,2 +1,2 @@",
                                Lines =
                                {
                                    new GitDiffLine
                                    {
                                        Operation = GitDiffOperationType.Deleted,
                                        Content = "- line1"
                                    },
                                    new GitDiffLine
                                    {
                                        Operation = GitDiffOperationType.Created,
                                        Content = "+ line2"
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var target = new GitDiffParser();

            // act
            var actual = target.Parse(lines);

            // assert
            AssertChangeset(expected, actual);
        }

        private static void AssertChangeset(GitDiffChangeset expected, GitDiffChangeset actual)
        {
            Assert.Equal(expected.Files.Count, actual.Files.Count);
            Assert.Equal(expected.Created.Count(), actual.Created.Count());
            Assert.Equal(expected.Deleted.Count(), actual.Deleted.Count());
            Assert.Equal(expected.Modified.Count(), actual.Modified.Count());
            Assert.Equal(expected.Renamed.Count(), actual.Renamed.Count());

            for (var i = 0; i < expected.Files.Count; i++)
            {
                AssertFile(expected.Files.ElementAt(i), actual.Files.ElementAt(i));
            }
        }

        private static void AssertFile(GitDiffFile expected, GitDiffFile actual)
        {
            Assert.Equal(expected.Created, actual.Created);
            Assert.Equal(expected.Deleted, actual.Deleted);
            Assert.Equal(expected.Modified, actual.Modified);
            Assert.Equal(expected.Renamed, actual.Renamed);
            Assert.Equal(expected.Source, actual.Source);
            Assert.Equal(expected.Destination, actual.Destination);
            Assert.Equal(expected.Operation, actual.Operation);

            Assert.Equal(expected.Hunks.Count, actual.Hunks.Count);

            for (var i = 0; i < expected.Hunks.Count; i++)
            {
                AssertHunk(expected.Hunks.ElementAt(i), actual.Hunks.ElementAt(i));
            }
        }

        private static void AssertHunk(GitDiffHunk expected, GitDiffHunk actual)
        {
            Assert.Equal(expected.Content, actual.Content);
            Assert.Equal(expected.From.Start, actual.From.Start);
            Assert.Equal(expected.From.Count, actual.From.Count);
            Assert.Equal(expected.To.Start, actual.To.Start);
            Assert.Equal(expected.To.Count, actual.To.Count);

            Assert.Equal(expected.Lines.Count, actual.Lines.Count);

            for (var i = 0; i < expected.Lines.Count; i++)
            {
                AssertLine(expected.Lines.ElementAt(i), actual.Lines.ElementAt(i));
            }
        }

        private static void AssertLine(GitDiffLine expected, GitDiffLine actual)
        {
            Assert.Equal(expected.Content, actual.Content);
            Assert.Equal(expected.From, actual.From);
            Assert.Equal(expected.To, actual.To);
            Assert.Equal(expected.Operation, actual.Operation);
        }
    }
}
