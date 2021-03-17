using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(numberTextBox.Text == "" || capTextBox.Text == "") {
            return;
          }
          ConsoleApp1.Item[] items = new Item[int.Parse(numberTextBox.Text)];
          bool[] knapsack = ConsoleApp1.Knapsack.Generate(int.Parse(numberTextBox.Text), int.Parse(capTextBox.Text), ref items);
          StringBuilder sb = new StringBuilder();
          for(int i = 0; i < int.Parse(numberTextBox.Text); ++i) {
            sb.Append(items[i].weight.ToString());
            sb.Append(' ');
          }
          weightsTextBox.Text = sb.ToString();
          sb.Clear();
          for(int i = 0; i < int.Parse(numberTextBox.Text); ++i) {
            sb.Append(items[i].value.ToString());
            sb.Append(' ');
          }
          valuesTextBox.Text = sb.ToString();
          sb.Clear();
          for(int i = 0; i < int.Parse(numberTextBox.Text); ++i) {
            sb.Append(knapsack[i] == true ? '1' : '0');
            sb.Append(' ');
          }
          itemsTextBox.Text = sb.ToString();
        }
  }
}
