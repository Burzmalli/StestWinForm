using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StestWinForm
{
    public partial class Form1 : Form
    {
        #region Variable Declarations

        private int currentCard = 0;
        private Deck library = new Deck();
        private int turnsToRun = 0;
        private int spellsInDeck = 0;
        private int landsInDeck = 0;
        private int gamesToRun = 0;
        private string gamesLog = "";
        //private int logInterval = 500;
        private int[] medianLands = { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] gameLandStreaks = { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int currentStreakNum = -1;
        private int currentStreakCount = 0;
        private int minGood = 0;
        private int maxGood = 0;
        private int[] landScrewStreak = { 0, 0, 0 };
        private int[] totalLandScrews = { 0, 0, 0 };
        private int landScrewNum = -1;
        private int landScrewCount = 0;
        private int currentScrewStreak = 0;
        private int totalScrewStreak = 0;
        private bool printDetails;
        private List<Card> hand = new List<Card>();
        private int[] curveTracker;
        private int handLands = 0;

        #endregion

        #region UI Handling

        public Form1()
        {
            InitializeComponent();

            RunButton.Click += new EventHandler(runSim);
        }

        #endregion

        #region Report Out Handling

        public int getMedian()
        {
            int greatest = 0;
            int medianNum = 0;
            for (int i = 0; i < medianLands.Count<int>(); i++)
            {
                if (medianLands[i] > greatest)
                {
                    greatest = medianLands[i];
                    medianNum = i;
                }
            }
            return medianNum;
        }

        public int getMedianAmt()
        {
            int greatest = 0;
            for (int i = 0; i < medianLands.Count<int>(); i++)
            {
                if (medianLands[i] > greatest)
                {
                    greatest = medianLands[i];
                }
            }
            return greatest;
        }

        private double getLandAverage()
        {
            double average = 0;

            for (int i = 0; i < medianLands.Count<int>(); i++)
            {
                average += medianLands[i] * i;
            }

            average = average / (double)gamesToRun;

            return average;
        }

        private void reportOut()
        {
            ResultsText.Text += "Average lands in opening hand: " + getLandAverage().ToString() + "\n";
            ResultsText.Text += "Median lands in opening hand: " + getMedian() + " (" + getMedianAmt() + ")" + "\n";
            for (int i = 0; i < gameLandStreaks.Count<int>(); i++)
            {
                ResultsText.Text += "Longest streak of opening hands with " + i.ToString() + " starting lands: " + gameLandStreaks[i].ToString() + "\n";
            }
            ResultsText.Text += "Longest streak of empty hands: " + landScrewStreak[0] + "\n";
            ResultsText.Text += "Longest streak of good hands: " + landScrewStreak[1] + "\n";
            ResultsText.Text += "Longest streak of flooded hands: " + landScrewStreak[2] + "\n";
            ResultsText.Text += "Longest streak of screwed hands: " + totalScrewStreak + "\n";
            ResultsText.Text += "Total cases of short hands: " + totalLandScrews[0] + " (" + Math.Round(((double)(totalLandScrews[0] * 100) / gamesToRun), 2).ToString() + "%)\n";
            ResultsText.Text += "Total cases of good hands: " + totalLandScrews[1] + " (" + Math.Round(((double)(totalLandScrews[1] * 100) / gamesToRun), 2).ToString() + "%)\n";
            ResultsText.Text += "Total cases of flooded hands: " + totalLandScrews[2] + " (" + Math.Round(((double)(totalLandScrews[2] * 100) / gamesToRun), 2).ToString() + "%)\n";
            if (printDetails)
            {
                ResultsText.Text += "\n" + gamesLog;
            }
        }

        #endregion

        #region Simulation Functions

        public void resetArrays()
        {
            for (int i = 0; i < medianLands.Count<int>(); i++)
            {
                medianLands[i] = 0;
                gameLandStreaks[i] = 0;
            }
            for (int i = 0; i < landScrewStreak.Count<int>(); i++)
            {
                landScrewStreak[i] = 0;
                totalLandScrews[i] = 0;
            }

            if (turnsToRun > 0)
            {
                for (int i = 0; i < curveTracker.Count<int>(); i++)
                {
                    curveTracker[i] = 0;
                }
            }
        }

        private void resetForRun()
        {
            ResultsText.Clear();
            //allInitialLands = 0;
            gamesLog = "";
            resetArrays();
            library.clearDeck();
            fillDeck();
            currentStreakNum = -1;
            currentStreakCount = 0;
            landScrewNum = -1;
            landScrewCount = 0;
            totalScrewStreak = 0;
            currentScrewStreak = 0;
            hand.Clear();
        }

        private void loadVariables()
        {
            printDetails = (bool)DetailsCheck.Checked;
            if (!Int32.TryParse(TurnBox.Text.Trim(), out turnsToRun))
            {
                turnsToRun = 0;
            }
            if (!Int32.TryParse(SpellBox.Text.Trim(), out spellsInDeck))
            {
                spellsInDeck = 0;
            }
            if (!Int32.TryParse(LandBox.Text.Trim(), out landsInDeck))
            {
                landsInDeck = 0;
            }
            if (!Int32.TryParse(GameBox.Text.Trim(), out gamesToRun))
            {
                gamesToRun = 0;
            }
            if (!Int32.TryParse(MinBox.Text.Trim(), out minGood))
            {
                minGood = 0;
            }
            if (!Int32.TryParse(MaxBox.Text.Trim(), out maxGood))
            {
                maxGood = 0;
            }
            if (turnsToRun > 0)
            {
                curveTracker = new int[turnsToRun];
            }
        }

        private void runSim(object s, EventArgs e)
        {
            loadVariables();

            resetForRun();

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = gamesToRun;

            do
            {
                progressBar1.Value++;
                runCycle();
            } while (progressBar1.Value != progressBar1.Maximum);

            reportOut();
        }

        private void fillDeck()
        {
            for (int i = 0; i < spellsInDeck; i++)
            {
                library.addCard(new Card(1));
            }

            for (int i = 0; i < landsInDeck; i++)
            {
                library.addCard(new Card(0));
            }
        }

        private void runCycle()
        {
            library.shuffle();
            hand.Clear();
            currentCard = 0;
            handLands = 0;

            for (int i = 0; i < 7; i++)
            {
                hand.Add(library.drawCard(currentCard));
                if (hand[i].getCardType() == "Land")
                {
                    handLands++;
                }
                currentCard++;
            }

            analyzeHand();

            if (turnsToRun > 0 && printDetails)
            {
                rabbitHunt();
            }
        }

        private void rabbitHunt()
        {
            gamesLog += "Next " + turnsToRun.ToString() + " turns: ";
            for (int i = 0; i < turnsToRun; i++)
            {
                gamesLog += library.drawCard(currentCard).getCardType();
                currentCard++;
                if (i < turnsToRun - 1)
                {
                    gamesLog += ", ";
                }
                else
                {
                    gamesLog += "\n";
                }
            }
            gamesLog += "\n";
        }

        #endregion

        #region Analysis Functions

        private int getLandCount()
        {
            int totalLands = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].getCardType() == "Land")
                {
                    totalLands++;
                }
            }
            return totalLands;
        }

        private void checkLandScrew(int totalLands)
        {
            if (totalLands < minGood)
            {
                if (landScrewNum != 0)
                {
                    if (landScrewNum < 0)
                    {
                        landScrewStreak[0] = 1;
                    }
                    landScrewNum = 0;
                    landScrewCount = 1;
                }
                else
                {
                    landScrewCount++;
                }
                currentScrewStreak++;
            }
            else if (totalLands > maxGood)
            {
                if (landScrewNum != 2)
                {
                    if (landScrewNum < 0)
                    {
                        landScrewStreak[2] = 1;
                    }
                    landScrewNum = 2;
                    landScrewCount = 1;
                }
                else
                {
                    landScrewCount++;
                }
                currentScrewStreak++;
            }
            else
            {
                if (landScrewNum != 1)
                {
                    if (landScrewNum < 0)
                    {
                        landScrewStreak[1] = 1;
                    }
                    landScrewNum = 1;
                    landScrewCount = 1;
                }
                else
                {
                    landScrewCount++;
                }
                if (currentScrewStreak > 0)
                {
                    if (currentScrewStreak > totalScrewStreak)
                    {
                        totalScrewStreak = currentScrewStreak;
                    }
                }
                currentScrewStreak = 0;
            }
            if (landScrewStreak[landScrewNum] < landScrewCount)
            {
                landScrewStreak[landScrewNum] = landScrewCount;
            }

            totalLandScrews[landScrewNum]++;
        }

        private void analyzeHand()
        {
            if (printDetails)
            {
                gamesLog += "Initial Lands: " + handLands.ToString() + "\n";
            }

            medianLands[handLands]++;

            checkLandStreak(handLands);

            checkLandScrew(handLands);
        }

        private void checkLandStreak(int totalLands)
        {
            if (totalLands == currentStreakNum)
            {
                currentStreakCount++;
            }
            else
            {
                if (currentStreakNum < 0)
                {
                    gameLandStreaks[totalLands] = 1;
                }
                currentStreakNum = totalLands;
                currentStreakCount = 1;
            }
            if (gameLandStreaks[currentStreakNum] < currentStreakCount)
            {
                gameLandStreaks[currentStreakNum] = currentStreakCount;
            }
        }

        #endregion
    }
}