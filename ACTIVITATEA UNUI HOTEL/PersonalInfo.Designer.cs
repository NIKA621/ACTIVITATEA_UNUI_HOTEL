
namespace ACTIVITATEA_UNUI_HOTEL
{
    partial class PersonalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalTelefontbl = new System.Windows.Forms.TextBox();
            this.NumePersonaltbl = new System.Windows.Forms.TextBox();
            this.PersonalIdtbl = new System.Windows.Forms.TextBox();
            this.Sexulcb = new System.Windows.Forms.ComboBox();
            this.PersonalGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.CautareClienttb = new System.Windows.Forms.TextBox();
            this.DeletePersonalbtn = new System.Windows.Forms.Button();
            this.PersonalEditBtn = new System.Windows.Forms.Button();
            this.AddPersonalBtn = new System.Windows.Forms.Button();
            this.parolatb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(392, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatie Personal";
            // 
            // PersonalTelefontbl
            // 
            this.PersonalTelefontbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalTelefontbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PersonalTelefontbl.Location = new System.Drawing.Point(12, 318);
            this.PersonalTelefontbl.Name = "PersonalTelefontbl";
            this.PersonalTelefontbl.Size = new System.Drawing.Size(247, 27);
            this.PersonalTelefontbl.TabIndex = 2;
            this.PersonalTelefontbl.Text = "NumarTelefon";
            // 
            // NumePersonaltbl
            // 
            this.NumePersonaltbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumePersonaltbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumePersonaltbl.Location = new System.Drawing.Point(12, 255);
            this.NumePersonaltbl.Name = "NumePersonaltbl";
            this.NumePersonaltbl.Size = new System.Drawing.Size(247, 27);
            this.NumePersonaltbl.TabIndex = 3;
            this.NumePersonaltbl.Text = "NumePersonal";
            // 
            // PersonalIdtbl
            // 
            this.PersonalIdtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalIdtbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PersonalIdtbl.Location = new System.Drawing.Point(12, 195);
            this.PersonalIdtbl.Name = "PersonalIdtbl";
            this.PersonalIdtbl.Size = new System.Drawing.Size(247, 27);
            this.PersonalIdtbl.TabIndex = 4;
            this.PersonalIdtbl.Text = "PersonalId";
            // 
            // Sexulcb
            // 
            this.Sexulcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sexulcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Sexulcb.FormattingEnabled = true;
            this.Sexulcb.Items.AddRange(new object[] {
            "Femenin",
            "Masculin"});
            this.Sexulcb.Location = new System.Drawing.Point(12, 433);
            this.Sexulcb.Name = "Sexulcb";
            this.Sexulcb.Size = new System.Drawing.Size(247, 33);
            this.Sexulcb.TabIndex = 5;
            this.Sexulcb.Text = "Sexul";
            this.Sexulcb.SelectedIndexChanged += new System.EventHandler(this.Sexulcb_SelectedIndexChanged);
            // 
            // PersonalGridView
            // 
            this.PersonalGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PersonalGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalGridView.Location = new System.Drawing.Point(370, 195);
            this.PersonalGridView.Name = "PersonalGridView";
            this.PersonalGridView.RowHeadersWidth = 51;
            this.PersonalGridView.RowTemplate.Height = 24;
            this.PersonalGridView.Size = new System.Drawing.Size(695, 737);
            this.PersonalGridView.TabIndex = 6;
            this.PersonalGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonalGridView_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Honeydew;
            this.button4.Location = new System.Drawing.Point(710, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 54);
            this.button4.TabIndex = 13;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CautareClienttb
            // 
            this.CautareClienttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CautareClienttb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CautareClienttb.Location = new System.Drawing.Point(512, 164);
            this.CautareClienttb.Name = "CautareClienttb";
            this.CautareClienttb.Size = new System.Drawing.Size(199, 30);
            this.CautareClienttb.TabIndex = 12;
            this.CautareClienttb.Text = "CautarePersonal";
            // 
            // DeletePersonalbtn
            // 
            this.DeletePersonalbtn.FlatAppearance.BorderSize = 0;
            this.DeletePersonalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePersonalbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePersonalbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DeletePersonalbtn.Location = new System.Drawing.Point(171, 513);
            this.DeletePersonalbtn.Name = "DeletePersonalbtn";
            this.DeletePersonalbtn.Size = new System.Drawing.Size(119, 42);
            this.DeletePersonalbtn.TabIndex = 17;
            this.DeletePersonalbtn.Text = "DELETE";
            this.DeletePersonalbtn.UseVisualStyleBackColor = true;
            this.DeletePersonalbtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // PersonalEditBtn
            // 
            this.PersonalEditBtn.FlatAppearance.BorderSize = 0;
            this.PersonalEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalEditBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalEditBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PersonalEditBtn.Location = new System.Drawing.Point(92, 513);
            this.PersonalEditBtn.Name = "PersonalEditBtn";
            this.PersonalEditBtn.Size = new System.Drawing.Size(73, 42);
            this.PersonalEditBtn.TabIndex = 16;
            this.PersonalEditBtn.Text = "EDIT";
            this.PersonalEditBtn.UseVisualStyleBackColor = true;
            this.PersonalEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddPersonalBtn
            // 
            this.AddPersonalBtn.FlatAppearance.BorderSize = 0;
            this.AddPersonalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPersonalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersonalBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddPersonalBtn.Location = new System.Drawing.Point(11, 513);
            this.AddPersonalBtn.Name = "AddPersonalBtn";
            this.AddPersonalBtn.Size = new System.Drawing.Size(75, 42);
            this.AddPersonalBtn.TabIndex = 15;
            this.AddPersonalBtn.Text = "ADD";
            this.AddPersonalBtn.UseVisualStyleBackColor = true;
            this.AddPersonalBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // parolatb
            // 
            this.parolatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parolatb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parolatb.Location = new System.Drawing.Point(12, 372);
            this.parolatb.Name = "parolatb";
            this.parolatb.Size = new System.Drawing.Size(247, 27);
            this.parolatb.TabIndex = 18;
            this.parolatb.Text = "Parola";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(799, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(92, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 892);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parolatb);
            this.Controls.Add(this.DeletePersonalbtn);
            this.Controls.Add(this.PersonalEditBtn);
            this.Controls.Add(this.AddPersonalBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CautareClienttb);
            this.Controls.Add(this.PersonalGridView);
            this.Controls.Add(this.Sexulcb);
            this.Controls.Add(this.PersonalIdtbl);
            this.Controls.Add(this.NumePersonaltbl);
            this.Controls.Add(this.PersonalTelefontbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalInfo";
            this.Text = "PersonalInfo";
            this.Load += new System.EventHandler(this.PersonalInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PersonalTelefontbl;
        private System.Windows.Forms.TextBox NumePersonaltbl;
        private System.Windows.Forms.TextBox PersonalIdtbl;
        private System.Windows.Forms.ComboBox Sexulcb;
        private System.Windows.Forms.DataGridView PersonalGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CautareClienttb;
        private System.Windows.Forms.Button DeletePersonalbtn;
        private System.Windows.Forms.Button PersonalEditBtn;
        private System.Windows.Forms.Button AddPersonalBtn;
        private System.Windows.Forms.TextBox parolatb;
        private System.Windows.Forms.Button button1;
    }
}