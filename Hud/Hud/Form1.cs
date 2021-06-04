using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using Hud.Properties;

namespace Hud
{
    public partial class Form1 : Form
    {
        //Process[] processes = Process.GetProcessesByName("PokerStars");
        //List<string> pokerRooms = new List<string>();
        private Dictionary<string, Player> playerDictionary = new Dictionary<string, Player>();
        private Dictionary<int, TextBox> seatDictionaryTable1 = new Dictionary<int, TextBox>();
        private Dictionary<int, TextBox> seatDictionaryTable2 = new Dictionary<int, TextBox>();
        private Dictionary<int, TextBox> seatDictionaryTable3 = new Dictionary<int, TextBox>();
        private Dictionary<int, TextBox> seatDictionaryTable4 = new Dictionary<int, TextBox>();
        private Dictionary<int, Dictionary<int, TextBox>> seatsDictionary = new Dictionary<int, Dictionary<int, TextBox>>();
        private Dictionary<int, TextBox> tempDictionary1 = new Dictionary<int, TextBox>();
        private Dictionary<int, TextBox> tempDictionary2 = new Dictionary<int, TextBox>();
        private Dictionary<int, TextBox> tempDictionary3 = new Dictionary<int, TextBox>();
        private Dictionary<int, TextBox> tempDictionary4 = new Dictionary<int, TextBox>();
        private Dictionary<int, Dictionary<int, TextBox>> tempsDictionary = new Dictionary<int, Dictionary<int, TextBox>>();
        private static Color colorTextBox = new Color();
        private Button[] saveButtons = new Button[4];
        private TextBox[] seats1 = new TextBox[4];
        private FileSystemWatcher fileWatcher = new FileSystemWatcher();
        private string filePath;
        private string dataFilePath = "";
        private string hudPath = "";
        private string fileWatcherPath = "";
        private string mainPlayerName = "";
        private bool fileChanged = false;
        private static string dataFile = @"\playerstest.dat";
        private bool[] tablesFree = new bool[] { true, true, true, true };
        private bool[] tableSorted = new bool[] { false, false, false, false };
        private Label[] tableNames = new Label[4];

        private PlayerInfoForm table1seat2, table1seat3, table1seat4, table1seat5, table1seat6;
        private PlayerInfoForm table2seat2, table2seat3, table2seat4, table2seat5, table2seat6;
        private PlayerInfoForm table3seat2, table3seat3, table3seat4, table3seat5, table3seat6;
        private PlayerInfoForm table4seat2, table4seat3, table4seat4, table4seat5, table4seat6;


        public Form1()
        {
            InitializeComponent();

            fileWatcher.Path = fileWatcherPath = Settings.Default.HandsHistoryPath;
            hudPath = Settings.Default.DataFilePath;
            dataFilePath = hudPath + dataFile;
            mainPlayerNickname.Text = playerName.Text = mainPlayerName = Settings.Default.MainPlayerName;

            colorTextBox = seat1Table1.BackColor;
            tableNames[0] = table1Name;
            tableNames[1] = table2Name;
            tableNames[2] = table3Name;
            tableNames[3] = table4Name;
            seats1[0] = seat1Table1;
            seats1[1] = seat1Table2;
            seats1[2] = seat1Table3;
            seats1[3] = seat1Table4;
            saveButtons[0] = saveTable1;
            saveButtons[1] = saveTable2;
            saveButtons[2] = saveTable3;
            saveButtons[3] = saveTable4;
            seatDictionaryTable1.Add(1, seat1Table1);
            seatDictionaryTable1.Add(2, seat2Table1);
            seatDictionaryTable1.Add(3, seat3Table1);
            seatDictionaryTable1.Add(4, seat4Table1);
            seatDictionaryTable1.Add(5, seat5Table1);
            seatDictionaryTable1.Add(6, seat6Table1);

            seatDictionaryTable2.Add(1, seat1Table2);
            seatDictionaryTable2.Add(2, seat2Table2);
            seatDictionaryTable2.Add(3, seat3Table2);
            seatDictionaryTable2.Add(4, seat4Table2);
            seatDictionaryTable2.Add(5, seat5Table2);
            seatDictionaryTable2.Add(6, seat6Table2);

            seatDictionaryTable3.Add(1, seat1Table3);
            seatDictionaryTable3.Add(2, seat2Table3);
            seatDictionaryTable3.Add(3, seat3Table3);
            seatDictionaryTable3.Add(4, seat4Table3);
            seatDictionaryTable3.Add(5, seat5Table3);
            seatDictionaryTable3.Add(6, seat6Table3);

            seatDictionaryTable4.Add(1, seat1Table4);
            seatDictionaryTable4.Add(2, seat2Table4);
            seatDictionaryTable4.Add(3, seat3Table4);
            seatDictionaryTable4.Add(4, seat4Table4);
            seatDictionaryTable4.Add(5, seat5Table4);
            seatDictionaryTable4.Add(6, seat6Table4);

            seatsDictionary.Add(1, seatDictionaryTable1);
            seatsDictionary.Add(2, seatDictionaryTable2);
            seatsDictionary.Add(3, seatDictionaryTable3);
            seatsDictionary.Add(4, seatDictionaryTable4);

            tempDictionary1 = seatsDictionary[1].ToDictionary(entry => entry.Key, entry => entry.Value);
            tempDictionary2 = seatsDictionary[2].ToDictionary(entry => entry.Key, entry => entry.Value);
            tempDictionary3 = seatsDictionary[3].ToDictionary(entry => entry.Key, entry => entry.Value);
            tempDictionary4 = seatsDictionary[4].ToDictionary(entry => entry.Key, entry => entry.Value);
            tempsDictionary.Add(1, tempDictionary1);
            tempsDictionary.Add(2, tempDictionary2);
            tempsDictionary.Add(3, tempDictionary3);
            tempsDictionary.Add(4, tempDictionary4);

            if (!string.IsNullOrEmpty(fileWatcherPath))
            {
                fileWatcher.Changed += FileSystemWatcher_Changed;
                fileWatcher.EnableRaisingEvents = true;
            }
            if (!string.IsNullOrEmpty(hudPath))
                OpenDataFile();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(fileChanged)
            {
                List<string> result = new List<string>();
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (sr.Peek() >= 0)
                        {
                            result.Add(sr.ReadLine());
                        }
                    }

                    result.Reverse();
                    result.RemoveAt(0);
                    result.RemoveAt(0);
                    result.RemoveAt(0);

                    int i = 0;
                    foreach (string line in result)
                    {
                        if (String.IsNullOrEmpty(line))
                            break;
                        i++;
                    }
                    result.RemoveRange(i, result.Count - i);
                    result.Reverse();
                    AnalyzeHands(result, true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                fileChanged = false;
            }
        }

        private void AnalyzeAllButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        List<string> result = new List<string>();

                        using (StreamReader sr = new StreamReader(file))
                        {
                            while (sr.Peek() >= 0)
                            {
                                result.Add(sr.ReadLine());
                            }
                        }
                        AnalyzeHands(result, false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + file);
                    }
                }
                MessageBox.Show("Zakończyłem analizę wszystkich plików", "Koniec");
            }
        }

        private void AnalyzeHands(List<string> result, bool oneHand)
        {
            int lineNumber = 0, tableLineNumber = 0, buttonLineNumber = 0;
            int streetNumber = 0;
            int callCount = 0, raiseCount = 0, betCount = 0;
            int button = 0;
            bool cBet = false, attemptToSteal = false;
            int tableToUse = -1;
            bool anyTableFree = true;
            Dictionary<int, string> newPlayers = new Dictionary<int, string>();
            if (oneHand)
            {
                //result.RemoveAt(0); //usuwanie pierwszej linijki
                string tableName = result[1].Substring(7, result[1].IndexOf("'", 7) - 7);
                int x = 0;
                bool tableAlreadyOpen = true;
                while (tableToUse == -1)
                {
                    if (x == 4)
                    {
                        if (!tablesFree.Contains(true))
                        {
                            fileChanged = false;
                            anyTableFree = false;
                            MessageBox.Show("Brak wolnych stołów!", "Otwarto za dużo stołów.");
                            break;
                        }
                            
                        tableAlreadyOpen = false;
                        x = 0;
                    }

                    if (tableNames[x].Text == tableName && tableAlreadyOpen == true)
                    {
                        tableToUse = x + 1;
                    }
                    else if (tableNames[x].Text.Contains("Table") && tableAlreadyOpen == false)
                    {
                        tableToUse = x + 1;
                    }
                    x++;
                }
                if (!anyTableFree)
                    return;
                tablesFree[tableToUse - 1] = false;
                tableNames[tableToUse - 1].Text = tableName;
                //result.RemoveAt(0); //usuwanie linjiki z nazwą stołu i buttonem
            }



            foreach (string line in result)
            {
                if (string.IsNullOrEmpty(line))
                    streetNumber = 0;

                else if (oneHand && line.Contains(" joins the "))
                {
                    if (newPlayers.ContainsKey((int)line[line.Length - 2] - '0'))
                        newPlayers.Remove((int)line[line.Length - 2] - '0');
                    newPlayers.Add((int)line[line.Length - 2] - '0', line.Substring(0, line.IndexOf(" joins ")));
                }
                    

                else
                {
                    if (line.Substring(0, 4) == "*** ")
                    {

                        if (line == "*** SUMMARY ***")
                            streetNumber = 10;
                        else
                            streetNumber++;
                        callCount = raiseCount = betCount = button = 0;
                        cBet = attemptToSteal = false;
                    }

                    else
                    {
                        string name = "";
                        switch (streetNumber)
                        {
                            case 0:
                                if (oneHand)
                                {

                                    if (line.Contains(": " + mainPlayerName + " ("))
                                    {
                                        Int32.TryParse(line[5].ToString(), out int seatNumber);
                                        if (tableSorted[tableToUse - 1] == false)
                                        {
                                            for (int n = 1; n <= 6; n++)
                                            {
                                                int tempNumber = n + seatNumber - 1;
                                                if (tempNumber > 6)
                                                    tempNumber = tempNumber - 6;
                                                seatsDictionary[tableToUse][tempNumber] = tempsDictionary[tableToUse][n];
                                            }
                                            tableSorted[tableToUse - 1] = true;
                                        }
                                        saveButtons[tableToUse - 1].Visible = true;
                                        string path = hudPath + @"\table" + tableToUse + ".txt";
                                        using (StreamWriter sw = new StreamWriter(path))
                                        {
                                            foreach (String tempLine in result)
                                            {
                                                sw.WriteLine(tempLine);
                                            }
                                        }
                                    }
                                }
                                if (line.Substring(0, 6) == "Table ")
                                {
                                    button = (int)line[line.IndexOf("#") + 1] - 48;
                                    tableLineNumber = lineNumber;
                                }

                                else if (line.Substring(0, 5) == "Seat ")
                                {
                                    name = line.Substring(8, line.IndexOf(" ($") - 8);
                                    if (!playerDictionary.ContainsKey(name))
                                        playerDictionary.Add(name, new Player());
                                    if ((int)line[5] - 48 == button)
                                        buttonLineNumber = lineNumber;
                                }

                                else if(line.Contains(" small blind "))
                                {
                                    string nametem = result[buttonLineNumber].Substring(8, result[buttonLineNumber].IndexOf(" ($") - 8);
                                    playerDictionary[result[buttonLineNumber].Substring(8, result[buttonLineNumber].IndexOf(" ($") - 8)].PossibleStealer = true;
                                    if (result[buttonLineNumber + 1].Substring(0, 5) == "Seat ")
                                    {
                                        playerDictionary[result[buttonLineNumber + 1].Substring(8, result[buttonLineNumber + 1].IndexOf(" ($") - 8)].PossibleStealer = true;
                                    }
                                    else
                                        playerDictionary[result[tableLineNumber + 1].Substring(8, result[tableLineNumber + 1].IndexOf(" ($") - 8)].PossibleStealer = true;

                                    if (result[buttonLineNumber - 1].Substring(0, 5) == "Seat ")
                                        playerDictionary[result[buttonLineNumber - 1].Substring(8, result[buttonLineNumber - 1].IndexOf(" ($") - 8)].PossibleStealer = true;
                                    else
                                    {
                                        for (int i = 6; i > 1; i--)
                                        {
                                            if (result[tableLineNumber + i].Substring(0, 5) == "Seat")
                                            {
                                                playerDictionary[result[tableLineNumber + i].Substring(8, result[tableLineNumber + i].IndexOf(" ($") - 8)].PossibleStealer = true;
                                                break;
                                            }
                                        }
                                    }
                                }

                                break;
                            case 1:
                                if (line.Contains(": ") || line.Contains("Uncalled bet "))
                                {
                                    if (line.Contains("Uncalled bet "))
                                        name = line.Substring(33, line.Length - 33);
                                    else
                                        name = line.Substring(0, line.IndexOf(":"));
                                    if (!playerDictionary.ContainsKey(name))
                                        playerDictionary.Add(name, new Player());
                                    if (line.Contains(" folds"))
                                    {
                                        if (raiseCount == 0)
                                        {
                                            playerDictionary[name].NumberOfLimpHands++;
                                            if(playerDictionary[name].PossibleStealer)
                                                playerDictionary[name].NumberOfStealHands++;
                                        }

                                        else if (raiseCount == 1)
                                        {
                                            if (attemptToSteal)
                                            {
                                                playerDictionary[name].NumberOfFoldToStealHands++;
                                                playerDictionary[name].FoldToSteal++;
                                            }
                                            playerDictionary[name].NumberOf3BetHands++;
                                        }

                                        else if (raiseCount == 2)
                                        {
                                            if (playerDictionary[name].MoneyInPot)
                                            {
                                                playerDictionary[name].NumberOf3BetFoldHands++;
                                                playerDictionary[name].NumberOf4BetHands++;
                                                playerDictionary[name].FoldTo3Bet++;
                                            }
                                        }

                                        else if (raiseCount == 3)
                                        {
                                            if (playerDictionary[name].Done3Bet)
                                            {
                                                playerDictionary[name].FoldTo4Bet++;
                                                playerDictionary[name].NumberOf4BetFoldHands++;
                                            }
                                        }
                                    }

                                    else if (line.Contains(" raises "))
                                    {
                                        raiseCount++;
                                        if(raiseCount == 0)
                                            playerDictionary[name].NumberOfLimpHands++;
                                        if (raiseCount == 1 && playerDictionary[name].PossibleStealer)
                                        {
                                            playerDictionary[name].NumberOfStealHands++;
                                            playerDictionary[name].Steal++;
                                            attemptToSteal = true;
                                        }
                                        else if (raiseCount == 2)
                                        {
                                            if (attemptToSteal)
                                            {
                                                playerDictionary[name].NumberOfFoldToStealHands++;
                                                attemptToSteal = false;
                                            }
                                            playerDictionary[name].Bet3Bet++;
                                            playerDictionary[name].NumberOf3BetHands++;
                                            playerDictionary[name].Done3Bet = true;
                                        }
                                        else if (raiseCount == 3)
                                        {
                                            playerDictionary[name].Bet4Bet++;
                                            playerDictionary[name].NumberOf4BetHands++;
                                            playerDictionary[name].NumberOf3BetFoldHands++;
                                        }
                                        else if (raiseCount == 4)
                                        {
                                            playerDictionary[name].NumberOf4BetFoldHands++;
                                        }
                                        callCount = 0;
                                        playerDictionary[name].PreflopAgr = true;
                                        playerDictionary[name].PreflopR = true;
                                        playerDictionary[name].MoneyInPot = true;
                                    }

                                    else if (line.Contains(" calls "))
                                    {
                                        if(raiseCount == 0)
                                        {
                                            playerDictionary[name].Limp++;
                                            playerDictionary[name].NumberOfLimpHands++;
                                        }
                                        if (raiseCount == 1)
                                        {
                                            if (attemptToSteal)
                                            {
                                                playerDictionary[name].NumberOfFoldToStealHands++;
                                            }
                                            playerDictionary[name].NumberOf3BetHands++;
                                        }

                                        else if (raiseCount == 2)
                                        {
                                            playerDictionary[name].NumberOf4BetHands++;
                                            playerDictionary[name].NumberOf3BetFoldHands++;
                                        }
                                        else if (raiseCount == 3)
                                            playerDictionary[name].NumberOf4BetFoldHands++;
                                        callCount++;
                                        playerDictionary[name].MoneyInPot = true;
                                        playerDictionary[name].PreflopAgr = false;
                                    }
                                }
                                break;

                            case 2:
                                if (line.Contains(": "))
                                {
                                    name = line.Substring(0, line.IndexOf(":"));
                                    playerDictionary[name].SawFlop = true;
                                    if (line.Contains(" folds"))
                                    {
                                        if (betCount == 1 && cBet)
                                        {
                                            if (!playerDictionary[name].PreflopAgr)
                                            {
                                                playerDictionary[name].NumberOfCBetFoldHands++;
                                                playerDictionary[name].FoldToCBet++;
                                            }
                                        }
                                    }

                                    else if (line.Contains(" bets "))
                                    {
                                        if (playerDictionary[name].PreflopAgr)
                                        {
                                            playerDictionary[name].NumberOfCBetHands++;
                                            playerDictionary[name].BetCBet++;
                                            cBet = true;
                                        }
                                        betCount++;
                                    }

                                    else if (line.Contains(" checks"))
                                    {
                                        if (playerDictionary[name].PreflopAgr && raiseCount == 0)
                                            playerDictionary[name].NumberOfCBetHands++;
                                    }

                                    else if (line.Contains(" raises "))
                                    {
                                        raiseCount++;
                                        if (betCount == 1 && cBet)
                                        {
                                            if (!playerDictionary[name].PreflopAgr)
                                            {
                                                playerDictionary[name].NumberOfCBetFoldHands++;
                                            }
                                        }
                                        playerDictionary[name].FlopRaise++;
                                    }

                                    else if (line.Contains(" calls "))
                                    {
                                        if (betCount == 1 && cBet)
                                        {
                                            if (!playerDictionary[name].PreflopAgr)
                                            {
                                                playerDictionary[name].NumberOfCBetFoldHands++;
                                            }
                                        }
                                        callCount++;
                                    }
                                }
                                break;

                            case 3:
                                if (line.Contains(": "))
                                {
                                    name = line.Substring(0, line.IndexOf(":"));
                                    if (line.Contains(" folds"))
                                    {

                                    }

                                    else if (line.Contains(" checks"))
                                    {
                                    }

                                    else if (line.Contains(" raises "))
                                    {
                                        raiseCount++;
                                    }

                                    else if (line.Contains(" calls "))
                                    {
                                        callCount++;
                                    }

                                    else if (line.Contains(" bets "))
                                    {
                                        betCount++;
                                    }
                                }
                                break;

                            case 10:
                                if (line.Contains(": "))
                                {
                                    name = line.Substring(8, line.Substring(8, 16).IndexOf(" "));
                                    if (!playerDictionary.ContainsKey(name))
                                    {
                                        if (line.Contains(" (button) "))
                                            name = line.Substring(8, line.IndexOf(" (button) ") - 8);
                                        else if (line.Contains(" (small blind) "))
                                            name = line.Substring(8, line.IndexOf(" (small blind) ") - 8);
                                        else if (line.Contains(" (big blind) "))
                                            name = line.Substring(8, line.IndexOf(" (big blind) ") - 8);
                                        else if (line.Contains(" folded "))
                                            name = line.Substring(8, line.IndexOf(" folded ") - 8);
                                        else if (line.Contains(" collected "))
                                            name = line.Substring(8, line.IndexOf(" collected ") - 8);
                                        else if (line.Contains(" showed "))
                                            name = line.Substring(8, line.IndexOf(" showed ") - 8);
                                        else if (line.Contains(" mucked "))
                                            name = line.Substring(8, line.IndexOf(" mucked ") - 8);
                                    }
                                    if (line.Contains(" mucked ") || line.Contains(" showed "))
                                    {
                                        if (line.Contains(" won ("))
                                            playerDictionary[name].WonSD++;
                                        playerDictionary[name].WTSD++;
                                    }
                                        
                                    playerDictionary[name].NumberOfHands++;
                                    playerDictionary[name].SumUp();
                                    if (oneHand)
                                    {
                                        int seat = Int32.Parse(line.Substring(5, 1));
                                        seatsDictionary[tableToUse][seat].Text = name;
                                        if (playerDictionary.ContainsKey(name))
                                        {
                                            if (playerDictionary[name].Fish)
                                                seatsDictionary[tableToUse][seat].BackColor = Color.DarkGreen;
                                            else
                                                seatsDictionary[tableToUse][seat].BackColor = colorTextBox;
                                            seatsDictionary[tableToUse][seat].Text = name + playerDictionary[name].PlayerInfo();
                                        }
                                    }
                                }
                                else if (line.Substring(0, 5) == "Total" && oneHand)
                                {
                                    for (int y = 1; y <= 6; y++)
                                    {
                                        seatsDictionary[tableToUse][y].Text = "";
                                        seatsDictionary[tableToUse][y].BackColor = colorTextBox;
                                    }
                                }
                                break;
                        }
                    }
                }
                lineNumber++;
            }
            foreach(int value in newPlayers.Keys)
            {
                if (!playerDictionary.ContainsKey(newPlayers[value]))
                    playerDictionary.Add(newPlayers[value], new Player());
                if (playerDictionary[newPlayers[value]].Fish)
                    seatsDictionary[tableToUse][value].BackColor = Color.DarkGreen;
                else
                    seatsDictionary[tableToUse][value].BackColor = colorTextBox;
                seatsDictionary[tableToUse][value].Text = newPlayers[value] + playerDictionary[newPlayers[value]].PlayerInfo();
            }
        }

        private void ClearTableClick(object sender, EventArgs e)
        {
            int tableNumber = (int)(sender as Button).Name[10] - 48;
            for (int i = 1; i <= 6; i++)
            {
                seatsDictionary[tableNumber][i] = tempsDictionary[tableNumber][i];
                seatsDictionary[tableNumber][i].Text = "";
                seatsDictionary[tableNumber][i].BackColor = colorTextBox;
            }
            tableSorted[tableNumber - 1] = false;
            tableNames[tableNumber - 1].Text = "Table " + tableNumber;
            tablesFree[tableNumber - 1] = true;
            saveButtons[tableNumber - 1].Visible = false;
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            string name = playerName.Text;
            playerStats.Text = "";
            if (!string.IsNullOrEmpty(name))
            {
                if (playerDictionary.ContainsKey(name))
                {
                    if (playerDictionary[name].Fish)
                        playerStats.BackColor = Color.DarkGreen;
                    else
                        playerStats.BackColor = colorTextBox;
                    playerStats.Text = name + playerDictionary[name].PlayerInfo();
                }
            }
        }


        private void SaveLastHand(object sender, EventArgs e)
        {
            int tableNumber = (int)(sender as Button).Name[9] - 48;
            string pathToRead = hudPath + @"\table" + tableNumber + ".txt";

            string lastHandsPath = hudPath + @"\lastHands" + DateTime.Today.ToString("d") + ".txt";
            try
            {
                using (StreamWriter sw = File.AppendText(lastHandsPath))
                using (StreamReader sr = new StreamReader(pathToRead))
                {
                    while (sr.Peek() >= 0)
                    {
                        sw.WriteLine(sr.ReadLine());
                    }
                    sw.WriteLine("\n");
                    for (int i = 1; i <= 6; i++)
                    {
                        if (!string.IsNullOrEmpty(seatsDictionary[tableNumber][i].Text))
                            sw.WriteLine(seatsDictionary[tableNumber][i].Text.Replace("\n", " "));
                    }
                    sw.WriteLine("\r\n");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            saveButtons[tableNumber - 1].Visible = false;
        }

        private void PlayerFishChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                if ((sender as TextBox).BackColor != Color.DarkGreen)
                {
                    (sender as TextBox).BackColor = Color.DarkGreen;
                    playerDictionary[(sender as TextBox).Text.Substring(0, (sender as TextBox).Text.IndexOf(" ("))].Fish = true;
                }

                else
                {
                    (sender as TextBox).BackColor = colorTextBox;
                    playerDictionary[(sender as TextBox).Text.Substring(0, (sender as TextBox).Text.IndexOf(" ("))].Fish = false;
                }
            }
        }

        private void SetupNickButton_Click(object sender, EventArgs e)
        {
            mainPlayerName = Settings.Default.MainPlayerName = mainPlayerNickname.Text;
            MessageBox.Show("Nick został zmieniony.", "Zmieniono");
        }

        private void HistoryPathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileWatcher.Path = fileWatcherPath = Settings.Default.HandsHistoryPath = folderBrowserDialog1.SelectedPath;
                fileWatcher.Changed += FileSystemWatcher_Changed;
                fileWatcher.EnableRaisingEvents = true;
                Settings.Default.Save();
                MessageBox.Show("Ścieżka do historii plików została zmieniona.", "Zmieniono");
            }
        }

        private void DataPathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                hudPath = Settings.Default.DataFilePath = folderBrowserDialog1.SelectedPath;
                dataFilePath = hudPath + dataFile;
                OpenDataFile();
                Settings.Default.Save();
                MessageBox.Show("Ściezka do zapisu danych została zmieniona.", "Zmieniono");
            }

        }

        private void OpenDataFile()
        {
            if (!string.IsNullOrEmpty(dataFilePath))
            {
                try
                {
                    using (Stream stream = File.Open(dataFilePath, FileMode.OpenOrCreate))
                    {
                        if (stream.Length != 0)
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            playerDictionary = (Dictionary<string, Player>)binaryFormatter.Deserialize(stream);
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            filePath = e.FullPath;
            fileChanged = true;
        } 

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            if (!string.IsNullOrEmpty(hudPath))
            {
                try
                {
                    using (Stream stream = File.Open(dataFilePath, FileMode.Create))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(stream, playerDictionary);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);


        private void HoverButton_Click(object sender, EventArgs e)
        {

            if (!this.TopMost)
            {

                this.TopMost = true;
                this.Show();
                this.Width = 1920;
                this.Height = 1080;
                this.BackColor = Color.DarkRed;
                controlGroup.Visible = false;
                groupTable1.Location = new Point(255, 2);
                groupTable2.Location = new Point(968, 2);
                groupTable3.Location = new Point(255, 522);
                groupTable4.Location = new Point(968, 522);
                groupTable1.Size = new Size(700,513);
                groupTable2.Size = new Size(700, 513);
                groupTable3.Size = new Size(700, 513);
                groupTable4.Size = new Size(700, 513);
                groupTable1.BackColor = Color.DarkRed;
                groupTable2.BackColor = Color.DarkRed;
                groupTable3.BackColor = Color.DarkRed;
                groupTable4.BackColor = Color.DarkRed;
                for (int i = 1; i <= 4; i++)
                {
                    seatsDictionary[i][1].Visible = false;
                    seatsDictionary[i][2].Location = new Point(10, 315);
                    seatsDictionary[i][3].Location = new Point(15, 165);
                    seatsDictionary[i][4].Location = new Point(130, 45);
                    seatsDictionary[i][5].Location = new Point(545, 165);
                    seatsDictionary[i][6].Location = new Point(540, 320);
                }
                SetWindowLong(this.Handle, -20, (uint)GetWindowLong(this.Handle, -20) | (uint)0x80000 | (uint)0x20);
            }
            else
            {
                this.TopMost = false;
                this.Width = 1280;
                this.Height = 1024;
                this.BackColor = Color.Black;
                controlGroup.Visible = true;
                groupTable1.Location = new Point(23, 16);
                groupTable2.Location = new Point(481, 16);
                groupTable3.Location = new Point(23, 415);
                groupTable4.Location = new Point(481, 415);
                groupTable1.Size = new Size(452, 393);
                groupTable2.Size = new Size(452, 393);
                groupTable3.Size = new Size(452, 393);
                groupTable4.Size = new Size(452, 393);
                groupTable1.BackColor = Color.Black;
                groupTable2.BackColor = Color.Black;
                groupTable3.BackColor = Color.Black;
                groupTable4.BackColor = Color.Black;
                for (int i = 1; i <= 4; i++)
                {
                    seatsDictionary[i][1].Visible = true;
                    seatsDictionary[i][2].Location = new Point(25, 210);
                    seatsDictionary[i][3].Location = new Point(25, 120);
                    seatsDictionary[i][4].Location = new Point(133, 30);
                    seatsDictionary[i][5].Location = new Point(253, 120);
                    seatsDictionary[i][6].Location = new Point(253, 210);
                }

            }
            
            
        }

        private void ChangeTables_Click(object sender, EventArgs e)
        {
            if(tableToSwap1.Value != tableToSwap2.Value)
            {
                GroupBox[] groupTables = new GroupBox[] { groupTable1, groupTable2, groupTable3, groupTable4 };
                int X = groupTables[(int)tableToSwap1.Value - 1].Location.X;
                int Y = groupTables[(int)tableToSwap1.Value - 1].Location.Y;
                groupTables[(int)tableToSwap1.Value - 1].Location = groupTables[(int)tableToSwap2.Value - 1].Location;
                groupTables[(int)tableToSwap2.Value - 1].Location = new Point(X, Y);
            }
        }


        private void CreateHud_Click(object sender, EventArgs e)
        {
            table1seat2 = new PlayerInfoForm(10, 315);
            table1seat3 = new PlayerInfoForm(15, 165);
            table1seat4 = new PlayerInfoForm(130, 45);
            table1seat5 = new PlayerInfoForm(545, 165);
            table1seat6 = new PlayerInfoForm(540, 320);
        }

        private void HudOnButton_Click(object sender, EventArgs e)
        {
            table1seat2.playerInfoTextBox = seat2Table1;
            table1seat3.playerInfoTextBox = seat3Table1;
            table1seat4.playerInfoTextBox = seat4Table1;
            table1seat5.playerInfoTextBox = seat5Table1;
            table1seat6.playerInfoTextBox = seat6Table1;
            table1seat2.Show();
            table1seat3.Show();
            table1seat4.Show();
            table1seat5.Show();
            table1seat6.Show();
        }


        /*private void refreshButton_Click(object sender, EventArgs e)
        {
            processes = Process.GetProcessesByName("PokerStars");
            foreach (Process process in processes)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    roomName = process.MainWindowTitle;

                    for (int i = 0; i < roomName.Length; i++)
                    {
                        if (roomName.Substring(i, 1) == "-")
                        {
                            roomName = roomName.Substring(0, i - 1);
                            break;
                        }
                    }
                    Console.WriteLine(roomName);
                    //Console.WriteLine("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);
                }
            }
        }
        */

    }
}
