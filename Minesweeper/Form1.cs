using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minesweeper.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using ClassLibraryMineSweeper;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public enum Items //Determins if tile contains bomb
        {
            None,
            Bomb,
        }
        public enum State  //determins if the player places flags or reveales tiles
        {
            Detector,
            Flag
        }
        public class Tile
        {
            private Button button = new Button();
            private Items contains = Items.None;
            private bool revealed = false;
            private int detected = 0;
            private (int, int) coordinates;
            private bool flag = false;
            private bool detectorFinished = false;
            public Button Getbutton()
            {
                return button;
            }
            public Items Getcontains()
            {
                return contains;
            }
            public bool Getrevealed()
            {
                return revealed;
            }
            public int Getdetected()
            {
                return detected;
            }
            public (int, int) Getcoordinates()
            {
                return coordinates;
            }
            public bool Getflag()
            {
                return flag;
            }
            public bool GetdetectorFinished()
            {
                return detectorFinished;
            }
            public void Setcontains(Items newcontains)
            {
                contains = newcontains;
            }
            public void Setrevealed(bool newrevealed)
            {
                revealed = newrevealed;
            }
            public void Setdetected(int newdetected)
            {
                detected = newdetected;
            }
            public void Setcoordinates((int, int) newcoordinates)
            {
                coordinates = newcoordinates;
            }
            public void Setflag(bool newflag)
            {
                flag = newflag;
            }
            public void SetdetectorFinished(bool newdetectorFinished)
            {
                detectorFinished = newdetectorFinished;
            }
        }

        Tile[,] Board;
        int length;
        (int, int)[] directions = { (-1,-1), (-1, 0), (-1, 1),
                                    ( 0,-1),/*(0, 0)*/( 0, 1),
                                    ( 1,-1), ( 1, 0), ( 1, 1)}; //Used for checking neighbouring tiles 
        State currentstate = State.Detector;        //   List<Button> buttons = new List<Button>();
        int placedFlags = 0;
        bool start = true;
        int revealedTiles;
        int Bombs;
        public Form1()
        {
            InitializeComponent();
            BombNumber.Maximum = tileNumber.Value * tileNumber.Value; //Limit so there cant be more Bombs than tiles

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tileGenerator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PresetEasy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PresetHard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PresetModerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tileNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BombNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DetectorButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stateShower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            switchState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void tileGenerator_Click(object sender, EventArgs e)
        {
            generateBoard(this);
        }
        public void ClearButtons() //Deletes all buttons for regenerating the board
        {
            if (start == false)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        this.Controls.Remove(Board[i, j].Getbutton());
                    }
                }
            }
            else
            {
                start = false;
            }
        }
        public void placeBombs()//Determins which tiles contain bombs
        {
            Items item;
            int i;
            int j;
            Random rnd = new Random();
            for (int b = 0; b < Bombs; b++)
            {
                i = rnd.Next(0, length);
                j = rnd.Next(0, length);
                if (Board[i, j].Getcontains() == Items.None)
                {

                    Board[i, j].Setcontains(Items.Bomb);
                }
                else
                {
                    b--;
                }
            }
        }
        public int mineDetector(int i, int j) //Counts neighbouring bombs
        {
            int num = 0;
            foreach ((int, int) dir in directions)
            {
                if (i + dir.Item1 < length && i + dir.Item1 > -1 && j + dir.Item2 < length && j + dir.Item2 > -1)
                {
                    if (Board[i + dir.Item1, j + dir.Item2].Getcontains() == Items.Bomb)
                    {
                        num++;
                    }
                }
            }
            return num;
        }
        public void writeDetection() //Writes number of neigbouring Bombs on the button
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (Board[i, j].Getcontains() != Items.Bomb)
                    {
                        Board[i, j].Setdetected(mineDetector(i, j));
                    }
                }
            }
        }
        public void generateBoard(Form Form1)
        {
            victory.Text = "";
            ClearButtons();
            length = Convert.ToInt32(tileNumber.Value);
            revealedTiles = length * length - Convert.ToInt32(BombNumber.Value);
            Board = new Tile[length, length];
            placedFlags = 0;
            Bombs = Convert.ToInt32(BombNumber.Value);
            // Form1.Width = 649 + length * 25 ;   
            // Form1.Height = 500 + length * 10;
            Form1.Width = ClassLibraryMineSweeper.Functions.AppWidth(length);     // Set the width to 800 pixels
            Form1.Height = ClassLibraryMineSweeper.Functions.AppHeight(length);
            int loci;
            int locj;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Tile newbutton = new Tile();
                    loci = ClassLibraryMineSweeper.Functions.ButtonLocationi(i);
                    locj = ClassLibraryMineSweeper.Functions.ButtonLocationj(j);
                    newbutton.Getbutton().Location = new Point(locj, loci);
                    newbutton.Getbutton().BackColor = Color.Gray;
                    newbutton.Getbutton().Size = new Size(30, 30);
                    newbutton.Getbutton().Visible = true;
                    newbutton.Getbutton().BringToFront();
                    newbutton.Getbutton().Name = i + "" + j;
                    newbutton.Getbutton().Font = new Font(newbutton.Getbutton().Font.FontFamily, 16, FontStyle.Bold);
                    newbutton.Getbutton().Click += UniversalButtonClickHandler;
                    this.Controls.Add(newbutton.Getbutton());
                    Board[i, j] = newbutton;
                    Board[i, j].Setcoordinates((i, j));

                }

            }
            BombsLeftCounter.Text = "Bombs Left: " + BombNumber.Value;
            placeBombs();
            writeDetection();
        }

        public Tile FindButton(Button clickedButton) //searches which button was pressed in Board
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (Board[i, j].Getbutton() == clickedButton)
                    {
                        return Board[i, j];
                    }
                }
            }
            return Board[0, 0];
        }
        public void PlaceFlag(Tile ourtile)
        {
            if (ourtile.Getflag() == true)
            {
                ourtile.Setflag(false);
                ourtile.Getbutton().BackColor = Color.Gray;
                ourtile.Getbutton().Image = null;
                placedFlags--;
            }
            else
            {
                if (placedFlags < BombNumber.Value)
                {
                    ourtile.Setflag(true);
                    ourtile.Getbutton().BackColor = Color.White;
                    Image originalImage = Properties.Resources.flag;
                    Image resizedImage = originalImage.GetThumbnailImage(ourtile.Getbutton().Width, ourtile.Getbutton().Height, null, IntPtr.Zero);
                    ourtile.Getbutton().Image = resizedImage;
                    placedFlags++;
                }
            }
            BombsLeftCounter.Text = "Bombs Left: " + (Bombs - placedFlags);
        }

        public void revealBoard(int i, int j) //Using BFS it reveals as much of the Board as it can
        {
            Queue<(int, int)> kju = new Queue<(int, int)>();
            kju.Enqueue((i, j));
            (int, int) current;
            (int, int) temp;
            while (kju.Count > 0)
            {
                current = kju.Dequeue();
                if (Board[current.Item1, current.Item2].Getcontains() != Items.Bomb && Board[current.Item1, current.Item2].Getrevealed() == false)
                {
                    revealedTiles--;
                    if (Board[current.Item1, current.Item2].Getdetected() != 0)
                    {
                        Board[current.Item1, current.Item2].Getbutton().Text = Convert.ToString(Board[current.Item1, current.Item2].Getdetected());
                    }

                    Board[current.Item1, current.Item2].Getbutton().BackColor = Color.White;
                    Board[current.Item1, current.Item2].Setrevealed(true);
                    if (Board[current.Item1, current.Item2].Getdetected() == 0)
                    {
                        temp = current;
                        foreach ((int, int) dir in directions)
                        {
                            if (current.Item1 + dir.Item1 < length && current.Item1 + dir.Item1 > -1 && current.Item2 + dir.Item2 < length && current.Item2 + dir.Item2 > -1)
                            {
                                temp = (current.Item1 + dir.Item1, current.Item2 + dir.Item2);
                                kju.Enqueue(temp);
                            }

                        }
                    }
                }

            }
        }
        public void revealAll() //Game over reveal of the Board
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Board[i, j].Setrevealed(true);
                    if (Board[i, j].Getcontains() == Items.Bomb)
                    {
                        Board[i, j].Getbutton().BackColor = Color.White;
                        Image originalImage = Properties.Resources.bomb;
                        Image resizedImage = originalImage.GetThumbnailImage(Board[i, j].Getbutton().Width, Board[i, j].Getbutton().Height, null, IntPtr.Zero);
                        Board[i, j].Getbutton().Image = resizedImage;
                    }
                    else
                    {
                        Board[i, j].Getbutton().BackColor = Color.White;
                        Board[i, j].Getbutton().Image = null;
                        if (Board[i, j].Getdetected() != 0)
                        {
                            Board[i, j].Getbutton().Text = Convert.ToString(Board[i, j].Getdetected());
                        }
                    }
                }
            }
        }
        public void checkVictory()
        {
            if (revealedTiles <= 0)
            {
                victory.Text = "Victory";
            }
        }


        private void UniversalButtonClickHandler(object sender, EventArgs e) //Managing button presses in Board
        {
            Button clickedButton = (Button)sender;
            Tile ourtile = FindButton(clickedButton);

            if (currentstate == State.Detector)
            {
                if (ourtile.Getflag() == false)//Just to make sure it doesnt accidently land on suspected tile
                {
                    int i = ourtile.Getcoordinates().Item1;
                    int j = ourtile.Getcoordinates().Item2;
                    if (ourtile.Getcontains() == Items.Bomb)
                    {
                        revealAll();
                        return;
                    }
                    else
                    {
                        ourtile.Setrevealed(false);
                        revealBoard(i, j);
                    }
                    checkVictory();
                }
            }
            else
            {
                /*placedFlags=ourtile.PlaceFlag(Convert.ToInt32(BombNumber.Value),placedFlags);
                BombsLeftCounter.Text = "Bombs Left: " + (Bombs - placedFlags);*/
                PlaceFlag(ourtile);
            }

        }

        private void switchState_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (currentstate == State.Detector)
            {
                currentstate = State.Flag;
                clickedButton.Text = "Switch to Detector";
                stateShower.Text = "Current State: Flags";
                clickedButton.BackColor = Color.Red;

            }
            else
            {
                currentstate = State.Detector;
                clickedButton.Text = "Switch to Flags";
                stateShower.Text = "Current State: Detector";
                clickedButton.BackColor = Color.Green;
            }
        }

        private void tileNumber_ValueChanged(object sender, EventArgs e)
        {
            BombNumber.Maximum = tileNumber.Value * tileNumber.Value;
        }

        private void PresetEasy_Click(object sender, EventArgs e)
        {
            tileNumber.Value = 9;
            BombNumber.Value = 10;
            generateBoard(this);
        }

        private void PresetModerate_Click(object sender, EventArgs e)
        {
            tileNumber.Value = 16;
            BombNumber.Value = 40;
            generateBoard(this);
        }

        private void PresetHard_Click(object sender, EventArgs e)
        {
            tileNumber.Value = 21;
            BombNumber.Value = 99;
            generateBoard(this);
        }

        private void DetectorButton_Click(object sender, EventArgs e)
        {
            DetectorSweep();
        }
        public void DetectorSweep()  //Goes through Board searching for obvious bombs
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (Board[i, j].Getrevealed() == true && Board[i, j].Getdetected() > 0 && Board[i, j].GetdetectorFinished() == false)
                    {
                        if (DetectorDetectBombs(Board[i, j]))
                        {
                            DetectorPaintTiles(Board[i, j]);
                        }
                    }
                }
            }
            DetectorMarkSaveSweep();
        }
        public bool DetectorDetectBombs(Tile t) //Counts if unrevealed tiles match the number on the tile(tile.detected)
        {
            int numBombs = t.Getdetected();
            int found = 0;
            (int, int) ij = t.Getcoordinates();
            foreach ((int, int) dir in directions)
            {
                if (ij.Item1 + dir.Item1 < length && ij.Item1 + dir.Item1 > -1 && ij.Item2 + dir.Item2 < length && ij.Item2 + dir.Item2 > -1) //Checks for boundries
                {
                    if (Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getrevealed() == false)
                    {
                        found++;
                    }
                }
            }
            if (found == numBombs)
            {
                return true;
            }
            return false;
        }
        public void DetectorPaintTiles(Tile t) //Marks the found tiles from the Detector
        {
            int numBombs = t.Getdetected();
            (int, int) ij = t.Getcoordinates();
            foreach ((int, int) dir in directions)
            {
                if (ij.Item1 + dir.Item1 < length && ij.Item1 + dir.Item1 > -1 && ij.Item2 + dir.Item2 < length && ij.Item2 + dir.Item2 > -1) //Checks for boundries
                {
                    if (Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getrevealed() == false)
                    {
                        Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().BackColor = Color.White;
                        Image originalImage = Properties.Resources.flag_mark;
                        Image resizedImage = originalImage.GetThumbnailImage(Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Width, Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Height, null, IntPtr.Zero);

                        // Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Image = ResizeImage(Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Width,Properties.Resources.flag_mark);
                        Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Image = resizedImage;
                        Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Setflag(true);
                    }
                }
            }
        }
        public void DetectorMarkSaveSweep() //Check for obvious revealable tiles by sweeping the Board
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    if (Board[i, j].Getrevealed() == true && Board[i, j].Getdetected() > 0 && Board[i, j].GetdetectorFinished() == false)
                    {
                        DetectorMarkSaveSearchTile(Board[i, j]);
                    }
                }
            }
        }
        public void DetectorMarkSaveSearchTile(Tile t) //Counts the bombs in neighbouring tiles
        {
            int numBombs = t.Getdetected();
            int found = 0;
            (int, int) ij = t.Getcoordinates();
            foreach ((int, int) dir in directions)
            {
                if (ij.Item1 + dir.Item1 < length && ij.Item1 + dir.Item1 > -1 && ij.Item2 + dir.Item2 < length && ij.Item2 + dir.Item2 > -1) //Checks for boundries
                {
                    if (Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Image != null)
                    {
                        found++;
                    }
                }
            }
            if (found == numBombs)
            {
                DetectorMarkSaveTiles(t);
            }
        }
        public void DetectorMarkSaveTiles(Tile t)  //Marks the found save tiles
        {
            int numBombs = t.Getdetected();
            int found = 0;
            (int, int) ij = t.Getcoordinates();
            foreach ((int, int) dir in directions)
            {
                if (ij.Item1 + dir.Item1 < length && ij.Item1 + dir.Item1 > -1 && ij.Item2 + dir.Item2 < length && ij.Item2 + dir.Item2 > -1) //Checks for boundries
                {
                    if (Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getrevealed() == false && Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().Image == null)
                    {
                        Board[ij.Item1 + dir.Item1, ij.Item2 + dir.Item2].Getbutton().BackColor = Color.Green;
                    }
                }
            }
        }
    }
}
