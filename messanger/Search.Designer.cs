namespace messanger
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.pn_SearchResult = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.lb_Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pn_SearchResult
            // 
            this.pn_SearchResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_SearchResult.Location = new System.Drawing.Point(0, 42);
            this.pn_SearchResult.Name = "pn_SearchResult";
            this.pn_SearchResult.Size = new System.Drawing.Size(400, 500);
            this.pn_SearchResult.TabIndex = 0;
            // 
            // tb_Search
            // 
            this.tb_Search.ForeColor = System.Drawing.Color.Gray;
            this.tb_Search.Location = new System.Drawing.Point(12, 567);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(239, 21);
            this.tb_Search.TabIndex = 3;
            this.tb_Search.Text = "프로젝트 또는 팀장의 이름을 입력하세요.";
            this.tb_Search.Enter += new System.EventHandler(this.tb_Search_Enter);
            this.tb_Search.Leave += new System.EventHandler(this.tb_Search_Leave);
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(257, 565);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 23);
            this.bt_Search.TabIndex = 1;
            this.bt_Search.Text = "찾기";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(338, 565);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(50, 23);
            this.bt_Close.TabIndex = 2;
            this.bt_Close.Text = "닫기";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Search.Location = new System.Drawing.Point(125, 9);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(143, 21);
            this.lb_Search.TabIndex = 4;
            this.lb_Search.Text = "프로젝트 찾기";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.pn_SearchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_SearchResult;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Label lb_Search;
    }
}