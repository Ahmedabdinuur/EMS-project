namespace EMS
{
    partial class SearchEmployee
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
            label1 = new Label();
            textBoxid = new TextBox();
            buttonsearch = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxyears = new TextBox();
            textBoxsallery = new TextBox();
            textBoxrole = new TextBox();
            textBoxaddress = new TextBox();
            textBoxcontact = new TextBox();
            textBoxempid = new TextBox();
            textBoxname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee ID";
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(127, 21);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(125, 27);
            textBoxid.TabIndex = 1;
            // 
            // buttonsearch
            // 
            buttonsearch.Cursor = Cursors.Hand;
            buttonsearch.Location = new Point(274, 19);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new Size(134, 29);
            buttonsearch.TabIndex = 2;
            buttonsearch.Text = "Search";
            buttonsearch.UseVisualStyleBackColor = true;
            buttonsearch.Click += buttonsearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(535, 212);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 10;
            label6.Text = "Service Years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(323, 212);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Sallery";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(834, 133);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 12;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(567, 133);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 13;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(68, 212);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 14;
            label2.Text = "Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(34, 133);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 15;
            label7.Text = "Employee ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(315, 133);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 16;
            label8.Text = "Name";
            // 
            // textBoxyears
            // 
            textBoxyears.Location = new Point(646, 209);
            textBoxyears.Name = "textBoxyears";
            textBoxyears.ReadOnly = true;
            textBoxyears.Size = new Size(125, 27);
            textBoxyears.TabIndex = 3;
            // 
            // textBoxsallery
            // 
            textBoxsallery.Location = new Point(395, 209);
            textBoxsallery.Name = "textBoxsallery";
            textBoxsallery.ReadOnly = true;
            textBoxsallery.Size = new Size(125, 27);
            textBoxsallery.TabIndex = 4;
            // 
            // textBoxrole
            // 
            textBoxrole.Location = new Point(890, 130);
            textBoxrole.Name = "textBoxrole";
            textBoxrole.ReadOnly = true;
            textBoxrole.Size = new Size(125, 27);
            textBoxrole.TabIndex = 5;
            // 
            // textBoxaddress
            // 
            textBoxaddress.Location = new Point(646, 130);
            textBoxaddress.Name = "textBoxaddress";
            textBoxaddress.ReadOnly = true;
            textBoxaddress.Size = new Size(125, 27);
            textBoxaddress.TabIndex = 6;
            // 
            // textBoxcontact
            // 
            textBoxcontact.Location = new Point(147, 209);
            textBoxcontact.Name = "textBoxcontact";
            textBoxcontact.ReadOnly = true;
            textBoxcontact.Size = new Size(125, 27);
            textBoxcontact.TabIndex = 7;
            // 
            // textBoxempid
            // 
            textBoxempid.Location = new Point(147, 133);
            textBoxempid.Name = "textBoxempid";
            textBoxempid.ReadOnly = true;
            textBoxempid.Size = new Size(125, 27);
            textBoxempid.TabIndex = 8;
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(395, 130);
            textBoxname.Name = "textBoxname";
            textBoxname.ReadOnly = true;
            textBoxname.Size = new Size(125, 27);
            textBoxname.TabIndex = 9;
            // 
            // SearchEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 182, 255);
            ClientSize = new Size(1062, 436);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBoxyears);
            Controls.Add(textBoxsallery);
            Controls.Add(textBoxrole);
            Controls.Add(textBoxaddress);
            Controls.Add(textBoxcontact);
            Controls.Add(textBoxempid);
            Controls.Add(textBoxname);
            Controls.Add(buttonsearch);
            Controls.Add(textBoxid);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchEmployee";
            Text = "SearchEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxid;
        private Button buttonsearch;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private TextBox textBoxyears;
        private TextBox textBoxsallery;
        private TextBox textBoxrole;
        private TextBox textBoxaddress;
        private TextBox textBoxcontact;
        private TextBox textBoxempid;
        private TextBox textBoxname;
    }
}