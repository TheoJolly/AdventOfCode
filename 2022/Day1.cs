using System.Collections;

namespace AoC2022
{
    class Day1
    {
        private string[] lines; 

        public Day1()
        {
            lines = File.ReadAllLines("Day1.txt");
        }

        public int GetMaxElfCalorieCount()
        {
            int max = -1;
            int singleElfTotal = 0;

            foreach (string line in lines)
            {
                if (line == "")
                {
                    if (singleElfTotal > max)
                    {
                        max = singleElfTotal;
                    }
                    singleElfTotal = 0;
                } else
                {
                    singleElfTotal += Int32.Parse(line);
                }
            }
            return max;
        }

        public int GetTopThreeElvesCalorieCountsTotal()
        {
            ArrayList elfCalorieCountTotals = new ArrayList();
            int singleElfTotal = 0;

            foreach (string line in lines)
            {
                if (line == "")
                {
                    elfCalorieCountTotals.Add(singleElfTotal);
                    singleElfTotal = 0;
                } else
                {
                    singleElfTotal += Int32.Parse(line);
                }
            }
            
            elfCalorieCountTotals.Sort();
            elfCalorieCountTotals.Reverse();
            return (int)elfCalorieCountTotals[0] + (int)elfCalorieCountTotals[1] + (int)elfCalorieCountTotals[2];
        }
    }
}