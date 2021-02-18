using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btn_roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int dice = rnd.Next(1, 6);
        
            lb_dice.Text = Convert.ToString(dice);
            for (byte i = 0; i < dice; i++)
            {
                if (pb_pion.Location.X == 200 && pb_pion.Location.Y == 15)
                {
                    btn_roll.Enabled = false;
                    btn_roll.Visible = false;
                    dice = 0;
                    MessageBox.Show("Gata!");
                }
                else
                if (  pb_pion.Location.Y== 546 || pb_pion.Location.Y ==428 || pb_pion.Location.Y == 310 || pb_pion.Location.Y == 74 || pb_pion.Location.Y == 192)
                {
                    if (pb_pion.Location.X == 672)
                    {
                        this.SuspendLayout();
                        pb_pion.Location = new Point(pb_pion.Location.X, pb_pion.Location.Y - 59);
                        this.ResumeLayout();
                    }
                    else
                    {
                        this.SuspendLayout();
                        pb_pion.Location = new Point(pb_pion.Location.X+59, pb_pion.Location.Y);
                        this.ResumeLayout();
                    }
                }
                else
                {
                    if (pb_pion.Location.X == 200 )
                    {
                        this.SuspendLayout();
                        pb_pion.Location = new Point(pb_pion.Location.X, pb_pion.Location.Y - 59);
                        this.ResumeLayout();
                    }
                    else
                    {
                        this.SuspendLayout();
                        pb_pion.Location = new Point(pb_pion.Location.X - 59, pb_pion.Location.Y);
                        this.ResumeLayout();
                    }
                }
                
           
                
            }

            if (pb_pion.Location.X == 259 && pb_pion.Location.Y == 546)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(318,369);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 377 && pb_pion.Location.Y == 546)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(554, 487);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 613 && pb_pion.Location.Y == 546)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(731, 369);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 200 && pb_pion.Location.Y == 428)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(259, 310);
                this.ResumeLayout();

            }
            else

            if (pb_pion.Location.X == 613 && pb_pion.Location.Y == 428)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(377, 74);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 336 && pb_pion.Location.Y == 369)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(377, 310);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 731 && pb_pion.Location.Y == 251)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(554, 192);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 731 && pb_pion.Location.Y == 133)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(731, 15);
                this.ResumeLayout();

            }
            else

            if (pb_pion.Location.X == 200 && pb_pion.Location.Y == 133)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(200, 15);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 318 && pb_pion.Location.Y == 15)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(318, 133);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 495 && pb_pion.Location.Y == 15)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(495, 133);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 613 && pb_pion.Location.Y == 15)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(613, 133);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 554 && pb_pion.Location.Y == 74)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(377, 428);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 377 && pb_pion.Location.Y == 192)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(200, 251);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 259 && pb_pion.Location.Y == 192)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(318, 487);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 436 && pb_pion.Location.Y == 251)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(613, 251);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 672 && pb_pion.Location.Y == 310)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(731, 487);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 554 && pb_pion.Location.Y == 310)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(495, 428);
                this.ResumeLayout();

            }
            else
                if (pb_pion.Location.X == 436 && pb_pion.Location.Y == 487)
            {
                this.SuspendLayout();
                pb_pion.Location = new Point(495, 546);
                this.ResumeLayout();

            }

        }

    }
}
