
namespace CentralInsuranceCargoPolicyTest
{
    partial class CargoTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoTestForm));
            this.apptokenbtn = new System.Windows.Forms.Button();
            this.clientloginbtn = new System.Windows.Forms.Button();
            this.cargobtn = new System.Windows.Forms.Button();
            this.txtboxResult = new System.Windows.Forms.TextBox();
            this.txtJsonInput = new System.Windows.Forms.TextBox();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAppUser = new System.Windows.Forms.TextBox();
            this.txtAppSecrect = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutPuttxt = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // apptokenbtn
            // 
            this.apptokenbtn.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.apptokenbtn.Location = new System.Drawing.Point(76, 40);
            this.apptokenbtn.Name = "apptokenbtn";
            this.apptokenbtn.Size = new System.Drawing.Size(200, 46);
            this.apptokenbtn.TabIndex = 27;
            this.apptokenbtn.Text = "احراز حویت مرحله ی اول";
            this.apptokenbtn.UseVisualStyleBackColor = true;
            this.apptokenbtn.Click += new System.EventHandler(this.apptokenbtn_Click);
            // 
            // clientloginbtn
            // 
            this.clientloginbtn.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clientloginbtn.Location = new System.Drawing.Point(76, 116);
            this.clientloginbtn.Name = "clientloginbtn";
            this.clientloginbtn.Size = new System.Drawing.Size(200, 46);
            this.clientloginbtn.TabIndex = 28;
            this.clientloginbtn.Text = "احراز هویت مرحله ی دوم";
            this.clientloginbtn.UseVisualStyleBackColor = true;
            this.clientloginbtn.Click += new System.EventHandler(this.clientlogin_Click);
            // 
            // cargobtn
            // 
            this.cargobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargobtn.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cargobtn.Location = new System.Drawing.Point(732, 38);
            this.cargobtn.Name = "cargobtn";
            this.cargobtn.Size = new System.Drawing.Size(147, 146);
            this.cargobtn.TabIndex = 29;
            this.cargobtn.Text = "فراخوانی سرویس ثبت پیشنهاد باربری";
            this.cargobtn.UseVisualStyleBackColor = true;
            this.cargobtn.Click += new System.EventHandler(this.cargobtn_Click);
            // 
            // txtboxResult
            // 
            this.txtboxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxResult.Location = new System.Drawing.Point(12, 418);
            this.txtboxResult.Multiline = true;
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxResult.Size = new System.Drawing.Size(650, 472);
            this.txtboxResult.TabIndex = 30;
            // 
            // txtJsonInput
            // 
            this.txtJsonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJsonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJsonInput.Location = new System.Drawing.Point(919, 38);
            this.txtJsonInput.Multiline = true;
            this.txtJsonInput.Name = "txtJsonInput";
            this.txtJsonInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJsonInput.Size = new System.Drawing.Size(348, 341);
            this.txtJsonInput.TabIndex = 31;
            this.txtJsonInput.Text = resources.GetString("txtJsonInput.Text");
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(95, 14);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(411, 22);
            this.txtBasePath.TabIndex = 32;
            this.txtBasePath.Text = "https://bime.net.iraneit.com:3023/BimeApiManager_Release/\r\n";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(1141, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 32);
            this.label11.TabIndex = 42;
            this.label11.Text = ": داده های ورودی ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "BasePath:";
            // 
            // txtAppUser
            // 
            this.txtAppUser.Location = new System.Drawing.Point(58, 33);
            this.txtAppUser.Name = "txtAppUser";
            this.txtAppUser.Size = new System.Drawing.Size(150, 27);
            this.txtAppUser.TabIndex = 33;
            // 
            // txtAppSecrect
            // 
            this.txtAppSecrect.Location = new System.Drawing.Point(58, 74);
            this.txtAppSecrect.Name = "txtAppSecrect";
            this.txtAppSecrect.Size = new System.Drawing.Size(150, 27);
            this.txtAppSecrect.TabIndex = 34;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(302, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 27);
            this.txtUsername.TabIndex = 35;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(302, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 27);
            this.txtPassword.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "AppUser:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 38;
            this.label8.Text = "AppSecret";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(243, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 14);
            this.label10.TabIndex = 39;
            this.label10.Text = "UserName:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(243, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 40;
            this.label9.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apptokenbtn);
            this.groupBox1.Controls.Add(this.clientloginbtn);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 205);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فراخوانی سرویس های احراز هویت";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtAppUser);
            this.groupBox2.Controls.Add(this.txtAppSecrect);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 127);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ورودی های احراز هویت";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1129, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = ": داده های خروجی ";
            // 
            // OutPuttxt
            // 
            this.OutPuttxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutPuttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPuttxt.Location = new System.Drawing.Point(732, 418);
            this.OutPuttxt.Multiline = true;
            this.OutPuttxt.Name = "OutPuttxt";
            this.OutPuttxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutPuttxt.Size = new System.Drawing.Size(535, 472);
            this.OutPuttxt.TabIndex = 46;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(12, 393);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 17);
            this.time.TabIndex = 47;
            this.time.Text = "Time : ";
            this.time.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CargoTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 947);
            this.Controls.Add(this.time);
            this.Controls.Add(this.OutPuttxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBasePath);
            this.Controls.Add(this.txtJsonInput);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.cargobtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargoTestForm";
            this.Text = "نرم افزار شبیه ساز ثبت پیشنهاد بیمه نامه مه ی باربری";
            this.Load += new System.EventHandler(this.CargoTestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button apptokenbtn;
        private System.Windows.Forms.Button clientloginbtn;
        private System.Windows.Forms.Button cargobtn;
        private System.Windows.Forms.TextBox txtboxResult;
        private System.Windows.Forms.TextBox txtJsonInput;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAppUser;
        private System.Windows.Forms.TextBox txtAppSecrect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutPuttxt;
        private System.Windows.Forms.Label time;
    }
}

