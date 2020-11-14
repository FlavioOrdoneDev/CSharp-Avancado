using System;

namespace Hive_Simulator
{
    public class Queen : Bee
    {
        public Queen(Worker[] workers)
            :base(275)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                totalConsumption += workers[i].GetHoneyConsuption();
            }
            totalConsumption += GetHoneyConsuption();

            shiftNumber++;
            string report = "Relatório para o turno #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Operária #" + (i + 1) + " terminou o trabalho\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Operária #" + (i + 1) + " não está trabalhando\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += "Operária #" + (i + 1) + " está fazendo '" + workers[i].CurrentJob + "' para " + workers[i].ShiftsLeft + " mais turnos\r\n";

                    }
                    else
                        report += "Operária #" + (i + 1) + " irá terminar '" + workers[i].CurrentJob + "' depois deste turno\r\n";                    
                }
            }

            report += "Consumo total de mel : " + totalConsumption + " unidades";

            return report;
        }

        public override double GetHoneyConsuption()
        {
            double Consumption = 0;
            double largestWorkConsumption = 0;
            int workersDoingJobs = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsuption() > largestWorkConsumption)
                    largestWorkConsumption = workers[i].GetHoneyConsuption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }
            Consumption += largestWorkConsumption;

            if (workersDoingJobs >= 3)
                Consumption += 30;
            else
                Consumption += 20;            

            return Consumption;
        }
    }
}
