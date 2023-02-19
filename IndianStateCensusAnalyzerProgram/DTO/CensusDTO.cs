using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProgram.POCO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string statecode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodedao)
        {
            this.serialNumber = stateCodedao.serialNumber;
            this.stateName= stateCodedao.stateName;
            this.tin= stateCodedao.tin;
            this.statecode= stateCodedao.stateCode;
        }

        public CensusDTO(CensusDataDAO censusDataDao)
        {
            this.state=censusDataDao.state;
            this.population=censusDataDao.population;
            this.area=censusDataDao.area;
            this.density=censusDataDao.density;
        }

       

    }
}
