namespace Revisao
{
    partial class Divisao
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
            this.bt_calcular = new System.Windows.Forms.Button();
            this.tx_valor1 = new System.Windows.Forms.TextBox();
            this.tx_valor2 = new System.Windows.Forms.TextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(95, 233);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(100, 23);
            this.bt_calcular.TabIndex = 0;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // tx_valor1
            // 
            this.tx_valor1.Location = new System.Drawing.Point(80, 118);
            this.tx_valor1.Name = "tx_valor1";
            this.tx_valor1.Size = new System.Drawing.Size(131, 20);
            this.tx_valor1.TabIndex = 1;
            // 
            // tx_valor2
            // 
            this.tx_valor2.Location = new System.Drawing.Point(80, 167);
            this.tx_valor2.Name = "tx_valor2";
            this.tx_valor2.Size = new System.Drawing.Size(131, 20);
            this.tx_valor2.TabIndex = 2;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(77, 207);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(35, 13);
            this.lb_resultado.TabIndex = 3;
            this.lb_resultado.Text = "label1";
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 352);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.tx_valor2);
            this.Controls.Add(this.tx_valor1);
            this.Controls.Add(this.bt_calcular);
            this.Name = "Divisao";
            this.Text = "Divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.TextBox tx_valor1;
        private System.Windows.Forms.TextBox tx_valor2;
        private System.Windows.Forms.Label lb_resultado;
    }
}