
namespace T21_UnitTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_trapecio = new System.Windows.Forms.RadioButton();
            this.rb_romboide = new System.Windows.Forms.RadioButton();
            this.rb_Rombo = new System.Windows.Forms.RadioButton();
            this.rb_pentagono = new System.Windows.Forms.RadioButton();
            this.rb_rectangulo = new System.Windows.Forms.RadioButton();
            this.rb_triangulo = new System.Windows.Forms.RadioButton();
            this.rb_Circulo = new System.Windows.Forms.RadioButton();
            this.rb_cuadrado = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rb_trapecio);
            this.groupBox1.Controls.Add(this.rb_romboide);
            this.groupBox1.Controls.Add(this.rb_Rombo);
            this.groupBox1.Controls.Add(this.rb_pentagono);
            this.groupBox1.Controls.Add(this.rb_rectangulo);
            this.groupBox1.Controls.Add(this.rb_triangulo);
            this.groupBox1.Controls.Add(this.rb_Circulo);
            this.groupBox1.Controls.Add(this.rb_cuadrado);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular el area";
            // 
            // rb_trapecio
            // 
            this.rb_trapecio.AutoSize = true;
            this.rb_trapecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_trapecio.Location = new System.Drawing.Point(6, 252);
            this.rb_trapecio.Name = "rb_trapecio";
            this.rb_trapecio.Size = new System.Drawing.Size(84, 21);
            this.rb_trapecio.TabIndex = 7;
            this.rb_trapecio.TabStop = true;
            this.rb_trapecio.Text = "Trapecio";
            this.rb_trapecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_trapecio.UseVisualStyleBackColor = true;
            this.rb_trapecio.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_romboide
            // 
            this.rb_romboide.AutoSize = true;
            this.rb_romboide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_romboide.Location = new System.Drawing.Point(6, 186);
            this.rb_romboide.Name = "rb_romboide";
            this.rb_romboide.Size = new System.Drawing.Size(92, 21);
            this.rb_romboide.TabIndex = 6;
            this.rb_romboide.TabStop = true;
            this.rb_romboide.Text = "Romboide";
            this.rb_romboide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_romboide.UseVisualStyleBackColor = true;
            this.rb_romboide.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_Rombo
            // 
            this.rb_Rombo.AutoSize = true;
            this.rb_Rombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Rombo.Location = new System.Drawing.Point(6, 219);
            this.rb_Rombo.Name = "rb_Rombo";
            this.rb_Rombo.Size = new System.Drawing.Size(73, 21);
            this.rb_Rombo.TabIndex = 5;
            this.rb_Rombo.TabStop = true;
            this.rb_Rombo.Text = "Rombo";
            this.rb_Rombo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Rombo.UseVisualStyleBackColor = true;
            this.rb_Rombo.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_pentagono
            // 
            this.rb_pentagono.AutoSize = true;
            this.rb_pentagono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_pentagono.Location = new System.Drawing.Point(6, 153);
            this.rb_pentagono.Name = "rb_pentagono";
            this.rb_pentagono.Size = new System.Drawing.Size(97, 21);
            this.rb_pentagono.TabIndex = 4;
            this.rb_pentagono.TabStop = true;
            this.rb_pentagono.Text = "Pentagono";
            this.rb_pentagono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_pentagono.UseVisualStyleBackColor = true;
            this.rb_pentagono.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_rectangulo
            // 
            this.rb_rectangulo.AutoSize = true;
            this.rb_rectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_rectangulo.Location = new System.Drawing.Point(6, 120);
            this.rb_rectangulo.Name = "rb_rectangulo";
            this.rb_rectangulo.Size = new System.Drawing.Size(100, 21);
            this.rb_rectangulo.TabIndex = 3;
            this.rb_rectangulo.TabStop = true;
            this.rb_rectangulo.Text = "Rectangulo";
            this.rb_rectangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_rectangulo.UseVisualStyleBackColor = true;
            this.rb_rectangulo.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_triangulo
            // 
            this.rb_triangulo.AutoSize = true;
            this.rb_triangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_triangulo.Location = new System.Drawing.Point(6, 87);
            this.rb_triangulo.Name = "rb_triangulo";
            this.rb_triangulo.Size = new System.Drawing.Size(88, 21);
            this.rb_triangulo.TabIndex = 2;
            this.rb_triangulo.TabStop = true;
            this.rb_triangulo.Text = "Triangulo";
            this.rb_triangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_triangulo.UseVisualStyleBackColor = true;
            this.rb_triangulo.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_Circulo
            // 
            this.rb_Circulo.AutoSize = true;
            this.rb_Circulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Circulo.Location = new System.Drawing.Point(6, 54);
            this.rb_Circulo.Name = "rb_Circulo";
            this.rb_Circulo.Size = new System.Drawing.Size(71, 21);
            this.rb_Circulo.TabIndex = 1;
            this.rb_Circulo.TabStop = true;
            this.rb_Circulo.Text = "Circulo";
            this.rb_Circulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Circulo.UseVisualStyleBackColor = true;
            this.rb_Circulo.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // rb_cuadrado
            // 
            this.rb_cuadrado.AutoSize = true;
            this.rb_cuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_cuadrado.Location = new System.Drawing.Point(6, 21);
            this.rb_cuadrado.Name = "rb_cuadrado";
            this.rb_cuadrado.Size = new System.Drawing.Size(90, 21);
            this.rb_cuadrado.TabIndex = 0;
            this.rb_cuadrado.TabStop = true;
            this.rb_cuadrado.Text = "Cuadrado";
            this.rb_cuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_cuadrado.UseVisualStyleBackColor = true;
            this.rb_cuadrado.CheckedChanged += new System.EventHandler(this.showTXT);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 22);
            this.textBox1.TabIndex = 1;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(23, 346);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(306, 44);
            this.bt_Aceptar.TabIndex = 2;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de áreas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_pentagono;
        private System.Windows.Forms.RadioButton rb_rectangulo;
        private System.Windows.Forms.RadioButton rb_triangulo;
        private System.Windows.Forms.RadioButton rb_Circulo;
        private System.Windows.Forms.RadioButton rb_cuadrado;
        private System.Windows.Forms.RadioButton rb_romboide;
        private System.Windows.Forms.RadioButton rb_Rombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.RadioButton rb_trapecio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

