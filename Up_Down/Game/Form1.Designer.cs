
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_roll = new System.Windows.Forms.Button();
            this.lb_dice = new System.Windows.Forms.Label();
            this.pb_pion = new System.Windows.Forms.PictureBox();
            this.poz = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_roll
            // 
            this.btn_roll.AutoSize = true;
            this.btn_roll.Location = new System.Drawing.Point(819, 443);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(122, 65);
            this.btn_roll.TabIndex = 0;
            this.btn_roll.Text = "Dice";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // lb_dice
            // 
            this.lb_dice.AutoSize = true;
            this.lb_dice.Font = new System.Drawing.Font("Showcard Gothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_dice.Location = new System.Drawing.Point(834, 155);
            this.lb_dice.Name = "lb_dice";
            this.lb_dice.Size = new System.Drawing.Size(91, 119);
            this.lb_dice.TabIndex = 1;
            this.lb_dice.Text = "1";
            this.lb_dice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_pion
            // 
            this.pb_pion.BackColor = System.Drawing.Color.Transparent;
            this.pb_pion.Image = ((System.Drawing.Image)(resources.GetObject("pb_pion.Image")));
            this.pb_pion.Location = new System.Drawing.Point(200, 546);
            this.pb_pion.Name = "pb_pion";
            this.pb_pion.Size = new System.Drawing.Size(51, 58);
            this.pb_pion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pion.TabIndex = 2;
            this.pb_pion.TabStop = false;
            // 
            // poz
            // 
            this.poz.AutoSize = true;
            this.poz.Location = new System.Drawing.Point(41, 177);
            this.poz.Name = "poz";
            this.poz.Size = new System.Drawing.Size(0, 15);
            this.poz.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(179, 389);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(981, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.poz);
            this.Controls.Add(this.pb_pion);
            this.Controls.Add(this.lb_dice);
            this.Controls.Add(this.btn_roll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pb_pion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Label lb_dice;
        private System.Windows.Forms.PictureBox pb_pion;
        private System.Windows.Forms.Label poz;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}

