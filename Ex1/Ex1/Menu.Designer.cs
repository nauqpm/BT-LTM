﻿namespace Ex1
{
    partial class Menu
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
            btnServer = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Font = new Font("Segoe UI Variable Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServer.Location = new Point(31, 40);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(147, 84);
            btnServer.TabIndex = 0;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // btnClient
            // 
            btnClient.Font = new Font("Segoe UI Variable Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClient.Location = new Point(233, 40);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(147, 84);
            btnClient.TabIndex = 1;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 163);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnServer;
        private Button btnClient;
    }
}
