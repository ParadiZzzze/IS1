using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //game
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label6.Text = " ";
            mprice.Text = " ";

            double pr = Convert.ToDouble(price.Text);
            double v=0,p=0,o=0,d=0,pl=0,pi=0,ssd=0;
            string pathToFile = "видеокарты.txt";
            List<string> name = new List<string>();
            List<string> cena = new List<string>();
            List<string> socket = new List<string>();
            List<string> memory = new List<string>();
            string socket_now = "6";
            string memory_now = "4";

            string[] fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string []sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for(int i = name.Count()-1; i >=0 ; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.328)
                {
                    label7.Text = cena[i] + "  " + name[i];
                    v = Convert.ToDouble(cena[i]);
                    break;
                }
            }


            pathToFile = "проц.txt";
            name = new List<string>();
            cena = new List<string>();
            
            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.192)
                {
                    label9.Text = cena[i] + "  " + name[i];
                    p = Convert.ToDouble(cena[i]);
                    socket_now = socket[i];
                    break;
                }
            }


            pathToFile = "озу.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                memory.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.158)
                {
                    label11.Text = cena[i] + "  " + name[i];
                    o = Convert.ToDouble(cena[i]);
                    memory_now = memory[i];
                    break;
                }
            }

            pathToFile = "диск.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
               
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }

            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.066)
                {
                    label10.Text = cena[i] + "  " + name[i];
                    d = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "платы.txt";
            name = new List<string>();
            cena = new List<string>();
            socket = new List<string>();
            memory = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
                memory.Add(sp[3]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if ((Convert.ToDouble(cena[i]) <= pr * 0.10) & (socket[i] == socket_now) & (memory[i] == memory_now))
                {
                    label8.Text = cena[i] + "  " + name[i];
                    pl = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "питание.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.084)
                {
                    label3.Text = cena[i] + "  " + name[i];
                    pi = Convert.ToDouble(cena[i]);
                    break;
                }
            }


            pathToFile = "ssd.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {

                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }

            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.056)
                {
                    label6.Text = cena[i] + "  " + name[i];
                    d = Convert.ToDouble(cena[i]);
                    break;
                }
            }
            if ((label3.Text == " ") || (label7.Text == " ") || (label8.Text == " ") || (label9.Text == " ") || (label10.Text == " ") || (label11.Text == " ")) MessageBox.Show("Невозможно подобрать конфигурацию ПК за данный бюджет", "Ошибка подбора конфигурации");
            mprice.Text = Convert.ToString(v + p + o + d + pl + pi+ssd);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //office
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label6.Text = " ";
            mprice.Text = " ";
            label7.Text = "0";
            label6.Text = "0";
            double pr = Convert.ToDouble(price.Text);
            double  p=0, o=0, d=0, pl=0, pi=0;
          
            string pathToFile = "проц.txt";
            List<string> name = new List<string>();
            List<string> cena = new List<string>();
            List<string> socket = new List<string>();
            List<string> memory = new List<string>();
            string socket_now = "657";
            string memory_now = "2345";

            string[] fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.35)
                {
                    label9.Text = cena[i] + "  " + name[i];
                    p = Convert.ToDouble(cena[i]);
                    socket_now = socket[i];
                    break;
                }
            }


            pathToFile = "озу.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                memory.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.15)
                {
                    label11.Text = cena[i] + "  " + name[i];
                    o = Convert.ToDouble(cena[i]);
                    memory_now = memory[i];
                    break;
                }
            }

            pathToFile = "диск.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {

                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }

            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.15)
                {
                    label10.Text = cena[i] + "  " + name[i];
                    d = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "платы.txt";
            name = new List<string>();
            cena = new List<string>();
            socket = new List<string>();
            memory = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
                memory.Add(sp[3]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if ((Convert.ToDouble(cena[i]) <= pr * 0.20) & (socket[i] == socket_now) & (memory[i] == memory_now))
                {
                    label8.Text = cena[i] +"  "+ name[i];
                    pl = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "питание.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.15)
                {
                    label3.Text = cena[i] + "  " + name[i];
                    pi = Convert.ToDouble(cena[i]);
                    break;
                }
            }
            if ((label3.Text == " ") || (label7.Text == " ") || (label8.Text == " ") || (label9.Text == " ") || (label10.Text == " ") || (label11.Text == " ")) MessageBox.Show("Невозможно подобрать конфигурацию ПК за данный бюджет", "Ошибка подбора конфигурации");
            mprice.Text = Convert.ToString( p + o + d + pl + pi);
        }
        //Home
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label6.Text = " ";
            mprice.Text = " ";
            double pr = Convert.ToDouble(price.Text);
            double v = 0, p = 0, o = 0, d = 0, pl = 0, pi = 0, ssd = 0;
            string pathToFile = "видеокарты.txt";
            List<string> name = new List<string>();
            List<string> cena = new List<string>();
            List<string> socket = new List<string>();
            List<string> memory = new List<string>();
            string socket_now = "46t";
            string memory_now = "awd";

            string[] fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if(pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.21)
                    {
                        label7.Text = cena[i] + "  " + name[i];
                        v = Convert.ToDouble(cena[i]);
                        break;
                    }
                }

                if (Convert.ToDouble(cena[i]) <= pr * 0.24)
                {
                    label7.Text = cena[i] + "  " + name[i];
                    v = Convert.ToDouble(cena[i]);
                    break;
                }
            }


            pathToFile = "проц.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.21)
                    {
                        label9.Text = cena[i] + "  " + name[i];
                        p = Convert.ToDouble(cena[i]);
                        socket_now = socket[i];
                        break;
                    }
                }

                if (Convert.ToDouble(cena[i]) <= pr * 0.29)
                {
                    label9.Text = cena[i] + "  " + name[i];
                    p = Convert.ToDouble(cena[i]);
                    socket_now = socket[i];
                    break;
                }
            }


            pathToFile = "озу.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                memory.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.12)
                    {
                        label11.Text = cena[i] + "  " + name[i];
                        o = Convert.ToDouble(cena[i]);
                        memory_now = memory[i];
                        break;
                    }
                }
                if (Convert.ToDouble(cena[i]) <= pr * 0.14)
                {
                    label11.Text = cena[i] + "  " + name[i];
                    o = Convert.ToDouble(cena[i]);
                    memory_now = memory[i];
                    break;
                }
            }

            pathToFile = "диск.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {

                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }

            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.10)
                {
                    label10.Text = cena[i] + "  " + name[i];
                    d = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "платы.txt";
            name = new List<string>();
            cena = new List<string>();
            socket = new List<string>();
            memory = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
                memory.Add(sp[3]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if ((Convert.ToDouble(cena[i]) <= pr * 0.12) & (socket[i] == socket_now) & (memory[i] == memory_now))
                    {
                        label8.Text = cena[i] + "  " + name[i];
                        pl = Convert.ToDouble(cena[i]);
                        break;
                    }
                }
                if ((Convert.ToDouble(cena[i]) <= pr * 0.15) &(socket[i] == socket_now) & (memory[i] == memory_now))
                {
                    label8.Text = cena[i] + "  " + name[i];
                    pl = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "питание.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.10)
                    {
                        label3.Text = cena[i] + "  " + name[i];
                        pi = Convert.ToDouble(cena[i]);
                        break;
                    }
                }
                if (Convert.ToDouble(cena[i]) <= pr * 0.11)
                {
                    label3.Text = cena[i] + "  " + name[i];
                    pi = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            if (pr >= 50000)
            {
                pathToFile = "ssd.txt";
                name = new List<string>();
                cena = new List<string>();

                fn = File.ReadAllLines(pathToFile);
                for (int i = 0; i < fn.Length; i++)
                {

                    string[] sp = fn[i].Split(';');
                    name.Add(sp[0]);
                    cena.Add(sp[1]);
                }

                for (int i = name.Count() - 1; i >= 0; i--)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.11)
                    {
                        label6.Text = cena[i] + "  " + name[i];
                        d = Convert.ToDouble(cena[i]);
                        break;
                    }
                }
            }
            if ((label3.Text == " ") || (label7.Text == " ") || (label8.Text == " ") || (label9.Text == " ") || (label10.Text == " ") || (label11.Text == " ")) MessageBox.Show("Невозможно подобрать конфигурацию ПК за данный бюджет", "Ошибка подбора конфигурации");
            
            mprice.Text = Convert.ToString(v + p + o + d + pl + pi + ssd);
        }
        //work
        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label6.Text = " ";
            mprice.Text = " ";
            double pr = Convert.ToDouble(price.Text);
            double v = 0, p = 0, o = 0, d = 0, pl = 0, pi = 0, ssd = 0;
            string pathToFile = "видеокарты.txt";
            List<string> name = new List<string>();
            List<string> cena = new List<string>();
            List<string> socket = new List<string>();
            List<string> memory = new List<string>();
            string socket_now = "546";
            string memory_now = "ytj";

            string[] fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.12)
                    {
                        label7.Text = cena[i] + "  " + name[i];
                        v = Convert.ToDouble(cena[i]);
                        break;
                    }
                }
                if (Convert.ToDouble(cena[i]) <= pr * 0.13)
                {
                    label7.Text = cena[i] + "  " + name[i];
                    v = Convert.ToDouble(cena[i]);
                    break;
                }
            }


            pathToFile = "проц.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.23)
                    {
                        label9.Text = cena[i] + "  " + name[i];
                        p = Convert.ToDouble(cena[i]);
                        socket_now = socket[i];
                        break;
                    }
                }
                if (Convert.ToDouble(cena[i]) <= pr * 0.30)
                {
                    label9.Text = cena[i] + "  " + name[i];
                    p = Convert.ToDouble(cena[i]);
                    socket_now = socket[i];
                    break;
                }
            }


            pathToFile = "озу.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                memory.Add(sp[2]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.23)
                {
                    label11.Text = cena[i] + "  " + name[i];
                    o = Convert.ToDouble(cena[i]);
                    memory_now = memory[i];
                    break;
                }
            }

            pathToFile = "диск.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {

                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }

            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (pr >= 50000)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.10)
                    {
                        label10.Text = cena[i] + "  " + name[i];
                        d = Convert.ToDouble(cena[i]);
                        break;
                    }
                }
                if (Convert.ToDouble(cena[i]) <= pr * 0.12)
                {
                    label10.Text = cena[i] + "  " + name[i];
                    d = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "платы.txt";
            name = new List<string>();
            cena = new List<string>();
            socket = new List<string>();
            memory = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
                socket.Add(sp[2]);
                memory.Add(sp[3]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if ((Convert.ToDouble(cena[i]) <= pr * 0.16) & (socket[i] == socket_now) & (memory[i] == memory_now))
                {
                    label8.Text = cena[i] + "  " + name[i];
                    pl = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            pathToFile = "питание.txt";
            name = new List<string>();
            cena = new List<string>();

            fn = File.ReadAllLines(pathToFile);
            for (int i = 0; i < fn.Length; i++)
            {
                string[] sp = fn[i].Split(';');
                name.Add(sp[0]);
                cena.Add(sp[1]);
            }
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(cena[i]) <= pr * 0.10)
                {
                    label3.Text = cena[i] + "  " + name[i];
                    pi = Convert.ToDouble(cena[i]);
                    break;
                }
            }

            if (pr >= 50000)
            {
                pathToFile = "ssd.txt";
                name = new List<string>();
                cena = new List<string>();

                fn = File.ReadAllLines(pathToFile);
                for (int i = 0; i < fn.Length; i++)
                {

                    string[] sp = fn[i].Split(';');
                    name.Add(sp[0]);
                    cena.Add(sp[1]);
                }

                for (int i = name.Count() - 1; i >= 0; i--)
                {
                    if (Convert.ToDouble(cena[i]) <= pr * 0.1)
                    {
                        label6.Text = cena[i] + "  " + name[i];
                        d = Convert.ToDouble(cena[i]);
                        break;
                    }
                }
            }
            if ((label3.Text == " ") || (label7.Text == " ") || (label8.Text == " ") || (label9.Text == " ") || (label10.Text == " ") || (label11.Text == " ")) MessageBox.Show("Невозможно подобрать конфигурацию ПК за данный бюджет", "Ошибка подбора конфигурации");
            mprice.Text = Convert.ToString(v + p + o + d + pl + pi + ssd);
        }
    }
}
