namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int P1Point = 0;
        private int P2Point = 0;

        private string P1Result = "";
        private string P2Result = "";

        private string Player1Name;
        private string Player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.Player1Name = player1Name;
            this.Player2Name = player2Name;
        }

        public string GetScore()
        {
            var score = "";

            if (P1Point == P2Point) 
            {
                if (P1Point > 2)
                {
                    score = "Deuce";
                }
                else 
                {
                    if (P1Point == 0)
                        score = "Love";

                    if (P1Point == 1)
                        score = "Fifteen";

                    if (P1Point == 2)
                        score = "Thirty";

                    score += "-All";
                }
            }
            //-----------------------------------------

            if ((P1Point > 0) && (P2Point == 0))
            {
                if (P1Point == 1)
                    P1Result = "Fifteen";
                if (P1Point == 2)
                    P1Result = "Thirty";
                if (P1Point == 3)
                    P1Result = "Forty";

                P2Result = "Love";
                score = P1Result + "-" + P2Result;
            }
            //-----------------------------------------
            if ((P2Point > 0) && (P1Point == 0))
            {
                if (P2Point == 1)
                    P2Result = "Fifteen";
                if (P2Point == 2)
                    P2Result = "Thirty";
                if (P2Point == 3)
                    P2Result = "Forty";

                P1Result = "Love";
                score = P1Result + "-" + P2Result;
            }
            //-----------------------------------------
            if ((P1Point > P2Point) && (P1Point < 4))
            {
                if (P1Point == 2)
                    P1Result = "Thirty";
                if (P1Point == 3)
                    P1Result = "Forty";
                if (P2Point == 1)
                    P2Result = "Fifteen";
                if (P2Point == 2)
                    P2Result = "Thirty";
                score = P1Result + "-" + P2Result;
            }
            //-----------------------------------------
            if ((P2Point > P1Point) && (P2Point < 4))
            {
                if (P2Point == 2)
                    P2Result = "Thirty";
                if (P2Point == 3)
                    P2Result = "Forty";
                if (P1Point == 1)
                    P1Result = "Fifteen";
                if (P1Point == 2)
                    P1Result = "Thirty";
                score = P1Result + "-" + P2Result;
            }
            //-----------------------------------------
            if ((P1Point > P2Point) && (P2Point >= 3))
            {
                score = "Advantage player1";
            }
            //-----------------------------------------
            if ((P2Point > P1Point) && (P1Point >= 3))
            {
                score = "Advantage player2";
            }
            //-----------------------------------------
            if ((P1Point >= 4) && (P2Point >= 0) && ((P1Point - P2Point) >= 2))
            {
                score = "Win for player1";
            }
            //-----------------------------------------
            if ((P2Point >= 4) && (P1Point >= 0) && ((P2Point - P1Point) >= 2))
            {
                score = "Win for player2";
            }
            return score;
        }

        //public void SetP1Score(int number)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        P1Score();
        //    }
        //}

        //public void SetP2Score(int number)
        //{
        //    for (var i = 0; i < number; i++)
        //    {
        //        P2Score();
        //    }
        //}

        //private void P1Score()
        //{
        //    P1Point++;
        //}

        //private void P2Score()
        //{
        //    P2Point++;
        //}

        public void WonPoint(string player)
        {
            if (player == Player1Name)
                P1Point++;
            else
                P2Point++;
        }

    }
}

