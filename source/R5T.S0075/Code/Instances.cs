using System;


namespace R5T.S0075
{
    public static class Instances
    {
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static O0018.ILocalGitRepositoryOperations LocalGitRepositoryOperations => O0018.LocalGitRepositoryOperations.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IPaths Paths => S0075.Paths.Instance;	
    }
}