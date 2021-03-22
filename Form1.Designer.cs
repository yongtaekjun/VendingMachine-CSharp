
namespace VendingMachine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbItemDisplay = new System.Windows.Forms.PictureBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbBalanceSign = new System.Windows.Forms.Label();
            this.pbTooney = new System.Windows.Forms.PictureBox();
            this.pbLooney = new System.Windows.Forms.PictureBox();
            this.pbQuater = new System.Windows.Forms.PictureBox();
            this.pbDime = new System.Windows.Forms.PictureBox();
            this.pbNickle = new System.Windows.Forms.PictureBox();
            this.pbPenny = new System.Windows.Forms.PictureBox();
            this.bReturn = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTooney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLooney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNickle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenny)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItemDisplay
            // 
            this.pbItemDisplay.Image = ((System.Drawing.Image)(resources.GetObject("pbItemDisplay.Image")));
            this.pbItemDisplay.Location = new System.Drawing.Point(2, 2);
            this.pbItemDisplay.Name = "pbItemDisplay";
            this.pbItemDisplay.Size = new System.Drawing.Size(303, 502);
            this.pbItemDisplay.TabIndex = 0;
            this.pbItemDisplay.TabStop = false;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(2, 510);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(303, 77);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.TabStop = false;
            // 
            // lbBalance
            // 
            this.lbBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbBalance.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbBalance.ForeColor = System.Drawing.Color.Yellow;
            this.lbBalance.Location = new System.Drawing.Point(392, 43);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(160, 23);
            this.lbBalance.TabIndex = 2;
            this.lbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBalanceSign
            // 
            this.lbBalanceSign.AutoSize = true;
            this.lbBalanceSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbBalanceSign.Location = new System.Drawing.Point(311, 43);
            this.lbBalanceSign.Name = "lbBalanceSign";
            this.lbBalanceSign.Size = new System.Drawing.Size(75, 17);
            this.lbBalanceSign.TabIndex = 3;
            this.lbBalanceSign.Text = "Balance $ ";
            // 
            // pbTooney
            // 
            this.pbTooney.Image = ((System.Drawing.Image)(resources.GetObject("pbTooney.Image")));
            this.pbTooney.Location = new System.Drawing.Point(314, 87);
            this.pbTooney.Name = "pbTooney";
            this.pbTooney.Size = new System.Drawing.Size(43, 50);
            this.pbTooney.TabIndex = 4;
            this.pbTooney.TabStop = false;
            this.pbTooney.Click += new System.EventHandler(this.pbTooney_Click);
            // 
            // pbLooney
            // 
            this.pbLooney.Image = ((System.Drawing.Image)(resources.GetObject("pbLooney.Image")));
            this.pbLooney.Location = new System.Drawing.Point(363, 87);
            this.pbLooney.Name = "pbLooney";
            this.pbLooney.Size = new System.Drawing.Size(43, 50);
            this.pbLooney.TabIndex = 5;
            this.pbLooney.TabStop = false;
            this.pbLooney.Click += new System.EventHandler(this.pbLooney_Click);
            // 
            // pbQuater
            // 
            this.pbQuater.Image = ((System.Drawing.Image)(resources.GetObject("pbQuater.Image")));
            this.pbQuater.Location = new System.Drawing.Point(412, 87);
            this.pbQuater.Name = "pbQuater";
            this.pbQuater.Size = new System.Drawing.Size(43, 50);
            this.pbQuater.TabIndex = 6;
            this.pbQuater.TabStop = false;
            this.pbQuater.Click += new System.EventHandler(this.pbQuater_Click);
            // 
            // pbDime
            // 
            this.pbDime.Image = ((System.Drawing.Image)(resources.GetObject("pbDime.Image")));
            this.pbDime.Location = new System.Drawing.Point(463, 95);
            this.pbDime.Name = "pbDime";
            this.pbDime.Size = new System.Drawing.Size(41, 36);
            this.pbDime.TabIndex = 7;
            this.pbDime.TabStop = false;
            this.pbDime.Click += new System.EventHandler(this.pbDime_Click);
            // 
            // pbNickle
            // 
            this.pbNickle.Image = ((System.Drawing.Image)(resources.GetObject("pbNickle.Image")));
            this.pbNickle.Location = new System.Drawing.Point(510, 87);
            this.pbNickle.Name = "pbNickle";
            this.pbNickle.Size = new System.Drawing.Size(42, 44);
            this.pbNickle.TabIndex = 8;
            this.pbNickle.TabStop = false;
            this.pbNickle.Click += new System.EventHandler(this.pbNickle_Click);
            // 
            // pbPenny
            // 
            this.pbPenny.Image = ((System.Drawing.Image)(resources.GetObject("pbPenny.Image")));
            this.pbPenny.Location = new System.Drawing.Point(560, 95);
            this.pbPenny.Name = "pbPenny";
            this.pbPenny.Size = new System.Drawing.Size(31, 36);
            this.pbPenny.TabIndex = 9;
            this.pbPenny.TabStop = false;
            this.pbPenny.Click += new System.EventHandler(this.pbPenny_Click);
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(412, 182);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(75, 23);
            this.bReturn.TabIndex = 10;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Yellow;
            this.btnA.Location = new System.Drawing.Point(365, 285);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(36, 33);
            this.btnA.TabIndex = 11;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Yellow;
            this.btnB.Location = new System.Drawing.Point(407, 285);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(36, 33);
            this.btnB.TabIndex = 12;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Yellow;
            this.btnC.Location = new System.Drawing.Point(449, 285);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(36, 33);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Yellow;
            this.btnD.Location = new System.Drawing.Point(491, 285);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(36, 33);
            this.btnD.TabIndex = 14;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(365, 324);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 33);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(407, 324);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 33);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(449, 324);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 33);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Yellow;
            this.btn4.Location = new System.Drawing.Point(491, 324);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 33);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(617, 599);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.pbPenny);
            this.Controls.Add(this.pbNickle);
            this.Controls.Add(this.pbDime);
            this.Controls.Add(this.pbQuater);
            this.Controls.Add(this.pbLooney);
            this.Controls.Add(this.pbTooney);
            this.Controls.Add(this.lbBalanceSign);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.pbItemDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTooney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLooney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNickle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItemDisplay;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbBalanceSign;
        private System.Windows.Forms.PictureBox pbTooney;
        private System.Windows.Forms.PictureBox pbLooney;
        private System.Windows.Forms.PictureBox pbQuater;
        private System.Windows.Forms.PictureBox pbDime;
        private System.Windows.Forms.PictureBox pbNickle;
        private System.Windows.Forms.PictureBox pbPenny;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

