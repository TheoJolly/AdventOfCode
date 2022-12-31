namespace AoC2022
{
    class Day4
    {
        private string[] lines; 

        public Day4()
        {
            lines = File.ReadAllLines("Day4.txt");
        }

        public int countFullyContainedAssignments()
        {
            int count = 0;
            foreach (string line in lines)
            {
                string[] assignments = line.Split(',');
                string firstRange = assignments[0];
                string secondRange = assignments[1];

                string[] firstVals = firstRange.Split('-');
                string[] secondVals = secondRange.Split('-');

                if ((Int32.Parse(firstVals[0]) <= Int32.Parse(secondVals[0]) && Int32.Parse(firstVals[1]) >= Int32.Parse(secondVals[1]))
                || (Int32.Parse(secondVals[0]) <= Int32.Parse(firstVals[0]) && Int32.Parse(secondVals[1]) >= Int32.Parse(firstVals[1])))
                {
                    count++;
                }
            }
            return count;
        }

        public int countOverlappingAssignments()
        {
            int count = 0;
            foreach (string line in lines)
            {
                string[] assignments = line.Split(',');
                string firstRange = assignments[0];
                string secondRange = assignments[1];

                string[] firstVals = firstRange.Split('-');
                string[] secondVals = secondRange.Split('-');

                if ((Int32.Parse(secondVals[0]) >= Int32.Parse(firstVals[0]) && Int32.Parse(secondVals[0]) <= Int32.Parse(firstVals[1]))
                || (Int32.Parse(secondVals[1]) >= Int32.Parse(firstVals[0]) && Int32.Parse(secondVals[1]) <= Int32.Parse(firstVals[1]))
                || (Int32.Parse(firstVals[0]) >= Int32.Parse(secondVals[0]) && Int32.Parse(firstVals[0]) <= Int32.Parse(secondVals[1]))
                || (Int32.Parse(firstVals[1]) >= Int32.Parse(secondVals[0]) && Int32.Parse(firstVals[1]) <= Int32.Parse(secondVals[1])))
                {
                    count++;
                }
            }
            return count;
        }
    }
}