
namespace ACTIVITATEA_UNUI_HOTEL
{
    partial class Clientinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clientidtbl = new System.Windows.Forms.TextBox();
            this.telefontbl = new System.Windows.Forms.TextBox();
            this.numeclienttbl = new System.Windows.Forms.TextBox();
            this.taraclientcb = new System.Windows.Forms.ComboBox();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.EditClientBtn = new System.Windows.Forms.Button();
            this.DeleteClientbtn = new System.Windows.Forms.Button();
            this.CautareClienttb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
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
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatie Clienti";
            // 
            // Clientidtbl
            // 
            this.Clientidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clientidtbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Clientidtbl.Location = new System.Drawing.Point(29, 183);
            this.Clientidtbl.Name = "Clientidtbl";
            this.Clientidtbl.Size = new System.Drawing.Size(247, 27);
            this.Clientidtbl.TabIndex = 1;
            this.Clientidtbl.Text = "Clientid";
            // 
            // telefontbl
            // 
            this.telefontbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telefontbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.telefontbl.Location = new System.Drawing.Point(27, 295);
            this.telefontbl.Name = "telefontbl";
            this.telefontbl.Size = new System.Drawing.Size(247, 27);
            this.telefontbl.TabIndex = 2;
            this.telefontbl.Text = "Telefon";
            // 
            // numeclienttbl
            // 
            this.numeclienttbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeclienttbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numeclienttbl.Location = new System.Drawing.Point(29, 243);
            this.numeclienttbl.Name = "numeclienttbl";
            this.numeclienttbl.Size = new System.Drawing.Size(247, 27);
            this.numeclienttbl.TabIndex = 3;
            this.numeclienttbl.Text = "NumeClient";
            // 
            // taraclientcb
            // 
            this.taraclientcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taraclientcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.taraclientcb.FormattingEnabled = true;
            this.taraclientcb.Items.AddRange(new object[] {
            "INDIA",
            "SPANIA",
            "ROMINIA",
            "UCRAINA",
            "MOLDOVA",
            "RUSIA ",
            "GERMANIA",
            "BELGIA",
            "FRANTA"});
            this.taraclientcb.Location = new System.Drawing.Point(27, 350);
            this.taraclientcb.Name = "taraclientcb";
            this.taraclientcb.Size = new System.Drawing.Size(247, 33);
            this.taraclientcb.TabIndex = 4;
            this.taraclientcb.Text = "Tara";
            // 
            // ClientGridView
            // 
            this.ClientGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Location = new System.Drawing.Point(391, 183);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowHeadersWidth = 51;
            this.ClientGridView.RowTemplate.Height = 24;
            this.ClientGridView.Size = new System.Drawing.Size(695, 737);
            this.ClientGridView.TabIndex = 5;
            this.ClientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.FlatAppearance.BorderSize = 0;
            this.AddClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClientBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddClientBtn.Location = new System.Drawing.Point(27, 433);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(75, 42);
            this.AddClientBtn.TabIndex = 6;
            this.AddClientBtn.Text = "ADD";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditClientBtn
            // 
            this.EditClientBtn.FlatAppearance.BorderSize = 0;
            this.EditClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditClientBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditClientBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.EditClientBtn.Location = new System.Drawing.Point(108, 433);
            this.EditClientBtn.Name = "EditClientBtn";
            this.EditClientBtn.Size = new System.Drawing.Size(73, 42);
            this.EditClientBtn.TabIndex = 7;
            this.EditClientBtn.Text = "EDIT";
            this.EditClientBtn.UseVisualStyleBackColor = true;
            this.EditClientBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteClientbtn
            // 
            this.DeleteClientbtn.FlatAppearance.BorderSize = 0;
            this.DeleteClientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteClientbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClientbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DeleteClientbtn.Location = new System.Drawing.Point(201, 433);
            this.DeleteClientbtn.Name = "DeleteClientbtn";
            this.DeleteClientbtn.Size = new System.Drawing.Size(119, 42);
            this.DeleteClientbtn.TabIndex = 8;
            this.DeleteClientbtn.Text = "DELETE";
            this.DeleteClientbtn.UseVisualStyleBackColor = true;
            this.DeleteClientbtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // CautareClienttb
            // 
            this.CautareClienttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CautareClienttb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CautareClienttb.Location = new System.Drawing.Point(570, 147);
            this.CautareClienttb.Name = "CautareClienttb";
            this.CautareClienttb.Size = new System.Drawing.Size(139, 30);
            this.CautareClienttb.TabIndex = 9;
            this.CautareClienttb.Text = "CautareClient";
            this.CautareClienttb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Honeydew;
            this.button4.Location = new System.Drawing.Point(715, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(803, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(74, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 892);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CautareClienttb);
            this.Controls.Add(this.DeleteClientbtn);
            this.Controls.Add(this.EditClientBtn);
            this.Controls.Add(this.AddClientBtn);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.taraclientcb);
            this.Controls.Add(this.numeclienttbl);
            this.Controls.Add(this.telefontbl);
            this.Controls.Add(this.Clientidtbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientinfo";
            this.Load += new System.EventHandler(this.Clientinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Clientidtbl;
        private System.Windows.Forms.TextBox telefontbl;
        private System.Windows.Forms.TextBox numeclienttbl;
        private System.Windows.Forms.ComboBox taraclientcb;
        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button EditClientBtn;
        private System.Windows.Forms.Button DeleteClientbtn;
        private System.Windows.Forms.TextBox CautareClienttb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}