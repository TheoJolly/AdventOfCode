namespace AoC2022
{
    class Day2
    {
        private string[] lines; 

        public Day2()
        {
            lines = File.ReadAllLines("Day2.txt");
        }

        public int GetRPSTournamentScore()
        {
            int total = 0;

            foreach (string line in lines)
            {
                string[] moves = line.Split(' ');
                string theirMove = moves[0];
                string myMove = moves[1];

                switch (myMove)
                {
                    case "X":
                        total += 1;
                        switch (theirMove)
                        {
                            case "A":
                                total += 3;
                                break;
                            case "B":
                                break; // lost = 0
                            case "C":
                                total += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Y":
                        total += 2;
                        switch (theirMove)
                        {
                            case "A":
                                total += 6;
                                break;
                            case "B":
                                total += 3;
                                break;
                            case "C":
                                break; // lost = 0
                            default:
                                break;
                        }
                        break;
                    case "Z":
                        total += 3;
                        switch (theirMove)
                        {
                            case "A":
                                break; // lost = 0
                            case "B":
                                total += 6;
                                break;
                            case "C":
                                total += 3;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            return total;
        }

        public int GetRPSTournamentScore_new()
        {
            int total = 0;

            foreach (string line in lines)
            {
                string[] moves = line.Split(' ');
                string theirMove = moves[0];
                string outcome = moves[1];

                switch (outcome)
                {
                    case "X": // lose : +0
                        switch (theirMove)
                        {
                            case "A":
                                total += 3; // scissors
                                break;
                            case "B":
                                total += 1; // rock
                                break;
                            case "C":
                                total += 2; // paper
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Y": // draw : +3
                        total += 3;
                        switch (theirMove)
                        {
                            case "A":
                                total += 1; // rock
                                break;
                            case "B":
                                total += 2; // paper
                                break;
                            case "C":
                                total += 3; // scissors
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Z": // win : +6
                        total += 6;
                        switch (theirMove)
                        {
                            case "A":
                                total += 2; // paper
                                break;
                            case "B":
                                total += 3; // scissors
                                break;
                            case "C":
                                total += 1; // rock
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            return total;
        }
    }
}