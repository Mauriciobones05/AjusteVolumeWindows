
namespace AjusteVolumeWindows
{
    partial class AjusteVolumeWindows
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
            this.trackBarMicrofone = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSistema = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblVolumeSistema = new System.Windows.Forms.Label();
            this.lblVolumeMicrofone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMicrofone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração de Som - Windows";
            // 
            // trackBarMicrofone
            // 
            this.trackBarMicrofone.AutoSize = false;
            this.trackBarMicrofone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBarMicrofone.Location = new System.Drawing.Point(22, 74);
            this.trackBarMicrofone.Maximum = 100;
            this.trackBarMicrofone.Name = "trackBarMicrofone";
            this.trackBarMicrofone.Size = new System.Drawing.Size(327, 45);
            this.trackBarMicrofone.TabIndex = 1;
            this.trackBarMicrofone.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarMicrofone.Scroll += new System.EventHandler(this.trackBarMicrofone_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volume de Microfone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume de Áudio:";
            // 
            // trackBarSistema
            // 
            this.trackBarSistema.AutoSize = false;
            this.trackBarSistema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBarSistema.Location = new System.Drawing.Point(22, 170);
            this.trackBarSistema.Maximum = 100;
            this.trackBarSistema.Name = "trackBarSistema";
            this.trackBarSistema.Size = new System.Drawing.Size(327, 45);
            this.trackBarSistema.TabIndex = 3;
            this.trackBarSistema.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSistema.Scroll += new System.EventHandler(this.trackBarSistema_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "0";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(248, 221);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(130, 30);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click_1);
            // 
            // lblVolumeSistema
            // 
            this.lblVolumeSistema.AutoSize = true;
            this.lblVolumeSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeSistema.Location = new System.Drawing.Point(131, 151);
            this.lblVolumeSistema.Name = "lblVolumeSistema";
            this.lblVolumeSistema.Size = new System.Drawing.Size(27, 16);
            this.lblVolumeSistema.TabIndex = 10;
            this.lblVolumeSistema.Text = "0%";
            // 
            // lblVolumeMicrofone
            // 
            this.lblVolumeMicrofone.AutoSize = true;
            this.lblVolumeMicrofone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeMicrofone.Location = new System.Drawing.Point(154, 55);
            this.lblVolumeMicrofone.Name = "lblVolumeMicrofone";
            this.lblVolumeMicrofone.Size = new System.Drawing.Size(27, 16);
            this.lblVolumeMicrofone.TabIndex = 11;
            this.lblVolumeMicrofone.Text = "0%";
            // 
            // AjusteVolumeWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.lblVolumeMicrofone);
            this.Controls.Add(this.lblVolumeSistema);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarSistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarMicrofone);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 374);
            this.MinimizeBox = false;
            this.Name = "AjusteVolumeWindows";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Volume ";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMicrofone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarMicrofone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarSistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblVolumeSistema;
        private System.Windows.Forms.Label lblVolumeMicrofone;
    }
}

