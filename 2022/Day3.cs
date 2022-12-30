namespace AoC2022
{
    class Day3
    {
        private string[] lines; 

        public Day3()
        {
            lines = File.ReadAllLines("Day3.txt");
        }

        public int sumCommonPriorities()
        {
            int sum = 0;
            foreach (string line in lines)
            {
                Rucksack curr = new Rucksack(line);
                sum += curr.getCommonItemPriority();
            }
            return sum;
        }

        public int sumGroupPriorities()
        {
            // divide lines into groups of 3
            int i = 0;
            var query = from line in lines
                        let num = i++
                        group line by num / 3 into groupOf3
                        select groupOf3.ToArray();
            var results = query.ToArray();

            int sum = 0;
            foreach (string[] groupOf3 in results)
            {
                string firstString = groupOf3[0];
                for (int ii = 0; ii < firstString.Length; ii++)
                {
                    char compareChar = firstString[ii];
                    if (groupOf3[1].Contains(compareChar) && groupOf3[2].Contains(compareChar))
                    {
                        if (Char.IsUpper(compareChar))
                        {
                            sum += (int)compareChar - 38;
                        } else
                        {
                            sum += (int)compareChar - 96;
                        }
                        break;
                    }
                }
            }
            return sum;
        }
    }

    class Rucksack
    {
        private string firstCompartment;
        private string secondCompartment;
        private char commonItem;

        public Rucksack(string inputLine)
        {
            int halfLength = inputLine.Length / 2;
            firstCompartment = inputLine.Substring(0, halfLength);
            secondCompartment = inputLine.Substring(halfLength);
            
            for (int ii = 0; ii < halfLength; ii++)
            {
                char compareChar = firstCompartment[ii];
                if (secondCompartment.Contains(compareChar))
                {
                    commonItem = compareChar;
                    break;
                }
            }
        }

        // return priority based off of difference from ASCII code
        public int getCommonItemPriority()
        {
            if (Char.IsUpper(commonItem))
            {
                return (int)commonItem - 38;
            } else
            {
                return (int)commonItem - 96;
            }
        }
    }
}