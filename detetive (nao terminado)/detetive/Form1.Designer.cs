namespace detetive
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbP1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbP2 = new System.Windows.Forms.CheckBox();
            this.cbP3 = new System.Windows.Forms.CheckBox();
            this.cbP4 = new System.Windows.Forms.CheckBox();
            this.cbP5 = new System.Windows.Forms.CheckBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interrogatório";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbP1
            // 
            this.cbP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbP1.AutoSize = true;
            this.cbP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP1.Location = new System.Drawing.Point(36, 90);
            this.cbP1.Name = "cbP1";
            this.cbP1.Size = new System.Drawing.Size(163, 20);
            this.cbP1.TabIndex = 1;
            this.cbP1.Text = "Telefonou para vitima?";
            this.cbP1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(38, 113);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(163, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Telefonou para vitima?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbP2
            // 
            this.cbP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbP2.AutoSize = true;
            this.cbP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP2.Location = new System.Drawing.Point(36, 113);
            this.cbP2.Name = "cbP2";
            this.cbP2.Size = new System.Drawing.Size(180, 20);
            this.cbP2.TabIndex = 1;
            this.cbP2.Text = "Esteve no local do crime?";
            this.cbP2.UseVisualStyleBackColor = true;
            // 
            // cbP3
            // 
            this.cbP3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbP3.AutoSize = true;
            this.cbP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP3.Location = new System.Drawing.Point(36, 136);
            this.cbP3.Name = "cbP3";
            this.cbP3.Size = new System.Drawing.Size(155, 20);
            this.cbP3.TabIndex = 1;
            this.cbP3.Text = "Mora perto da vitima?";
            this.cbP3.UseVisualStyleBackColor = true;
            // 
            // cbP4
            // 
            this.cbP4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbP4.AutoSize = true;
            this.cbP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP4.Location = new System.Drawing.Point(36, 159);
            this.cbP4.Name = "cbP4";
            this.cbP4.Size = new System.Drawing.Size(149, 20);
            this.cbP4.TabIndex = 1;
            this.cbP4.Text = "Devia para a vitima?";
            this.cbP4.UseVisualStyleBackColor = true;
            // 
            // cbP5
            // 
            this.cbP5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbP5.AutoSize = true;
            this.cbP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP5.Location = new System.Drawing.Point(36, 182);
            this.cbP5.Name = "cbP5";
            this.cbP5.Size = new System.Drawing.Size(185, 20);
            this.cbP5.TabIndex = 1;
            this.cbP5.Text = "Já trabalhou com a vitima?";
            this.cbP5.UseVisualStyleBackColor = true;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnalisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(36, 218);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(79, 29);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(418, 221);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::detetive.Properties.Resources.inocente;
            this.pictureBox1.Location = new System.Drawing.Point(422, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(639, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.cbP5);
            this.Controls.Add(this.cbP4);
            this.Controls.Add(this.cbP3);
            this.Controls.Add(this.cbP2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cbP1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbP1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbP2;
        private System.Windows.Forms.CheckBox cbP3;
        private System.Windows.Forms.CheckBox cbP4;
        private System.Windows.Forms.CheckBox cbP5;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

