namespace Car_Rental_Managment_System
{
    partial class viewBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cusID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_carID = new System.Windows.Forms.Label();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_return = new System.Windows.Forms.Label();
            this.inputlbl_cusID = new System.Windows.Forms.Label();
            this.inputlbl_carID = new System.Windows.Forms.Label();
            this.inputlbl_name = new System.Windows.Forms.Label();
            this.inputlbl_ID = new System.Windows.Forms.Label();
            this.inputlbl_bal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputtxt_bID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Managment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car Rental";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(174, 49);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(550, 23);
            this.txt_search.TabIndex = 5;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(730, 47);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 25);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 331);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter the Booking ID";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(817, 47);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 25);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Booking ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(224, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cusID
            // 
            this.lbl_cusID.AutoSize = true;
            this.lbl_cusID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusID.ForeColor = System.Drawing.Color.White;
            this.lbl_cusID.Location = new System.Drawing.Point(11, 70);
            this.lbl_cusID.Name = "lbl_cusID";
            this.lbl_cusID.Size = new System.Drawing.Size(74, 15);
            this.lbl_cusID.TabIndex = 17;
            this.lbl_cusID.Text = "Customer ID";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(358, 70);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 18;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(357, 97);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(83, 15);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "NIC / Passport";
            // 
            // lbl_carID
            // 
            this.lbl_carID.AutoSize = true;
            this.lbl_carID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carID.ForeColor = System.Drawing.Color.White;
            this.lbl_carID.Location = new System.Drawing.Point(11, 97);
            this.lbl_carID.Name = "lbl_carID";
            this.lbl_carID.Size = new System.Drawing.Size(40, 15);
            this.lbl_carID.TabIndex = 19;
            this.lbl_carID.Text = "Car ID";
            // 
            // lbl_bal
            // 
            this.lbl_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bal.ForeColor = System.Drawing.Color.White;
            this.lbl_bal.Location = new System.Drawing.Point(668, 70);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(48, 15);
            this.lbl_bal.TabIndex = 20;
            this.lbl_bal.Text = "Balance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(755, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lbl_return
            // 
            this.lbl_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_return.AutoSize = true;
            this.lbl_return.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return.ForeColor = System.Drawing.Color.White;
            this.lbl_return.Location = new System.Drawing.Point(668, 97);
            this.lbl_return.Name = "lbl_return";
            this.lbl_return.Size = new System.Drawing.Size(70, 15);
            this.lbl_return.TabIndex = 22;
            this.lbl_return.Text = "Return Date";
            // 
            // inputlbl_cusID
            // 
            this.inputlbl_cusID.AutoSize = true;
            this.inputlbl_cusID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlbl_cusID.ForeColor = System.Drawing.Color.White;
            this.inputlbl_cusID.Location = new System.Drawing.Point(131, 70);
            this.inputlbl_cusID.Name = "inputlbl_cusID";
            this.inputlbl_cusID.Size = new System.Drawing.Size(85, 15);
            this.inputlbl_cusID.TabIndex = 23;
            this.inputlbl_cusID.Text = "CUSTOMER ID";
            // 
            // inputlbl_carID
            // 
            this.inputlbl_carID.AutoSize = true;
            this.inputlbl_carID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlbl_carID.ForeColor = System.Drawing.Color.White;
            this.inputlbl_carID.Location = new System.Drawing.Point(131, 97);
            this.inputlbl_carID.Name = "inputlbl_carID";
            this.inputlbl_carID.Size = new System.Drawing.Size(45, 15);
            this.inputlbl_carID.TabIndex = 24;
            this.inputlbl_carID.Text = "CAR ID";
            // 
            // inputlbl_name
            // 
            this.inputlbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputlbl_name.AutoSize = true;
            this.inputlbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlbl_name.ForeColor = System.Drawing.Color.White;
            this.inputlbl_name.Location = new System.Drawing.Point(477, 70);
            this.inputlbl_name.Name = "inputlbl_name";
            this.inputlbl_name.Size = new System.Drawing.Size(41, 15);
            this.inputlbl_name.TabIndex = 25;
            this.inputlbl_name.Text = "NAME";
            // 
            // inputlbl_ID
            // 
            this.inputlbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputlbl_ID.AutoSize = true;
            this.inputlbl_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlbl_ID.ForeColor = System.Drawing.Color.White;
            this.inputlbl_ID.Location = new System.Drawing.Point(477, 97);
            this.inputlbl_ID.Name = "inputlbl_ID";
            this.inputlbl_ID.Size = new System.Drawing.Size(20, 15);
            this.inputlbl_ID.TabIndex = 26;
            this.inputlbl_ID.Text = "ID";
            // 
            // inputlbl_bal
            // 
            this.inputlbl_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputlbl_bal.AutoSize = true;
            this.inputlbl_bal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlbl_bal.ForeColor = System.Drawing.Color.White;
            this.inputlbl_bal.Location = new System.Drawing.Point(752, 70);
            this.inputlbl_bal.Name = "inputlbl_bal";
            this.inputlbl_bal.Size = new System.Drawing.Size(58, 15);
            this.inputlbl_bal.TabIndex = 27;
            this.inputlbl_bal.Text = "BALANCE";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(305, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(652, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 102);
            this.panel1.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputtxt_bID);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.inputlbl_bal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.inputlbl_ID);
            this.groupBox1.Controls.Add(this.lbl_cusID);
            this.groupBox1.Controls.Add(this.inputlbl_name);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.inputlbl_carID);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.inputlbl_cusID);
            this.groupBox1.Controls.Add(this.lbl_carID);
            this.groupBox1.Controls.Add(this.lbl_return);
            this.groupBox1.Controls.Add(this.lbl_bal);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 154);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Section";
            // 
            // inputtxt_bID
            // 
            this.inputtxt_bID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtxt_bID.FormattingEnabled = true;
            this.inputtxt_bID.Location = new System.Drawing.Point(87, 30);
            this.inputtxt_bID.Name = "inputtxt_bID";
            this.inputtxt_bID.Size = new System.Drawing.Size(131, 23);
            this.inputtxt_bID.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 100);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Section";
            // 
            // viewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(963, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRMS - Return / Booking";
            this.Load += new System.EventHandler(this.viewBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cusID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_carID;
        private System.Windows.Forms.Label lbl_bal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_return;
        private System.Windows.Forms.Label inputlbl_cusID;
        private System.Windows.Forms.Label inputlbl_carID;
        private System.Windows.Forms.Label inputlbl_name;
        private System.Windows.Forms.Label inputlbl_ID;
        private System.Windows.Forms.Label inputlbl_bal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox inputtxt_bID;
    }
}