namespace EMS
{
    partial class DeleteEmployee
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
            textBoxempid = new TextBox();
            label1 = new Label();
            buttondel = new Button();
            SuspendLayout();
            // 
            // textBoxempid
            // 
            textBoxempid.Location = new Point(506, 89);
            textBoxempid.Name = "textBoxempid";
            textBoxempid.Size = new Size(166, 27);
            textBoxempid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(403, 92);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee ID";
            // 
            // buttondel
            // 
            buttondel.Cursor = Cursors.Hand;
            buttondel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttondel.Location = new Point(406, 216);
            buttondel.Name = "buttondel";
            buttondel.Size = new Size(266, 97);
            buttondel.TabIndex = 2;
            buttondel.Text = "Delete";
            buttondel.UseVisualStyleBackColor = true;
            buttondel.Click += buttondel_Click;
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 77, 109);
            ClientSize = new Size(1062, 436);
            Controls.Add(buttondel);
            Controls.Add(label1);
            Controls.Add(textBoxempid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteEmployee";
            Text = "DeleteEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxempid;
        private Label label1;
        private Button buttondel;
    }
}