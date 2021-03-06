﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZopperPerm
{
    public partial class PermMainWindow : Form
    {
        //Total number of permutations
        private ulong totalCount;

        //Maximum displayable lines
        //Currently 100 000
        private const int maxDisplayed = 100000;

        //Permutations calculator
        private CalculatePermutations c;
        public PermMainWindow()
        {
            InitializeComponent();
            permutationButton.Checked = true;
            totalCount = 0;
            c = CalculatePermutations.Instance;
        }

        private void PermMainWindow_Load(object sender, EventArgs e)
        {

        }

        //Generates permutations/combinations
        private void generateAction(object sender, EventArgs e)
        {
            //Return if wrong action
            if (sender != generateButton)
            {
                return;
            }

            //Return if invalid input
            if (stringToPermute.Text.Length == 0 || kValue.Value == 0)
            {
                mainOutput.Clear();
                return;
            }

            //Clear display
            mainOutput.Clear();

            //Otherwise create object to get permutations
            c.setString(stringToPermute.Text);
            string filename = "";
            if (fileOutput.Checked)
            {
                filename = fileName.Text;
            }
            c.setStreamWriter(filename);
            if (permutationButton.Checked)
            {
                c.perm((int)kValue.Value);
            }
            else
            {
                c.comb((int)kValue.Value);
            }
            if (!fileOutput.Checked)
            {
                mainOutput.Lines = c.getOutput().ToArray();
            }
        }

        //Change k bounds
        private void changeK(object sender, EventArgs e)
        {
            if (sender != stringToPermute)
            {
                return;
            }

            kValue.Maximum = stringToPermute.Text.Length;
            kValue.Minimum = 0;
            kValue.Value = stringToPermute.Text.Length;
            updateTotal();
        }

        //Update displayed total
        private void updateTotal()
        {
            //Find Total number of output lines
            c.setString(stringToPermute.Text);
            if (permutationButton.Checked)
            {
                totalCount = c.numPerm((int)kValue.Value);
            }
            else
            {
                totalCount = c.numComb((int)kValue.Value);
            }
            total.Text = "Total: " + totalCount.ToString();

            //Mandatory file output if not displayable
            if (totalCount > maxDisplayed)
            {
                fileOutput.Checked = true;
                fileOutput.Enabled = false;
            }
            //Otherwise uncheck it
            else
            {
                fileOutput.Enabled = true;
                fileOutput.Checked = false;
            }
        }

        //Enable file output
        private void fileOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == fileOutput)
            {
                fileName.Visible = fileOutput.Checked;
            }

            if (fileOutput.Checked)
            {
                c.setStreamWriter(fileName.Text);
            }
            else
            {
                c.setStreamWriter("");
            }
        }

        //Update total
        private void changeKValue(object sender, EventArgs e)
        {
            updateTotal();
        }

        //Update total
        private void updateRadioButtons(object sender, EventArgs e)
        {
            updateTotal();
        }

        //Change file name
        private void fileName_TextChanged(object sender, EventArgs e)
        {
            if (fileOutput.Checked)
            {
                c.setStreamWriter(fileName.Text);
            }
            else
            {
                c.setStreamWriter("");
            }
        }

        //Close program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open dialog
            OpenFileDialog fileDialog = new OpenFileDialog();

            //Set filters
            fileDialog.Filter = "All Files (*.*)|*.*";
            
            //Disable multiselect
            fileDialog.Multiselect = false;

            //Show dialog
            fileDialog.ShowDialog();

            //String List
            List<string> l = new List<string>();

            //Get file
            if (fileDialog.FileName != "")
            {
                Stream file = fileDialog.OpenFile();

                StreamReader reader = new StreamReader(file);

                //Read all lines
                while (!reader.EndOfStream)
                {
                    l.Add(reader.ReadLine());
                }

                //Close file
                reader.Dispose();
                file.Close();
                file.Dispose();

                //Set output
                mainOutput.Lines = l.ToArray();
            }
        }

        //Save file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New savefileDialog
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "output.txt";
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //Write file
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);

                List<string> l = mainOutput.Lines.ToList();
                foreach(string str in l) {
                    writer.WriteLine(str);
                }

                writer.Close();
                writer.Dispose();
            }
            saveFile.Dispose();
        }
    }
}
