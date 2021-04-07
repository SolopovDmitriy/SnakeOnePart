using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        private Direction Direction { get; set; }

        private GameField _gameField;
        private Food _food;
        private Snake _snake;
        public MainForm()
        {
            InitializeComponent();
            _gameField = new GameField();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panelMainForm.Controls.Add(_gameField.GameFieldControl);
            _food = new Food();
            //_food.X = 600;
            //_food.Y = 200;
            _snake = new Snake();
            _gameField.GameFieldControl.Paint += GameFieldControl_Paint;
            gameTimer.Interval = 1000 / 60;
            gameTimer.Start();
            gameTimer.Tick += GameTimer_Tick; //подписались на тик таймера

            //timerTest.Start();
            timerTest.Tick += TimerTest_Tick;


           
        }

        private void TimerTest_Tick(object sender, EventArgs e)
        {
            _food.Respawn(_gameField.GameFieldControl);
            _gameField.GameFieldControl.Refresh();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //раз в тик перерисовать игровое поле
            //_gameField.GameFieldControl.Refresh();
        }

        private void GameFieldControl_Paint(object sender, PaintEventArgs e)
        {
            _food.Draw(e.Graphics);
            _snake.Draw(e.Graphics);
        }


        // my code
        public bool CanChangeDirection(Direction currentDirection, Direction newDirection)
        {
            if (currentDirection == Direction.UP && newDirection == Direction.DOWN ||
                currentDirection == Direction.DOWN && newDirection == Direction.UP ||
                currentDirection == Direction.LEFT && newDirection == Direction.RIGHT ||
                currentDirection == Direction.RIGHT && newDirection == Direction.LEFT)
            {
                return false;
            }
               
            return true;
        }



        // my code
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Direction newDirection = Direction;
            switch (e.KeyCode)
            {
                case Keys.D:
                    newDirection = Direction.RIGHT;
                    break;
                case Keys.A:
                    newDirection = Direction.LEFT;
                    break;
                case Keys.W:
                    newDirection = Direction.UP;
                    break;
                case Keys.S:
                    newDirection = Direction.DOWN;
                    break;
            }


            //switch (e.KeyCode)
            //{
            //    case Keys.Right:
            //        newDirection = Direction.RIGHT;
            //        break;
            //    case Keys.Left:
            //        newDirection = Direction.LEFT;
            //        break;
            //    case Keys.Up:
            //        newDirection = Direction.UP;
            //        break;
            //    case Keys.Down:
            //        newDirection = Direction.DOWN;
            //        break;
            //}
            if (CanChangeDirection(Direction, newDirection))
            {
                Direction = newDirection;
                //MessageBox.Show(Direction.ToString());
                this.Text = Direction.ToString();
            }
            else
            {
                // MessageBox.Show("error");
                this.Text = "Error";
            }
        }




    }
}
