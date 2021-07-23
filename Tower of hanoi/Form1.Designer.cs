
namespace Tower_of_hanoi
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 27);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_mDown);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_mMove);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_mUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 166);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 166);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 166);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 27);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_mDown);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button5_mMove);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_mUp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(95, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 27);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_mDown);
            this.button6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button6_mMove);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_mUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1058, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

