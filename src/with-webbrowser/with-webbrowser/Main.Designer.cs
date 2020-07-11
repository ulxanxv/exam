namespace with_webbrowser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.infoPanelToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgrammButton = new System.Windows.Forms.ToolStripButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.doItButton = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xPointLabel = new System.Windows.Forms.Label();
            this.yPointLabel = new System.Windows.Forms.Label();
            this.closeDocButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoPanelToolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(860, 388);
            this.webBrowser1.TabIndex = 0;
            // 
            // infoPanelToolStrip
            // 
            this.infoPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton,
            this.toolStripSeparator1,
            this.aboutProgrammButton});
            this.infoPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            this.infoPanelToolStrip.Name = "infoPanelToolStrip";
            this.infoPanelToolStrip.Size = new System.Drawing.Size(884, 25);
            this.infoPanelToolStrip.TabIndex = 1;
            this.infoPanelToolStrip.Text = "toolStrip1";
            // 
            // fileMenuButton
            // 
            this.fileMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.exitButton});
            this.fileMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuButton.Image")));
            this.fileMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuButton.Name = "fileMenuButton";
            this.fileMenuButton.Size = new System.Drawing.Size(49, 22);
            this.fileMenuButton.Text = "Файл";
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(180, 22);
            this.openFileButton.Text = "Открыть";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 22);
            this.exitButton.Text = "Выход";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutProgrammButton
            // 
            this.aboutProgrammButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutProgrammButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutProgrammButton.Image")));
            this.aboutProgrammButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutProgrammButton.Name = "aboutProgrammButton";
            this.aboutProgrammButton.Size = new System.Drawing.Size(86, 22);
            this.aboutProgrammButton.Text = "О программе";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // doItButton
            // 
            this.doItButton.Location = new System.Drawing.Point(518, 484);
            this.doItButton.Name = "doItButton";
            this.doItButton.Size = new System.Drawing.Size(174, 37);
            this.doItButton.TabIndex = 3;
            this.doItButton.Text = "Рассчитать";
            this.doItButton.UseVisualStyleBackColor = true;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(12, 467);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(219, 20);
            this.xTextBox.TabIndex = 4;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(12, 493);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(219, 20);
            this.yTextBox.TabIndex = 4;
            // 
            // xPointLabel
            // 
            this.xPointLabel.AutoSize = true;
            this.xPointLabel.Location = new System.Drawing.Point(237, 470);
            this.xPointLabel.Name = "xPointLabel";
            this.xPointLabel.Size = new System.Drawing.Size(54, 13);
            this.xPointLabel.TabIndex = 5;
            this.xPointLabel.Text = "— точка X";
            // 
            // yPointLabel
            // 
            this.yPointLabel.AutoSize = true;
            this.yPointLabel.Location = new System.Drawing.Point(237, 496);
            this.yPointLabel.Name = "yPointLabel";
            this.yPointLabel.Size = new System.Drawing.Size(54, 13);
            this.yPointLabel.TabIndex = 5;
            this.yPointLabel.Text = "— точка Y";
            // 
            // closeDocButton
            // 
            this.closeDocButton.Location = new System.Drawing.Point(698, 484);
            this.closeDocButton.Name = "closeDocButton";
            this.closeDocButton.Size = new System.Drawing.Size(174, 37);
            this.closeDocButton.TabIndex = 6;
            this.closeDocButton.Text = "Закрыть документ";
            this.closeDocButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 459);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(110, 17);
            this.statusLabel.Text = "Статус расчета  — ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.closeDocButton);
            this.Controls.Add(this.yPointLabel);
            this.Controls.Add(this.xPointLabel);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.doItButton);
            this.Controls.Add(this.infoPanelToolStrip);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 520);
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экзамен";
            this.infoPanelToolStrip.ResumeLayout(false);
            this.infoPanelToolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip infoPanelToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aboutProgrammButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button doItButton;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label xPointLabel;
        private System.Windows.Forms.Label yPointLabel;
        private System.Windows.Forms.Button closeDocButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

