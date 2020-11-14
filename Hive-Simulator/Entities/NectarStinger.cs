using Hive_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hive_Simulator.Entities
{
    public class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(string[] jobsICanDo, int weigth)
            :base(jobsICanDo, weigth)
        {
            this.jobsICanDo = jobsICanDo;
        }

        private string[] jobsICanDo;

        int stingerLength;
        int alertLevel;

        public int AlertLevel { get { return alertLevel; } }

        public int StingerLength { get { return stingerLength; } set { stingerLength = value; } }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public int SharpenStinger(int length)
        {
            throw new NotImplementedException();
        }

        public void FindFlowers()
        {
            throw new NotImplementedException();
        }

        public void GatherNectar()
        {
            throw new NotImplementedException();
        }        

        public void ReturnToHive()
        {
            throw new NotImplementedException();
        }

        
    }
}
