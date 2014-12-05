using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame_v1
{
    class Players       // Klass för att lägga till element i listan, enbar vissa properteis från Form2 ska användas.
    {
        private string playerScoreList { get; set; }
        private string playerNameList { get; set; }
        private bool playerIsAIList { get; set; }
        private bool playerIsTurnList { get; set; }

        public Players(string player1ScoreList, string player1NameList, bool player1AILst, bool playerIsTurnList)
        {
            this.playerScoreList = player1ScoreList;
            this.playerNameList = player1NameList;
            this.playerIsAIList = player1AILst;
            this.playerIsTurnList = playerIsTurnList;
        }

    }

}
