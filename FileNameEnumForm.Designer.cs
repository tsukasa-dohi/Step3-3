namespace Step3_3
{
    partial class Step3_3
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchFolderPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderPathTxtBx = new System.Windows.Forms.TextBox();
            this.OutputFilePathTxtBx = new System.Windows.Forms.TextBox();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.OutputFileBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchFolderPath
            // 
            this.SearchFolderPath.AutoSize = true;
            this.SearchFolderPath.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchFolderPath.Location = new System.Drawing.Point(29, 106);
            this.SearchFolderPath.Name = "SearchFolderPath";
            this.SearchFolderPath.Size = new System.Drawing.Size(66, 15);
            this.SearchFolderPath.TabIndex = 0;
            this.SearchFolderPath.Text = "検索フォルダ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "出力ファイル";
            // 
            // FolderPathTxtBx
            // 
            this.FolderPathTxtBx.Location = new System.Drawing.Point(98, 103);
            this.FolderPathTxtBx.Name = "FolderPathTxtBx";
            this.FolderPathTxtBx.Size = new System.Drawing.Size(315, 19);
            this.FolderPathTxtBx.TabIndex = 2;
            // 
            // OutputFilePathTxtBx
            // 
            this.OutputFilePathTxtBx.Location = new System.Drawing.Point(98, 152);
            this.OutputFilePathTxtBx.Name = "OutputFilePathTxtBx";
            this.OutputFilePathTxtBx.Size = new System.Drawing.Size(315, 19);
            this.OutputFilePathTxtBx.TabIndex = 3;
            // 
            // FolderBtn
            // 
            this.FolderBtn.Location = new System.Drawing.Point(417, 103);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(19, 19);
            this.FolderBtn.TabIndex = 4;
            this.FolderBtn.Text = "...";
            this.FolderBtn.UseVisualStyleBackColor = true;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // OutputFileBtn
            // 
            this.OutputFileBtn.Location = new System.Drawing.Point(417, 152);
            this.OutputFileBtn.Name = "OutputFileBtn";
            this.OutputFileBtn.Size = new System.Drawing.Size(19, 19);
            this.OutputFileBtn.TabIndex = 5;
            this.OutputFileBtn.Text = "...";
            this.OutputFileBtn.UseVisualStyleBackColor = true;
            this.OutputFileBtn.Click += new System.EventHandler(this.OutputFileBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartBtn.Location = new System.Drawing.Point(360, 200);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 49);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "実行(&E)";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.Location = new System.Drawing.Point(27, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(214, 25);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "フォルダ内ファイル名列挙";
            // 
            // Step3_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.OutputFileBtn);
            this.Controls.Add(this.FolderBtn);
            this.Controls.Add(this.OutputFilePathTxtBx);
            this.Controls.Add(this.FolderPathTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchFolderPath);
            this.Name = "Step3_3";
            this.Text = "FlieNameEnumeation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FolderPathTxtBx;
        private System.Windows.Forms.TextBox OutputFilePathTxtBx;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Button OutputFileBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label TitleLabel;
    }
}

