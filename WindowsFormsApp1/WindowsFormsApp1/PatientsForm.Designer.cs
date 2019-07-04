namespace WindowsFormsApp1
{
    partial class PatientsForm
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
            this.dataPatient = new System.Windows.Forms.DataGridView();
            this.textF = new System.Windows.Forms.TextBox();
            this.textL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPatient
            // 
            this.dataPatient.AllowUserToAddRows = false;
            this.dataPatient.AllowUserToDeleteRows = false;
            this.dataPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatient.Location = new System.Drawing.Point(289, 12);
            this.dataPatient.Name = "dataPatient";
            this.dataPatient.ReadOnly = true;
            this.dataPatient.Size = new System.Drawing.Size(499, 426);
            this.dataPatient.TabIndex = 0;
            // 
            // textF
            // 
            this.textF.Location = new System.Drawing.Point(94, 34);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(175, 20);
            this.textF.TabIndex = 1;
            this.textF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textL
            // 
            this.textL.Location = new System.Drawing.Point(94, 70);
            this.textL.Name = "textL";
            this.textL.Size = new System.Drawing.Size(175, 20);
            this.textL.TabIndex = 2;
            this.textL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEARCH PATIENT INFORMATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patient ID";
            // 
            // textPID
            // 
            this.textPID.Location = new System.Drawing.Point(94, 106);
            this.textPID.Name = "textPID";
            this.textPID.Size = new System.Drawing.Size(175, 20);
            this.textPID.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Addbutton.Location = new System.Drawing.Point(194, 143);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "Adjust";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // PatientsForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textL);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.dataPatient);
            this.Name = "PatientsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPatient;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.TextBox textL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Addbutton;
    }
}