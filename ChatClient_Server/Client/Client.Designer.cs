namespace Client
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
            this.listViewCLient = new System.Windows.Forms.ListView();
            this.GuiTin = new System.Windows.Forms.Button();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewCLient
            // 
            this.listViewCLient.HideSelection = false;
            this.listViewCLient.Location = new System.Drawing.Point(5, 12);
            this.listViewCLient.Name = "listViewCLient";
            this.listViewCLient.Size = new System.Drawing.Size(855, 368);
            this.listViewCLient.TabIndex = 0;
            this.listViewCLient.UseCompatibleStateImageBehavior = false;
            this.listViewCLient.View = System.Windows.Forms.View.List;
            // 
            // GuiTin
            // 
            this.GuiTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiTin.Location = new System.Drawing.Point(675, 461);
            this.GuiTin.Name = "GuiTin";
            this.GuiTin.Size = new System.Drawing.Size(131, 45);
            this.GuiTin.TabIndex = 1;
            this.GuiTin.Text = "Gửi";
            this.GuiTin.UseVisualStyleBackColor = true;
            this.GuiTin.Click += new System.EventHandler(this.GuiTin_Click);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(12, 461);
            this.textBoxClient.Multiline = true;
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(622, 45);
            this.textBoxClient.TabIndex = 2;
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameClient.Location = new System.Drawing.Point(5, 396);
            this.textBoxNameClient.Multiline = true;
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(159, 47);
            this.textBoxNameClient.TabIndex = 3;
            // 
            // Client
            // 
            this.AcceptButton = this.GuiTin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 518);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.GuiTin);
            this.Controls.Add(this.listViewCLient);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCLient;
        private System.Windows.Forms.Button GuiTin;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxNameClient;
    }
}

