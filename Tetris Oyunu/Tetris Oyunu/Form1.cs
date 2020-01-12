using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tetris_Oyunu
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys key);
        public Form1()
        {
            InitializeComponent();
        }
        bool play = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(play)
            {

            }
            else
            {
                sekilGetir();
                play = true;
                sure.Enabled = true;
            }
            

        }
        int puan = 0;
        PictureBox[] kutular = new PictureBox[4];
        PictureBox[] bitenler = new PictureBox[600];
        Rectangle[] Yerler = new Rectangle[600];

        Rectangle[] Yeni = new Rectangle[4];
        int[,] arrray = new int[16,10];
        int sinir = 0; bool kontrolBool = true,ilk = true;
        void sekilGetir()
        {
            Random karistir = new Random();
            int t = karistir.Next(0, 5);


            if (t == 0)
            {

                anaFonksiyon();
                kutular[0].Location = new Point(91, -60);
                kutular[1].Location = new Point(121, -60);
                kutular[2].Location = new Point(121, -30);
                kutular[3].Location = new Point(151, -30);
                sekil1.Enabled = true;
            }
            else if (t == 1)
            {
                anaFonksiyon();
                kutular[0].Location = new Point(121, -90);
                kutular[1].Location = new Point(121, -60);
                kutular[2].Location = new Point(121, -30);
                kutular[3].Location = new Point(151, -30);
                sekil2.Enabled = true;
            }
            else if (t == 2)
            {
                anaFonksiyon();
                kutular[0].Location = new Point(121, -60);
                kutular[1].Location = new Point(151, -60);
                kutular[2].Location = new Point(121, -30);
                kutular[3].Location = new Point(151, -30);
                sekil3.Enabled = true;
            }
            else if (t == 3)
            {
                anaFonksiyon();
                kutular[0].Location = new Point(121, -120);
                kutular[1].Location = new Point(121, -90);
                kutular[2].Location = new Point(121, -60);
                kutular[3].Location = new Point(121, -30);
                sekil4.Enabled = true;
            }
            else if (t == 4)
            {
                anaFonksiyon();
                kutular[0].Location = new Point(91, -60);
                kutular[1].Location = new Point(121, -60);
                kutular[2].Location = new Point(151, -60);
                kutular[3].Location = new Point(151, -30);
                sekil5.Enabled = true;
            }

            if (ilk == false)
            {
                xx1 = 0;
                kontrol.Start();
                /*
                for (int i = 0; i < 4; i++)
                {
                    Yeni[i] = new Rectangle(kutular[i].Location.X, kutular[i].Location.Y, 40, 40);
                    bitenler[sinir] = kutular[i];
                    Yerler[sinir] = Yeni[i];
                    sinir++;
                }  
*/
            }

            ilk = false;


        }
        void anaFonksiyon()
        {
            for (int i = 0; i < 4; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Width = 30;
                picture.Height = 30;
                this.Controls.Add(picture);
                picture.Image = Properties.Resources.square;
                picture.BackColor = Color.Black;
                picture.SizeMode = PictureBoxSizeMode.CenterImage;
                picture.BringToFront();
                kutular[i] = picture;
            //    bitenler[sinir] = picture;
             //   sinir++;
            }
        }
        Timer tut;
        int xx1 =0, xx2=0,yy1=0;
        void hareket(int x1, int x2, int x3, int x4)
        {
            if(kont)
            {

                tut.Interval = 1;

                if (kutular[0].Location.Y >= 450 || kutular[1].Location.Y >= 450 || kutular[2].Location.Y >= 450 || kutular[3].Location.Y >= 450 || kontrolBool == false)
                {

                    for (int i = 0; i < 4; i++)
                    {
                        //   Yeni[i] = new Rectangle(kutular[i].Location.X, kutular[i].Location.Y , 30 , 30);
                        bitenler[sinir] = kutular[i];
                        //  Yerler[sinir] = Yeni[i];
                        sinir++;
                        //   MessageBox.Show(bitenler[i].Location.X + " , " + bitenler[i].Location.Y);
                    }

                    tut.Enabled = false;
                    sekilGetir();
                    kontrolBool = true;
                }
                else
                {


                    if ((x1 > 1 && x2 > 1 && x3 > 1 && x4 > 1))
                    {
                        if (GetAsyncKeyState(Keys.Left) < 0)
                        {
                            xx1 -= 30;

                        }


                    }
                    if ((x1 < 270 && x2 < 270 && x3 < 270 && x4 < 270))
                    {
                        if (GetAsyncKeyState(Keys.Right) < 0)
                        {
                            xx1 += 30;
                        }
                    }



                    if (GetAsyncKeyState(Keys.Down) < 0)
                    {
                        kutular[0].Location = new Point(x1, kutular[0].Location.Y + 30);
                        kutular[1].Location = new Point(x2, kutular[1].Location.Y + 30);
                        kutular[2].Location = new Point(x3, kutular[2].Location.Y + 30);
                        kutular[3].Location = new Point(x4, kutular[3].Location.Y + 30);
                    }
                    tut.Interval = 200;
                    kutular[0].Location = new Point(x1, kutular[0].Location.Y + 30);
                    kutular[1].Location = new Point(x2, kutular[1].Location.Y + 30);
                    kutular[2].Location = new Point(x3, kutular[2].Location.Y + 30);
                    kutular[3].Location = new Point(x4, kutular[3].Location.Y + 30);
                    siraKontrol();
                    /*
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Yeni[i] = new Rectangle(kutular[i].Location.X, kutular[i].Location.Y, 40, 40);

                                        }
                                        deneme(Yeni[0], Yeni[1], Yeni[2], Yeni[3]);
                    */
                }

            }
          
           
        } 
        private void sekil1_Tick(object sender, EventArgs e)
        {
            tut = sekil1;
            hareket(91+xx1,121+xx1,121+xx1,151+xx1);
        }

        private void sekil2_Tick(object sender, EventArgs e)
        {
            tut = sekil2;
            hareket(121+xx1, 121+xx1, 121+xx1, 151+xx1);

        }

        private void sekil3_Tick(object sender, EventArgs e)
        {
            tut = sekil3;
            hareket(121+xx1, 151+xx1, 121+xx1, 151+xx1);
        }

        private void sekil4_Tick(object sender, EventArgs e)
        {
            tut = sekil4;
            hareket(121+xx1, 121+xx1, 121+xx1, 121+xx1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol.Stop();
            kontrol.Enabled = false;
            tut.Enabled = false;
            sure.Stop();
            sekil1.Stop();
            sekil2.Stop();
            sekil3.Stop();
            sekil4.Stop();
            sekil5.Stop();
            for (int i = 0; i<sinir; i++)
            {
                this.Controls.Remove(bitenler[i]);
                bitenler[i] = null;
            }
            for(int i= 0; i<4; i++ )
            {
                this.Controls.Remove(kutular[i]);
                kutular[i] = null;
            }
            kontrolBool = true;
            sinir = 0;
            puan = 0;
            ilk = true;
            kont = true;
            sekilGetir();
            sure.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sekil1ne = 1;
        private void dondur_Tick(object sender, EventArgs e)
        {
            if(tut == sekil1)
            {
                if(sekil1ne == 1)
                {
                    if(GetAsyncKeyState(Keys.Up) < 0)
                    {
                        kutular[0].Location = new Point(kutular[2].Location.X +30, kutular[2].Location.Y - 30);
                        kutular[1].Location = new Point(kutular[2].Location.X + 30, kutular[2].Location.Y - 30);
                        kutular[2].Location = new Point(kutular[2].Location.X + 30, kutular[2].Location.Y - 30);
                        kutular[3].Location = new Point(kutular[2].Location.X + 30, kutular[2].Location.Y - 30);

                    }
                }
                else
                {

                }

            }
            else if(tut == sekil2)
            {

            }
            else if(tut == sekil3)
            {

            }
            else if(tut == sekil4)
            {

            }
            else if(tut == sekil5)
            {

            }
        }
        
        private void sure_Tick(object sender, EventArgs e)
        {
            if(kont)
            {
                puan = puan + 1;
            }
            
        }

        private void sekil5_Tick(object sender, EventArgs e)
        {
            tut = sekil5;
            hareket(91+xx1, 121+xx1, 151+xx1, 151+xx1);
        }

        private void kontrol_Tick(object sender, EventArgs e)
        {
            
 /*
            foreach (Rectangle r1 in this.Yerler)
            {
                foreach (Rectangle r2 in Yeni)
                {
                    if (r1.IntersectsWith(r2))
                    {
                        tut.Stop();
                        MessageBox.Show("çarptı");
                    }
                }
                    
            }
              

             */

            if(kont)
            {
                for (int i = 0; i < 4; i++)   
                {
                    for (int j = 0; j < sinir; j++)
                    {
                        if ((bitenler[j].Location.X == kutular[i].Location.X) && (bitenler[j].Location.Y == kutular[i].Location.Y + 30))
                        {
                            kontrolBool = false;
                            break;

                        }
                        if (bitenler[j].Location.Y == 0)
                        {
                            kontrol.Stop();
                            tut.Stop();
                            oyunBitti();
                        }


                    }
                }
            }
           
        }

        void siraKontrol()
        {
            int sira1 = 0, sira2 = 0;
            int[] dizi1 = new int[10];
            for(int i = 0; i<sinir; i++)
            {
                if (bitenler[i].Location.Y == 450)
                {
                        int t = bitenler[i].Location.X;
                        if(t == 1 || t == 31 || t == 61 || t == 91 || t == 121 || t == 151 || t == 181 || t == 211 || t == 241 || t == 271 )
                        {
                            dizi1[sira1] = i;
                            sira1++;
                        } 
                }
            }

            if(sira1 >= 10)
            {
                for(int i = 0; i<10; i++)
                {
                    this.Controls.Remove(bitenler[dizi1[i]]);
                }
                for(int i = 0; i<sinir; i++)
                {
                    bitenler[i].Location = new Point(bitenler[i].Location.X , bitenler[i].Location.Y +30);
                }
                puan = puan + 100;
            }
            sira1 = 0;
        }
        bool kont = true;
        void oyunBitti()
        {
            kontrol.Stop();
            sure.Stop();
            tut.Stop();
            sekil1.Stop();
            sekil2.Stop();
            sekil3.Stop();
            sekil4.Stop();
            sekil5.Stop();
            if(kont == true)
            {
                MessageBox.Show("Oyun Bitti , Puanınız : " + puan);
                kont = false;
            }
            
            puan = 0;
        }
    }
}
