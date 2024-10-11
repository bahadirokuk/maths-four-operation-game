using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islem
{
    public partial class Form2 : Form
    {
        Level2 islem1 = new Level2();
        Level2 islem2 = new Level2();
        Level2 islem3 = new Level2();
        Level2 islem4 = new Level2();
        Level2 islem5 = new Level2();
        int point = 0;
        int page = 1;
        int timer = 120;
        List<Game> list2 = new List<Game>();
        public Form2()
        {
            InitializeComponent();
        }
        void calculation_all()
        {
            point = numericUpDown1.Value == islem1.calculation() ? point += 1*islem1.hardnes() : point;
            point = numericUpDown2.Value == islem2.calculation() ? point += 1*islem2.hardnes() : point;
            point = numericUpDown3.Value == islem3.calculation() ? point += 1*islem3.hardnes() : point;
            point = numericUpDown4.Value == islem4.calculation() ? point += 1*islem4.hardnes() : point;
            point = numericUpDown5.Value == islem5.calculation() ? point += 1*islem5.hardnes() : point;
        }
        private void basla_Click(object sender, EventArgs e)
        {
            assign();
            timer1.Start();
            basla.Enabled = false;
            cevaplabutton.Visible = true;
        }
        private void cevaplabutton_Click_1(object sender, EventArgs e)
        {
            calculation_all();
            pointlabel.Text = point.ToString();
            timer += 30;
            islem1 = new Level2();
            islem2 = new Level2();
            islem3 = new Level2();
            islem4 = new Level2();
            islem5 = new Level2();
            page++;
            if (page == 4){
                bitirbutton.Visible = true;
                CreateLabelAt(list2);
            }
            pagelabel.Text = page.ToString() + "/4";
            assign();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer--;
            label4.Text = timer.ToString();
            if (timer == 0)
            {
                timer1.Stop(); ;
                MessageBox.Show("Zaman doldu kaybettiniz");
                Close();
            }
        }

        private void bitirbutton_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            calculation_all();
            pointlabel.Text = point.ToString();
            if (point >= 11)
            {
                if (point < 16)
                {
                    File.AppendAllText("mytextfile.txt", "LEVEL 2 SKOR :✯       Player point = " + pointlabel.Text + "\n");
                    MessageBox.Show("✯", "Your point = " + pointlabel.Text, MessageBoxButtons.OK);
                }
                if (point >= 16 && point < 19)
                {
                    File.AppendAllText("mytextfile.txt", "LEVEL 2 SKOR :✯✯      Player point = " + pointlabel.Text + "\n");
                    MessageBox.Show("✯✯", "Your point = " + pointlabel.Text, MessageBoxButtons.OK);
                }
                if (point >= 19)
                {
                    File.AppendAllText("mytextfile.txt", "LEVEL 2 SKOR :✯✯✯     Player point = " + pointlabel.Text + "\n");
                    MessageBox.Show("✯✯✯", "Your point = " + pointlabel.Text, MessageBoxButtons.OK);
                }
                File.WriteAllText("Level" + ".txt", "Son Kalınan Bölüm 3");
                Form3 form3 = new Form3();
                this.Close();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("basarısız oldunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        void assign()
        {
            sayi1label1.Text = islem1.number1 + "   " + islem1.op + "   " + islem1.number2 + "  =";
            sayi1label2.Text = islem2.number1 + "   " + islem2.op + "   " + islem2.number2 + "  =";
            sayi1label3.Text = islem3.number1 + "   " + islem3.op + "   " + islem3.number2 + "  =";
            sayi1label4.Text = islem4.number1 + "   " + islem4.op + "   " + islem4.number2 + "  =";
            sayi1label5.Text = islem5.number1 + "   " + islem5.op + "   " + islem5.number2 + "  =";
            pasbutton1.Visible = true;
            pasbutton2.Visible = true;
            pasbutton3.Visible = true;
            pasbutton4.Visible = true;
            pasbutton5.Visible = true;
        }
        private void CreateLabelAt(List<Game> list)
        {
            int layer = 1;
            foreach (var i in list)
            {
                Label pasLabel = new Label();
                pasLabel.Text = i.number1 + "  " + i.op + "  " + i.number2 + "  =";
                pasLabel.Location = new System.Drawing.Point(450, 70 + (65 * layer));
                pasLabel.AutoSize = true;

                NumericUpDown pasNum = new NumericUpDown();
                pasNum.Location = new System.Drawing.Point(540, 70 + (65 * layer) - 1);
                pasNum.Size = new System.Drawing.Size(81, 27);
                pasNum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
                pasNum.Minimum = new decimal(new int[] { 10000, 0, 0, -2147483648 });

                Button cevapButton = new Button();
                cevapButton.Text = "cevapla";
                cevapButton.Size = new System.Drawing.Size(71, 29);
                cevapButton.Location = new System.Drawing.Point(650, 70 + (65 * layer) - 1);
                cevapButton.Click += (s, args) => cevapButton_Click(cevapButton, args, i, pasNum);

                this.Controls.Add(pasLabel);
                this.Controls.Add(pasNum);
                this.Controls.Add(cevapButton);
                layer++;
            }
        }
        private void cevapButton_Click(Button sender, EventArgs e, Game i, NumericUpDown pasNum)
        {
            point = pasNum.Value == i.calculation() ? point += 1 * i.hardnes() : point;
            pointlabel.Text = point.ToString();
            sender.Enabled = false;
        }
        private void pasbutton1_Click_1(object sender, EventArgs e)
        {
            list2.Add(islem1);
            pasbutton1.Visible = false;
        }
        private void pasbutton2_Click_1(object sender, EventArgs e)
        {
            list2.Add(islem2);
            pasbutton2.Visible = false;
        }
        private void pasbutton3_Click_1(object sender, EventArgs e)
        {
            list2.Add(islem3);
            pasbutton3.Visible = false;
        }
        private void pasbutton4_Click_1(object sender, EventArgs e)
        {
            list2.Add(islem4);
            pasbutton4.Visible = false;
        }
        private void pasbutton5_Click_1(object sender, EventArgs e)
        {
            list2.Add(islem5);
            pasbutton5.Visible = false;
        }

    }
}
