using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Tower_of_hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Locations locations = new Locations();
        private bool enableMoving = false;
        private Point initialClickedPoint;

        #region button2
        private void button2_Click(object sender, EventArgs e){}
        private void button2_mDown(object sender, MouseEventArgs e)
        {
            if (locations.counter2 == 0 && locations.counter5 == 0){}
            else if (locations.counter2 == 0 && locations.counter6 == 0){}
            else if (locations.counter2 == 1 && locations.counter5 == 1){}
            else if (locations.counter2 == 1 && locations.counter6 == 1){}
            else if (locations.counter2 == 2 && locations.counter5 == 2){}
            else if (locations.counter2 == 2 && locations.counter6 == 2){}
            else {enableMoving = true;}

            initialClickedPoint = e.Location;
            button2.Location = new Point(e.X + button2.Left - initialClickedPoint.X, e.Y + button2.Top - initialClickedPoint.Y);
            button2.Left = e.X + button2.Left - initialClickedPoint.X;
            button2.Left = e.Y + button2.Left - initialClickedPoint.Y;
            locations.Button2X = button2.Location.X;
            locations.Button2Y = button2.Location.Y;
        }
        private void button2_mUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
            if (button2.Location.X > 0 && button2.Location.X < 100)
            {
                if (locations.counter5 == 0)
                {
                    button2.Location = new Point(locations.Button2X, locations.Button2Y);
                }
                else if (locations.counter6 == 0)
                {
                    button2.Location = new Point(locations.Button2X, locations.Button2Y);
                }
                else
                {
                    button2.Location = new Point(50, 400);
                    locations.counter2 = 0;
                }
            }
            else if(button2.Location.X > 300 && button2.Location.X < 400)
            {
                if (locations.counter5 == 1)
                {
                    button2.Location = new Point(locations.Button2X, locations.Button2Y);
                }
                else if (locations.counter6 == 1)
                {
                    button2.Location = new Point(locations.Button2X, locations.Button2Y);
                }
                else
                {
                    button2.Location = new Point(350, 400);
                    locations.counter2 = 1;
                }
            }
            else if(button2.Location.X > 600 && button2.Location.X < 700)
            {
                if (locations.counter5 == 2)
                {
                    button2.Location = new Point(locations.Button2X, locations.Button2Y);
                }
                else if (locations.counter6 == 2)
                {
                    button2.Location = new Point(locations.Button2X, locations.Button2Y);
                }
                else
                {
                    button2.Location = new Point(650, 400);
                    locations.counter2 = 2;
                }
            }
            else
            {
                button2.Location = new Point(locations.Button2X, locations.Button2Y);
            }
        }
        private void button2_mMove(object sender, MouseEventArgs e)
        {
            if (enableMoving)
            {
                button2.Location = new Point(e.X + button2.Left - initialClickedPoint.X,
                    e.Y + button2.Top - initialClickedPoint.Y);
            }
        }
        #endregion
        #region button5
        private void button5_Click(object sender, EventArgs e){}

        private void button5_mDown(object sender, MouseEventArgs e)
        {
            if (locations.counter5 == 0 && locations.counter6 == 0) { }
            else if (locations.counter5 == 1 && locations.counter6 == 1) { }
            else if (locations.counter5 == 2 && locations.counter6 == 2) { }
            else{enableMoving = true;}

            initialClickedPoint = e.Location;
            button5.Location = new Point(e.X + button5.Left - initialClickedPoint.X, e.Y + button5.Top - initialClickedPoint.Y);
            button5.Left = e.X + button5.Left - initialClickedPoint.X;
            button5.Left = e.Y + button5.Left - initialClickedPoint.Y;
            locations.Button5X = button5.Location.X;
            locations.Button5Y = button5.Location.Y;
        }

        private void button5_mUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
            if (button5.Location.X > 20 && button5.Location.X < 120)
            {
                if (locations.counter6 == 0)
                {
                    button5.Location = new Point(locations.Button5X, locations.Button5Y);
                }
                else
                {
                    if (locations.counter2 != 0)
                    {
                        button5.Location = new Point(70, 400);
                    }
                    else
                    {
                        button5.Location = new Point(70, 370);
                    }
                    locations.counter5 = 0;
                }
            }
            else if (button5.Location.X > 320 && button5.Location.X < 420)
            {
                if (locations.counter6 == 1)
                {
                    button5.Location = new Point(locations.Button5X, locations.Button5Y);
                }
                else
                {
                    if (locations.counter2 != 1)
                    {
                        button5.Location = new Point(370, 400);
                    }
                    else
                    {
                        button5.Location = new Point(370, 370);
                    }
                    locations.counter5 = 1;
                }
            }
            else if (button5.Location.X > 620 && button5.Location.X < 720)
            {
                if (locations.counter6 == 2)
                {
                    button5.Location = new Point(locations.Button5X, locations.Button5Y);
                }
                else
                {
                    if (locations.counter2 != 2)
                    {
                        button5.Location = new Point(670, 400);
                    }
                    else
                    {
                        button5.Location = new Point(670, 370);
                    }
                    locations.counter5 = 2;
                }
            }
            else
            {
                button5.Location = new Point(locations.Button5X, locations.Button5Y);
            }
        }

        private void Button5_mMove(object sender, MouseEventArgs e)
        {
            if (enableMoving)
            {
                button5.Location = new Point(e.X + button5.Left - initialClickedPoint.X,
                    e.Y + button5.Top - initialClickedPoint.Y);
            }
        }
        #endregion
        #region button6
        private void button6_Click(object sender, EventArgs e){}
        private void button6_mDown(object sender, MouseEventArgs e)
        {
            enableMoving = true;
            initialClickedPoint = e.Location;
            button6.Location = new Point(e.X + button6.Left - initialClickedPoint.X, e.Y + button6.Top - initialClickedPoint.Y);
            button6.Left = e.X + button6.Left - initialClickedPoint.X;
            button6.Left = e.Y + button6.Left - initialClickedPoint.Y;
            locations.Button6X = button6.Location.X;
            locations.Button6Y = button6.Location.Y;
        }
        private void button6_mUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
            if (button6.Location.X > 45 && button6.Location.X < 145)
            {
                if (locations.counter2 == 0 && locations.counter5 != 0)
                {
                    button6.Location = new Point(95, 370);
                }
                else if (locations.counter2 != 0 && locations.counter5 == 0)
                {
                    button6.Location = new Point(95, 370);
                }
                else if (locations.counter2 != 0 && locations.counter5 != 0)
                {
                    button6.Location = new Point(95, 400);
                }
                else
                {
                    button6.Location = new Point(95, 340);
                }
                locations.counter6 = 0;
            }
            else if (button6.Location.X > 345 && button6.Location.X < 445)
            {
                if (locations.counter2 == 1 && locations.counter5 != 1)
                {
                    button6.Location = new Point(395, 370);
                }
                else if (locations.counter2 != 1 && locations.counter5 == 1)
                {
                    button6.Location = new Point(395, 370);
                }
                else if (locations.counter2 != 1 && locations.counter5 != 1)
                {
                    button6.Location = new Point(395, 400);
                }
                else
                {
                    button6.Location = new Point(395, 340);
                }
                locations.counter6 = 1;
            }
            else if (button6.Location.X > 645 && button6.Location.X < 745)
            {
                if (locations.counter2 == 2 && locations.counter5 != 2)
                {
                    button6.Location = new Point(695, 370);
                }
                else if (locations.counter2 != 2 && locations.counter5 == 2)
                {
                    button6.Location = new Point(695, 370);
                }
                else if (locations.counter2 != 2 && locations.counter5 != 2)
                {
                    button6.Location = new Point(695, 400);
                }
                else
                {
                    button6.Location = new Point(695, 340);
                }
                locations.counter6 = 2;
            }
            else
            {
                button6.Location = new Point(locations.Button6X, locations.Button6Y);
            }
        }
        private void button6_mMove(object sender, MouseEventArgs e)
        {
            if (enableMoving)
            {
                button6.Location = new Point(e.X + button6.Left - initialClickedPoint.X,
                    e.Y + button6.Top - initialClickedPoint.Y);
            }
        }
        #endregion
    }
}
