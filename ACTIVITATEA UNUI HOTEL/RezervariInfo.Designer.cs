
namespace ACTIVITATEA_UNUI_HOTEL
{
    partial class RezervariInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervariInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.CautareReztb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RezervariGridView = new System.Windows.Forms.DataGridView();
            this.Rezidtb = new System.Windows.Forms.TextBox();
            this.DeletePersonalbtn = new System.Windows.Forms.Button();
            this.PersonalEditBtn = new System.Windows.Forms.Button();
            this.AddPersonalBtn = new System.Windows.Forms.Button();
            this.Clientcb = new System.Windows.Forms.ComboBox();
            this.Cameracb = new System.Windows.Forms.ComboBox();
            this.Datain = new System.Windows.Forms.DateTimePicker();
            this.Dataout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 116);
            this.panel1.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(969, 72);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(61, 25);
            this.Datelbl.TabIndex = 2;
            this.Datelbl.Text = "Date";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatie Rezervari";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Honeydew;
            this.button4.Location = new System.Drawing.Point(701, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 54);
            this.button4.TabIndex = 26;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CautareReztb
            // 
            this.CautareReztb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CautareReztb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CautareReztb.Location = new System.Drawing.Point(496, 146);
            this.CautareReztb.Name = "CautareReztb";
            this.CautareReztb.Size = new System.Drawing.Size(199, 30);
            this.CautareReztb.TabIndex = 25;
            this.CautareReztb.Text = "CautareRezervare";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(790, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RezervariGridView
            // 
            this.RezervariGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RezervariGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RezervariGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervariGridView.Location = new System.Drawing.Point(391, 182);
            this.RezervariGridView.Name = "RezervariGridView";
            this.RezervariGridView.RowHeadersWidth = 51;
            this.RezervariGridView.RowTemplate.Height = 24;
            this.RezervariGridView.Size = new System.Drawing.Size(695, 737);
            this.RezervariGridView.TabIndex = 28;
            this.RezervariGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezervariGridView_CellContentClick);
            // 
            // Rezidtb
            // 
            this.Rezidtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rezidtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Rezidtb.Location = new System.Drawing.Point(124, 157);
            this.Rezidtb.Name = "Rezidtb";
            this.Rezidtb.Size = new System.Drawing.Size(210, 27);
            this.Rezidtb.TabIndex = 29;
            this.Rezidtb.Text = "RezervariId";
            // 
            // DeletePersonalbtn
            // 
            this.DeletePersonalbtn.FlatAppearance.BorderSize = 0;
            this.DeletePersonalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePersonalbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePersonalbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DeletePersonalbtn.Location = new System.Drawing.Point(174, 536);
            this.DeletePersonalbtn.Name = "DeletePersonalbtn";
            this.DeletePersonalbtn.Size = new System.Drawing.Size(119, 42);
            this.DeletePersonalbtn.TabIndex = 32;
            this.DeletePersonalbtn.Text = "DELETE";
            this.DeletePersonalbtn.UseVisualStyleBackColor = true;
            this.DeletePersonalbtn.Click += new System.EventHandler(this.DeletePersonalbtn_Click);
            // 
            // PersonalEditBtn
            // 
            this.PersonalEditBtn.FlatAppearance.BorderSize = 0;
            this.PersonalEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalEditBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalEditBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PersonalEditBtn.Location = new System.Drawing.Point(95, 536);
            this.PersonalEditBtn.Name = "PersonalEditBtn";
            this.PersonalEditBtn.Size = new System.Drawing.Size(73, 42);
            this.PersonalEditBtn.TabIndex = 31;
            this.PersonalEditBtn.Text = "EDIT";
            this.PersonalEditBtn.UseVisualStyleBackColor = true;
            this.PersonalEditBtn.Click += new System.EventHandler(this.PersonalEditBtn_Click);
            // 
            // AddPersonalBtn
            // 
            this.AddPersonalBtn.FlatAppearance.BorderSize = 0;
            this.AddPersonalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPersonalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersonalBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddPersonalBtn.Location = new System.Drawing.Point(14, 536);
            this.AddPersonalBtn.Name = "AddPersonalBtn";
            this.AddPersonalBtn.Size = new System.Drawing.Size(75, 42);
            this.AddPersonalBtn.TabIndex = 30;
            this.AddPersonalBtn.Text = "ADD";
            this.AddPersonalBtn.UseVisualStyleBackColor = true;
            this.AddPersonalBtn.Click += new System.EventHandler(this.AddPersonalBtn_Click);
            // 
            // Clientcb
            // 
            this.Clientcb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clientcb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Clientcb.FormattingEnabled = true;
            this.Clientcb.Location = new System.Drawing.Point(124, 225);
            this.Clientcb.Name = "Clientcb";
            this.Clientcb.Size = new System.Drawing.Size(210, 27);
            this.Clientcb.TabIndex = 33;
            this.Clientcb.Text = "ClientNume";
            this.Clientcb.SelectedIndexChanged += new System.EventHandler(this.Clientcb_SelectedIndexChanged);
            // 
            // Cameracb
            // 
            this.Cameracb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cameracb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Cameracb.FormattingEnabled = true;
            this.Cameracb.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118"});
            this.Cameracb.Location = new System.Drawing.Point(124, 270);
            this.Cameracb.Name = "Cameracb";
            this.Cameracb.Size = new System.Drawing.Size(210, 27);
            this.Cameracb.TabIndex = 34;
            this.Cameracb.Text = "NumarCamera";
            this.Cameracb.SelectedIndexChanged += new System.EventHandler(this.Cameracb_SelectedIndexChanged);
            // 
            // Datain
            // 
            this.Datain.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Datain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datain.Location = new System.Drawing.Point(124, 339);
            this.Datain.Name = "Datain";
            this.Datain.Size = new System.Drawing.Size(210, 28);
            this.Datain.TabIndex = 35;
            this.Datain.ValueChanged += new System.EventHandler(this.Datain_ValueChanged);
            // 
            // Dataout
            // 
            this.Dataout.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Dataout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dataout.Location = new System.Drawing.Point(124, 382);
            this.Dataout.Name = "Dataout";
            this.Dataout.Size = new System.Drawing.Size(210, 28);
            this.Dataout.TabIndex = 36;
            this.Dataout.ValueChanged += new System.EventHandler(this.Dataout_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(9, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "DataOut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(9, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "DataIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Camera";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(124, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 42;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RezervariInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 892);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dataout);
            this.Controls.Add(this.Datain);
            this.Controls.Add(this.Cameracb);
            this.Controls.Add(this.Clientcb);
            this.Controls.Add(this.DeletePersonalbtn);
            this.Controls.Add(this.PersonalEditBtn);
            this.Controls.Add(this.AddPersonalBtn);
            this.Controls.Add(this.Rezidtb);
            this.Controls.Add(this.RezervariGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CautareReztb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervariInfo";
            this.Text = "RezervariInfo";
            this.Load += new System.EventHandler(this.RezervariInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CautareReztb;
        private System.Windows.Forms.DataGridView RezervariGridView;
        private System.Windows.Forms.TextBox Rezidtb;
        private System.Windows.Forms.Button DeletePersonalbtn;
        private System.Windows.Forms.Button PersonalEditBtn;
        private System.Windows.Forms.Button AddPersonalBtn;
        private System.Windows.Forms.ComboBox Clientcb;
        private System.Windows.Forms.ComboBox Cameracb;
        private System.Windows.Forms.DateTimePicker Datain;
        private System.Windows.Forms.DateTimePicker Dataout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}