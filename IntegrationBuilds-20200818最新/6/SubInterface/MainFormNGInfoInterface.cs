﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _6
{
    
    public partial class MainFormNGInfoInterface : UserControl
    {
        MainForm mainForm;
        public MainFormNGInfoInterface(MainForm temp)
        {
            InitializeComponent();
            mainForm = temp;
        }

        private void informationANgtable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                //MessageBox.Show("col:" + e.ColumnIndex + "row:" + e.RowIndex);
                if (e.RowIndex < 0)
                    return;
                if (informationANgtable.Rows[e.RowIndex].Cells[informationANgtable.ColumnCount - 1].Value == null)

                    return;

                if (informationANgtable.Rows[e.RowIndex].Cells[informationANgtable.ColumnCount - 1].Value.ToString().Equals("A"))
                {

                    if (e.ColumnIndex == 0 || e.ColumnIndex == informationANgtable.ColumnCount - 1)
                        return;
                    if (e.ColumnIndex % 2 != 0)  // 正面
                    {
                        string positiveNGId = informationANgtable.Rows[e.RowIndex].Cells[1].Value.ToString();
                        //SingleClassNG singleClassNGPositiveA = mainForm.singleClassNGPositiveAList[0];
                        foreach (SingleClassNG singleClassNGPositiveA in mainForm.singleClassNGPositiveAList)
                        {
                            if (singleClassNGPositiveA.Id.ToString().Equals(positiveNGId))
                            {
                                string[] picPathNGPositiveA = singleClassNGPositiveA.PicPath;
                                if (picPathNGPositiveA[(e.ColumnIndex - 1) / 2 - 1] != null)
                                {
                                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    process.StartInfo.FileName = picPathNGPositiveA[(e.ColumnIndex - 1) / 2 - 1];
                                    process.Start();
                                    process.Dispose();
                                    ////建立新的系统进程    
                                    //System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    ////设置文件名，此处为图片的真实路径+文件名    
                                    //process.StartInfo.FileName = picPathNGPositiveA[(e.ColumnIndex - 1) / 2 - 1];
                                    ////此为关键部分。设置进程运行参数，此时为最大化窗口显示图片。    
                                    //process.StartInfo.Arguments = "rundll32.exe C://WINDOWS//system32//shimgvw.dll,ImageView_Fullscreen";
                                    ////此项为是否使用Shell执行程序，因系统默认为true，此项也可不设，但若设置必须为true    
                                    //process.StartInfo.UseShellExecute = true;
                                    ////此处可以更改进程所打开窗体的显示样式，可以不设    
                                    //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                                    //process.Start();
                                    //process.Dispose();
                                }
                            }
                        }
                    }
                    else   //背面
                    {
                        string negativeNGId = informationANgtable.Rows[e.RowIndex].Cells[2].Value.ToString();
                        foreach (SingleClassNG singleClassNGNegativeA in mainForm.singleClassNGNegativeAList)
                        {
                            if (singleClassNGNegativeA.Id.ToString().Equals(negativeNGId))
                            {
                                string[] picPathNGNegativeA = singleClassNGNegativeA.PicPath;
                                if (picPathNGNegativeA[(e.ColumnIndex - 2) / 2 - 1] != null)
                                {
                                    //System.Diagnostics.Process.Start(picPathNGNegativeA[(e.ColumnIndex - 2) / 2 - 1]);

                                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    process.StartInfo.FileName = picPathNGNegativeA[(e.ColumnIndex - 2) / 2 - 1];
                                    process.Start();
                                    process.Dispose();
                                }
                            }
                        }
                    }
                }
                else
                {

                    if (e.ColumnIndex % 2 != 0)  // 正面
                    {
                        string positiveNGId = informationANgtable.Rows[e.RowIndex].Cells[1].Value.ToString();
                        foreach (SingleClassNG singleClassNGPositiveB in mainForm.singleClassNGPositiveBList)
                        {
                            if (singleClassNGPositiveB.Id.ToString().Equals(positiveNGId))
                            {
                                string[] picPathNGPositiveB = singleClassNGPositiveB.PicPath;
                                if (picPathNGPositiveB[(e.ColumnIndex - 1) / 2 - 1] != null)
                                {
                                    //System.Diagnostics.Process.Start(picPathNGPositiveB[(e.ColumnIndex - 1) / 2 - 1]);


                                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    process.StartInfo.FileName = picPathNGPositiveB[(e.ColumnIndex - 1) / 2 - 1];
                                    process.Start();
                                    process.Dispose();
                                    ////建立新的系统进程    
                                    //System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    ////设置文件名，此处为图片的真实路径+文件名    
                                    //process.StartInfo.FileName = picPathNGPositiveA[(e.ColumnIndex - 1) / 2 - 1];
                                    ////此为关键部分。设置进程运行参数，此时为最大化窗口显示图片。    
                                    //process.StartInfo.Arguments = "rundll32.exe C://WINDOWS//system32//shimgvw.dll,ImageView_Fullscreen";
                                    ////此项为是否使用Shell执行程序，因系统默认为true，此项也可不设，但若设置必须为true    
                                    //process.StartInfo.UseShellExecute = true;
                                    ////此处可以更改进程所打开窗体的显示样式，可以不设    
                                    //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                                    //process.Start();
                                    //process.Dispose();
                                }
                            }
                        }
                    }
                    else   //背面
                    {
                        string negativeNGId = informationANgtable.Rows[e.RowIndex].Cells[2].Value.ToString();
                        foreach (SingleClassNG singleClassNGNegativeB in mainForm.singleClassNGNegativeBList)
                        {
                            if (singleClassNGNegativeB.Id.ToString().Equals(negativeNGId))
                            {
                                string[] picPathNGNegativeB = singleClassNGNegativeB.PicPath;
                                if (picPathNGNegativeB[(e.ColumnIndex - 2) / 2 - 1] != null)
                                {
                                    //System.Diagnostics.Process.Start(picPathNGNegativeB[(e.ColumnIndex - 2) / 2 - 1]);

                                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    process.StartInfo.FileName = picPathNGNegativeB[(e.ColumnIndex - 2) / 2 - 1];
                                    process.Start();
                                    process.Dispose();
                                }
                            }
                        }
                    }
                }


            }
            catch
            {

            }

        }

        private void btnClearNGStatics_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要清空NG串信息吗?", "确认", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                informationANgtable.Rows.Clear();
                mainForm.singleClassNGPositiveAList.Clear();
                mainForm.singleClassNGPositiveBList.Clear();
                mainForm.singleClassNGNegativeAList.Clear();
                mainForm.singleClassNGNegativeBList.Clear();
            }
            
        }

        private void MainFormNGInfoInterface_Load(object sender, EventArgs e)
        {
            
            if (Global.isEnglish=="0")
            {
                informationANgtable.Columns[0].HeaderText = "时间";
                for (int i = 0; i < 24; i++)
                {
                    informationANgtable.Columns[3 + 2 * i].HeaderText = "正面";
                    informationANgtable.Columns[4 + 2 * i].HeaderText = "背面";
                }
              
            }
            else
            {
                informationANgtable.Columns[0].HeaderText = "Time";
                for (int i = 0; i < 24; i++)
                {
                    informationANgtable.Columns[3 + 2 * i].HeaderText = "P";
                    informationANgtable.Columns[4 + 2 * i].HeaderText = "N";
                }

            }
        }
    }
}
