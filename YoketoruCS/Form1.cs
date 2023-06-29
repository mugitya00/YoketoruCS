using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        //—ñ‹“Žqenum
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }

        State nextState = State.Title;
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeState();
            UpdateState();
        }
        void ChangeState()
        {
            if (nextState == State.None) return;

            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;
                    labelGameover.Visible = false;
                    buttonTitle.Visible = false;
                    labelClear.Visible = false;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;

                    break;

                    case State.Gameover:
                    labelGameover.Visible = false;
                    buttonTitle.Visible= false;
                    break;

                    case State.Clear:
                    labelClear.Visible = false;
                    break;

            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}