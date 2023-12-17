using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ModUpdater
{
    partial class ModUpdaterForm : Form
    {
        /// <summary>
        ///  Zipファイルの解凍
        /// </summary>
        /// <param name="filename">相対(または絶対)ファイル名</param>
        private void extractZip(String inZipFile)
        {

            String inFile = inZipFile;

            // 入力ファイルは.gzファイルのみ有効
            if (!inFile.ToLower().EndsWith(".zip"))
            {
                return;
            }


            // 解凍したファイルを置くディレクトリのパス
            string extractPath = strTmpDir;

            // ZIPファイルを解凍する
            UnzipFile(inZipFile, extractPath);

            Console.WriteLine("ZIPファイルの解凍が完了しました。");
        }

        // ZIPファイルを解凍するメソッド
        private static void UnzipFile(string inZipFile, string extractPath)
        {
            try
            {
                // ZIPファイルを解凍する
                ZipFile.ExtractToDirectory(inZipFile, extractPath);
            } catch(Exception)
            {

            }
        }
    }
}