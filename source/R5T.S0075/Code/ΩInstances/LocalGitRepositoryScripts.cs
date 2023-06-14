using System;


namespace R5T.S0075
{
    public class LocalGitRepositoryScripts : ILocalGitRepositoryScripts
    {
        #region Infrastructure

        public static ILocalGitRepositoryScripts Instance { get; } = new LocalGitRepositoryScripts();


        private LocalGitRepositoryScripts()
        {
        }

        #endregion
    }
}
