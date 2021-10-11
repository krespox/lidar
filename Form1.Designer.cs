namespace lidar
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
            this.components = new System.ComponentModel.Container();
            this.board = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.connectoToComPort = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connection = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.startScan = new System.Windows.Forms.Button();
            this.getHeight = new System.Windows.Forms.Label();
            this.meter = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.SaveSurface = new System.Windows.Forms.Button();
            this.LoadSurface = new System.Windows.Forms.Button();
            this.diodstate = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.board.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.board.Controls.Add(this.panel5);
            this.board.Location = new System.Drawing.Point(267, 18);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(521, 400);
            this.board.TabIndex = 0;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.board_Paint_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.panel5.Location = new System.Drawing.Point(266, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 2);
            this.panel5.TabIndex = 10;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.ForeColor = System.Drawing.Color.Coral;
            this.result.Location = new System.Drawing.Point(173, 5);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(70, 22);
            this.result.TabIndex = 9;
            this.result.Text = "Results";
            this.result.Visible = false;
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.area.Location = new System.Drawing.Point(40, 110);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(0, 22);
            this.area.TabIndex = 7;
            // 
            // connectoToComPort
            // 
            this.connectoToComPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.connectoToComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectoToComPort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectoToComPort.ForeColor = System.Drawing.Color.Coral;
            this.connectoToComPort.Location = new System.Drawing.Point(3, 17);
            this.connectoToComPort.Name = "connectoToComPort";
            this.connectoToComPort.Size = new System.Drawing.Size(127, 48);
            this.connectoToComPort.TabIndex = 0;
            this.connectoToComPort.Text = "Connect";
            this.connectoToComPort.UseVisualStyleBackColor = false;
            this.connectoToComPort.Click += new System.EventHandler(this.connectoToComPort_Click);
            // 
            // connection
            // 
            this.connection.AutoSize = true;
            this.connection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.connection.Location = new System.Drawing.Point(270, 425);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(0, 16);
            this.connection.TabIndex = 1;
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(101)))));
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.ForeColor = System.Drawing.Color.Coral;
            this.Disconnect.Location = new System.Drawing.Point(136, 17);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(127, 48);
            this.Disconnect.TabIndex = 2;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // startScan
            // 
            this.startScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.startScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startScan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startScan.ForeColor = System.Drawing.Color.Coral;
            this.startScan.Location = new System.Drawing.Point(3, 71);
            this.startScan.Name = "startScan";
            this.startScan.Size = new System.Drawing.Size(260, 31);
            this.startScan.TabIndex = 3;
            this.startScan.Text = "Start Scan";
            this.startScan.UseVisualStyleBackColor = false;
            this.startScan.Click += new System.EventHandler(this.startScan_Click);
            // 
            // getHeight
            // 
            this.getHeight.AutoSize = true;
            this.getHeight.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.getHeight.Location = new System.Drawing.Point(40, 50);
            this.getHeight.Name = "getHeight";
            this.getHeight.Size = new System.Drawing.Size(0, 22);
            this.getHeight.TabIndex = 4;
            // 
            // meter
            // 
            this.meter.AutoSize = true;
            this.meter.Location = new System.Drawing.Point(94, 168);
            this.meter.Name = "meter";
            this.meter.Size = new System.Drawing.Size(66, 13);
            this.meter.TabIndex = 5;
            this.meter.Text = "FromArduino";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.width.Location = new System.Drawing.Point(40, 80);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(0, 22);
            this.width.TabIndex = 6;
            // 
            // SaveSurface
            // 
            this.SaveSurface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.SaveSurface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSurface.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveSurface.ForeColor = System.Drawing.Color.Coral;
            this.SaveSurface.Location = new System.Drawing.Point(3, 196);
            this.SaveSurface.Name = "SaveSurface";
            this.SaveSurface.Size = new System.Drawing.Size(125, 23);
            this.SaveSurface.TabIndex = 8;
            this.SaveSurface.Text = "Safe surface";
            this.SaveSurface.UseVisualStyleBackColor = false;
            this.SaveSurface.Click += new System.EventHandler(this.SaveSurface_Click);
            // 
            // LoadSurface
            // 
            this.LoadSurface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.LoadSurface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSurface.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadSurface.ForeColor = System.Drawing.Color.Coral;
            this.LoadSurface.Location = new System.Drawing.Point(134, 196);
            this.LoadSurface.Name = "LoadSurface";
            this.LoadSurface.Size = new System.Drawing.Size(129, 23);
            this.LoadSurface.TabIndex = 9;
            this.LoadSurface.TabStop = false;
            this.LoadSurface.Text = "Load surface";
            this.LoadSurface.UseVisualStyleBackColor = false;
            this.LoadSurface.Click += new System.EventHandler(this.LoadSurface_Click);
            // 
            // diodstate
            // 
            this.diodstate.BackColor = System.Drawing.Color.Maroon;
            this.diodstate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.diodstate.FlatAppearance.BorderSize = 3;
            this.diodstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diodstate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.diodstate.Location = new System.Drawing.Point(110, 128);
            this.diodstate.Name = "diodstate";
            this.diodstate.Size = new System.Drawing.Size(20, 20);
            this.diodstate.TabIndex = 0;
            this.diodstate.TabStop = false;
            this.diodstate.UseVisualStyleBackColor = false;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.state.Location = new System.Drawing.Point(136, 127);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(53, 21);
            this.state.TabIndex = 10;
            this.state.Text = "State";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.result);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.area);
            this.panel1.Controls.Add(this.getHeight);
            this.panel1.Controls.Add(this.width);
            this.panel1.Location = new System.Drawing.Point(3, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 167);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            this.panel1.VisibleChanged += new System.EventHandler(this.panel1_VisibleChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.panel3.Location = new System.Drawing.Point(160, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 2);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.panel2.Location = new System.Drawing.Point(3, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 2);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.Location = new System.Drawing.Point(263, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 2);
            this.panel4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.diodstate);
            this.Controls.Add(this.LoadSurface);
            this.Controls.Add(this.SaveSurface);
            this.Controls.Add(this.meter);
            this.Controls.Add(this.startScan);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.connectoToComPort);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Miernik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.board.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Button connectoToComPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label connection;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button startScan;
        private System.Windows.Forms.Label getHeight;
        private System.Windows.Forms.Label meter;
        private System.Windows.Forms.Label width;
        
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Button SaveSurface;
        private System.Windows.Forms.Button LoadSurface;
        private System.Windows.Forms.Button diodstate;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

