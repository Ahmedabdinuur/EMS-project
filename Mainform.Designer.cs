namespace EMS
{
    partial class Mainform
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panelapp = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 70, 83);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 145);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(148, 30);
            label1.Name = "label1";
            label1.Size = new Size(767, 67);
            label1.TabIndex = 1;
            label1.Text = "Employee Management System";
            label1.MouseDown += panel1_MouseDown;
            label1.MouseMove += panel1_MouseMove;
            label1.MouseUp += panel1_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 70, 87);
            panel2.BackgroundImage = Properties.Resources.close;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(997, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(53, 51);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            // 
            // panelapp
            // 
            panelapp.BackColor = Color.FromArgb(244, 162, 97);
            panelapp.Dock = DockStyle.Bottom;
            panelapp.Location = new Point(0, 237);
            panelapp.Margin = new Padding(0);
            panelapp.Name = "panelapp";
            panelapp.Size = new Size(1062, 436);
            panelapp.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(0, 145);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1062, 92);
            panel4.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(200, 182, 255);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(788, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(274, 92);
            button4.TabIndex = 0;
            button4.Text = "Search Employee";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 77, 109);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(526, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(265, 92);
            button3.TabIndex = 0;
            button3.Text = "Delete Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(106, 153, 78);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(263, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(265, 92);
            button2.TabIndex = 0;
            button2.Text = "Add Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 119, 182);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(265, 92);
            button1.TabIndex = 0;
            button1.Text = "Show Employees";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(panel4);
            Controls.Add(panelapp);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainform";
            Text = "Mainform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panelapp;
        private Panel panel4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}