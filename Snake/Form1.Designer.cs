namespace Snake
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
            this.lblSnakeHead = new System.Windows.Forms.Label();
            this.pbApple = new System.Windows.Forms.PictureBox();
            this.lblContandorTxT = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSnakeHead
            // 
            this.lblSnakeHead.AutoSize = true;
            this.lblSnakeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnakeHead.Location = new System.Drawing.Point(592, 199);
            this.lblSnakeHead.Name = "lblSnakeHead";
            this.lblSnakeHead.Size = new System.Drawing.Size(30, 31);
            this.lblSnakeHead.TabIndex = 0;
            this.lblSnakeHead.Text = ">";
            // 
            // pbApple
            // 
            this.pbApple.Image = global::Snake.Properties.Resources.bxcbiiu1wxa71;
            this.pbApple.Location = new System.Drawing.Point(639, 199);
            this.pbApple.Name = "pbApple";
            this.pbApple.Size = new System.Drawing.Size(44, 39);
            this.pbApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApple.TabIndex = 1;
            this.pbApple.TabStop = false;
            this.pbApple.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblContandorTxT
            // 
            this.lblContandorTxT.AutoSize = true;
            this.lblContandorTxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContandorTxT.Location = new System.Drawing.Point(3, 9);
            this.lblContandorTxT.Name = "lblContandorTxT";
            this.lblContandorTxT.Size = new System.Drawing.Size(113, 33);
            this.lblContandorTxT.TabIndex = 2;
            this.lblContandorTxT.Text = "Puntos:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(107, 9);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(31, 33);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "0";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblContandorTxT);
            this.Controls.Add(this.pbApple);
            this.Controls.Add(this.lblSnakeHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSnakeHead;
        private System.Windows.Forms.PictureBox pbApple;
        private System.Windows.Forms.Label lblContandorTxT;
        private System.Windows.Forms.Label lblContador;
    }
}

