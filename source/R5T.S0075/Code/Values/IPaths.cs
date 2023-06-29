using System;

using R5T.T0131;


namespace R5T.S0075
{
    [ValuesMarker]
    public partial interface IPaths : IValuesMarker,
        Z0015.IFilePaths,
        Z0046.IDirectoryPaths,
        Z0046.IFilePaths
    {

    }
}
