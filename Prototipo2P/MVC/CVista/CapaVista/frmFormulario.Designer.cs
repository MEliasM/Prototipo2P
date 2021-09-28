
namespace CapaVista
{
    partial class frmFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulario));
            this.dgvForm = new System.Windows.Forms.DataGridView();
            this.btnForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForm
            // 
            this.dgvForm.AllowUserToAddRows = false;
            this.dgvForm.AllowUserToDeleteRows = false;
            this.dgvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm.Location = new System.Drawing.Point(30, 73);
            this.dgvForm.Name = "dgvForm";
            this.dgvForm.ReadOnly = true;
            this.dgvForm.RowHeadersWidth = 51;
            this.dgvForm.RowTemplate.Height = 24;
            this.dgvForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvForm.Size = new System.Drawing.Size(720, 216);
            this.dgvForm.TabIndex = 0;
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(39, 333);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(106, 33);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "Alumnos";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Informacion";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\marco\\Desktop\\Componentes Graficos Vb2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Of" +
    "fice2007\\office2007.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Maestros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Notas Alumnos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.dgvForm);
            this.Name = "frmFormulario";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForm;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Label label1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}