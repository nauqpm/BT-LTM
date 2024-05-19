namespace Ex2
{
    partial class Main
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
            btnSendMail = new Button();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            rtbBody = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSendMail
            // 
            btnSendMail.Location = new Point(12, 12);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(125, 69);
            btnSendMail.TabIndex = 0;
            btnSendMail.Text = "Send Mail";
            btnSendMail.UseVisualStyleBackColor = true;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(256, 12);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(532, 27);
            txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(256, 54);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(532, 27);
            txtTo.TabIndex = 2;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(124, 100);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(664, 27);
            txtSubject.TabIndex = 3;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(124, 145);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(664, 293);
            rtbBody.TabIndex = 4;
            rtbBody.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 5;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 57);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 6;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 103);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 145);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 8;
            label4.Text = "Body:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbBody);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(btnSendMail);
            Name = "Main";
            Text = "Ex2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendMail;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubject;
        private RichTextBox rtbBody;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}