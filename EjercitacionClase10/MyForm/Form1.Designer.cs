namespace MyForm
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
            this.btnSword = new System.Windows.Forms.Button();
            this.btnAxe = new System.Windows.Forms.Button();
            this.btnBow = new System.Windows.Forms.Button();
            this.lblAttack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSword
            // 
            this.btnSword.Location = new System.Drawing.Point(115, 111);
            this.btnSword.Name = "btnSword";
            this.btnSword.Size = new System.Drawing.Size(90, 38);
            this.btnSword.TabIndex = 0;
            this.btnSword.Text = "Espada";
            this.btnSword.UseVisualStyleBackColor = true;
            this.btnSword.Click += new System.EventHandler(this.btnSword_Click);
            // 
            // btnAxe
            // 
            this.btnAxe.Location = new System.Drawing.Point(115, 184);
            this.btnAxe.Name = "btnAxe";
            this.btnAxe.Size = new System.Drawing.Size(90, 38);
            this.btnAxe.TabIndex = 1;
            this.btnAxe.Text = "Hacha";
            this.btnAxe.UseVisualStyleBackColor = true;
            this.btnAxe.Click += new System.EventHandler(this.btnAxe_Click);
            // 
            // btnBow
            // 
            this.btnBow.Location = new System.Drawing.Point(115, 259);
            this.btnBow.Name = "btnBow";
            this.btnBow.Size = new System.Drawing.Size(90, 35);
            this.btnBow.TabIndex = 2;
            this.btnBow.Text = "Arco";
            this.btnBow.UseVisualStyleBackColor = true;
            this.btnBow.Click += new System.EventHandler(this.btnBow_Click);
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAttack.Location = new System.Drawing.Point(115, 343);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(0, 32);
            this.lblAttack.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Equipar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Atacar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.btnBow);
            this.Controls.Add(this.btnAxe);
            this.Controls.Add(this.btnSword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSword;
        private Button btnAxe;
        private Button btnBow;
        private Label lblAttack;
        private Label label1;
        private Button button1;
    }
}