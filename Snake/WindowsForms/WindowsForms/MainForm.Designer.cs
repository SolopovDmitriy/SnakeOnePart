namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip_MenuForm = new System.Windows.Forms.ToolStrip();
            this.menuStrip_MainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_MainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 703);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1139, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_MenuForm
            // 
            this.toolStrip_MenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_MenuForm.Location = new System.Drawing.Point(0, 28);
            this.toolStrip_MenuForm.Name = "toolStrip_MenuForm";
            this.toolStrip_MenuForm.Size = new System.Drawing.Size(1139, 25);
            this.toolStrip_MenuForm.TabIndex = 1;
            this.toolStrip_MenuForm.Text = "toolStrip1";
            // 
            // menuStrip_MainForm
            // 
            this.menuStrip_MainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_MainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainForm.Name = "menuStrip_MainForm";
            this.menuStrip_MainForm.Size = new System.Drawing.Size(1139, 28);
            this.menuStrip_MainForm.TabIndex = 2;
            this.menuStrip_MainForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // panelMainForm
            // 
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(0, 53);
            this.panelMainForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(1139, 650);
            this.panelMainForm.TabIndex = 3;
            // 
            // timerTest
            // 
            this.timerTest.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 725);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.toolStrip_MenuForm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip_MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip_MainForm;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
           
            this.menuStrip_MainForm.ResumeLayout(false);
            this.menuStrip_MainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip_MenuForm;
        private System.Windows.Forms.MenuStrip menuStrip_MainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.Timer timerTest;
    }
}

