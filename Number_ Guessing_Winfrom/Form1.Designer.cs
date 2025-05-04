namespace WinFormApp
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
            txtInput = new TextBox();
            btnInput = new Button();
            label2 = new Label();
            lblResult = new Label();
            lblLife = new Label();
            brnReset = new Button();
            label3 = new Label();
            label4 = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1, 175);
            label1.Name = "label1";
            label1.Size = new Size(347, 28);
            label1.TabIndex = 0;
            label1.Text = "Guess The Number between 1 and 100";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F);
            txtInput.Location = new Point(415, 175);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(77, 34);
            txtInput.TabIndex = 1;
            // 
            // btnInput
            // 
            btnInput.Font = new Font("Segoe UI", 12F);
            btnInput.Location = new Point(548, 169);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(131, 41);
            btnInput.TabIndex = 2;
            btnInput.Text = "Check Guess";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(415, 237);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 3;
            label2.Text = "Result :";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(566, 237);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(65, 28);
            lblResult.TabIndex = 4;
            lblResult.Text = "label3";
            // 
            // lblLife
            // 
            lblLife.AutoSize = true;
            lblLife.Font = new Font("Segoe UI", 12F);
            lblLife.Location = new Point(566, 285);
            lblLife.Name = "lblLife";
            lblLife.Size = new Size(65, 28);
            lblLife.TabIndex = 5;
            lblLife.Text = "label3";
            // 
            // brnReset
            // 
            brnReset.Font = new Font("Segoe UI", 12F);
            brnReset.Location = new Point(484, 369);
            brnReset.Name = "brnReset";
            brnReset.Size = new Size(98, 39);
            brnReset.TabIndex = 6;
            brnReset.Text = "Reset";
            brnReset.UseVisualStyleBackColor = true;
            brnReset.Click += brnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(436, 285);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 7;
            label3.Text = "Life : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(490, 25);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 8;
            label4.Text = "Score : ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 14F);
            lblScore.Location = new Point(581, 25);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(78, 32);
            lblScore.TabIndex = 9;
            lblScore.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScore);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(brnReset);
            Controls.Add(lblLife);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(btnInput);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Button btnInput;
        private Label label2;
        private Label lblResult;
        private Label lblLife;
        private Button brnReset;
        private Label label3;
        private Label label4;
        private Label lblScore;
    }
}
