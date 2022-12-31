namespace AoC2022
{
    class Day5
    {
        private string[] lines; 

        public Day5()
        {
            lines = File.ReadAllLines("Day5.txt");
        }

        public List<LinkedList<string>> moveCrates()
        {
            List<LinkedList<string>> crates = new List<LinkedList<string>>();
            for (int ii = 0; ii < 9; ii++)
            {
                crates.Add(new LinkedList<string>());
            }

            // ADDS EMPTY TO LIST
            foreach (string line in lines[..8])
            {
                // 35 chars per string, 3-1-3-1-...-3
                if (line.Substring(0,3) != "   ")
                {
                    crates[0].AddLast(line.Substring(0,3));
                }

                if (line.Substring(4,3) != "   ")
                {
                    crates[1].AddLast(line.Substring(4,3));
                }

                if (line.Substring(8,3) != "   ")
                {
                    crates[2].AddLast(line.Substring(8,3));
                }

                if (line.Substring(12,3) != "   ")
                {
                    crates[3].AddLast(line.Substring(12,3));
                }

                if (line.Substring(16,3) != "   ")
                {
                    crates[4].AddLast(line.Substring(16,3));
                }

                if (line.Substring(20,3) != "   ")
                {
                    crates[5].AddLast(line.Substring(20,3));
                }

                if (line.Substring(24,3) != "   ")
                {
                    crates[6].AddLast(line.Substring(24,3));
                }

                if (line.Substring(28,3) != "   ")
                {
                    crates[7].AddLast(line.Substring(28,3));
                }

                if (line.Substring(32,3) != "   ")
                {
                    crates[8].AddLast(line.Substring(32,3));
                }
            }

            foreach (string line in lines[10..lines.Length])
            {
                int amt = Int32.Parse(line.Split("move ")[1].Split(" from")[0]);
                int from = Int32.Parse(line.Split("from ")[1].Split(" to")[0]) - 1;
                int to = Int32.Parse(line.Split("to ")[1]) - 1;

                for (int ii = 0; ii < amt; ii++)
                {
                    crates[to].AddFirst(crates[from].ElementAt(0));
                    crates[from].RemoveFirst();
                }
            }

            return crates;
        }

        public List<LinkedList<string>> moveCrates_9001()
        {
            List<LinkedList<string>> crates = new List<LinkedList<string>>();
            for (int ii = 0; ii < 9; ii++)
            {
                crates.Add(new LinkedList<string>());
            }

            foreach (string line in lines[..8])
            {
                // 35 chars per string, 3-1-3-1-...-3
                if (line.Substring(0,3) != "   ")
                {
                    crates[0].AddLast(line.Substring(0,3));
                }

                if (line.Substring(4,3) != "   ")
                {
                    crates[1].AddLast(line.Substring(4,3));
                }

                if (line.Substring(8,3) != "   ")
                {
                    crates[2].AddLast(line.Substring(8,3));
                }

                if (line.Substring(12,3) != "   ")
                {
                    crates[3].AddLast(line.Substring(12,3));
                }

                if (line.Substring(16,3) != "   ")
                {
                    crates[4].AddLast(line.Substring(16,3));
                }

                if (line.Substring(20,3) != "   ")
                {
                    crates[5].AddLast(line.Substring(20,3));
                }

                if (line.Substring(24,3) != "   ")
                {
                    crates[6].AddLast(line.Substring(24,3));
                }

                if (line.Substring(28,3) != "   ")
                {
                    crates[7].AddLast(line.Substring(28,3));
                }

                if (line.Substring(32,3) != "   ")
                {
                    crates[8].AddLast(line.Substring(32,3));
                }
            }

            foreach (string line in lines[10..lines.Length])
            {
                int amt = Int32.Parse(line.Split("move ")[1].Split(" from")[0]);
                int from = Int32.Parse(line.Split("from ")[1].Split(" to")[0]) - 1;
                int to = Int32.Parse(line.Split("to ")[1]) - 1;

                List<string> toMove = new List<string>();
                for (int ii = 0; ii < amt; ii++)
                {
                    toMove.Add(crates[from].ElementAt(0)); // ABC -> toMove = ABC
                    crates[from].RemoveFirst();
                }
                // toMove : before should be ABC -> CBA; now ABC -> ABC
                for (int ii = toMove.Count - 1; ii >= 0; ii--)
                {
                    crates[to].AddFirst(toMove[ii]);
                }
            }

            return crates;
        }
    }
}