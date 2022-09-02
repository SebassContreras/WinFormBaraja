
namespace WinFormBaraja
{
    partial class formBaraja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBaraja));
            this.butBarajar = new System.Windows.Forms.Button();
            this.numCartas = new System.Windows.Forms.Label();
            this.butnumCartas = new System.Windows.Forms.Button();
            this.labBaraja = new System.Windows.Forms.Label();
            this.butBaraja = new System.Windows.Forms.Button();
            this.butRobaCarta = new System.Windows.Forms.Button();
            this.labRobaCarta = new System.Windows.Forms.Label();
            this.butCartaAzar = new System.Windows.Forms.Button();
            this.labCartaAzar = new System.Windows.Forms.Label();
            this.picCartas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // butBarajar
            // 
            this.butBarajar.Location = new System.Drawing.Point(564, 23);
            this.butBarajar.Name = "butBarajar";
            this.butBarajar.Size = new System.Drawing.Size(195, 94);
            this.butBarajar.TabIndex = 0;
            this.butBarajar.Text = "Barajar";
            this.butBarajar.UseVisualStyleBackColor = true;
            // 
            // numCartas
            // 
            this.numCartas.AutoSize = true;
            this.numCartas.Location = new System.Drawing.Point(50, 47);
            this.numCartas.Name = "numCartas";
            this.numCartas.Size = new System.Drawing.Size(214, 20);
            this.numCartas.TabIndex = 1;
            this.numCartas.Text = "Numero de Cartas En La Baraja";
            // 
            // butnumCartas
            // 
            this.butnumCartas.Location = new System.Drawing.Point(270, 43);
            this.butnumCartas.Name = "butnumCartas";
            this.butnumCartas.Size = new System.Drawing.Size(94, 29);
            this.butnumCartas.TabIndex = 2;
            this.butnumCartas.Text = "Mostrar";
            this.butnumCartas.UseVisualStyleBackColor = true;
            this.butnumCartas.Click += new System.EventHandler(this.butnumCartas_Click);
            // 
            // labBaraja
            // 
            this.labBaraja.AutoSize = true;
            this.labBaraja.Location = new System.Drawing.Point(50, 97);
            this.labBaraja.Name = "labBaraja";
            this.labBaraja.Size = new System.Drawing.Size(201, 20);
            this.labBaraja.TabIndex = 3;
            this.labBaraja.Text = "Todas Las cartas En La Baraja";
            // 
            // butBaraja
            // 
            this.butBaraja.Location = new System.Drawing.Point(270, 93);
            this.butBaraja.Name = "butBaraja";
            this.butBaraja.Size = new System.Drawing.Size(94, 29);
            this.butBaraja.TabIndex = 4;
            this.butBaraja.Text = "Mostrar";
            this.butBaraja.UseVisualStyleBackColor = true;
            this.butBaraja.Click += new System.EventHandler(this.butBaraja_Click);
            // 
            // butRobaCarta
            // 
            this.butRobaCarta.Location = new System.Drawing.Point(270, 151);
            this.butRobaCarta.Name = "butRobaCarta";
            this.butRobaCarta.Size = new System.Drawing.Size(94, 29);
            this.butRobaCarta.TabIndex = 6;
            this.butRobaCarta.Text = "Robar";
            this.butRobaCarta.UseVisualStyleBackColor = true;
            // 
            // labRobaCarta
            // 
            this.labRobaCarta.AutoSize = true;
            this.labRobaCarta.Location = new System.Drawing.Point(50, 155);
            this.labRobaCarta.Name = "labRobaCarta";
            this.labRobaCarta.Size = new System.Drawing.Size(176, 20);
            this.labRobaCarta.TabIndex = 5;
            this.labRobaCarta.Text = "Robar Carta De La Baraja";
            // 
            // butCartaAzar
            // 
            this.butCartaAzar.Location = new System.Drawing.Point(270, 211);
            this.butCartaAzar.Name = "butCartaAzar";
            this.butCartaAzar.Size = new System.Drawing.Size(94, 29);
            this.butCartaAzar.TabIndex = 8;
            this.butCartaAzar.Text = "Coger";
            this.butCartaAzar.UseVisualStyleBackColor = true;
            // 
            // labCartaAzar
            // 
            this.labCartaAzar.AutoSize = true;
            this.labCartaAzar.Location = new System.Drawing.Point(50, 215);
            this.labCartaAzar.Name = "labCartaAzar";
            this.labCartaAzar.Size = new System.Drawing.Size(140, 20);
            this.labCartaAzar.TabIndex = 7;
            this.labCartaAzar.Text = "Coger Carta Al Azar";
            // 
            // picCartas
            // 
            this.picCartas.Image = ((System.Drawing.Image)(resources.GetObject("picCartas.Image")));
            this.picCartas.Location = new System.Drawing.Point(600, 135);
            this.picCartas.Name = "picCartas";
            this.picCartas.Size = new System.Drawing.Size(126, 116);
            this.picCartas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCartas.TabIndex = 9;
            this.picCartas.TabStop = false;
            // 
            // formBaraja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.picCartas);
            this.Controls.Add(this.butCartaAzar);
            this.Controls.Add(this.labCartaAzar);
            this.Controls.Add(this.butRobaCarta);
            this.Controls.Add(this.labRobaCarta);
            this.Controls.Add(this.butBaraja);
            this.Controls.Add(this.labBaraja);
            this.Controls.Add(this.butnumCartas);
            this.Controls.Add(this.numCartas);
            this.Controls.Add(this.butBarajar);
            this.Name = "formBaraja";
            this.Text = "Baraja De Cartas";
            ((System.ComponentModel.ISupportInitialize)(this.picCartas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBarajar;
        private System.Windows.Forms.Label numCartas;
        private System.Windows.Forms.Button butnumCartas;
        private System.Windows.Forms.Label labBaraja;
        private System.Windows.Forms.Button butBaraja;
        private System.Windows.Forms.Button butRobaCarta;
        private System.Windows.Forms.Label labRobaCarta;
        private System.Windows.Forms.Button butCartaAzar;
        private System.Windows.Forms.Label labCartaAzar;
        private System.Windows.Forms.PictureBox picCartas;
    }
}

