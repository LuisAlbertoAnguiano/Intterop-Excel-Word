namespace Intterop_Excel_Word
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Tbx_Nombre = new System.Windows.Forms.TextBox();
            this.Tbx_Texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Directorio = new System.Windows.Forms.TextBox();
            this.Btn_Directorio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Archivo Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tbx_Nombre
            // 
            this.Tbx_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Nombre.Location = new System.Drawing.Point(333, 68);
            this.Tbx_Nombre.MaxLength = 60;
            this.Tbx_Nombre.Name = "Tbx_Nombre";
            this.Tbx_Nombre.Size = new System.Drawing.Size(281, 29);
            this.Tbx_Nombre.TabIndex = 1;
            // 
            // Tbx_Texto
            // 
            this.Tbx_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Texto.Location = new System.Drawing.Point(333, 126);
            this.Tbx_Texto.MaxLength = 200;
            this.Tbx_Texto.Name = "Tbx_Texto";
            this.Tbx_Texto.Size = new System.Drawing.Size(281, 29);
            this.Tbx_Texto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carpeta de destino";
            // 
            // Tbx_Directorio
            // 
            this.Tbx_Directorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Directorio.Location = new System.Drawing.Point(333, 177);
            this.Tbx_Directorio.MaxLength = 200;
            this.Tbx_Directorio.Name = "Tbx_Directorio";
            this.Tbx_Directorio.Size = new System.Drawing.Size(281, 29);
            this.Tbx_Directorio.TabIndex = 6;
            // 
            // Btn_Directorio
            // 
            this.Btn_Directorio.BackColor = System.Drawing.Color.Silver;
            this.Btn_Directorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Directorio.Location = new System.Drawing.Point(620, 177);
            this.Btn_Directorio.Name = "Btn_Directorio";
            this.Btn_Directorio.Size = new System.Drawing.Size(36, 29);
            this.Btn_Directorio.TabIndex = 7;
            this.Btn_Directorio.Text = "...";
            this.Btn_Directorio.UseVisualStyleBackColor = false;
            this.Btn_Directorio.Click += new System.EventHandler(this.Btn_Directorio_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(230, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(326, 81);
            this.button2.TabIndex = 8;
            this.button2.Text = "Generar Archivo Word";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Directorio);
            this.Controls.Add(this.Tbx_Directorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_Texto);
            this.Controls.Add(this.Tbx_Nombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tbx_Nombre;
        private System.Windows.Forms.TextBox Tbx_Texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_Directorio;
        private System.Windows.Forms.Button Btn_Directorio;
        private System.Windows.Forms.Button button2;
    }
}

