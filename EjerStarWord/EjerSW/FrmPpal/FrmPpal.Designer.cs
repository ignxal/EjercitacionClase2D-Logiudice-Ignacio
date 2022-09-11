
namespace FrmPpal
{
    partial class FrmPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPpal));
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lstEjercito = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbClon = new System.Windows.Forms.CheckBox();
            this.cmbBlaster = new System.Windows.Forms.ComboBox();
            this.lblBlaster = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(21, 22);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 332);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 41);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Location = new System.Drawing.Point(12, 379);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(135, 34);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lstEjercito
            // 
            this.lstEjercito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEjercito.BackColor = System.Drawing.Color.White;
            this.lstEjercito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEjercito.ForeColor = System.Drawing.Color.IndianRed;
            this.lstEjercito.FormattingEnabled = true;
            this.lstEjercito.ItemHeight = 20;
            this.lstEjercito.Location = new System.Drawing.Point(176, 154);
            this.lstEjercito.Name = "lstEjercito";
            this.lstEjercito.Size = new System.Drawing.Size(624, 244);
            this.lstEjercito.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // ckbClon
            // 
            this.ckbClon.AutoSize = true;
            this.ckbClon.Location = new System.Drawing.Point(48, 295);
            this.ckbClon.Name = "ckbClon";
            this.ckbClon.Size = new System.Drawing.Size(51, 19);
            this.ckbClon.TabIndex = 5;
            this.ckbClon.Text = "Clon";
            this.ckbClon.UseVisualStyleBackColor = true;
            // 
            // cmbBlaster
            // 
            this.cmbBlaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlaster.FormattingEnabled = true;
            this.cmbBlaster.Location = new System.Drawing.Point(21, 101);
            this.cmbBlaster.Name = "cmbBlaster";
            this.cmbBlaster.Size = new System.Drawing.Size(121, 23);
            this.cmbBlaster.TabIndex = 6;
            // 
            // lblBlaster
            // 
            this.lblBlaster.AutoSize = true;
            this.lblBlaster.Location = new System.Drawing.Point(21, 83);
            this.lblBlaster.Name = "lblBlaster";
            this.lblBlaster.Size = new System.Drawing.Size(42, 15);
            this.lblBlaster.TabIndex = 7;
            this.lblBlaster.Text = "Blaster";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 129);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBlaster);
            this.Controls.Add(this.cmbBlaster);
            this.Controls.Add(this.ckbClon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEjercito);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a la fabrica de troopers del Lado Oscuro";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lstEjercito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbClon;
        private System.Windows.Forms.ComboBox cmbBlaster;
        private System.Windows.Forms.Label lblBlaster;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

