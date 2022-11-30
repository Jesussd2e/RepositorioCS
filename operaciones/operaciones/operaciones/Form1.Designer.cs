
namespace operaciones
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.lbsalir = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnseno = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::operaciones.Properties.Resources.calc;
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPERACIONES BASICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(249, 181);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(183, 38);
            this.txtnum1.TabIndex = 4;
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            this.txtnum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(249, 259);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(183, 38);
            this.txtnum2.TabIndex = 5;
            this.txtnum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum2_KeyPress);
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.Color.GreenYellow;
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(547, 90);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(142, 38);
            this.btnsuma.TabIndex = 6;
            this.btnsuma.Text = "suma";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.Color.Aquamarine;
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(547, 147);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(142, 40);
            this.btnresta.TabIndex = 7;
            this.btnresta.Text = "resta";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmul
            // 
            this.btnmul.BackColor = System.Drawing.Color.Violet;
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(547, 204);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(142, 43);
            this.btnmul.TabIndex = 8;
            this.btnmul.Text = "multiplica";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.RosyBrown;
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(547, 275);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(142, 40);
            this.btndivide.TabIndex = 9;
            this.btndivide.Text = "divide";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultado.Location = new System.Drawing.Point(243, 359);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(34, 31);
            this.lbresultado.TabIndex = 10;
            this.lbresultado.Text = "R";
            // 
            // lbsalir
            // 
            this.lbsalir.AutoSize = true;
            this.lbsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsalir.ForeColor = System.Drawing.Color.Red;
            this.lbsalir.Location = new System.Drawing.Point(760, 464);
            this.lbsalir.Name = "lbsalir";
            this.lbsalir.Size = new System.Drawing.Size(80, 29);
            this.lbsalir.TabIndex = 11;
            this.lbsalir.Text = "SALIR";
            this.lbsalir.Click += new System.EventHandler(this.lbsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Location = new System.Drawing.Point(659, 25);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(64, 45);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "C";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnseno
            // 
            this.btnseno.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseno.Location = new System.Drawing.Point(547, 337);
            this.btnseno.Name = "btnseno";
            this.btnseno.Size = new System.Drawing.Size(142, 38);
            this.btnseno.TabIndex = 16;
            this.btnseno.Text = "seno";
            this.btnseno.UseVisualStyleBackColor = false;
            this.btnseno.Click += new System.EventHandler(this.btnseno_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Grados",
            "Radianes"});
            this.checkedListBox1.Location = new System.Drawing.Point(267, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 46);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(709, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "POLAR->RECTANGULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(709, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "RECTANGULAR->POLAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnseno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lbsalir);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opweraciones basicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Label lbsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnseno;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

