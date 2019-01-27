using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimPsikoloji1
{
    public partial class Burdon : Form
    {
        int j;
        public Burdon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                Random rnd = new Random();
                char[,] array = new char[22, 30];



                for (int i = 1; i < 22; i++)
                {
                    for (int j = 1; j < 30; j++)
                    {
                        array[i, j] = 'Ç';
                    }
                }

                for (int i = 0; i < 30; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'a';
                        //sayacA++;
                    }
                    else
                    {
                        i--;
                    }
                }

                for (int i = 0; i < 29; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'b';
                        //sayacB++;
                    }
                    else
                    {
                        i--;
                    }
                }

                for (int i = 0; i < 31; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'd';
                        //sayacD++;
                    }
                    else
                    {
                        i--;
                    }
                }

                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'c';
                        //sayacC++;
                    }
                    else
                    {
                        i--;
                    }
                }

                for (int i = 0; i < 30; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'z';
                        //sayacZ++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'p';
                        //sayacP++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'e';
                        //sayacE++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 's';
                        //sayacS++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 30; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'g';
                        //sayacG++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'f';
                        //sayacF++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 't';
                        //sayacT++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'v';
                        //sayacV++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'm';
                        //sayacM++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 37; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'n';
                        //sayacN++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 30; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'l';
                        //sayacl++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 30; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = '1';
                        //sayac1++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 33; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'y';
                        //sayacY++;
                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int randomAX = rnd.Next(1, 22);
                    int randomAY = rnd.Next(1, 30);
                    if (array[randomAX, randomAY] == 'Ç')
                    {
                        array[randomAX, randomAY] = 'o';
                        //sayacO++;
                    }
                    else
                    {
                        i--;
                    }
                }





                int seatno = 1;

                //int btnLocationX = 40;

                //int btnLocationY = 30;
                int lblLocationX = 30;
                int lblLocationY = 20;



                try

                {

                    for (int i = 0; i < 22; i++)
                    {

                        int row = 65;

                        for (j = 0; j < 30; j++)
                        {
                            Label lbl = new Label();
                            lbl.Click += new EventHandler(lbl_Click);
                            lbl.Name = seatno.ToString();
                            lbl.Size = new System.Drawing.Size(30, 28);
                            lbl.Font = new Font("Arial", 10, FontStyle.Bold);
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            //lbl.Size satırını yazmadım.
                            lbl.Location = new Point(lblLocationX * i, lblLocationY * j);
                            this.Controls.Add(lbl);
                            lbl.Text = array[i, j].ToString();

                            row = row + 1;
                            seatno = seatno + 1;

                        }


                        if (i == 22)

                        {
                            lblLocationX = 50;
                        }

                    }

                }



                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);

                }
            
            

        }

        

        int sayacA = 0;
        int sayacB = 0;
        int sayacC = 0;
        int sayacD = 0;
        int sayacG = 0;
        int sayac1 = 0;
        int sayacl = 0;
        int sayacZ = 0;
        int sayacP = 0;
        int sayacE = 0;
        int sayacS = 0;
        int sayacF = 0;
        int sayacT = 0;
        int sayacV = 0;
        int sayacM = 0;
        int sayacN = 0;
        int sayacY = 0;
        int sayacO = 0;

        private void lbl_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = sender as System.Windows.Forms.Label;

            
            if (lbl.BackColor == Color.FromArgb(255, 128, 128))
            {
                lbl.BackColor = Color.White;

                if (lbl.Text == 'a'.ToString())
                {
                    sayacA--;
                }
                else if (lbl.Text == 'b'.ToString())
                {
                    sayacB--;
                }
                else if (lbl.Text == 'c'.ToString())
                {
                    sayacC--;
                }
                else if (lbl.Text == 'd'.ToString())
                {
                    sayacD--;
                }
                else if (lbl.Text == 'g'.ToString())
                {
                    sayacG--;
                }
                else if (lbl.Text == '1'.ToString())
                {
                    sayac1--;
                }
                else if (lbl.Text == 'l'.ToString())
                {
                    sayacl--;
                }
                else if (lbl.Text == 'z'.ToString())
                {
                    sayacZ--;
                }
                else if (lbl.Text == 'p'.ToString())
                {
                    sayacP--;
                }
                else if (lbl.Text == 'e'.ToString())
                {
                    sayacE--;
                }
                else if (lbl.Text == 's'.ToString())
                {
                    sayacS--;
                }
                else if (lbl.Text == 'f'.ToString())
                {
                    sayacF--;
                }
                else if (lbl.Text == 't'.ToString())
                {
                    sayacT--;
                }
                else if (lbl.Text == 'v'.ToString())
                {
                    sayacV--;
                }
                else if (lbl.Text == 'm'.ToString())
                {
                    sayacM--;
                }
                else if (lbl.Text == 'n'.ToString())
                {
                    sayacN--;
                }
                else if (lbl.Text == 'y'.ToString())
                {
                    sayacY--;
                }
                else if (lbl.Text == 'o'.ToString())
                {
                    sayacO--;
                }

            }
            else
            {
                lbl.BackColor = Color.FromArgb(255, 128, 128);
                if (lbl.Text == 'a'.ToString())
                {
                    sayacA++;
                }
                else if (lbl.Text == 'b'.ToString())
                {
                    sayacB++;
                }
                else if (lbl.Text == 'c'.ToString())
                {
                    sayacC++;
                }
                else if (lbl.Text == 'd'.ToString())
                {
                    sayacD++;
                }
                else if (lbl.Text == 'g'.ToString())
                {
                    sayacG++;
                }
                else if (lbl.Text == '1'.ToString())
                {
                    sayac1++;
                }
                else if (lbl.Text == 'l'.ToString())
                {
                    sayacl++;
                }
                else if (lbl.Text == 'z'.ToString())
                {
                    sayacZ++;
                }
                else if (lbl.Text == 'p'.ToString())
                {
                    sayacP++;
                }
                else if (lbl.Text == 'e'.ToString())
                {
                    sayacE++;
                }
                else if (lbl.Text == 's'.ToString())
                {
                    sayacS++;
                }
                else if (lbl.Text == 'f'.ToString())
                {
                    sayacF++;
                }
                else if (lbl.Text == 't'.ToString())
                {
                    sayacT++;
                }
                else if (lbl.Text == 'v'.ToString())
                {
                    sayacV++;
                }
                else if (lbl.Text == 'm'.ToString())
                {
                    sayacM++;
                }
                else if (lbl.Text == 'n'.ToString())
                {
                    sayacN++;
                }
                else if (lbl.Text == 'y'.ToString())
                {
                    sayacY++;
                }
                else if (lbl.Text == 'o'.ToString())
                {
                    sayacO++;
                }
            }
            label2.Text = sayacA.ToString();
            label3.Text = sayacB.ToString();
            label5.Text = sayacD.ToString();
            label7.Text = sayacC.ToString();
            label9.Text = sayacZ.ToString();
            label11.Text = sayacP.ToString();
            label13.Text = sayacE.ToString();
            label15.Text = sayacS.ToString();
            label17.Text = sayacG.ToString();
            label19.Text = sayacF.ToString();
            label21.Text = sayacT.ToString();
            label23.Text = sayacV.ToString();
            label25.Text = sayacM.ToString();
            label27.Text = sayacN.ToString();
            label29.Text = sayacl.ToString();
            label31.Text = sayac1.ToString();
            label35.Text = sayacY.ToString();
            label37.Text = sayacO.ToString();

            label34.Text = (sayacA + sayacB + sayacD + sayacG).ToString();


        }
        DateTime EndOfTime;
        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Visible == false)
            {
                DialogResult secenek = MessageBox.Show("Süreniz Yeniden Başlatılacaktır.Süreyi Sıfırlamak İstediğinizden Emin Misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    
                    EndOfTime = DateTime.Now.AddMinutes(5);
                    timer1.Interval = 500;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(Timer1_Tick);

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                    label25.Visible = false;
                    label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label31.Visible = false;
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    label37.Visible = false;
                    label38.Visible = false;
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Süreniz Devam Etmektedir.!!");
                }
            }
            else
            {
                EndOfTime = DateTime.Now.AddMinutes(5);
                timer1.Interval = 500;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(Timer1_Tick);

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label36.Visible = false;
                label37.Visible = false;
                label38.Visible = false;

            }
            




        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Visible == false)
            {
                DialogResult secenek = MessageBox.Show("Süreniz Yeniden Başlatılacaktır.Süreyi Sıfırlamak İstediğinizden Emin Misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    EndOfTime = DateTime.Now.AddMinutes(10);
                    timer1.Interval = 500;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(Timer1_Tick);

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                    label25.Visible = false;
                    label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label31.Visible = false;
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    label37.Visible = false;
                    label38.Visible = false;
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Süreniz Devam Etmektedir.!!");
                }
            }
            else
            {
                EndOfTime = DateTime.Now.AddMinutes(10);
                timer1.Interval = 500;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(Timer1_Tick);

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label36.Visible = false;
                label37.Visible = false;
                label38.Visible = false;

            }
        }





        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Visible == false)
            {
                DialogResult secenek = MessageBox.Show("Süreniz Yeniden Başlatılacaktır.Süreyi Sıfırlamak İstediğinizden Emin Misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    EndOfTime = DateTime.Now.AddMinutes(15);
                    timer1.Interval = 500;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(Timer1_Tick);

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                    label25.Visible = false;
                    label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label31.Visible = false;
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    label37.Visible = false;
                    label38.Visible = false;
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Süreniz Devam Etmektedir.!!");
                }
            }
            else
            {
                EndOfTime = DateTime.Now.AddMinutes(15);
                timer1.Interval = 500;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(Timer1_Tick);

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label36.Visible = false;
                label37.Visible = false;
                label38.Visible = false;

            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = EndOfTime.Subtract(DateTime.Now);
            label39.Font = new Font("Arial", 20, FontStyle.Bold);
            label39.Text = ts.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Visible==false)
            {
                DialogResult secenek = MessageBox.Show("Süreyi Bitirip Sonuçları Göstermek İstediğinize Emin Misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    label21.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    label32.Visible = true;
                    label33.Visible = true;
                    label34.Visible = true;
                    label35.Visible = true;
                    label36.Visible = true;
                    label37.Visible = true;
                    label38.Visible = true;
                    timer1.Stop();
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Süreniz Devam Etmektedir.!!");
                }

            }
            else
            {
                MessageBox.Show("Süreniz Başlatılmamıştır.Sonuçlarınız Gösteriliyor.");
            }


        }
    }

}
