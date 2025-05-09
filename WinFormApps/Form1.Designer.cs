namespace WinFormApps
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(74, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 29);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(74, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 29);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(74, 150);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(166, 29);
            txtPhone.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(256, 378);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create Contact";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(624, 378);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Contact";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(755, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Contact";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(352, 378);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 9;
            btnView.Text = "View Contact";
            btnView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(621, 332);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 467);
            Controls.Add(dataGridView1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private DataGridView dataGridView1;
    }
}
