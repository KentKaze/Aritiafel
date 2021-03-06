﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritiafel.Characters;
using Aritiafel.Organizations;
using Aritiafel.Items;
using System.IO;
using System.Diagnostics;

namespace AritiafelTestForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        public void btnMessageBox_Click(object sender, EventArgs e)
        {
            DialogResult dr = RabbitCouriers.SentNoramlQuestion("點選OK或Cancel", "Test", Aritiafel.Items.ChoiceOptions.OKCancel, 2);

            if (dr == DialogResult.Cancel)
                Console.WriteLine(1);
            else
                Console.WriteLine(2);
        }

        public void btnMessageBox2_Click(object sender, EventArgs e)
        {
            Var.VarA = Var.VarA += "T";

            RabbitCouriers.SentInformation(Var.VarA);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RabbitCouriers.RegisterRMAndCI(Resources.Res.ResourceManager, new System.Globalization.CultureInfo("zh-TW"));
        }

        public void btnOpenFile_Click(object sender, EventArgs e)
        {   
            openFileDialog1.ShowDialogOrSetResult(this);
        }

        public void btnInputForm_Click(object sender, EventArgs e)
        {
            string result = frmInputBox.MyShow(this);
            RabbitCouriers.SentInformation(result);            
        }

        public void btnShowMessageByResource_Click(object sender, EventArgs e)
        {
            DialogResult dr = RabbitCouriers.SentNoramlQuestionByResource("QuestionString", "Q1", ChoiceOptions.YesNo, "Male", "Female");
            DialogResult dr2 = RabbitCouriers.SentNoramlQuestionByResource("QuestionString2", "Q2", ChoiceOptions.YesNo, "15", "16");

            if (dr == DialogResult.No && dr2 == DialogResult.Yes)
                RabbitCouriers.SentInformationByResource("AnswerString", "Answer");
        }

        private void btnTranslateZHCN_Click(object sender, EventArgs e)
        {
            string result;

            //byte[] bytes = Encoding.Default.GetBytes(txtText.Text);
            //result = Encoding.UTF8.GetString(bytes);

            result = WizardGuild.TranslateTextFromTraditionalChineseToSimplifiedChinese(txtText.Text);
                       //UnicodeEncoding.GetEncoding("UTF-8").GetEncoder();


            txtOutput.Text = result;
        }

        private void btnSaveUTF8_Click(object sender, EventArgs e)
        {
            string outputFile = Path.Combine(Application.StartupPath, "UTF-8.txt");

            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(txtOutput.Text);
                }
            }

            Process.Start(outputFile);
        }

        private void btnScript1_Click(object sender, EventArgs e)
        {
            //"C:\Programs\Standard\Aritiafel\Aritiafel"
            string file = @"C:\Programs\Standard\Aritiafel\Aritiafel\CFamilyNames.txt";
            string buffer;
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    buffer = sr.ReadToEnd();
                }
            }
            
            string outfile = @"C:\Programs\Standard\Aritiafel\Aritiafel\Data\SurnameOfChinese.csv";

            using (FileStream fs = new FileStream(outfile, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    int pos = 0;
                    while (pos < buffer.Length)
                    {
                        pos = buffer.IndexOf("php", pos + 1);
                        if (pos == -1)
                            break;
                        //MessageBox.Show(buffer.Substring(pos + 9, 1));
                        sw.WriteLine(buffer.Substring(pos + 5, 1));
                    }
                }
            }
            //" / word/"
        }
    }
}
