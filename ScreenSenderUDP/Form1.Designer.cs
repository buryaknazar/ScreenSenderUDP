namespace ScreenSenderUDP
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
            label1 = new Label();
            tbAddress = new TextBox();
            tbPort = new TextBox();
            tbPortLabel = new Label();
            tbInterval = new TextBox();
            label3 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 0;
            label1.Text = "Address:";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbAddress.Location = new Point(95, 17);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(100, 21);
            tbAddress.TabIndex = 1;
            tbAddress.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            tbPort.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbPort.Location = new Point(95, 92);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(100, 21);
            tbPort.TabIndex = 3;
            tbPort.Text = "9999";
            // 
            // tbPortLabel
            // 
            tbPortLabel.AutoSize = true;
            tbPortLabel.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPortLabel.ForeColor = Color.WhiteSmoke;
            tbPortLabel.Location = new Point(18, 92);
            tbPortLabel.Name = "tbPortLabel";
            tbPortLabel.Size = new Size(48, 17);
            tbPortLabel.TabIndex = 2;
            tbPortLabel.Text = "Port:";
            // 
            // tbInterval
            // 
            tbInterval.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbInterval.Location = new Point(96, 54);
            tbInterval.Name = "tbInterval";
            tbInterval.Size = new Size(100, 21);
            tbInterval.TabIndex = 5;
            tbInterval.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(17, 56);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 4;
            label3.Text = "Interval:";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(22, 163);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStop.Location = new Point(121, 163);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 29);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(215, 204);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(tbInterval);
            Controls.Add(label3);
            Controls.Add(tbPort);
            Controls.Add(tbPortLabel);
            Controls.Add(tbAddress);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ScreenSender";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbAddress;
        private TextBox tbPort;
        private Label tbPortLabel;
        private TextBox tbInterval;
        private Label label3;
        private Button btnStart;
        private Button btnStop;
    }
}