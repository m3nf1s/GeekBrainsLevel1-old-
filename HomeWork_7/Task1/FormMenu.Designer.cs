namespace Task1
{
    partial class FormMenu
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
            this.buttonMenuDoubler = new System.Windows.Forms.Button();
            this.buttonVacation = new System.Windows.Forms.Button();
            this.buttonMenuGuessTheButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMenuDoubler
            // 
            this.buttonMenuDoubler.Location = new System.Drawing.Point(12, 57);
            this.buttonMenuDoubler.Name = "buttonMenuDoubler";
            this.buttonMenuDoubler.Size = new System.Drawing.Size(111, 59);
            this.buttonMenuDoubler.TabIndex = 0;
            this.buttonMenuDoubler.Text = "Удвоитель";
            this.buttonMenuDoubler.UseVisualStyleBackColor = true;
            this.buttonMenuDoubler.Click += new System.EventHandler(this.buttonMenuDoubler_Click);
            // 
            // buttonVacation
            // 
            this.buttonVacation.Location = new System.Drawing.Point(284, 57);
            this.buttonVacation.Name = "buttonVacation";
            this.buttonVacation.Size = new System.Drawing.Size(111, 59);
            this.buttonVacation.TabIndex = 3;
            this.buttonVacation.Text = "Заявление на отпуск";
            this.buttonVacation.UseVisualStyleBackColor = true;
            this.buttonVacation.Click += new System.EventHandler(this.buttonVacation_Click);
            // 
            // buttonMenuGuessTheButton
            // 
            this.buttonMenuGuessTheButton.Location = new System.Drawing.Point(149, 57);
            this.buttonMenuGuessTheButton.Name = "buttonMenuGuessTheButton";
            this.buttonMenuGuessTheButton.Size = new System.Drawing.Size(111, 59);
            this.buttonMenuGuessTheButton.TabIndex = 4;
            this.buttonMenuGuessTheButton.Text = "Угадай число";
            this.buttonMenuGuessTheButton.UseVisualStyleBackColor = true;
            this.buttonMenuGuessTheButton.Click += new System.EventHandler(this.buttonMenuGuessTheButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 162);
            this.Controls.Add(this.buttonMenuGuessTheButton);
            this.Controls.Add(this.buttonVacation);
            this.Controls.Add(this.buttonMenuDoubler);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenuDoubler;
        private System.Windows.Forms.Button buttonVacation;
        private System.Windows.Forms.Button buttonMenuGuessTheButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}