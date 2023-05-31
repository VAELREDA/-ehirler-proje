using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şehirler_broce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//yeni şehir eklemek için
        {
            if (radioButton1.Checked)
            { listBox1.Items.Add(textBox1.Text); }//eklenek şehir "Şehirler " arasında eklemek 
            if (radioButton2.Checked)
            { listBox2.Items.Add(textBox1.Text); }// eklenek şehir "Gidilen Şehirler " arasında eklemek 

        }

        private void button2_Click(object sender, EventArgs e)//Şehirler list boxtan Gidilen Şehirler list bokına taşımak için
        {
            listBox2.Items.Add(listBox1.SelectedItem);//seçillen şehir bulmak için
            listBox1.Items.Remove(listBox1.SelectedItem);//seçilen şehir Şehirler lest boxtan silmek için

        }

        private void button3_Click(object sender, EventArgs e)//Gidilen Şehirler list boxtan Şehirler list bokına taşımak için
        {
            listBox1.Items.Add(listBox2.SelectedItem);//seçillen şehir bulmak için
            listBox2.Items.Remove(listBox2.SelectedItem);//seçilen şehir Gidilen Şehirler lest boxtan silmek için
        }

        private void button4_Click(object sender, EventArgs e)//Aranan Şehir girdiğimde Bul butonu tıkladığında
        {
            listBox1.SelectedIndex = listBox1.FindStringExact(textBox2.Text);//Şehirler lest box içindeyse bulacak
            listBox2.SelectedIndex = listBox2.FindStringExact(textBox2.Text);//Gidilen Şehirler arasında list box içindeyse bulacak
        }
        private void button5_Click(object sender, EventArgs e)//Silenecek Şehir girdiğimde Sil butonu tıkladığında
        {
            listBox1.SelectedIndex = listBox1.FindStringExact(textBox3.Text);//Şehirler lest box içindeyse bulacak
            listBox2.SelectedIndex = listBox2.FindStringExact(textBox3.Text);//Gidilen Şehirler arasında list box içindeyse bulacak
            listBox1.Items.Remove(listBox1.SelectedItem);//seçilen şehir silenecek Şehirler list boxta ise
            listBox2.Items.Remove(listBox2.SelectedItem);//seçilen şehir silenecek Gidilen Şehirler list boxta ise
        }
    }
}
