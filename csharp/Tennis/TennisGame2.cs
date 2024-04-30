using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int Player1Point = 0;
        private int Player2Point = 0;

        private string Player1Result = "";
        private string Player2Result = "";

        private string Player1Name;
        private string Player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.Player1Name = player1Name;
            this.Player2Name = player2Name;
        }
        private void ScoreMoreAndZero(int player1point, int player2point, ref string score, ref string player1result, ref string player2result)
        {
            if ((player1point > 0) && (player2point == 0))
            {
                if (player1point == 1)
                    player1result = "Fifteen";
                if (player1point == 2)
                    player1result = "Thirty";
                if (player1point == 3)
                    player1result = "Forty";

                player2result = "Love";
                score = player1result + "-" + player2result;
            }
        }
        private void ScoreMoreAndLess4(int player1point, int player2point, ref string score, ref string player1result, ref string player2result)
        {
            if ((player1point > player2point) && (player1point < 4))
            {
                if (player1point == 2)
                    player1result = "Thirty";
                if (player1point == 3)
                    player1result = "Forty";
                if (player2point == 1)
                    player2result = "Fifteen";
                if (player2point == 2)
                    player2result = "Thirty";
                score = Player1Result + "-" + Player2Result;
            }
        }
        public string GetScore()
        {
            var score = "";

            if (Player1Point == Player2Point) 
            {
                if (Player1Point > 2)
                {
                    score = "Deuce";
                }
                else 
                {
                    if (Player1Point == 0)
                        score = "Love";

                    if (Player1Point == 1)
                        score = "Fifteen";

                    if (Player1Point == 2)
                        score = "Thirty";

                    score += "-All";
                }
            }
            ScoreMoreAndZero(Player1Point, Player2Point, ref  score, ref  Player1Result, ref  Player2Result);
            ScoreMoreAndZero(Player2Point, Player1Point, ref score, ref Player2Result, ref Player1Result);
            
            ScoreMoreAndLess4(Player1Point, Player2Point, ref score, ref Player1Result, ref Player2Result);
            ScoreMoreAndLess4(Player2Point, Player1Point, ref score, ref Player2Result, ref Player1Result);

            if ((Player1Point > Player2Point) && (Player2Point >= 3))
            {
                score = "Advantage player1";
            }
            if ((Player2Point > Player1Point) && (Player1Point >= 3))
            {
                score = "Advantage player2";
            }
            if ((Player1Point >= 4) && (Player2Point >= 0) && ((Player1Point - Player2Point) >= 2))
            {
                score = "Win for player1";
            }
            if ((Player2Point >= 4) && (Player1Point >= 0) && ((Player2Point - Player1Point) >= 2))
            {
                score = "Win for player2";
            }
            return score;
        }

        public void WonPoint(string player)
        {
            if (player == Player1Name)
                Player1Point++;
            else
                Player2Point++;
        }

    }
}

