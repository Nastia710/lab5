using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presents
{
    public partial class Form1 : Form
    {
        string[] peoples = { "Vasia", "Petia", "Masha", "Lera" };
        string shosenPeople = "";
        public Form1()
        {
            InitializeComponent();
            foreach (string people in peoples)
            {
                comboBox1.Items.Add(people.ToString());
            }

            FirstPresent first = new FirstPresent();
            first.DrawPresent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = first.img;

            SecondPresent second = new SecondPresent();
            second.DrawPresent();
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Image = second.img;

            ThirdPresent third = new ThirdPresent();
            third.DrawPresent();
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Image = third.img;

            FourthPresent fourth = new FourthPresent();
            fourth.DrawPresent();
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.Image = fourth.img;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            shosenPeople = comboBox1.SelectedItem.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (shosenPeople != null && shosenPeople != "")
            {
                FirstPresent first = new FirstPresent();
                if (shosenPeople == "Vasia")
                {
                    first.Find_My_Present();
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = first.img;
                    MessageBox.Show("Ви знайшли мій подарунок!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    first.Find_Not_My_Present();
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = first.img;
                    MessageBox.Show("Здається це не мій подарунок", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (shosenPeople != null && shosenPeople != "")
            {
                SecondPresent second = new SecondPresent();
                if (shosenPeople == "Petia")
                {
                    second.Find_My_Present();
                    pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox4.Image = second.img;
                    MessageBox.Show("Так! Тепер я також маю подарунок!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    second.Find_Not_My_Present();
                    pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox4.Image = second.img;
                    MessageBox.Show("Ні! Це точно не мій подарунок!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (shosenPeople != null && shosenPeople != "")
            {
                ThirdPresent third = new ThirdPresent();
                if (shosenPeople == "Masha")
                {
                    third.Find_My_Present();
                    pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox6.Image = third.img;
                    MessageBox.Show("Дякую велике за подарунок", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    third.Find_Not_My_Present();
                    pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox6.Image = third.img;
                    MessageBox.Show("На жаль, цей подарунок не мені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (shosenPeople != null && shosenPeople != "")
            {
                FourthPresent fourth = new FourthPresent();
                if (shosenPeople == "Lera")
                {
                    fourth.Find_My_Present();
                    pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox8.Image = fourth.img;
                    MessageBox.Show("Це мій подарунок? Дякую велике!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    fourth.Find_Not_My_Present();
                    pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox8.Image = fourth.img;
                    MessageBox.Show("Хм.. здається ти помилився. Цей подарунок не мені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
