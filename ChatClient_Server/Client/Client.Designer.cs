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
            this.listViewCLient1 = new System.Windows.Forms.ListView();
            this.Cot1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuiTin = new System.Windows.Forms.Button();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_DatTen = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCLient1
            // 
            this.listViewCLient1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewCLient1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cot1,
            this.Cot2});
            this.listViewCLient1.HideSelection = false;
            this.listViewCLient1.Location = new System.Drawing.Point(5, 12);
            this.listViewCLient1.Name = "listViewCLient1";
            this.listViewCLient1.Size = new System.Drawing.Size(855, 378);
            this.listViewCLient1.TabIndex = 0;
            this.listViewCLient1.UseCompatibleStateImageBehavior = false;
            this.listViewCLient1.View = System.Windows.Forms.View.Details;
            // 
            // Cot1
            // 
            this.Cot1.Text = "";
            this.Cot1.Width = 320;
            // 
            // Cot2
            // 
            this.Cot2.Text = "";
            this.Cot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cot2.Width = 320;
            // 
            // GuiTin
            // 
            this.GuiTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiTin.Location = new System.Drawing.Point(729, 461);
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
            this.textBoxClient.Size = new System.Drawing.Size(490, 45);
            this.textBoxClient.TabIndex = 2;
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameClient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNameClient.Location = new System.Drawing.Point(507, 418);
            this.textBoxNameClient.Multiline = true;
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(144, 30);
            this.textBoxNameClient.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 399);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 59);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // bnt_DatTen
            // 
            this.bnt_DatTen.Location = new System.Drawing.Point(564, 454);
            this.bnt_DatTen.Name = "bnt_DatTen";
            this.bnt_DatTen.Size = new System.Drawing.Size(87, 33);
            this.bnt_DatTen.TabIndex = 8;
            this.bnt_DatTen.Text = "Name";
            this.bnt_DatTen.UseVisualStyleBackColor = true;
            this.bnt_DatTen.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(668, 399);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(46, 18);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "label2";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Client
            // 
            this.AcceptButton = this.GuiTin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 518);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.bnt_DatTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewCLient1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.GuiTin);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCLient1;
        private System.Windows.Forms.Button GuiTin;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader Cot1;
        private System.Windows.Forms.ColumnHeader Cot2;
        private System.Windows.Forms.Button bnt_DatTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTime;
    }
}

