﻿namespace ThreadShowOnController
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBxNow = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBxNow
            // 
            this.TxtBxNow.Location = new System.Drawing.Point(13, 13);
            this.TxtBxNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBxNow.Name = "TxtBxNow";
            this.TxtBxNow.ReadOnly = true;
            this.TxtBxNow.Size = new System.Drawing.Size(148, 27);
            this.TxtBxNow.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(13, 56);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(148, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 299);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtBxNow);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxNow;
        private System.Windows.Forms.Button BtnStart;
    }
}

