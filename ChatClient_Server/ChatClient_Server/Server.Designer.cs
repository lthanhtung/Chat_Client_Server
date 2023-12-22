namespace ChatClient_Server
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
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.GuiTin = new System.Windows.Forms.Button();
            this.listViewServer = new System.Windows.Forms.ListView();
            this.textBoxNameServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(12, 444);
            this.textBoxServer.Multiline = true;
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(624, 45);
            this.textBoxServer.TabIndex = 5;
            // 
            // GuiTin
            // 
            this.GuiTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiTin.Location = new System.Drawing.Point(665, 444);
            this.GuiTin.Name = "GuiTin";
            this.GuiTin.Size = new System.Drawing.Size(131, 45);
            this.GuiTin.TabIndex = 4;
            this.GuiTin.Text = "Gửi";
            this.GuiTin.UseVisualStyleBackColor = true;
            this.GuiTin.Click += new System.EventHandler(this.GuiTin_Click);
            // 
            // listViewServer
            // 
            this.listViewServer.HideSelection = false;
            this.listViewServer.Location = new System.Drawing.Point(12, 12);
            this.listViewServer.Name = "listViewServer";
            this.listViewServer.Size = new System.Drawing.Size(856, 376);
            this.listViewServer.TabIndex = 3;
            this.listViewServer.UseCompatibleStateImageBehavior = false;
            this.listViewServer.View = System.Windows.Forms.View.List;
            // 
            // textBoxNameServer
            // 
            this.textBoxNameServer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameServer.Location = new System.Drawing.Point(12, 394);
            this.textBoxNameServer.Multiline = true;
            this.textBoxNameServer.Name = "textBoxNameServer";
            this.textBoxNameServer.Size = new System.Drawing.Size(118, 44);
            this.textBoxNameServer.TabIndex = 6;
            // 
            // Server
            // 
            this.AcceptButton = this.GuiTin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 504);
            this.Controls.Add(this.textBoxNameServer);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.GuiTin);
            this.Controls.Add(this.listViewServer);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button GuiTin;
        private System.Windows.Forms.ListView listViewServer;
        private System.Windows.Forms.TextBox textBoxNameServer;
    }
}

