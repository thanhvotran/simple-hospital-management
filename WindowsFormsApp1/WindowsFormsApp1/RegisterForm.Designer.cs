namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.Label();
            this.PFname = new System.Windows.Forms.Label();
            this.PLname = new System.Windows.Forms.Label();
            this.PDoB = new System.Windows.Forms.Label();
            this.PGender = new System.Windows.Forms.Label();
            this.PPhone = new System.Windows.Forms.Label();
            this.PAddress = new System.Windows.Forms.Label();
            this.PGenre = new System.Windows.Forms.Label();
            this.textPID = new System.Windows.Forms.TextBox();
            this.textPFname = new System.Windows.Forms.TextBox();
            this.textPLname = new System.Windows.Forms.TextBox();
            this.textPGender = new System.Windows.Forms.TextBox();
            this.textPPhone = new System.Windows.Forms.TextBox();
            this.textPAddress = new System.Windows.Forms.TextBox();
            this.textPGenre = new System.Windows.Forms.TextBox();
            this.PAdd = new System.Windows.Forms.Button();
            this.textPDoB = new System.Windows.Forms.DateTimePicker();
            this.PRemove = new System.Windows.Forms.Button();
            this.PEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 20F);
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 359);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridViewGrid1_click);
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Location = new System.Drawing.Point(9, 114);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(54, 13);
            this.PID.TabIndex = 2;
            this.PID.Text = "Patient ID";
            this.PID.Click += new System.EventHandler(this.label2_Click);
            // 
            // PFname
            // 
            this.PFname.AutoSize = true;
            this.PFname.Location = new System.Drawing.Point(9, 144);
            this.PFname.Name = "PFname";
            this.PFname.Size = new System.Drawing.Size(57, 13);
            this.PFname.TabIndex = 3;
            this.PFname.Text = "First Name";
            // 
            // PLname
            // 
            this.PLname.AutoSize = true;
            this.PLname.Location = new System.Drawing.Point(9, 179);
            this.PLname.Name = "PLname";
            this.PLname.Size = new System.Drawing.Size(58, 13);
            this.PLname.TabIndex = 4;
            this.PLname.Text = "Last Name";
            // 
            // PDoB
            // 
            this.PDoB.AutoSize = true;
            this.PDoB.Location = new System.Drawing.Point(9, 215);
            this.PDoB.Name = "PDoB";
            this.PDoB.Size = new System.Drawing.Size(66, 13);
            this.PDoB.TabIndex = 5;
            this.PDoB.Text = "Date of Birth";
            this.PDoB.Click += new System.EventHandler(this.label5_Click);
            // 
            // PGender
            // 
            this.PGender.AutoSize = true;
            this.PGender.Location = new System.Drawing.Point(9, 253);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(42, 13);
            this.PGender.TabIndex = 6;
            this.PGender.Text = "Gender";
            // 
            // PPhone
            // 
            this.PPhone.AutoSize = true;
            this.PPhone.Location = new System.Drawing.Point(9, 282);
            this.PPhone.Name = "PPhone";
            this.PPhone.Size = new System.Drawing.Size(38, 13);
            this.PPhone.TabIndex = 7;
            this.PPhone.Text = "Phone";
            // 
            // PAddress
            // 
            this.PAddress.AutoSize = true;
            this.PAddress.Location = new System.Drawing.Point(9, 312);
            this.PAddress.Name = "PAddress";
            this.PAddress.Size = new System.Drawing.Size(45, 13);
            this.PAddress.TabIndex = 8;
            this.PAddress.Text = "Address";
            // 
            // PGenre
            // 
            this.PGenre.AutoSize = true;
            this.PGenre.Location = new System.Drawing.Point(9, 342);
            this.PGenre.Name = "PGenre";
            this.PGenre.Size = new System.Drawing.Size(36, 13);
            this.PGenre.TabIndex = 9;
            this.PGenre.Text = "Genre";
            this.PGenre.Click += new System.EventHandler(this.PGenre_Click);
            // 
            // textPID
            // 
            this.textPID.Location = new System.Drawing.Point(99, 114);
            this.textPID.Name = "textPID";
            this.textPID.Size = new System.Drawing.Size(178, 20);
            this.textPID.TabIndex = 10;
            this.textPID.TextChanged += new System.EventHandler(this.textPID_TextChanged);
            // 
            // textPFname
            // 
            this.textPFname.Location = new System.Drawing.Point(99, 144);
            this.textPFname.Name = "textPFname";
            this.textPFname.Size = new System.Drawing.Size(178, 20);
            this.textPFname.TabIndex = 11;
            // 
            // textPLname
            // 
            this.textPLname.Location = new System.Drawing.Point(99, 179);
            this.textPLname.Name = "textPLname";
            this.textPLname.Size = new System.Drawing.Size(178, 20);
            this.textPLname.TabIndex = 12;
            this.textPLname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textPGender
            // 
            this.textPGender.Location = new System.Drawing.Point(99, 246);
            this.textPGender.Name = "textPGender";
            this.textPGender.Size = new System.Drawing.Size(178, 20);
            this.textPGender.TabIndex = 14;
            // 
            // textPPhone
            // 
            this.textPPhone.Location = new System.Drawing.Point(99, 279);
            this.textPPhone.Name = "textPPhone";
            this.textPPhone.Size = new System.Drawing.Size(178, 20);
            this.textPPhone.TabIndex = 15;
            // 
            // textPAddress
            // 
            this.textPAddress.Location = new System.Drawing.Point(99, 312);
            this.textPAddress.Name = "textPAddress";
            this.textPAddress.Size = new System.Drawing.Size(178, 20);
            this.textPAddress.TabIndex = 16;
            // 
            // textPGenre
            // 
            this.textPGenre.Location = new System.Drawing.Point(99, 342);
            this.textPGenre.Name = "textPGenre";
            this.textPGenre.Size = new System.Drawing.Size(178, 20);
            this.textPGenre.TabIndex = 17;
            // 
            // PAdd
            // 
            this.PAdd.Location = new System.Drawing.Point(99, 381);
            this.PAdd.Name = "PAdd";
            this.PAdd.Size = new System.Drawing.Size(75, 23);
            this.PAdd.TabIndex = 18;
            this.PAdd.Text = "Add";
            this.PAdd.UseVisualStyleBackColor = true;
            this.PAdd.Click += new System.EventHandler(this.PAdd_Click);
            // 
            // textPDoB
            // 
            this.textPDoB.CustomFormat = "";
            this.textPDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textPDoB.Location = new System.Drawing.Point(99, 208);
            this.textPDoB.Name = "textPDoB";
            this.textPDoB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textPDoB.Size = new System.Drawing.Size(178, 20);
            this.textPDoB.TabIndex = 13;
            // 
            // PRemove
            // 
            this.PRemove.Location = new System.Drawing.Point(99, 411);
            this.PRemove.Name = "PRemove";
            this.PRemove.Size = new System.Drawing.Size(75, 23);
            this.PRemove.TabIndex = 19;
            this.PRemove.Text = "Remove";
            this.PRemove.UseVisualStyleBackColor = true;
            this.PRemove.Click += new System.EventHandler(this.PRemove_Click);
            // 
            // PEdit
            // 
            this.PEdit.Location = new System.Drawing.Point(192, 380);
            this.PEdit.Name = "PEdit";
            this.PEdit.Size = new System.Drawing.Size(75, 23);
            this.PEdit.TabIndex = 20;
            this.PEdit.Text = "Edit";
            this.PEdit.UseVisualStyleBackColor = true;
            this.PEdit.Click += new System.EventHandler(this.PEdit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PEdit);
            this.Controls.Add(this.PRemove);
            this.Controls.Add(this.textPDoB);
            this.Controls.Add(this.PAdd);
            this.Controls.Add(this.textPGenre);
            this.Controls.Add(this.textPAddress);
            this.Controls.Add(this.textPPhone);
            this.Controls.Add(this.textPGender);
            this.Controls.Add(this.textPLname);
            this.Controls.Add(this.textPFname);
            this.Controls.Add(this.textPID);
            this.Controls.Add(this.PGenre);
            this.Controls.Add(this.PAddress);
            this.Controls.Add(this.PPhone);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.PDoB);
            this.Controls.Add(this.PLname);
            this.Controls.Add(this.PFname);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label PFname;
        private System.Windows.Forms.Label PLname;
        private System.Windows.Forms.Label PDoB;
        private System.Windows.Forms.Label PGender;
        private System.Windows.Forms.Label PPhone;
        private System.Windows.Forms.Label PAddress;
        private System.Windows.Forms.Label PGenre;
        private System.Windows.Forms.TextBox textPID;
        private System.Windows.Forms.TextBox textPFname;
        private System.Windows.Forms.TextBox textPLname;
        private System.Windows.Forms.TextBox textPGender;
        private System.Windows.Forms.TextBox textPPhone;
        private System.Windows.Forms.TextBox textPAddress;
        private System.Windows.Forms.TextBox textPGenre;
        private System.Windows.Forms.Button PAdd;
        private System.Windows.Forms.DateTimePicker textPDoB;
        private System.Windows.Forms.Button PRemove;
        private System.Windows.Forms.Button PEdit;
    }
}