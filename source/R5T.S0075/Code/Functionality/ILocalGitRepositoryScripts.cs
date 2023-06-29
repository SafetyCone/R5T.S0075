using System;
using System.Linq;

using R5T.T0132;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.S0075
{
    [FunctionalityMarker]
    public partial interface ILocalGitRepositoryScripts : IFunctionalityMarker
    {
        public void Get_RepositoryUrl()
        {
            /// Inputs.
            var repositoryDirectoryPath =
                Instances.Paths.Example_RepositoryDirectoryPath
                ;


            /// Run.
            var repositoryUrl = Instances.LocalGitRepositoryOperations.Get_RepositoryUrl(repositoryDirectoryPath);

            Console.WriteLine($"{repositoryDirectoryPath}\n=>\n{repositoryUrl}");
        }

        /// <summary>
        /// Given a file or directory path in a repository, what is the repository's root directory path?
        /// </summary>
        public void Get_RepositoryDirectoryPath_ForPathInRepository()
        {
            /// Inputs.
            var pathsInRepositories = new IPath[]
            {
                Instances.Paths.Example_DirectoryWithinRepositoryDirectoryPath,
                Instances.Paths.Example_FileWithinRepositoryDirectoryPath
            };
            var outputTextFilePath =
                Paths.Instance.OutputTextFilePath
                ;


            /// Run.
            var repositoryDirectoryPathsByPath = pathsInRepositories
                .Select(path =>
                {
                    var repositoryDirectoryPath = Instances.LocalGitRepositoryOperations.Get_RepositoryDirectoryPath_ForPathInRepository(path);

                    return (path, repositoryDirectoryPath);
                })
                ;

            var lines = repositoryDirectoryPathsByPath
                .Select(pair => $"{pair.path}:\n => {pair.repositoryDirectoryPath}\n")
                ;

            Instances.NotepadPlusPlusOperator.WriteLinesAndOpen(
                outputTextFilePath,
                lines);
        }
    }
}
