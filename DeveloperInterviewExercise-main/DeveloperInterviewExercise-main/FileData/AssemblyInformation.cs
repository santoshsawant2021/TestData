using ThirdPartyTools;
using System;
using System.Linq;
namespace FileData
{
    public class AssemblyInformation : IAssemblyInformation
    {
        FileDetails objFileDetails = new FileDetails();

        public int Size(string _filePath)
        {
            try
            {
                if (AssemblyInfo.AsseblySize.Contains(_filePath))
                {
                    return objFileDetails.Size(_filePath);
                }
                else
                {
                    throw new InvalidArgumentException(_filePath);
                }
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public string Version(string[] args)
        {
            string _version = null;
            try
            {
                if (AssemblyInfo.AsseblyVersion.Contains(args[0]))
                {
                    if (args.Length == AssemblyInfo.ArgsSize)
                    {
                        _version = objFileDetails.Version(args[1]);
                    }
                    else
                    {
                        _version = objFileDetails.Version(args[0]);
                    }
                }
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _version;
        }
    }

}
