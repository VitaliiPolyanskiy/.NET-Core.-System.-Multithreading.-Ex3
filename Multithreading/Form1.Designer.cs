
namespace Multithreading
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слайдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thread1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thread2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thread3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thread4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartThreadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendThreadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResumeThreadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.слайдToolStripMenuItem,
            this.времяToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.playToolStripMenuItem.Text = "Потоки";
            // 
            // слайдToolStripMenuItem
            // 
            this.слайдToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thread1ToolStripMenuItem,
            this.thread2ToolStripMenuItem,
            this.thread3ToolStripMenuItem,
            this.thread4ToolStripMenuItem});
            this.слайдToolStripMenuItem.Name = "слайдToolStripMenuItem";
            this.слайдToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.слайдToolStripMenuItem.Text = "Слайд-шоу";
            // 
            // thread1ToolStripMenuItem
            // 
            this.thread1ToolStripMenuItem.Name = "thread1ToolStripMenuItem";
            this.thread1ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.thread1ToolStripMenuItem.Text = "Поток 1";
            this.thread1ToolStripMenuItem.Click += new System.EventHandler(this.thread1ToolStripMenuItem_Click);
            // 
            // thread2ToolStripMenuItem
            // 
            this.thread2ToolStripMenuItem.Name = "thread2ToolStripMenuItem";
            this.thread2ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.thread2ToolStripMenuItem.Text = "Поток 2";
            this.thread2ToolStripMenuItem.Click += new System.EventHandler(this.thread2ToolStripMenuItem_Click);
            // 
            // thread3ToolStripMenuItem
            // 
            this.thread3ToolStripMenuItem.Name = "thread3ToolStripMenuItem";
            this.thread3ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.thread3ToolStripMenuItem.Text = "Поток 3";
            this.thread3ToolStripMenuItem.Click += new System.EventHandler(this.thread3ToolStripMenuItem_Click);
            // 
            // thread4ToolStripMenuItem
            // 
            this.thread4ToolStripMenuItem.Name = "thread4ToolStripMenuItem";
            this.thread4ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.thread4ToolStripMenuItem.Text = "Поток 4";
            this.thread4ToolStripMenuItem.Click += new System.EventHandler(this.thread4ToolStripMenuItem_Click);
            // 
            // времяToolStripMenuItem
            // 
            this.времяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartThreadMenuItem,
            this.SuspendThreadMenuItem,
            this.ResumeThreadMenuItem});
            this.времяToolStripMenuItem.Name = "времяToolStripMenuItem";
            this.времяToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.времяToolStripMenuItem.Text = "Время";
            // 
            // StartThreadMenuItem
            // 
            this.StartThreadMenuItem.Name = "StartThreadMenuItem";
            this.StartThreadMenuItem.Size = new System.Drawing.Size(219, 22);
            this.StartThreadMenuItem.Text = "Запустить поток";
            this.StartThreadMenuItem.Click += new System.EventHandler(this.StartThreadMenuItem_Click);
            // 
            // SuspendThreadMenuItem
            // 
            this.SuspendThreadMenuItem.Enabled = false;
            this.SuspendThreadMenuItem.Name = "SuspendThreadMenuItem";
            this.SuspendThreadMenuItem.Size = new System.Drawing.Size(219, 22);
            this.SuspendThreadMenuItem.Text = "Приостановить поток";
            this.SuspendThreadMenuItem.Click += new System.EventHandler(this.SuspendThreadMenuItem_Click);
            // 
            // ResumeThreadMenuItem
            // 
            this.ResumeThreadMenuItem.Enabled = false;
            this.ResumeThreadMenuItem.Name = "ResumeThreadMenuItem";
            this.ResumeThreadMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ResumeThreadMenuItem.Text = "Восстановить исполнение";
            this.ResumeThreadMenuItem.Click += new System.EventHandler(this.ResumeThreadMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Многопоточность";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слайдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartThreadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuspendThreadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResumeThreadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thread1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thread2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thread3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thread4ToolStripMenuItem;
    }
}

