using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndianStateCensusAnalyzerProgram
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilePath,string dataHeaders)
        {
            string[] censusData;
            if(!File .Exists(csvFilePath)) 
            {
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.ExpectionType.FILE_NOT_FOUND);
            }
            if(Path.GetExtension(csvFilePath)!=".csv")
            {
                throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExpectionType.INVALID_FILE_TYPE);
            }
            censusData=File.ReadAllLines(csvFilePath);
            if (censusData[0]!=dataHeaders) 
            {
                throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.ExpectionType.INCORRECT_HEADER);
            }
            return censusData;

        }
    }
}
