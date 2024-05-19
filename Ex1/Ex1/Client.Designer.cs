namespace Ex1
{
    partial class Client
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
            lstChatBox = new ListBox();
            groupBox1 = new GroupBox();
            lstParticipants = new ListBox();
            User = new GroupBox();
            btnConnect = new Button();
            txtUserName = new TextBox();
            groupBox3 = new GroupBox();
            btnSend = new Button();
            txtMessage = new TextBox();
            groupBox1.SuspendLayout();
            User.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lstChatBox
            // 
            lstChatBox.FormattingEnabled = true;
            lstChatBox.Location = new Point(12, 12);
            lstChatBox.Name = "lstChatBox";
            lstChatBox.Size = new Size(596, 364);
            lstChatBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstParticipants);
            groupBox1.Location = new Point(614, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 624);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Participants";
            // 
            // lstParticipants
            // 
            lstParticipants.FormattingEnabled = true;
            lstParticipants.Location = new Point(6, 26);
            lstParticipants.Name = "lstParticipants";
            lstParticipants.Size = new Size(192, 584);
            lstParticipants.TabIndex = 0;
            // 
            // User
            // 
            User.Controls.Add(btnConnect);
            User.Controls.Add(txtUserName);
            User.Location = new Point(12, 384);
            User.Name = "User";
            User.Size = new Size(596, 82);
            User.TabIndex = 2;
            User.TabStop = false;
            User.Text = "User";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(496, 36);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(6, 36);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(475, 27);
            txtUserName.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSend);
            groupBox3.Controls.Add(txtMessage);
            groupBox3.Location = new Point(12, 472);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 164);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Messages";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(496, 68);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(6, 26);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(475, 124);
            txtMessage.TabIndex = 0;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 648);
            Controls.Add(groupBox3);
            Controls.Add(User);
            Controls.Add(groupBox1);
            Controls.Add(lstChatBox);
            Name = "Client";
            Text = "Client";
            FormClosed += Client_FormClosed;
            groupBox1.ResumeLayout(false);
            User.ResumeLayout(false);
            User.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstChatBox;
        private GroupBox groupBox1;
        private ListBox lstParticipants;
        private GroupBox User;
        private GroupBox groupBox3;
        private Button btnConnect;
        private TextBox txtUserName;
        private Button btnSend;
        private TextBox txtMessage;
    }
}