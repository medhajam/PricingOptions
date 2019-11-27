namespace PricingOptions
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStkp = new System.Windows.Forms.Label();
            this.lblStDeviation = new System.Windows.Forms.Label();
            this.lblStrkp = new System.Windows.Forms.Label();
            this.lblTTM = new System.Windows.Forms.Label();
            this.txtStrkP = new System.Windows.Forms.TextBox();
            this.txtTTM = new System.Windows.Forms.TextBox();
            this.txtStdrD = new System.Windows.Forms.TextBox();
            this.txtStkP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRiskRate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStkp
            // 
            this.lblStkp.AutoSize = true;
            this.lblStkp.Location = new System.Drawing.Point(12, 20);
            this.lblStkp.Name = "lblStkp";
            this.lblStkp.Size = new System.Drawing.Size(79, 17);
            this.lblStkp.TabIndex = 0;
            this.lblStkp.Text = "Stock Price";
            // 
            // lblStDeviation
            // 
            this.lblStDeviation.AutoSize = true;
            this.lblStDeviation.Location = new System.Drawing.Point(317, 106);
            this.lblStDeviation.Name = "lblStDeviation";
            this.lblStDeviation.Size = new System.Drawing.Size(129, 17);
            this.lblStDeviation.TabIndex = 1;
            this.lblStDeviation.Text = "Standard Deviation";
            // 
            // lblStrkp
            // 
            this.lblStrkp.AutoSize = true;
            this.lblStrkp.Location = new System.Drawing.Point(330, 18);
            this.lblStrkp.Name = "lblStrkp";
            this.lblStrkp.Size = new System.Drawing.Size(80, 17);
            this.lblStrkp.TabIndex = 2;
            this.lblStrkp.Text = "Strike Price";
            // 
            // lblTTM
            // 
            this.lblTTM.AutoSize = true;
            this.lblTTM.Location = new System.Drawing.Point(12, 101);
            this.lblTTM.Name = "lblTTM";
            this.lblTTM.Size = new System.Drawing.Size(178, 17);
            this.lblTTM.TabIndex = 3;
            this.lblTTM.Text = "Time To Maturity (in years)";
            // 
            // txtStrkP
            // 
            this.txtStrkP.Location = new System.Drawing.Point(452, 15);
            this.txtStrkP.Name = "txtStrkP";
            this.txtStrkP.Size = new System.Drawing.Size(100, 22);
            this.txtStrkP.TabIndex = 4;
            this.txtStrkP.Validating += new System.ComponentModel.CancelEventHandler(this.txtStrkP_Validating);
            // 
            // txtTTM
            // 
            this.txtTTM.Location = new System.Drawing.Point(196, 98);
            this.txtTTM.Name = "txtTTM";
            this.txtTTM.Size = new System.Drawing.Size(100, 22);
            this.txtTTM.TabIndex = 5;
            this.txtTTM.Validating += new System.ComponentModel.CancelEventHandler(this.txtTTM_Validating);
            // 
            // txtStdrD
            // 
            this.txtStdrD.Location = new System.Drawing.Point(452, 101);
            this.txtStdrD.Name = "txtStdrD";
            this.txtStdrD.Size = new System.Drawing.Size(100, 22);
            this.txtStdrD.TabIndex = 6;
            // 
            // txtStkP
            // 
            this.txtStkP.Location = new System.Drawing.Point(196, 17);
            this.txtStkP.Name = "txtStkP";
            this.txtStkP.Size = new System.Drawing.Size(100, 22);
            this.txtStkP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Risk Free interest Rate";
            // 
            // txtRiskRate
            // 
            this.txtRiskRate.Location = new System.Drawing.Point(196, 190);
            this.txtRiskRate.Name = "txtRiskRate";
            this.txtRiskRate.Size = new System.Drawing.Size(100, 22);
            this.txtRiskRate.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRiskRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStkP);
            this.Controls.Add(this.txtStdrD);
            this.Controls.Add(this.txtTTM);
            this.Controls.Add(this.txtStrkP);
            this.Controls.Add(this.lblTTM);
            this.Controls.Add(this.lblStrkp);
            this.Controls.Add(this.lblStDeviation);
            this.Controls.Add(this.lblStkp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStkp;
        private System.Windows.Forms.Label lblStDeviation;
        private System.Windows.Forms.Label lblStrkp;
        private System.Windows.Forms.Label lblTTM;
        private System.Windows.Forms.TextBox txtStrkP;
        private System.Windows.Forms.TextBox txtTTM;
        private System.Windows.Forms.TextBox txtStdrD;
        private System.Windows.Forms.TextBox txtStkP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRiskRate;
        private System.Windows.Forms.Button button1;
    }
}

