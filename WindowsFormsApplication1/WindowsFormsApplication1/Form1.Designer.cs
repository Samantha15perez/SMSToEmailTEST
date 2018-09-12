namespace WindowsFormsApplication1
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxMessageRecipient = new System.Windows.Forms.TextBox();
            this.textBoxMessageBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonVerizon = new System.Windows.Forms.RadioButton();
            this.radioButtonSprint = new System.Windows.Forms.RadioButton();
            this.radioButtonATT = new System.Windows.Forms.RadioButton();
            this.radioButtonMetro = new System.Windows.Forms.RadioButton();
            this.radioButtonCricket = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(113, 200);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMessageRecipient
            // 
            this.textBoxMessageRecipient.Location = new System.Drawing.Point(85, 173);
            this.textBoxMessageRecipient.Name = "textBoxMessageRecipient";
            this.textBoxMessageRecipient.Size = new System.Drawing.Size(133, 20);
            this.textBoxMessageRecipient.TabIndex = 1;
            // 
            // textBoxMessageBody
            // 
            this.textBoxMessageBody.Location = new System.Drawing.Point(12, 25);
            this.textBoxMessageBody.Multiline = true;
            this.textBoxMessageBody.Name = "textBoxMessageBody";
            this.textBoxMessageBody.Size = new System.Drawing.Size(268, 136);
            this.textBoxMessageBody.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cell Number:";
            // 
            // radioButtonVerizon
            // 
            this.radioButtonVerizon.AutoSize = true;
            this.radioButtonVerizon.Location = new System.Drawing.Point(12, 19);
            this.radioButtonVerizon.Name = "radioButtonVerizon";
            this.radioButtonVerizon.Size = new System.Drawing.Size(60, 17);
            this.radioButtonVerizon.TabIndex = 3;
            this.radioButtonVerizon.TabStop = true;
            this.radioButtonVerizon.Text = "Verizon";
            this.radioButtonVerizon.UseVisualStyleBackColor = true;
            this.radioButtonVerizon.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSprint
            // 
            this.radioButtonSprint.AutoSize = true;
            this.radioButtonSprint.Location = new System.Drawing.Point(12, 42);
            this.radioButtonSprint.Name = "radioButtonSprint";
            this.radioButtonSprint.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSprint.TabIndex = 3;
            this.radioButtonSprint.TabStop = true;
            this.radioButtonSprint.Text = "Sprint";
            this.radioButtonSprint.UseVisualStyleBackColor = true;
            // 
            // radioButtonATT
            // 
            this.radioButtonATT.AutoSize = true;
            this.radioButtonATT.Location = new System.Drawing.Point(12, 65);
            this.radioButtonATT.Name = "radioButtonATT";
            this.radioButtonATT.Size = new System.Drawing.Size(46, 17);
            this.radioButtonATT.TabIndex = 3;
            this.radioButtonATT.TabStop = true;
            this.radioButtonATT.Text = "ATT";
            this.radioButtonATT.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetro
            // 
            this.radioButtonMetro.AutoSize = true;
            this.radioButtonMetro.Location = new System.Drawing.Point(12, 88);
            this.radioButtonMetro.Name = "radioButtonMetro";
            this.radioButtonMetro.Size = new System.Drawing.Size(76, 17);
            this.radioButtonMetro.TabIndex = 3;
            this.radioButtonMetro.TabStop = true;
            this.radioButtonMetro.Text = "Metro PCS";
            this.radioButtonMetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonCricket
            // 
            this.radioButtonCricket.AutoSize = true;
            this.radioButtonCricket.Location = new System.Drawing.Point(12, 111);
            this.radioButtonCricket.Name = "radioButtonCricket";
            this.radioButtonCricket.Size = new System.Drawing.Size(101, 17);
            this.radioButtonCricket.TabIndex = 3;
            this.radioButtonCricket.TabStop = true;
            this.radioButtonCricket.Text = "Cricket Wireless";
            this.radioButtonCricket.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVerizon);
            this.groupBox1.Controls.Add(this.radioButtonCricket);
            this.groupBox1.Controls.Add(this.radioButtonSprint);
            this.groupBox1.Controls.Add(this.radioButtonMetro);
            this.groupBox1.Controls.Add(this.radioButtonATT);
            this.groupBox1.Location = new System.Drawing.Point(286, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provider";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 232);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessageBody);
            this.Controls.Add(this.textBoxMessageRecipient);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxMessageRecipient;
        private System.Windows.Forms.TextBox textBoxMessageBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonVerizon;
        private System.Windows.Forms.RadioButton radioButtonSprint;
        private System.Windows.Forms.RadioButton radioButtonATT;
        private System.Windows.Forms.RadioButton radioButtonMetro;
        private System.Windows.Forms.RadioButton radioButtonCricket;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

