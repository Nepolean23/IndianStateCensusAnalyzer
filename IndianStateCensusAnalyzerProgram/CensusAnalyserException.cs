using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProgram
{
    public class CensusAnalyserExpection : Exception
    {
        public enum ExpectionType
        {
            FILE_NOT_FOUND,INVALID_FILE_TYPE,INCORRECT_DELIMETER,INCORRECT_HEADER,NO_SUCH_COUNTRY
        }
        public ExpectionType etype;
        public CensusAnalyserExpection(string message,ExpectionType exceptionType):base (message)
        {
            this.etype = exceptionType;
        }

    }
}
