using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hud
{
    [Serializable]

    class Player
    {
        public int NumberOfHands, NumberOfMoneyPut, NumberOf3BetHands, NumberOf3BetFoldHands, NumberOf4BetHands, NumberOf4BetFoldHands, NumberOfCBetHands, NumberOfCBetFoldHands;
        public int NumberOfStealHands, NumberOfFoldToStealHands, NumberOfFlopSeenHands, NumberOfLimpHands;
        public int Bet3Bet, FoldTo3Bet;
        public int Bet4Bet, FoldTo4Bet;
        public int BetCBet, FoldToCBet;
        public int Steal, FoldToSteal;
        public int Limp;
        public int WTSD, WonSD;
        public int PreflopRaise, FlopRaise, TurnRaise, RiverRaise;
        public bool Fish;
        public bool MoneyInPot, PreflopR, PreflopAgr, Done3Bet, PossibleStealer, SawFlop; 

        public void SumUp()
        {
            if (MoneyInPot) NumberOfMoneyPut++;
            if (PreflopR) PreflopRaise++;
            if (SawFlop) NumberOfFlopSeenHands++;
            MoneyInPot = PreflopR = PreflopAgr = Done3Bet = PossibleStealer = SawFlop = false;
        }

        public string PlayerInfo()
        {
            string result = " (" + NumberOfHands + ") ";
            result += string.Format("\r\nVP:{0:F1}/PFR:{1:F1}", NumberOfMoneyPut * 100.0f / NumberOfHands,
                             PreflopRaise * 100.0f / NumberOfHands);

            result += string.Format("\r\n3B: {0:F1}/{1:F1}", Bet3Bet * 100.0f / NumberOf3BetHands,
                             FoldTo3Bet * 100.0f / NumberOf3BetFoldHands);

            result += string.Format("  4B: {0:F1}/{1:F1}", Bet4Bet * 100.0f / NumberOf4BetHands,
                             FoldTo4Bet * 100.0f / NumberOf4BetFoldHands);

            result += string.Format("\r\nATS:{0:F1}/{1:F1}", Steal * 100.0f / NumberOfStealHands,
                             FoldToSteal * 100.0f / NumberOfFoldToStealHands);

            result += string.Format("  CB: {0:F1}/{1:F1}", BetCBet * 100.0f / NumberOfCBetHands,
                             FoldToCBet * 100.0f / NumberOfCBetFoldHands);

            result += string.Format("\r\nWTSD: {0:F1}/{1:F1}", WTSD * 100.0f / NumberOfFlopSeenHands,
                             WonSD * 100.0f / WTSD);

            result += string.Format("  Limp: {0:F1}", Limp * 100.0f / NumberOfLimpHands);

            return result;
        }

    }
}
