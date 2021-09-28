namespace messanger
{
    partial class CalendarEdit
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
            this.tb_CalendarText = new System.Windows.Forms.TextBox();
            this.lb_Day = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_CalendarText
            // 
            this.tb_CalendarText.Location = new System.Drawing.Point(12, 52);
            this.tb_CalendarText.Multiline = true;
            this.tb_CalendarText.Name = "tb_CalendarText";
            this.tb_CalendarText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_CalendarText.Size = new System.Drawing.Size(280, 191);
            this.tb_CalendarText.TabIndex = 0;
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.BackColor = System.Drawing.Color.Transparent;
            this.lb_Day.Font = new System.Drawing.Font("휴먼모음T", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Day.ForeColor = System.Drawing.Color.White;
            this.lb_Day.Location = new System.Drawing.Point(25, 15);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(0, 27);
            this.lb_Day.TabIndex = 1;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.Color.Transparent;
            this.lb_Time.Font = new System.Drawing.Font("휴먼모음T", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Time.ForeColor = System.Drawing.Color.White;
            this.lb_Time.Location = new System.Drawing.Point(130, 15);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(0, 27);
            this.lb_Time.TabIndex = 2;
            // 
            // bt_Edit
            // 
            this.bt_Edit.Location = new System.Drawing.Point(12, 255);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(75, 23);
            this.bt_Edit.TabIndex = 3;
            this.bt_Edit.Text = "일정 추가";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(217, 255);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 4;
            this.bt_Cancel.Text = "취소";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(116, 255);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "일정 삭제";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // CalendarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_Day);
            this.Controls.Add(this.tb_CalendarText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarEdit";
            this.Text = "CalendarEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CalendarText;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_delete;
    }
}