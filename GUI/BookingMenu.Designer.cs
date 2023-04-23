
namespace DelPin___Eksamensprojekt.GUI
{
    partial class BookingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingMenu));
            this.AfdelingCmB = new System.Windows.Forms.ComboBox();
            this.MaskineCmB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RydFelterBookingBT = new System.Windows.Forms.Button();
            this.SletBookingBT = new System.Windows.Forms.Button();
            this.OpdaterBookingBT = new System.Windows.Forms.Button();
            this.OpretBookingBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.OrdreNrTxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RydFelterOrdreBT = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.KundeNrTxtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SletOrdreBT = new System.Windows.Forms.Button();
            this.OpdaterOrdreBT = new System.Windows.Forms.Button();
            this.OpretOrdreBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuBT = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AfdelingCmB
            // 
            this.AfdelingCmB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AfdelingCmB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfdelingCmB.FormattingEnabled = true;
            this.AfdelingCmB.Location = new System.Drawing.Point(213, 403);
            this.AfdelingCmB.Name = "AfdelingCmB";
            this.AfdelingCmB.Size = new System.Drawing.Size(200, 29);
            this.AfdelingCmB.TabIndex = 72;
            this.AfdelingCmB.SelectedIndexChanged += new System.EventHandler(this.AfdelingCmB_SelectedIndexChanged);
            // 
            // MaskineCmB
            // 
            this.MaskineCmB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaskineCmB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskineCmB.FormattingEnabled = true;
            this.MaskineCmB.Location = new System.Drawing.Point(213, 447);
            this.MaskineCmB.Name = "MaskineCmB";
            this.MaskineCmB.Size = new System.Drawing.Size(200, 29);
            this.MaskineCmB.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Maskine                  :";
            // 
            // RydFelterBookingBT
            // 
            this.RydFelterBookingBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RydFelterBookingBT.Location = new System.Drawing.Point(26, 649);
            this.RydFelterBookingBT.Name = "RydFelterBookingBT";
            this.RydFelterBookingBT.Size = new System.Drawing.Size(387, 31);
            this.RydFelterBookingBT.TabIndex = 69;
            this.RydFelterBookingBT.Text = "Ryd Alle Felter!";
            this.RydFelterBookingBT.UseVisualStyleBackColor = true;
            this.RydFelterBookingBT.Click += new System.EventHandler(this.RydFelterBookingBT_Click);
            // 
            // SletBookingBT
            // 
            this.SletBookingBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SletBookingBT.Location = new System.Drawing.Point(230, 570);
            this.SletBookingBT.Name = "SletBookingBT";
            this.SletBookingBT.Size = new System.Drawing.Size(183, 34);
            this.SletBookingBT.TabIndex = 68;
            this.SletBookingBT.Text = "Slet Valgte Booking";
            this.SletBookingBT.UseVisualStyleBackColor = true;
            this.SletBookingBT.Click += new System.EventHandler(this.SletBookingBT_Click);
            // 
            // OpdaterBookingBT
            // 
            this.OpdaterBookingBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpdaterBookingBT.Location = new System.Drawing.Point(26, 570);
            this.OpdaterBookingBT.Name = "OpdaterBookingBT";
            this.OpdaterBookingBT.Size = new System.Drawing.Size(183, 34);
            this.OpdaterBookingBT.TabIndex = 67;
            this.OpdaterBookingBT.Text = "Opdater Booking!";
            this.OpdaterBookingBT.UseVisualStyleBackColor = true;
            this.OpdaterBookingBT.Click += new System.EventHandler(this.OpdaterBookingBT_Click);
            // 
            // OpretBookingBT
            // 
            this.OpretBookingBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretBookingBT.Location = new System.Drawing.Point(26, 482);
            this.OpretBookingBT.Name = "OpretBookingBT";
            this.OpretBookingBT.Size = new System.Drawing.Size(387, 46);
            this.OpretBookingBT.TabIndex = 66;
            this.OpretBookingBT.Text = "Opret Ny Booking!";
            this.OpretBookingBT.UseVisualStyleBackColor = true;
            this.OpretBookingBT.Click += new System.EventHandler(this.OpretBookingBT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Afdeling                  :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(213, 355);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Slut Dato                 :";
            // 
            // OrdreNrTxtB
            // 
            this.OrdreNrTxtB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdreNrTxtB.Location = new System.Drawing.Point(213, 277);
            this.OrdreNrTxtB.Multiline = true;
            this.OrdreNrTxtB.Name = "OrdreNrTxtB";
            this.OrdreNrTxtB.Size = new System.Drawing.Size(200, 28);
            this.OrdreNrTxtB.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Starts Dato              :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Ordre Nr                 :";
            // 
            // RydFelterOrdreBT
            // 
            this.RydFelterOrdreBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RydFelterOrdreBT.Location = new System.Drawing.Point(26, 199);
            this.RydFelterOrdreBT.Name = "RydFelterOrdreBT";
            this.RydFelterOrdreBT.Size = new System.Drawing.Size(387, 31);
            this.RydFelterOrdreBT.TabIndex = 58;
            this.RydFelterOrdreBT.Text = "Ryd Alle Felter!";
            this.RydFelterOrdreBT.UseVisualStyleBackColor = true;
            this.RydFelterOrdreBT.Click += new System.EventHandler(this.RydFelterOrdreBT_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.Aqua;
            this.dataGridView2.Location = new System.Drawing.Point(511, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(660, 327);
            this.dataGridView2.TabIndex = 57;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // KundeNrTxtB
            // 
            this.KundeNrTxtB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundeNrTxtB.Location = new System.Drawing.Point(216, 78);
            this.KundeNrTxtB.Multiline = true;
            this.KundeNrTxtB.Name = "KundeNrTxtB";
            this.KundeNrTxtB.Size = new System.Drawing.Size(197, 29);
            this.KundeNrTxtB.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Kunde Nr                :";
            // 
            // SletOrdreBT
            // 
            this.SletOrdreBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SletOrdreBT.Location = new System.Drawing.Point(230, 159);
            this.SletOrdreBT.Name = "SletOrdreBT";
            this.SletOrdreBT.Size = new System.Drawing.Size(183, 34);
            this.SletOrdreBT.TabIndex = 53;
            this.SletOrdreBT.Text = "Slet Valgte Ordre!";
            this.SletOrdreBT.UseVisualStyleBackColor = true;
            this.SletOrdreBT.Click += new System.EventHandler(this.SletOrdreBT_Click);
            // 
            // OpdaterOrdreBT
            // 
            this.OpdaterOrdreBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpdaterOrdreBT.Location = new System.Drawing.Point(26, 159);
            this.OpdaterOrdreBT.Name = "OpdaterOrdreBT";
            this.OpdaterOrdreBT.Size = new System.Drawing.Size(183, 34);
            this.OpdaterOrdreBT.TabIndex = 52;
            this.OpdaterOrdreBT.Text = "Opdater Ordre!";
            this.OpdaterOrdreBT.UseVisualStyleBackColor = true;
            this.OpdaterOrdreBT.Click += new System.EventHandler(this.OpdaterOrdreBT_Click);
            // 
            // OpretOrdreBT
            // 
            this.OpretOrdreBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretOrdreBT.Location = new System.Drawing.Point(26, 122);
            this.OpretOrdreBT.Name = "OpretOrdreBT";
            this.OpretOrdreBT.Size = new System.Drawing.Size(387, 31);
            this.OpretOrdreBT.TabIndex = 50;
            this.OpretOrdreBT.Text = "Opret Ny Ordre!";
            this.OpretOrdreBT.UseVisualStyleBackColor = true;
            this.OpretOrdreBT.Click += new System.EventHandler(this.OpretOrdreBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Aqua;
            this.dataGridView1.Location = new System.Drawing.Point(511, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 152);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "Adminstrer Ordre og Bookinger";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1216, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 534);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(102, 534);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(196, 610);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 78;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1463, 24);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuBT
            // 
            this.MenuBT.Name = "MenuBT";
            this.MenuBT.Size = new System.Drawing.Size(50, 20);
            this.MenuBT.Text = "Menu";
            this.MenuBT.Click += new System.EventHandler(this.MenuBT_Click);
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1463, 687);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AfdelingCmB);
            this.Controls.Add(this.MaskineCmB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RydFelterBookingBT);
            this.Controls.Add(this.SletBookingBT);
            this.Controls.Add(this.OpdaterBookingBT);
            this.Controls.Add(this.OpretBookingBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrdreNrTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RydFelterOrdreBT);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.KundeNrTxtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SletOrdreBT);
            this.Controls.Add(this.OpdaterOrdreBT);
            this.Controls.Add(this.OpretOrdreBT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingMenu";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AfdelingCmB;
        private System.Windows.Forms.ComboBox MaskineCmB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RydFelterBookingBT;
        private System.Windows.Forms.Button SletBookingBT;
        private System.Windows.Forms.Button OpdaterBookingBT;
        private System.Windows.Forms.Button OpretBookingBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrdreNrTxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RydFelterOrdreBT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox KundeNrTxtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SletOrdreBT;
        private System.Windows.Forms.Button OpdaterOrdreBT;
        private System.Windows.Forms.Button OpretOrdreBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBT;
    }
}