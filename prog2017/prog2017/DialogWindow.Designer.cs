using System;

namespace prog2017
{
    partial class DialogWindow
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.Introduction = new System.Windows.Forms.Label();
            this.QuestionsBox = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.QuestionsCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // Key A
            //
            // this.AButton_Press;
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YesButton.Enabled = false;
            this.YesButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.YesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.YesButton.Location = new System.Drawing.Point(50, 200);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(80, 50);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Visible = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NoButton.Enabled = false;
            this.NoButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.NoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.NoButton.Location = new System.Drawing.Point(200, 200);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(80, 50);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Visible = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // Introduction
            // 
            this.Introduction.BackColor = System.Drawing.Color.Transparent;
            this.Introduction.CausesValidation = false;
            this.Introduction.Font = new System.Drawing.Font("HP Simplified", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Introduction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Introduction.Location = new System.Drawing.Point(22, 50);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(305, 22);
            this.Introduction.TabIndex = 2;
            this.Introduction.Text = "Guess  a number and press \"Start\" ";
            this.Introduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Introduction.UseMnemonic = false;
            this.Introduction.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuestionsBox
            // 
            this.QuestionsBox.BackColor = System.Drawing.Color.SeaGreen;
            this.QuestionsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionsBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuestionsBox.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionsBox.ForeColor = System.Drawing.Color.White;
            this.QuestionsBox.Location = new System.Drawing.Point(50, 100);
            this.QuestionsBox.Name = "QuestionsBox";
            this.QuestionsBox.Size = new System.Drawing.Size(230, 33);
            this.QuestionsBox.TabIndex = 3;
            this.QuestionsBox.Text = String.Empty;
            this.QuestionsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionsBox.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StartButton.Font = new System.Drawing.Font("HP Simplified", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.Color.DimGray;
            this.StartButton.Location = new System.Drawing.Point(72, 159);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(230, 50);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start guess";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // QuestionsCounter
            // 
            this.QuestionsCounter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QuestionsCounter.Enabled = false;
            this.QuestionsCounter.Font = new System.Drawing.Font("HP Simplified", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuestionsCounter.Location = new System.Drawing.Point(360, 100);
            this.QuestionsCounter.Name = "QuestionsCounter";
            this.QuestionsCounter.Size = new System.Drawing.Size(105, 33);
            this.QuestionsCounter.TabIndex = 5;
            this.QuestionsCounter.Text = "Answered questions:";
            this.QuestionsCounter.Visible = false;
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prog2017.Properties.Resources.Jellyfish;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(567, 347);
            this.Controls.Add(this.QuestionsCounter);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.QuestionsBox);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogWindow";
            this.Text = "DialogWindow";
            this.Load += new System.EventHandler(this.DialogWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label Introduction;
        private System.Windows.Forms.Label QuestionsBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label QuestionsCounter;
    }
}