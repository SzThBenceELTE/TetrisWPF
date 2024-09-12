using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Policy;
using TetrisModel;
using TetrisModel.Model;
using TetrisModel.Persistence;

namespace TetrisView
{
    public partial class GameWindow : Form
    {
        SaveToFile saver = new SaveToFile("save.txt");

        State state;
        int sizeWidth;
        int sizeHeight;
        public Button[,] _buttonGrid;

        int time;
        int points;

        public GameWindow()
        {
            //InitializeComponent();
            statusStrip1 = new StatusStrip();
            gameSpace = new Panel();

            //gameTick = new System.Windows.Forms.Timer();
            sizeWidth = 4;
            sizeHeight = 16;
            //state = new State(20,20);
            //gameTick.Stop();
            statusStrip1.Hide();
            gameSpace.Hide();
            

            
            

            this.Text = "TetrisWF 0.13";

            InitializeComponent();

            SaveButton.Hide();
            ResetButton.Hide();
            PauseButton.Hide();



        }

        private void gameTick_Tick(object sender, EventArgs e)
        {

            state.AddTime();
            time = state.getTime();
            TimerStatus.Text = $"Time passed: {time}";
            state.moveDown();
            //state.SecureRotateLeft();
            //Draw();

            //state.secureMoveRight();

            //UpdateButtons();

            //_buttonGrid[time, time].BackColor = Color.Green;





            for (int i = 2; i < sizeHeight + 2; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    if (state.table.isInside(i, j))
                    {
                        //_buttonGrid[i, j].Enabled = true;
                        switch (state.table[i, j])
                        {
                            case 0:
                                _buttonGrid[i, j].BackColor = Color.White;
                                break;
                            case 1:
                                _buttonGrid[i, j].BackColor = Color.Red;
                                break;
                            case 2:
                                _buttonGrid[i, j].BackColor = Color.Orange;
                                break;
                            case 3:
                                _buttonGrid[i, j].BackColor = Color.Yellow;
                                break;
                            case 4:
                                _buttonGrid[i, j].BackColor = Color.Green;
                                break;
                            case 5:
                                _buttonGrid[i, j].BackColor = Color.Blue;
                                break;
                            case 6:
                                _buttonGrid[i, j].BackColor = Color.Purple;
                                break;
                            case 7:
                                _buttonGrid[i, j].BackColor = Color.LightBlue;
                                break;
                        }
                    }
                }
            }

            Block b = state.getCurrent();
            Position offset = b.getOffset();

            foreach (Position p in b.tilePosition())
            {
                //if (p.row >= 2)
                if (state.table.isInside(p.row - 2, p.column))
                {
                    switch (b.getId())
                    {
                        case 0:
                            _buttonGrid[p.row, p.column].BackColor = Color.White;
                            break;
                        case 1:
                            _buttonGrid[p.row, p.column].BackColor = Color.Red;
                            break;
                        case 2:
                            _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                            break;
                        case 3:
                            _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                            break;
                        case 4:
                            _buttonGrid[p.row, p.column].BackColor = Color.Green;
                            break;
                        case 5:
                            _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                            break;
                        case 6:
                            _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                            break;
                        case 7:
                            _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                            break;
                    }
                }
            }



            if (!state.IsGameOver())
            {
                points = state.getPoints();
                PointsStripLabel.Text = $"Points: {points}";
            }
            else
            {
                StartButton.Show();
                gameTick.Stop();
                MessageBox.Show("Game Over! \n Points gathered: " + points + "\n Time survived: " + time, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //statusStrip1.Hide();
                time = 0;
                points = 0;
                
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        //List<Button> gombok;
        //int[] fullCols = new int[];

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Form1_KeyDown(sender, (KeyEventArgs)e);
            
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Get a game size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                state.ResetGame();
                StartButton.Text = "Reset with new Size";
                //StartButton.Hide();
                statusStrip1.Show();
            
                PauseButton.Show();
                gameTick.Start();

                _buttonGrid = new Button[gameSpace.Height, gameSpace.Width];
                gameSpace.Controls.Clear();

                int x = gameSpace.Width / sizeWidth;
                int y = gameSpace.Height / sizeHeight - 4;

                for (int i = 2; i < sizeHeight + 2; i++)
                {
                    //fullCols[i] = 0;

                    for (int j = 0; j < sizeWidth; j++)
                    {

                        _buttonGrid[i, j] = new Button();
                        _buttonGrid[i, j].Size = new Size(x, y);
                        _buttonGrid[i, j].Tag = i * sizeHeight + j;
                        _buttonGrid[i, j].Location = new Point(j * x, i * y);
                        //_buttonGrid[i, j].Text = " " + i + " " + j;
                        this._buttonGrid[i,j].KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
                        //_buttonGrid[i, j].Dock = DockStyle.Fill;
                        gameSpace.Controls.Add(_buttonGrid[i, j]);
                        //panel1.Controls.Add(btn);
                        //gombok.Add(btn);
                       


                        //gombok.Add(_buttonGrid[i, j]);
                        //btn.Click += Btn_Click;
                        //btn.Click += csinal;


                    }
                }
            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            /*Button bt = sender as Button;
            bt.BackColor = Color.Aqua;*/

        }

        /*private void UpdateButtons()
        {
            foreach (Button button in gombok)
            {
                switch(state.table.)
            }    
        }*/

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sizeWidth = 4;
            sizeHeight = 16;
            state = new State(16, 4);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sizeWidth = 8;
            sizeHeight = 16;
            state = new State(16, 8);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sizeWidth = 12;
            sizeHeight = 16;
            state = new State(16, 12);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (!state.IsGameOver())
            //{
            if (gameTick.Enabled)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        state.secureMoveRight();
                        break;
                    case Keys.A:
                        state.secureMoveLeft();
                        break;
                    case Keys.W:
                        state.SecureRotateLeft();
                        break;
                    case Keys.S:
                        state.moveDown();
                        break;
                    default:
                        break;
                }
                //e.SuppressKeyPress = true;

                //Draw();

                //state.AddTime();
                //time = state.getTime();
                //TimerStatus.Text = $"Time passed: {time}";
                //state.moveDown();

                //UpdateButtons();

                //_buttonGrid[time, time].BackColor = Color.Green;





                for (int i = 2; i < sizeHeight + 2; i++)
                {
                    for (int j = 0; j < sizeWidth; j++)
                    {
                        if (state.table.isInside(i, j))
                        {
                            //_buttonGrid[i, j].Enabled = true;
                            switch (state.table[i, j])
                            {
                                case 0:
                                    _buttonGrid[i, j].BackColor = Color.White;
                                    break;
                                case 1:
                                    _buttonGrid[i, j].BackColor = Color.Red;
                                    break;
                                case 2:
                                    _buttonGrid[i, j].BackColor = Color.Orange;
                                    break;
                                case 3:
                                    _buttonGrid[i, j].BackColor = Color.Yellow;
                                    break;
                                case 4:
                                    _buttonGrid[i, j].BackColor = Color.Green;
                                    break;
                                case 5:
                                    _buttonGrid[i, j].BackColor = Color.Blue;
                                    break;
                                case 6:
                                    _buttonGrid[i, j].BackColor = Color.Purple;
                                    break;
                                case 7:
                                    _buttonGrid[i, j].BackColor = Color.LightBlue;
                                    break;
                            }
                        }
                    }
                }

                Block b = state.getCurrent();
                Position offset = b.getOffset();

                foreach (Position p in b.tilePosition())
                {
                    //if (p.row >= 2)
                    if (state.table.isInside(p.row - 2, p.column))
                    {
                        switch (b.getId())
                        {
                            /*case 0:
                                 _buttonGrid[p.row, p.column].BackColor = Color.White;
                                 break;*/
                            case 1:
                                _buttonGrid[p.row, p.column].BackColor = Color.Red;
                                break;
                            case 2:
                                _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                                break;
                            case 3:
                                _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                                break;
                            case 4:
                                _buttonGrid[p.row, p.column].BackColor = Color.Green;
                                break;
                            case 5:
                                _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                                break;
                            case 6:
                                _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                                break;
                            case 7:
                                _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                                break;
                        }
                    }

                }



                if (!state.IsGameOver())
                {
                    points = state.getPoints();
                    PointsStripLabel.Text = $"Points: {points}";
                }
                else
                {
                    MessageBox.Show("Game Over! \n Points gathered: " + points + "\n Time survived: " + time, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    statusStrip1.Hide();
                    time = 0;
                    points = 0;
                    StartButton.Show();
                    gameTick.Stop();
                }
            }

            //}
        }
        private void Draw()
        {
            for (int i = 2; i < sizeHeight + 2; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    if (state.table.isInside(i, j))
                    {
                        //_buttonGrid[i, j].Enabled = true;
                        switch (state.table[i, j])
                        {
                            case 0:
                                _buttonGrid[i, j].BackColor = Color.White;
                                break;
                            case 1:
                                _buttonGrid[i, j].BackColor = Color.Red;
                                break;
                            case 2:
                                _buttonGrid[i, j].BackColor = Color.Orange;
                                break;
                            case 3:
                                _buttonGrid[i, j].BackColor = Color.Yellow;
                                break;
                            case 4:
                                _buttonGrid[i, j].BackColor = Color.Green;
                                break;
                            case 5:
                                _buttonGrid[i, j].BackColor = Color.Blue;
                                break;
                            case 6:
                                _buttonGrid[i, j].BackColor = Color.Purple;
                                break;
                            case 7:
                                _buttonGrid[i, j].BackColor = Color.LightBlue;
                                break;
                        }
                    }
                }
            }

            Block b = state.getCurrent();
            Position offset = b.getOffset();

            foreach (Position p in b.tilePosition())
            {
                //if (p.row >= 2)
                if (state.table.isInside(p.row - 2, p.column))
                {
                    switch (b.getId())
                    {
                        /* case 0:
                             _buttonGrid[p.row, p.column].BackColor = Color.White;
                             break;*/
                        case 1:
                            _buttonGrid[p.row, p.column].BackColor = Color.Red;
                            break;
                        case 2:
                            _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                            break;
                        case 3:
                            _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                            break;
                        case 4:
                            _buttonGrid[p.row, p.column].BackColor = Color.Green;
                            break;
                        case 5:
                            _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                            break;
                        case 6:
                            _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                            break;
                        case 7:
                            _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                            break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameTick.Enabled)
            {
                gameTick.Stop();
                PauseButton.Text = "Continue";
                SaveButton.Show();
                ResetButton.Show();
                LoadButton.Show();
            }
            else
            {
                gameTick.Start();
                PauseButton.Text = "Pause";
                SaveButton.Hide();
                ResetButton.Hide();
                LoadButton.Hide();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            state.ResetGame();
            points = 0;
            time = 0;
            TimerStatus.Text = $"Time passed: {time}";
            PointsStripLabel.Text = $"Points: {points}";

            for (int i = 2; i < sizeHeight + 2; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    if (state.table.isInside(i, j))
                    {
                        //_buttonGrid[i, j].Enabled = true;
                        switch (state.table[i, j])
                        {
                            case 0:
                                _buttonGrid[i, j].BackColor = Color.White;
                                break;
                            case 1:
                                _buttonGrid[i, j].BackColor = Color.Red;
                                break;
                            case 2:
                                _buttonGrid[i, j].BackColor = Color.Orange;
                                break;
                            case 3:
                                _buttonGrid[i, j].BackColor = Color.Yellow;
                                break;
                            case 4:
                                _buttonGrid[i, j].BackColor = Color.Green;
                                break;
                            case 5:
                                _buttonGrid[i, j].BackColor = Color.Blue;
                                break;
                            case 6:
                                _buttonGrid[i, j].BackColor = Color.Purple;
                                break;
                            case 7:
                                _buttonGrid[i, j].BackColor = Color.LightBlue;
                                break;
                        }
                    }
                }
            }

            Block b = state.getCurrent();
            Position offset = b.getOffset();

            foreach (Position p in b.tilePosition())
            {
                //if (p.row >= 2)
                if (state.table.isInside(p.row - 2, p.column))
                {
                    switch (b.getId())
                    {
                        /*case 0:
                             _buttonGrid[p.row, p.column].BackColor = Color.White;
                             break;*/
                        case 1:
                            _buttonGrid[p.row, p.column].BackColor = Color.Red;
                            break;
                        case 2:
                            _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                            break;
                        case 3:
                            _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                            break;
                        case 4:
                            _buttonGrid[p.row, p.column].BackColor = Color.Green;
                            break;
                        case 5:
                            _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                            break;
                        case 6:
                            _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                            break;
                        case 7:
                            _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                            break;
                    }
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saver.WriteState(state);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            state = saver.ReadState();

            sizeHeight = state.table.getRows() - 2;
            sizeWidth = state.table.getColums();

            //state.ResetGame();
            //StartButton.Text = "Reset with new Size";
            //StartButton.Hide();
            statusStrip1.Show();

            PauseButton.Show();
            state.time = state.time;
            state.points = state.points;
            TimerStatus.Text = $"Time passed: {time}";
            PointsStripLabel.Text = $"Points: {points}";
            gameTick.Start();

            _buttonGrid = new Button[gameSpace.Height, gameSpace.Width];
            gameSpace.Controls.Clear();

            int x = gameSpace.Width / sizeWidth;
            int y = gameSpace.Height / sizeHeight - 4;

            for (int i = 2; i < sizeHeight + 2; i++)
            {
                //fullCols[i] = 0;

                for (int j = 0; j < sizeWidth; j++)
                {

                    _buttonGrid[i, j] = new Button();
                    _buttonGrid[i, j].Size = new Size(x, y);
                    _buttonGrid[i, j].Tag = i * sizeHeight + j;
                    _buttonGrid[i, j].Location = new Point(j * x, i * y);
                    //_buttonGrid[i, j].Text = " " + i + " " + j;
                    this._buttonGrid[i, j].KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
                    //_buttonGrid[i, j].Dock = DockStyle.Fill;
                    gameSpace.Controls.Add(_buttonGrid[i, j]);
                }
            }

            for (int i = 2; i < sizeHeight; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    if (state.table.isInside(i, j))
                    {
                        //_buttonGrid[i, j].Enabled = true;
                        switch (state.table[i, j])
                        {
                            case 0:
                                _buttonGrid[i, j].BackColor = Color.White;
                                break;
                            case 1:
                                _buttonGrid[i, j].BackColor = Color.Red;
                                break;
                            case 2:
                                _buttonGrid[i, j].BackColor = Color.Orange;
                                break;
                            case 3:
                                _buttonGrid[i, j].BackColor = Color.Yellow;
                                break;
                            case 4:
                                _buttonGrid[i, j].BackColor = Color.Green;
                                break;
                            case 5:
                                _buttonGrid[i, j].BackColor = Color.Blue;
                                break;
                            case 6:
                                _buttonGrid[i, j].BackColor = Color.Purple;
                                break;
                            case 7:
                                _buttonGrid[i, j].BackColor = Color.LightBlue;
                                break;
                        }
                    }
                }
            }

            Block b = state.getCurrent();
            Position offset = b.getOffset();

            foreach (Position p in b.tilePosition())
            {
                //if (p.row >= 2)
                if (state.table.isInside(p.row - 2, p.column))
                {
                    switch (b.getId())
                    {
                        /*case 0:
                             _buttonGrid[p.row, p.column].BackColor = Color.White;
                             break;*/
                        case 1:
                            _buttonGrid[p.row, p.column].BackColor = Color.Red;
                            break;
                        case 2:
                            _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                            break;
                        case 3:
                            _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                            break;
                        case 4:
                            _buttonGrid[p.row, p.column].BackColor = Color.Green;
                            break;
                        case 5:
                            _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                            break;
                        case 6:
                            _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                            break;
                        case 7:
                            _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                            break;
                    }
                }

            }
        }
    }
}

        /*private void controlTimer_Tick(object sender, EventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Right:
                    state.secureMoveRight();
                    break;
                case Keys.Left:
                    state.secureMoveLeft();
                    break;
                case Keys.Up:
                    state.SecureRotateLeft();
                    break;
                case Keys.Down:
                    state.moveDown();
                    break;
                default:
                    break;
            }
            e.SuppressKeyPress = true;

            //Draw();

            //state.AddTime();
            //time = state.getTime();
            //TimerStatus.Text = $"Time passed: {time}";
            //state.moveDown();

            //UpdateButtons();

            //_buttonGrid[time, time].BackColor = Color.Green;





            for (int i = 2; i < sizeHeight + 2; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    if (state.table.isInside(i, j))
                    {
                        //_buttonGrid[i, j].Enabled = true;
                        switch (state.table[i, j])
                        {
                            case 0:
                                _buttonGrid[i, j].BackColor = Color.White;
                                break;
                            case 1:
                                _buttonGrid[i, j].BackColor = Color.Red;
                                break;
                            case 2:
                                _buttonGrid[i, j].BackColor = Color.Orange;
                                break;
                            case 3:
                                _buttonGrid[i, j].BackColor = Color.Yellow;
                                break;
                            case 4:
                                _buttonGrid[i, j].BackColor = Color.Green;
                                break;
                            case 5:
                                _buttonGrid[i, j].BackColor = Color.Blue;
                                break;
                            case 6:
                                _buttonGrid[i, j].BackColor = Color.Purple;
                                break;
                            case 7:
                                _buttonGrid[i, j].BackColor = Color.LightBlue;
                                break;
                        }
                    }
                }
            }

            Block b = state.getCurrent();
            Position offset = b.getOffset();

            foreach (Position p in b.tilePosition())
            {
                //if (p.row >= 2)
                if (state.table.isInside(p.row - 2, p.column))
                {
                    switch (b.getId())
                    {
                        /*case 0:
                             _buttonGrid[p.row, p.column].BackColor = Color.White;
                             break;
                        case 1:
                            _buttonGrid[p.row, p.column].BackColor = Color.Red;
                            break;
                        case 2:
                            _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                            break;
                        case 3:
                            _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                            break;
                        case 4:
                            _buttonGrid[p.row, p.column].BackColor = Color.Green;
                            break;
                        case 5:
                            _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                            break;
                        case 6:
                            _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                            break;
                        case 7:
                            _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                            break;
                    }
                }

            }



            if (!state.IsGameOver())
            {
                points = state.getPoints();
            }
            else
            {
                MessageBox.Show("Game Over! \n Points gathered: " + points + "\n Time survived: " + time, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                statusStrip1.Hide();
                time = 0;
                points = 0;
                StartButton.Show();
                gameTick.Stop();
            }*/

            
        
    
    


        /*async Task GameLoop()
        {
            Draw();

            while (!state.IsGameOver())
            {
                await Task.Delay(1000);
                state.moveDown();
                Draw();
            }
        }*/
        /*private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        //if (!state.IsGameOver())
        //{
        switch (e.KeyChar)
        {
            case Keys.Right:
                state.secureMoveRight();
                break;
            case Keys.Left:
                state.secureMoveLeft();
                break;
            case Keys.Up:
                state.SecureRotateLeft();
                break;
            case Keys.Down:
                state.moveDown();
                break;
            default:
                break;
        }
        e.SuppressKeyPress = true;

        //state.AddTime();
        //time = state.getTime();
        //TimerStatus.Text = $"Time passed: {time}";
        //state.moveDown();

        //UpdateButtons();

        //_buttonGrid[time, time].BackColor = Color.Green;





        for (int i = 2; i < sizeHeight + 2; i++)
        {
            for (int j = 0; j < sizeWidth; j++)
            {
                if (state.table.isInside(i, j))
                {
                    //_buttonGrid[i, j].Enabled = true;
                    switch (state.table[i, j])
                    {
                        case 0:
                            _buttonGrid[i, j].BackColor = Color.White;
                            break;
                        case 1:
                            _buttonGrid[i, j].BackColor = Color.Red;
                            break;
                        case 2:
                            _buttonGrid[i, j].BackColor = Color.Orange;
                            break;
                        case 3:
                            _buttonGrid[i, j].BackColor = Color.Yellow;
                            break;
                        case 4:
                            _buttonGrid[i, j].BackColor = Color.Green;
                            break;
                        case 5:
                            _buttonGrid[i, j].BackColor = Color.Blue;
                            break;
                        case 6:
                            _buttonGrid[i, j].BackColor = Color.Purple;
                            break;
                        case 7:
                            _buttonGrid[i, j].BackColor = Color.LightBlue;
                            break;
                    }
                }
            }
        }

        Block b = state.getCurrent();
        Position offset = b.getOffset();

        foreach (Position p in b.tilePosition())
        {
            //if (p.row >= 2)
            if (state.table.isInside(p.row - 2, p.column))
            {
                switch (b.getId())
                {
                    /* case 0:
                         _buttonGrid[p.row, p.column].BackColor = Color.White;
                         break;
                    case 1:
                        _buttonGrid[p.row, p.column].BackColor = Color.Red;
                        break;
                    case 2:
                        _buttonGrid[p.row, p.column].BackColor = Color.Orange;
                        break;
                    case 3:
                        _buttonGrid[p.row, p.column].BackColor = Color.Yellow;
                        break;
                    case 4:
                        _buttonGrid[p.row, p.column].BackColor = Color.Green;
                        break;
                    case 5:
                        _buttonGrid[p.row, p.column].BackColor = Color.Blue;
                        break;
                    case 6:
                        _buttonGrid[p.row, p.column].BackColor = Color.Purple;
                        break;
                    case 7:
                        _buttonGrid[p.row, p.column].BackColor = Color.LightBlue;
                        break;
                }
            }

        }



        if (!state.IsGameOver())
        {
            points = state.getPoints();
        }
        else
        {
            MessageBox.Show("Game Over! \n Points gathered: " + points + "\n Time survived: " + time, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //statusStrip1.Hide();
            time = 0;
            points = 0;
            StartButton.Show();
            gameTick.Stop();
        }
    }
}*/

        /*
         *  private void Create_Click(object sender, EventArgs e)
            {
                gombok = new List<Button>();
                panel1.Controls.Clear();
                int x = panel1.Width / size;
                int y = panel1.Height / size;
                for (int i = 0; i < size; i++)
                {
                    fullCols[i] = 0;

                    for (int j = 0; j < size; j++)
                    {
                        var btn = new Button();
                        btn.Size = new Size(x, y);
                        btn.Tag = i * size + j;
                        btn.Location = new Point(j * x, i * y);
                        panel1.Controls.Add(btn);
                        gombok.Add(btn);
                        btn.Click += csinal;


                    }
                }
            }
        */
    
