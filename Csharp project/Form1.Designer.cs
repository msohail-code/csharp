namespace Mid_Programs
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
            this.factorial = new System.Windows.Forms.Button();
            this.f_number = new System.Windows.Forms.TextBox();
            this.f_result = new System.Windows.Forms.TextBox();
            this.e_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.e_result = new System.Windows.Forms.Label();
            this.check_even = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.your_age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.age_result = new System.Windows.Forms.Label();
            this.age_textbox_res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(20, 137);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(147, 23);
            this.factorial.TabIndex = 0;
            this.factorial.Text = "Factorial";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // f_number
            // 
            this.f_number.Location = new System.Drawing.Point(20, 66);
            this.f_number.Name = "f_number";
            this.f_number.Size = new System.Drawing.Size(147, 20);
            this.f_number.TabIndex = 1;
            // 
            // f_result
            // 
            this.f_result.Location = new System.Drawing.Point(20, 101);
            this.f_result.Name = "f_result";
            this.f_result.ReadOnly = true;
            this.f_result.Size = new System.Drawing.Size(147, 20);
            this.f_result.TabIndex = 2;
            // 
            // e_number
            // 
            this.e_number.Location = new System.Drawing.Point(252, 66);
            this.e_number.Name = "e_number";
            this.e_number.Size = new System.Drawing.Size(142, 20);
            this.e_number.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Factorial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Even Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number is: ";
            // 
            // e_result
            // 
            this.e_result.AutoSize = true;
            this.e_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_result.Location = new System.Drawing.Point(319, 108);
            this.e_result.Name = "e_result";
            this.e_result.Size = new System.Drawing.Size(0, 16);
            this.e_result.TabIndex = 5;
            // 
            // check_even
            // 
            this.check_even.Location = new System.Drawing.Point(252, 137);
            this.check_even.Name = "check_even";
            this.check_even.Size = new System.Drawing.Size(142, 23);
            this.check_even.TabIndex = 6;
            this.check_even.Text = "Check Even";
            this.check_even.UseVisualStyleBackColor = true;
            this.check_even.Click += new System.EventHandler(this.check_even_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age in Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Age In years:";
            // 
            // your_age
            // 
            this.your_age.Location = new System.Drawing.Point(470, 85);
            this.your_age.Name = "your_age";
            this.your_age.Size = new System.Drawing.Size(149, 20);
            this.your_age.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Age";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age in days:";
            // 
            // age_result
            // 
            this.age_result.AutoSize = true;
            this.age_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_result.Location = new System.Drawing.Point(546, 118);
            this.age_result.Name = "age_result";
            this.age_result.Size = new System.Drawing.Size(0, 16);
            this.age_result.TabIndex = 5;
            // 
            // age_textbox_res
            // 
            this.age_textbox_res.Location = new System.Drawing.Point(470, 137);
            this.age_textbox_res.Name = "age_textbox_res";
            this.age_textbox_res.ReadOnly = true;
            this.age_textbox_res.Size = new System.Drawing.Size(149, 20);
            this.age_textbox_res.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.age_textbox_res);
            this.Controls.Add(this.your_age);
            this.Controls.Add(this.check_even);
            this.Controls.Add(this.e_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.age_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.e_number);
            this.Controls.Add(this.f_result);
            this.Controls.Add(this.f_number);
            this.Controls.Add(this.factorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.TextBox f_number;
        private System.Windows.Forms.TextBox f_result;
        private System.Windows.Forms.TextBox e_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label e_result;
        private System.Windows.Forms.Button check_even;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox your_age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label age_result;
        private System.Windows.Forms.TextBox age_textbox_res;
    }
}

