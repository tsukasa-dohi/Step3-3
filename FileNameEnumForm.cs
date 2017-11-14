using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step3_3
{
    public partial class Step3_3 : Form
    {
        // DLLを読み込む
        [DllImport("Step3-3Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static int DirectryAnalysis(string searchPath, string outputPath);

        public Step3_3()
        {
            InitializeComponent();
        }

        // 検索フォルダ参照ボタン押下
        private void FolderBtn_Click(object sender, EventArgs e)
        {
            //検索フォルダ選択ダイアログインスタンス生成
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderPathTxtBx.Text = fbd.SelectedPath;
            }
        }

        // 出力ファイル参照ボタン押下
        private void OutputFileBtn_Click(object sender, EventArgs e)
        {
            //出力ファイル選択ダイアログインスタンス生成
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OutputFilePathTxtBx.Text = sfd.FileName;
            }
        }

        // 実行ボタン押下
        private void StartBtn_Click(object sender, EventArgs e)
        {
            // 検索フォルダパスの取得
            string folderPath = FolderPathTxtBx.Text;

            // 出力ファイルパスの取得
            string outputPath = OutputFilePathTxtBx.Text;

            var list = DirectryAnalysis(folderPath, outputPath);

            MessageBox.Show("完了");
        }
    }
}
