﻿namespace Ex1
{
    partial class Server
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
            btnListen = new Button();
            txtIPAddress = new TextBox();
            label1 = new Label();
            lstChatBox = new ListBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(680, 34);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(116, 34);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(535, 27);
            txtIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "IP Address";
            // 
            // lstChatBox
            // 
            lstChatBox.FormattingEnabled = true;
            lstChatBox.Location = new Point(28, 81);
            lstChatBox.Name = "lstChatBox";
            lstChatBox.Size = new Size(746, 344);
            lstChatBox.TabIndex = 3;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstChatBox);
            Controls.Add(label1);
            Controls.Add(txtIPAddress);
            Controls.Add(btnListen);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private TextBox txtIPAddress;
        private Label label1;
        private ListBox lstChatBox;
    }
}