namespace StudentMS
{
    partial class Faculty
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
            this.login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.Label();
            this.studentDet1 = new StudentMS.studentDet();
            this.attendance1 = new StudentMS.Attendance();
            this.marks1 = new StudentMS.Marks();
            this.facultyReg1 = new StudentMS.FacultyReg();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.login.Location = new System.Drawing.Point(6, 112);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(188, 36);
            this.login.TabIndex = 8;
            this.login.Text = "Wall";
            this.login.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(6, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Faculty Registration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(6, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Attendance";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(6, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Evaluation mark";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(6, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 10;
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(742, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(46, 36);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.facultyReg1);
            this.panel2.Controls.Add(this.marks1);
            this.panel2.Controls.Add(this.attendance1);
            this.panel2.Controls.Add(this.studentDet1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 353);
            this.panel2.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(6, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 36);
            this.button5.TabIndex = 13;
            this.button5.Text = "Student Registration";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(6, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 36);
            this.button6.TabIndex = 14;
            this.button6.Text = "View Student";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 236);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(581, 58);
            this.dataGridView2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(499, 300);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 36);
            this.button7.TabIndex = 15;
            this.button7.Text = "Post";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.Color.Transparent;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.SystemColors.Control;
            this.fname.Location = new System.Drawing.Point(12, 12);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(82, 30);
            this.fname.TabIndex = 12;
            this.fname.Text = "Home";
            // 
            // studentDet1
            // 
            this.studentDet1.BackColor = System.Drawing.Color.Indigo;
            this.studentDet1.Location = new System.Drawing.Point(0, 0);
            this.studentDet1.Name = "studentDet1";
            this.studentDet1.Size = new System.Drawing.Size(600, 368);
            this.studentDet1.TabIndex = 16;
            // 
            // attendance1
            // 
            this.attendance1.BackColor = System.Drawing.Color.Indigo;
            this.attendance1.Location = new System.Drawing.Point(0, 0);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(600, 368);
            this.attendance1.TabIndex = 17;
            // 
            // marks1
            // 
            this.marks1.BackColor = System.Drawing.Color.Indigo;
            this.marks1.Location = new System.Drawing.Point(0, 0);
            this.marks1.Name = "marks1";
            this.marks1.Size = new System.Drawing.Size(600, 368);
            this.marks1.TabIndex = 18;
            // 
            // facultyReg1
            // 
            this.facultyReg1.BackColor = System.Drawing.Color.Indigo;
            this.facultyReg1.ForeColor = System.Drawing.Color.GhostWhite;
            this.facultyReg1.Location = new System.Drawing.Point(0, 0);
            this.facultyReg1.Name = "facultyReg1";
            this.facultyReg1.Size = new System.Drawing.Size(600, 368);
            this.facultyReg1.TabIndex = 19;
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Faculty";
            this.Text = "Faculty";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label fname;
        private studentDet studentDet1;
        private Attendance attendance1;
        private Marks marks1;
        private FacultyReg facultyReg1;
    }
}