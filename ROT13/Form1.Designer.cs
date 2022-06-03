
namespace ROT13
{
    partial class ROT13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROT13));
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbEncriptado = new System.Windows.Forms.Label();
            this.lbDesencriptado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTXTDesencriptado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbvl = new System.Windows.Forms.Label();
            this.lbRot13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Lime;
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.Location = new System.Drawing.Point(313, 164);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(146, 28);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "INICIAR";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encriptado por ROT13";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbEncriptado
            // 
            this.lbEncriptado.AutoSize = true;
            this.lbEncriptado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbEncriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbEncriptado.Location = new System.Drawing.Point(61, 388);
            this.lbEncriptado.Name = "lbEncriptado";
            this.lbEncriptado.Size = new System.Drawing.Size(0, 16);
            this.lbEncriptado.TabIndex = 4;
            // 
            // lbDesencriptado
            // 
            this.lbDesencriptado.AutoSize = true;
            this.lbDesencriptado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbDesencriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbDesencriptado.Location = new System.Drawing.Point(479, 278);
            this.lbDesencriptado.Name = "lbDesencriptado";
            this.lbDesencriptado.Size = new System.Drawing.Size(0, 16);
            this.lbDesencriptado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(3, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Encriptado ROT13";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(3, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Encriptado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(421, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Desencriptado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(421, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Texto desencriptado";
            // 
            // lbTXTDesencriptado
            // 
            this.lbTXTDesencriptado.AutoSize = true;
            this.lbTXTDesencriptado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTXTDesencriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbTXTDesencriptado.Location = new System.Drawing.Point(482, 352);
            this.lbTXTDesencriptado.Name = "lbTXTDesencriptado";
            this.lbTXTDesencriptado.Size = new System.Drawing.Size(0, 16);
            this.lbTXTDesencriptado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(3, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valores asignados para encriptar";
            // 
            // lbvl
            // 
            this.lbvl.AutoSize = true;
            this.lbvl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbvl.Location = new System.Drawing.Point(61, 333);
            this.lbvl.Name = "lbvl";
            this.lbvl.Size = new System.Drawing.Size(0, 16);
            this.lbvl.TabIndex = 12;
            // 
            // lbRot13
            // 
            this.lbRot13.AutoSize = true;
            this.lbRot13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbRot13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbRot13.Location = new System.Drawing.Point(64, 270);
            this.lbRot13.Name = "lbRot13";
            this.lbRot13.Size = new System.Drawing.Size(0, 16);
            this.lbRot13.TabIndex = 13;
            // 
            // ROT13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRot13);
            this.Controls.Add(this.lbvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTXTDesencriptado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDesencriptado);
            this.Controls.Add(this.lbEncriptado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ROT13";
            this.Text = "ROT13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbEncriptado;
        private System.Windows.Forms.Label lbDesencriptado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTXTDesencriptado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbvl;
        private System.Windows.Forms.Label lbRot13;
    }
}

