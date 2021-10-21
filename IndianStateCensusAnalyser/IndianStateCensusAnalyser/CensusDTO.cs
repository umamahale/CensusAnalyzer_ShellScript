using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser.DTO
{
    class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int Pin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnit;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;
        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.Pin = stateCodeDao.Pin;
            this.stateCode = stateCodeDao.stateCode;
        }
        public CensusDTO(CensusDataDAO censusDataDao)
        {
            this.state = censusDataDao.state;
            this.population = censusDataDao.population;
            this.area = censusDataDao.area;
            this.density = censusDataDao.density;

        }
        public CensusDTO(USCensusDAO usCensusDao)
        {
            this.stateCode = usCensusDao.stateId;
            this.stateName = usCensusDao.stateName;
            this.population = usCensusDao.population;
            this.housingUnit = usCensusDao.housingUnit;
            this.totalArea = usCensusDao.totalArea;
            this.waterArea = usCensusDao.waterArea;
            this.landArea = usCensusDao.landArea;
        }

    }
}
