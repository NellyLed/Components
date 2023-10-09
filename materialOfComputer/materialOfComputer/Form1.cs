using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary145;
namespace materialOfComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Processor one = new Processor("INTEL Core i9 10986XE");
            one.Stamp = textBox1.Text;
            Processor two = new Processor(3.00);
            two.Frequency = Convert.ToDouble(textBox2.Text);
            Processor three = new Processor(24.75);
            three.Kesh = Convert.ToDecimal(textBox3.Text);
            Processor four = new Processor(93990);
            four.Cost = Convert.ToInt32(textBox4.Text);

            richTextBox1.Text += one.StampCheck();
            richTextBox1.Text += two.FrequencyCheck();
            richTextBox1.Text += three.KeshCheck();
            richTextBox1.Text += four.CostCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MotherBoard f1 = new MotherBoard("INTEL Core i9 10980XE", 256.568, 18, 36, "LGA 2066", 64);
            f1.Socket = textBox8.Text;
            f1.Core = Convert.ToInt32(textBox6.Text);
            f1.Threads = Convert.ToInt32(textBox7.Text);
            f1.Rate = Convert.ToInt32(textBox9.Text);
            f1.Ram = Convert.ToDouble(textBox5.Text);
            List<string> Specifications = new List<string>();
            listBox1.Items.Add(f1.Quantity(Specifications));
            listBox1.Items.Add(f1.Volume(Specifications));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Computer g1 = new Computer(93990, 1000, 2100, 700, 400, 330, 1500, 680, 5000, 3320, 900, 20000); 
            g1.Harddrive = Convert.ToInt32(textBox10.Text);
            g1.Videocard = Convert.ToInt32(textBox13.Text);
            g1.Motherboard = Convert.ToInt32(textBox18.Text);
            g1.Networkadapter = Convert.ToInt32(textBox12.Text);
            g1.Powersupply = Convert.ToInt32(textBox14.Text);
            g1.Floppydrive = Convert.ToInt32(textBox15.Text);
            g1.Systemunit = Convert.ToInt32(textBox16.Text);
            g1.Monitor = Convert.ToInt32(textBox17.Text);
            g1.Soundadapter = Convert.ToInt32(textBox11.Text);
            g1.Ram1 = Convert.ToInt32(textBox19.Text);
            g1.Work = Convert.ToInt32(textBox20.Text);
            richTextBox1.Text += String.Format(" Стоимость сборки компьютера без учета стоимости его компонентов равна {0}\n", g1.CostworkCheck());
            List<int> Components = new List<int>();
            listBox2.Items.Add(g1.CostComponents1(Components));
            richTextBox1.Text += String.Format("Стоимость компонентов компьютера равна {0}\n", g1.CostComponents2(Components));
            richTextBox1.Text += String.Format("Стоимость полной суммы сборки компьютера равна {0}\n", g1.CostEverythingCheck());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MotherBoard d = new MotherBoard(textBox1.Text, Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox6.Text),
Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));
            Processor d2 = d;
            d.Stamp = "AMD Athlon 200GE Raven Ridge";
            richTextBox1.Text += String.Format("Восходящее преобразование от класса MotherBoard к классу Processor:Тип процессора {0}\n", d.Stamp);

            Computer r1 = new Computer(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox18.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox13.Text),
           Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox15.Text),
           Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox19.Text), Convert.ToInt32(textBox20.Text));
            Processor r2 = r1;
            r1.Cost = 3090;
            richTextBox1.Text += String.Format("Восходящее преобразование от класса Computer к классу Processor: Стоимость процессора {0}\n", r1.Cost);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object u = new MotherBoard(textBox1.Text, Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));
            Processor u1 = (Processor)u;
            u1.Stamp = "Intel Celeron G3900 Skylake";
            richTextBox1.Text += String.Format("Нисходящее преобразование от класса Processor к классу MotherBoard:Тип процессора {0}\n", u1.Stamp);
            Processor u2 = new Computer(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox18.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox11.Text),
         Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox19.Text), Convert.ToInt32(textBox20.Text));
            Computer u3 = (Computer)u2;
            u3.Cost = 4381;
            richTextBox1.Text += String.Format("Нисходящее преобразование от класса Processor к классу Computer:Стоимость процессора {0}\n", u3.Stamp);
        }
    }
}
