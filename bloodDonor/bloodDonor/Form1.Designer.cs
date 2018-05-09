namespace bloodDonor
{
    partial class Form1
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
            this.donorRegistrationButton = new System.Windows.Forms.Button();
            this.showMyProfileButton = new System.Windows.Forms.Button();
            this.searchByBloodGroupTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchByNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Blood Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // donorRegistrationButton
            // 
            this.donorRegistrationButton.Location = new System.Drawing.Point(387, 29);
            this.donorRegistrationButton.Name = "donorRegistrationButton";
            this.donorRegistrationButton.Size = new System.Drawing.Size(130, 23);
            this.donorRegistrationButton.TabIndex = 4;
            this.donorRegistrationButton.Text = "Register As A Donor";
            this.donorRegistrationButton.UseVisualStyleBackColor = true;
            this.donorRegistrationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // showMyProfileButton
            // 
            this.showMyProfileButton.Location = new System.Drawing.Point(442, 68);
            this.showMyProfileButton.Name = "showMyProfileButton";
            this.showMyProfileButton.Size = new System.Drawing.Size(75, 23);
            this.showMyProfileButton.TabIndex = 4;
            this.showMyProfileButton.Text = "My Profile";
            this.showMyProfileButton.UseVisualStyleBackColor = true;
            this.showMyProfileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchByBloodGroupTextBox
            // 
            this.searchByBloodGroupTextBox.Location = new System.Drawing.Point(163, 29);
            this.searchByBloodGroupTextBox.Name = "searchByBloodGroupTextBox";
            this.searchByBloodGroupTextBox.Size = new System.Drawing.Size(136, 20);
            this.searchByBloodGroupTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search By Name";
            // 
            // searchByNameTextBox
            // 
            this.searchByNameTextBox.Location = new System.Drawing.Point(163, 68);
            this.searchByNameTextBox.Name = "searchByNameTextBox";
            this.searchByNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.searchByNameTextBox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(17, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 223);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Blood Group";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contact Number";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adress";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchByNameTextBox);
            this.Controls.Add(this.searchByBloodGroupTextBox);
            this.Controls.Add(this.showMyProfileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.donorRegistrationButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button donorRegistrationButton;
        private System.Windows.Forms.Button showMyProfileButton;
        private System.Windows.Forms.TextBox searchByBloodGroupTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchByNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

