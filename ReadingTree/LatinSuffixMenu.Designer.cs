﻿namespace ReadingTree
{
    partial class LatinSuffixMenu
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
            this.BTN_MainMenu = new System.Windows.Forms.Button();
            this.LB_Select = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.BTN_Ive = new System.Windows.Forms.Button();
            this.BTN_Chun = new System.Windows.Forms.Button();
            this.BTN_Shun = new System.Windows.Forms.Button();
            this.BTN_zhun = new System.Windows.Forms.Button();
            this.BTN_Tion = new System.Windows.Forms.Button();
            this.BTN_Ture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_MainMenu
            // 
            this.BTN_MainMenu.Location = new System.Drawing.Point(166, 254);
            this.BTN_MainMenu.Name = "BTN_MainMenu";
            this.BTN_MainMenu.Size = new System.Drawing.Size(83, 45);
            this.BTN_MainMenu.TabIndex = 19;
            this.BTN_MainMenu.Text = "Main Menu";
            this.BTN_MainMenu.UseVisualStyleBackColor = true;
            this.BTN_MainMenu.Click += new System.EventHandler(this.BTN_MainMenu_Click);
            // 
            // LB_Select
            // 
            this.LB_Select.AutoSize = true;
            this.LB_Select.Location = new System.Drawing.Point(105, 62);
            this.LB_Select.Name = "LB_Select";
            this.LB_Select.Size = new System.Drawing.Size(213, 13);
            this.LB_Select.TabIndex = 20;
            this.LB_Select.Text = "Please select a category below to continue!";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(178, 23);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(59, 13);
            this.LB_Title.TabIndex = 21;
            this.LB_Title.Text = "Latin Suffix";
            // 
            // BTN_Ive
            // 
            this.BTN_Ive.Location = new System.Drawing.Point(59, 107);
            this.BTN_Ive.Name = "BTN_Ive";
            this.BTN_Ive.Size = new System.Drawing.Size(83, 45);
            this.BTN_Ive.TabIndex = 22;
            this.BTN_Ive.Text = "-Ive";
            this.BTN_Ive.UseVisualStyleBackColor = true;
            // 
            // BTN_Chun
            // 
            this.BTN_Chun.Location = new System.Drawing.Point(166, 107);
            this.BTN_Chun.Name = "BTN_Chun";
            this.BTN_Chun.Size = new System.Drawing.Size(83, 45);
            this.BTN_Chun.TabIndex = 23;
            this.BTN_Chun.Text = "-Sion /chun/";
            this.BTN_Chun.UseVisualStyleBackColor = true;
            // 
            // BTN_Shun
            // 
            this.BTN_Shun.Location = new System.Drawing.Point(274, 107);
            this.BTN_Shun.Name = "BTN_Shun";
            this.BTN_Shun.Size = new System.Drawing.Size(83, 45);
            this.BTN_Shun.TabIndex = 24;
            this.BTN_Shun.Text = "-Sion /shun/";
            this.BTN_Shun.UseVisualStyleBackColor = true;
            // 
            // BTN_zhun
            // 
            this.BTN_zhun.Location = new System.Drawing.Point(59, 171);
            this.BTN_zhun.Name = "BTN_zhun";
            this.BTN_zhun.Size = new System.Drawing.Size(83, 45);
            this.BTN_zhun.TabIndex = 25;
            this.BTN_zhun.Text = "-Sion /zhun/";
            this.BTN_zhun.UseVisualStyleBackColor = true;
            // 
            // BTN_Tion
            // 
            this.BTN_Tion.Location = new System.Drawing.Point(166, 171);
            this.BTN_Tion.Name = "BTN_Tion";
            this.BTN_Tion.Size = new System.Drawing.Size(83, 45);
            this.BTN_Tion.TabIndex = 26;
            this.BTN_Tion.Text = "-Tion";
            this.BTN_Tion.UseVisualStyleBackColor = true;
            // 
            // BTN_Ture
            // 
            this.BTN_Ture.Location = new System.Drawing.Point(274, 171);
            this.BTN_Ture.Name = "BTN_Ture";
            this.BTN_Ture.Size = new System.Drawing.Size(83, 45);
            this.BTN_Ture.TabIndex = 27;
            this.BTN_Ture.Text = "-Ture AND -Ure";
            this.BTN_Ture.UseVisualStyleBackColor = true;
            // 
            // LatinSuffixMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 332);
            this.Controls.Add(this.BTN_Ture);
            this.Controls.Add(this.BTN_Tion);
            this.Controls.Add(this.BTN_zhun);
            this.Controls.Add(this.BTN_Shun);
            this.Controls.Add(this.BTN_Chun);
            this.Controls.Add(this.BTN_Ive);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.LB_Select);
            this.Controls.Add(this.BTN_MainMenu);
            this.Name = "LatinSuffixMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_MainMenu;
        private System.Windows.Forms.Label LB_Select;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Button BTN_Ive;
        private System.Windows.Forms.Button BTN_Chun;
        private System.Windows.Forms.Button BTN_Shun;
        private System.Windows.Forms.Button BTN_zhun;
        private System.Windows.Forms.Button BTN_Tion;
        private System.Windows.Forms.Button BTN_Ture;
    }
}