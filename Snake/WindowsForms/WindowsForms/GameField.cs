using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class GameField
    {
        private GameFieldControl _gameFieldControl;
        public GameFieldControl GameFieldControl
        {
            get
            {
                return _gameFieldControl;
            }
        }
        public GameField()
        {
            _gameFieldControl = new GameFieldControl();
            _gameFieldControl.BackColor = Color.Cyan;
            _gameFieldControl.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
