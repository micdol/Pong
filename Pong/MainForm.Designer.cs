namespace Pong
{
    partial class Form_mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.panel_screen = new System.Windows.Forms.Panel();
            this.timer_ballMovement = new System.Windows.Forms.Timer(this.components);
            this.panel_paddle = new System.Windows.Forms.Panel();
            this.panel_screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(582, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(582, 41);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // panel_screen
            // 
            this.panel_screen.BackColor = System.Drawing.Color.White;
            this.panel_screen.Controls.Add(this.panel_paddle);
            this.panel_screen.Location = new System.Drawing.Point(12, 12);
            this.panel_screen.Name = "panel_screen";
            this.panel_screen.Size = new System.Drawing.Size(564, 449);
            this.panel_screen.TabIndex = 3;
            this.panel_screen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_screen_Paint);
            this.panel_screen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_screen_MouseMove);
            // 
            // timer_ballMovement
            // 
            this.timer_ballMovement.Interval = 17;
            this.timer_ballMovement.Tick += new System.EventHandler(this.timer_ballMovement_Tick);
            // 
            // panel_paddle
            // 
            this.panel_paddle.BackColor = System.Drawing.Color.Black;
            this.panel_paddle.Location = new System.Drawing.Point(200, 355);
            this.panel_paddle.Name = "panel_paddle";
            this.panel_paddle.Size = new System.Drawing.Size(170, 30);
            this.panel_paddle.TabIndex = 0;
            // 
            // Form_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 473);
            this.Controls.Add(this.panel_screen);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_start);
            this.Name = "Form_mainForm";
            this.Text = "Pong";
            this.panel_screen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Panel panel_screen;
        private System.Windows.Forms.Timer timer_ballMovement;
        private System.Windows.Forms.Panel panel_paddle;
    }
}

