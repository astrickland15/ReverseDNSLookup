namespace ReverseDNS
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
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Domain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.WriteText = new System.Windows.Forms.Button();
            this.DomCheck = new System.Windows.Forms.TextBox();
            this.IPResolve = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Match = new System.Windows.Forms.Label();
            this.notMatching = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.written = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(117, 28);
            this.IPAddress.Multiline = true;
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(233, 88);
            this.IPAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Domain
            // 
            this.Domain.Location = new System.Drawing.Point(441, 28);
            this.Domain.Multiline = true;
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(246, 88);
            this.Domain.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Domain";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(360, 59);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // WriteText
            // 
            this.WriteText.Location = new System.Drawing.Point(122, 346);
            this.WriteText.Name = "WriteText";
            this.WriteText.Size = new System.Drawing.Size(115, 23);
            this.WriteText.TabIndex = 5;
            this.WriteText.Text = "Write To Text File";
            this.WriteText.UseVisualStyleBackColor = true;
            this.WriteText.Click += new System.EventHandler(this.WriteText_Click);
            // 
            // DomCheck
            // 
            this.DomCheck.Location = new System.Drawing.Point(117, 160);
            this.DomCheck.Multiline = true;
            this.DomCheck.Name = "DomCheck";
            this.DomCheck.Size = new System.Drawing.Size(233, 88);
            this.DomCheck.TabIndex = 6;
            // 
            // IPResolve
            // 
            this.IPResolve.Location = new System.Drawing.Point(441, 160);
            this.IPResolve.Multiline = true;
            this.IPResolve.Name = "IPResolve";
            this.IPResolve.Size = new System.Drawing.Size(246, 88);
            this.IPResolve.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Domain";
            // 
            // Match
            // 
            this.Match.AutoSize = true;
            this.Match.Location = new System.Drawing.Point(356, 131);
            this.Match.Name = "Match";
            this.Match.Size = new System.Drawing.Size(0, 13);
            this.Match.TabIndex = 11;
            this.Match.Visible = false;
            // 
            // notMatching
            // 
            this.notMatching.Location = new System.Drawing.Point(287, 318);
            this.notMatching.Multiline = true;
            this.notMatching.Name = "notMatching";
            this.notMatching.Size = new System.Drawing.Size(246, 88);
            this.notMatching.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "These IPs are not forward confirmed:";
            // 
            // written
            // 
            this.written.AutoSize = true;
            this.written.Location = new System.Drawing.Point(158, 330);
            this.written.Name = "written";
            this.written.Size = new System.Drawing.Size(0, 13);
            this.written.TabIndex = 14;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(590, 346);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.written);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notMatching);
            this.Controls.Add(this.Match);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IPResolve);
            this.Controls.Add(this.DomCheck);
            this.Controls.Add(this.WriteText);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Domain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAddress);
            this.Name = "Form1";
            this.Text = "Reverse DNS Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Domain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button WriteText;
        private System.Windows.Forms.TextBox DomCheck;
        private System.Windows.Forms.TextBox IPResolve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Match;
        private System.Windows.Forms.TextBox notMatching;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label written;
        private System.Windows.Forms.Button clear;
    }
}

