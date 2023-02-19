﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianStateCensusAnalyzerProgram.POCO;


namespace IndianStateCensusAnalyzerProgram
{
    public class CSVAdapterFactory
    {
        public Dictionary<string,CensusDTO>LoadCsvData(CensusAnalyser.Country country,string csvFilePath,string dataHeaders)
        {
            switch(country) 
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath,dataHeaders);
                
                default:
                    throw new CensusAnalyserException("No Such Country", CensusAnalyserException.ExpectionType.NO_SUCH_COUNTRY);

            }
        }

    }
}
