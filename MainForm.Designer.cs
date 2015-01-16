/*
 * Сделано в SharpDevelop.
 * Пользователь: 055makarov
 * Дата: 16.10.2014
 * Время: 13:42
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace RemoteLaunchAppClient
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.txtTimeToExit = new System.Windows.Forms.TextBox();
            this.btnCheckConnect = new System.Windows.Forms.Button();
            this.btnSearchHosts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rIntEnabled = new System.Windows.Forms.RadioButton();
            this.rIntDisabled = new System.Windows.Forms.RadioButton();
            this.menuHostHistoy = new System.Windows.Forms.MenuStrip();
            this.историяХостовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuHostHistoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(368, 156);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(155, 30);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Выполнить";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.BtnLaunchClick);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(36, 192);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(487, 154);
            this.txtOutput.TabIndex = 1;
            // 
            // txtComputerName
            // 
            this.txtComputerName.Location = new System.Drawing.Point(36, 55);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(177, 20);
            this.txtComputerName.TabIndex = 2;
            // 
            // txtTimeToExit
            // 
            this.txtTimeToExit.Location = new System.Drawing.Point(219, 53);
            this.txtTimeToExit.Name = "txtTimeToExit";
            this.txtTimeToExit.Size = new System.Drawing.Size(114, 20);
            this.txtTimeToExit.TabIndex = 3;
            // 
            // btnCheckConnect
            // 
            this.btnCheckConnect.Location = new System.Drawing.Point(395, 22);
            this.btnCheckConnect.Name = "btnCheckConnect";
            this.btnCheckConnect.Size = new System.Drawing.Size(128, 23);
            this.btnCheckConnect.TabIndex = 4;
            this.btnCheckConnect.Text = "Проверка соединения";
            this.btnCheckConnect.UseVisualStyleBackColor = true;
            this.btnCheckConnect.Click += new System.EventHandler(this.BtnCheckConnectionClick);
            // 
            // btnSearchHosts
            // 
            this.btnSearchHosts.Location = new System.Drawing.Point(395, 55);
            this.btnSearchHosts.Name = "btnSearchHosts";
            this.btnSearchHosts.Size = new System.Drawing.Size(128, 23);
            this.btnSearchHosts.TabIndex = 5;
            this.btnSearchHosts.Text = "Поиск серверов";
            this.btnSearchHosts.UseVisualStyleBackColor = true;
            this.btnSearchHosts.Click += new System.EventHandler(this.BtnSearchHostsClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(216, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время жизни процесса:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNS/IP компьютера";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(36, 166);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(326, 20);
            this.txtInput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выполняемая комманда:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rIntEnabled);
            this.groupBox1.Controls.Add(this.rIntDisabled);
            this.groupBox1.Location = new System.Drawing.Point(36, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rIntEnabled
            // 
            this.rIntEnabled.Location = new System.Drawing.Point(6, 36);
            this.rIntEnabled.Name = "rIntEnabled";
            this.rIntEnabled.Size = new System.Drawing.Size(171, 24);
            this.rIntEnabled.TabIndex = 1;
            this.rIntEnabled.TabStop = true;
            this.rIntEnabled.Text = "запуск сессии консоли";
            this.rIntEnabled.UseVisualStyleBackColor = true;
            this.rIntEnabled.CheckedChanged += new System.EventHandler(this.RIntEnabledCheckedChanged);
            // 
            // rIntDisabled
            // 
            this.rIntDisabled.Checked = true;
            this.rIntDisabled.Location = new System.Drawing.Point(6, 10);
            this.rIntDisabled.Name = "rIntDisabled";
            this.rIntDisabled.Size = new System.Drawing.Size(220, 24);
            this.rIntDisabled.TabIndex = 0;
            this.rIntDisabled.TabStop = true;
            this.rIntDisabled.Text = "запуск процесса";
            this.rIntDisabled.UseVisualStyleBackColor = true;
            // 
            // menuHostHistoy
            // 
            this.menuHostHistoy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяХостовToolStripMenuItem});
            this.menuHostHistoy.Location = new System.Drawing.Point(0, 0);
            this.menuHostHistoy.Name = "menuHostHistoy";
            this.menuHostHistoy.Size = new System.Drawing.Size(535, 24);
            this.menuHostHistoy.TabIndex = 11;
            this.menuHostHistoy.Text = "menuHostHistory";
            // 
            // историяХостовToolStripMenuItem
            // 
            this.историяХостовToolStripMenuItem.Name = "историяХостовToolStripMenuItem";
            this.историяХостовToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.историяХостовToolStripMenuItem.Text = "История хостов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchHosts);
            this.Controls.Add(this.btnCheckConnect);
            this.Controls.Add(this.txtTimeToExit);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.menuHostHistoy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuHostHistoy;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалённый запуск программ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.groupBox1.ResumeLayout(false);
            this.menuHostHistoy.ResumeLayout(false);
            this.menuHostHistoy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.ToolStripMenuItem историяХостовToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuHostHistoy;
		private System.Windows.Forms.RadioButton rIntEnabled;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rIntDisabled;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearchHosts;
		private System.Windows.Forms.Button btnCheckConnect;
		private System.Windows.Forms.TextBox txtTimeToExit;
		private System.Windows.Forms.TextBox txtComputerName;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnLaunch;
	}
}
