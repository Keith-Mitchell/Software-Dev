﻿namespace CS478_text_adventure_game
{
    partial class startForm
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
            this.start = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(286, 171);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(204, 74);
            this.start.TabIndex = 0;
            this.start.Text = "START GAME";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(286, 251);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(204, 74);
            this.options.TabIndex = 1;
            this.options.Text = "OPTIONS";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(286, 331);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(204, 74);
            this.exit.TabIndex = 2;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.options);
            this.Controls.Add(this.start);
            this.Name = "startForm";
            this.Text = "Start Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exit;
    }
}

