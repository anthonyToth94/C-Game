using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGame
{
    public partial class Playground : Form
    {
        bool lovesEn = false;
        bool lovesEnemy = false;
        Random r = new Random(); //Ha kellene
        Random r2 = new Random();
        bool fegyverEn = false;
        bool fegyverEnemy = false;
        //karakter.Location = new System.Drawing.Pont(x, y)
                                          // r.Next(10,1250) , r.Next(-100, 0);
        int gunEn;
        int gunEnemy;
        int sebzesem;
        int sebzeseEnemynek;
      
        
        int hpEnemy;
        int hpEnyem;
        public Playground()
        {
            InitializeComponent();
            betoltes();
            Kezdes();

      

        }

        public void betoltes()
        {
            karakterem.BackColor = Character.szinem;
            label1.Text = Character.karatkerNev;
        }

        public void Kezdes()
        {
            //Enemy
            golyoEnyem1.Visible = false;
            golyoEnyem2.Visible = false;
            golyoEnyem3.Visible = false;
            golyoEnyem4.Visible = false;
            golyoEnyem5.Visible = false;
            fegyverEnemy1.Visible = false;
            fegyverEnemy2.Visible = false;
            fegyverEnemy3.Visible = false;
            fegyverEnemy4.Visible = false;
            fegyverEnemy5.Visible = false;
            hpEnemy = 1000;

            //Én
            golyoEnemy1.Visible = false;
            golyoEnemy2.Visible = false;
            golyoEnemy3.Visible = false;
            golyoEnemy4.Visible = false;
            golyoEnemy5.Visible = false;
            fegyverEnyem1.Visible = false;
            fegyverEnyem2.Visible = false;
            fegyverEnyem3.Visible = false;
            fegyverEnyem4.Visible = false;
            fegyverEnyem5.Visible = false;
            hpEnyem = 1000;

            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (lovesEn == false && fegyverEn == true && label5.Text.Contains("0"))
                {
                    timerEnGolyo1.Start();
                    lovesEn = true;
                    golyoEnyem1.Location = new Point(435, 466);
                    golyoEnyem2.Location = new Point(506, 466);
                    golyoEnyem3.Location = new Point(471, 426);
                    golyoEnyem4.Location = new Point(414, 439);
                    golyoEnyem5.Location = new Point(533, 439);
                }
                else
                {
                    MessageBox.Show("Please select gun!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (lovesEnemy == false && fegyverEnemy == true)
                {
                    timerEnemyGolyo1.Start();
                    lovesEnemy = true;
                    golyoEnemy1.Location = new Point(438, 104);
                    golyoEnemy2.Location = new Point(503, 104);
                    golyoEnemy3.Location = new Point(471, 140);
                    golyoEnemy4.Location = new Point(414, 112);
                    golyoEnemy5.Location = new Point(533, 112);
                }
           
            }
            
            
           
        }

        private void timerEnGolyo1_Tick(object sender, EventArgs e)
        {
                if (lovesEn == true)
                {  
                    if(gunEn == 1)
                    {
                        golyoEnyem1.Top -= 25;

                        golyoEnyem1.Show();

                        if (golyoEnyem1.Top < 80 )
                        {
                            lovesEn = false;
                            fegyverEn = false;
                            golyoEnyem1.Hide();       
                            fegyverEnyem1.Hide();
                            timerEnGolyo1.Stop();
                            label5.Text = "1";
                            hpEnemy = hpEnemy - sebzesem;
                            sebzes.Text = $"- {sebzesem.ToString()}";
                            sebzes.Visible = true;
                            HpEnemy();
                            button1.Enabled = true;
                        }
                    }
                    else if (gunEn == 2)
                    {
                        golyoEnyem1.Top -= 25;
                        golyoEnyem2.Top -= 25;

                        golyoEnyem1.Show();
                        golyoEnyem2.Show();

                        if (golyoEnyem1.Top < 80 || golyoEnyem2.Top < 80)
                        {
                            lovesEn = false;
                            fegyverEn = false;
                            golyoEnyem1.Hide();
                            golyoEnyem2.Hide();
                            fegyverEnyem1.Hide();
                            fegyverEnyem2.Hide();
                            timerEnGolyo1.Stop();
                            label5.Text = "1";
                            hpEnemy = hpEnemy - sebzesem;
                            sebzes.Text = $"- {sebzesem.ToString()}";
                            sebzes.Visible = true;
                            HpEnemy();
                            button1.Enabled = true;
                        }
                    }
                    else if (gunEn == 3)
                    {
                        golyoEnyem3.Top -= 25;

                        golyoEnyem3.Show();

                        if (golyoEnyem3.Top < 80)
                        {
                            lovesEn = false;
                            fegyverEn = false;
                            golyoEnyem3.Hide();
                            fegyverEnyem3.Hide();
                            timerEnGolyo1.Stop();
                            label5.Text = "1";
                            hpEnemy = hpEnemy - sebzesem;
                            sebzes.Text = $"- {sebzesem.ToString()}";
                            sebzes.Visible = true;
                            HpEnemy();
                            button1.Enabled = true;
                        }
                    }
                    else if (gunEn == 4)
                    {
                        golyoEnyem4.Top -= 25;
                        golyoEnyem5.Top -= 25;

                        golyoEnyem4.Show();
                        golyoEnyem5.Show();

                        if (golyoEnyem4.Top < 80 || golyoEnyem5.Top < 80)
                        {
                            lovesEn = false;
                            fegyverEn = false;
                            golyoEnyem4.Hide();
                            golyoEnyem5.Hide();
                            fegyverEnyem4.Hide();
                            fegyverEnyem5.Hide();
                            timerEnGolyo1.Stop();
                            label5.Text = "1";
                            hpEnemy = hpEnemy - sebzesem;
                            sebzes.Text = $"- {sebzesem.ToString()}";
                            sebzes.Visible = true;
                            HpEnemy();
                            button1.Enabled = true;
                        }
                    }
                    else if (gunEn == 5)
                    {
                        golyoEnyem1.Top -= 25;
                        golyoEnyem2.Top -= 25;
                        golyoEnyem3.Top -= 25;
                        golyoEnyem4.Top -= 25;
                        golyoEnyem5.Top -= 25;

                        golyoEnyem1.Show();
                        golyoEnyem2.Show();
                        golyoEnyem3.Show();
                        golyoEnyem4.Show();
                        golyoEnyem5.Show();
                    

                        if (golyoEnyem1.Top < 80 || golyoEnyem2.Top < 80 || golyoEnyem3.Top < 80 || golyoEnyem4.Top < 80 || golyoEnyem5.Top < 80)
                        {
                            lovesEn = false;
                            fegyverEn = false;
                            golyoEnyem1.Hide();
                            golyoEnyem2.Hide();
                            golyoEnyem3.Hide();
                            golyoEnyem4.Hide();
                            golyoEnyem5.Hide();
                            fegyverEnyem1.Hide();
                            fegyverEnyem2.Hide();
                            fegyverEnyem3.Hide();
                            fegyverEnyem4.Hide();
                            fegyverEnyem5.Hide();
                            timerEnGolyo1.Stop();
                            label5.Text = "1";
                            hpEnemy = hpEnemy - sebzesem;
                            sebzes.Text = $"- {sebzesem.ToString()}";
                            sebzes.Visible = true;
                            HpEnemy();
                            button1.Enabled = true;
                        }
                    }       
                }
            enemyHp.Text = hpEnemy.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

                button1.Enabled = false;
  
            if (hpEnemy <= 0 && hpEnyem > 0)
            {
                MessageBox.Show("Gratulation you are the winner!");
                button3.Visible = true;
            }
            else if(hpEnyem <= 0 && hpEnemy > 0)
            {
                MessageBox.Show("Computer the winner");
                button3.Visible = true;
            }
            else if(hpEnyem <= 0 && hpEnemy <= 0)
            {
                if(hpEnyem < hpEnemy)
                {
                    MessageBox.Show("Computer the winner");
                }
                else
                {
                    MessageBox.Show("Gratulation you are the winner!");
                }
                button3.Visible = true;
            }

            sebzes.Visible = false;
            fegyverEn = true;
            gunEn = r.Next(1, 6); 
            //MessageBox.Show(gunEn.ToString());
           
            if (gunEn == 1)
            {
                sebzesem = r.Next(10,72);
                fegyverEnyem1.Show();
            }
            else if(gunEn == 2)
            {
                sebzesem = r.Next(50,112);
                
                fegyverEnyem1.Show();
                fegyverEnyem2.Show();
            }
            else if (gunEn == 3)
            {
                sebzesem = r.Next(80,130);
                
                fegyverEnyem3.Show();
            }
            else if (gunEn == 4)
            {
                sebzesem = r.Next(100,150);
               
                fegyverEnyem4.Show();
                fegyverEnyem5.Show();
            }
            else if(gunEn == 5)
            {
                sebzesem = r.Next(150, 300);
 
                fegyverEnyem1.Show();
                fegyverEnyem2.Show();
                fegyverEnyem3.Show();
                fegyverEnyem4.Show();
                fegyverEnyem5.Show();
            }
      
        
            label5.Text = "0";

            // try enemy
            sebzesEnemy.Visible = false;
            fegyverEnemy = true;
            gunEnemy = r.Next(1, 6);
            //MessageBox.Show(gunEn.ToString());

            if (gunEnemy == 1)
            {
                sebzeseEnemynek = r2.Next(10, 72);
                fegyverEnemy1.Show();
            }
            else if (gunEnemy == 2)
            {
                sebzeseEnemynek = r2.Next(50, 112);

                fegyverEnemy1.Show();
                fegyverEnemy2.Show();
            }
            else if (gunEnemy == 3)
            {
                sebzeseEnemynek = r2.Next(80, 130);

                fegyverEnemy3.Show();
            }
            else if (gunEnemy == 4)
            {
                sebzeseEnemynek = r2.Next(100, 150);

                fegyverEnemy4.Show();
                fegyverEnemy5.Show();
            }
            else if (gunEnemy == 5)
            {
                sebzeseEnemynek = r2.Next(150, 300);

                fegyverEnemy1.Show();
                fegyverEnemy2.Show();
                fegyverEnemy3.Show();
                fegyverEnemy4.Show();
                fegyverEnemy5.Show();
            }

          
        }
        public void HpEnemy()
        {
            if(hpEnemy == 1000)
            {
                hpBarFelso.Location = new Point(0, 0);
            }
            else if(hpEnemy < 1000 && hpEnemy > 900)
            {
                hpBarFelso.Location = new Point(10, 0);
            }
            else if (hpEnemy <= 900 && hpEnemy > 700)
            {
                hpBarFelso.Location = new Point(20, 0);
            }
            else if (hpEnemy <= 700 && hpEnemy > 500)
            {
                hpBarFelso.Location = new Point(55, 0);
            }
            else if (hpEnemy <= 500 && hpEnemy > 300)
            {
                hpBarFelso.Location = new Point(95, 0);
            }
            else if (hpEnemy <= 300 && hpEnemy > 100)
            {
                hpBarFelso.Location = new Point(131, 0);
            }
            else if(hpEnemy <= 100 && hpEnemy > 0)
            {
                hpBarFelso.Location = new Point(165, 0);
            }
            else if(hpEnemy == 0 || hpEnemy < 0)
            {
                hpBarFelso.Location = new Point(200, 0);
            }
        }
        public void HpEnyem()
        {
            if (hpEnyem == 1000)
            {
                hpBarEnyemFelso.Location = new Point(0, 0);
            }
            else if (hpEnyem < 1000 && hpEnyem > 900)
            {
                hpBarEnyemFelso.Location = new Point(10, 0);
            }
            else if (hpEnyem <= 900 && hpEnyem > 700)
            {
                hpBarEnyemFelso.Location = new Point(20, 0);
            }
            else if (hpEnyem <= 700 && hpEnyem > 500)
            {
                hpBarEnyemFelso.Location = new Point(55, 0);
            }
            else if (hpEnyem <= 500 && hpEnyem > 300)
            {
                hpBarEnyemFelso.Location = new Point(95, 0);
            }
            else if (hpEnyem <= 300 && hpEnyem > 100)
            {
                hpBarEnyemFelso.Location = new Point(131, 0);
            }
            else if (hpEnyem <= 100 && hpEnyem > 0)
            {
                hpBarEnyemFelso.Location = new Point(165, 0);
            }
            else if (hpEnyem == 0 || hpEnyem < 0)
            {
                hpBarEnyemFelso.Location = new Point(200, 0);
            }
        }
        private void timerEnemyGolyo1_Tick(object sender, EventArgs e)
        {
            if (lovesEnemy == true)
            {
                if (gunEnemy == 1)
                {
                    golyoEnemy1.Top += 25;

                    golyoEnemy1.Show();

                    if (golyoEnemy1.Top > 483)
                    {
                        lovesEnemy = false;
                        fegyverEnemy = false;
                        golyoEnemy1.Hide();
                        fegyverEnemy1.Hide();
                        timerEnemyGolyo1.Stop();
                      
                        hpEnyem = hpEnyem - sebzeseEnemynek;
                        sebzesEnemy.Text = $"- {sebzeseEnemynek.ToString()}";
                        sebzesEnemy.Visible = true;
                        HpEnyem();
                        
                    }
                }
                else if (gunEnemy == 2)
                {
                    golyoEnemy1.Top += 25;
                    golyoEnemy2.Top += 25;

                    golyoEnemy1.Show();
                    golyoEnemy2.Show();

                    if (golyoEnemy1.Top > 483 || golyoEnemy2.Top > 483)
                    {
                        lovesEnemy = false;
                        fegyverEnemy = false;
                        golyoEnemy1.Hide();
                        golyoEnemy2.Hide();
                        fegyverEnemy1.Hide();
                        fegyverEnemy2.Hide();
                        timerEnemyGolyo1.Stop();

                        hpEnyem = hpEnyem - sebzeseEnemynek;
                        sebzesEnemy.Text = $"- {sebzeseEnemynek.ToString()}";
                        sebzesEnemy.Visible = true;
                        HpEnyem();
                       
                    }
                }
                else if (gunEnemy == 3)
                {
                    golyoEnemy3.Top += 25;

                    golyoEnemy3.Show();

                    if (golyoEnemy3.Bounds.IntersectsWith(karakterem.Bounds))
                    {
                        lovesEnemy = false;
                        fegyverEnemy = false;
                        golyoEnemy3.Hide();
                        fegyverEnemy3.Hide();
                        timerEnemyGolyo1.Stop();

                        hpEnyem = hpEnyem - sebzeseEnemynek;
                        sebzesEnemy.Text = $"- {sebzeseEnemynek.ToString()}";
                        sebzesEnemy.Visible = true;
                        HpEnyem();
                        
                    }
                }
                else if (gunEnemy == 4)
                {
                    golyoEnemy4.Top += 25;
                    golyoEnemy5.Top += 25;

                    golyoEnemy4.Show();
                    golyoEnemy5.Show();

                    if (golyoEnemy4.Top > 483 || golyoEnemy5.Top > 483)
                    {
                        lovesEnemy = false;
                        fegyverEnemy = false;
                        golyoEnemy4.Hide();
                        golyoEnemy5.Hide();
                        fegyverEnemy4.Hide();
                        fegyverEnemy5.Hide();
                        timerEnemyGolyo1.Stop();

                        hpEnyem = hpEnyem - sebzeseEnemynek;
                        sebzesEnemy.Text = $"- {sebzeseEnemynek.ToString()}";
                        sebzesEnemy.Visible = true;
                        HpEnyem();
                        
                    }
                }
                else if (gunEnemy == 5)
                {
                    golyoEnemy1.Top += 25;
                    golyoEnemy2.Top += 25;
                    golyoEnemy3.Top += 25;
                    golyoEnemy4.Top += 25;
                    golyoEnemy5.Top += 25;

                    golyoEnemy1.Show();
                    golyoEnemy2.Show();
                    golyoEnemy3.Show();
                    golyoEnemy4.Show();
                    golyoEnemy5.Show();


                    if (golyoEnemy1.Top > 483 || golyoEnemy2.Top > 483 || golyoEnemy3.Bounds.IntersectsWith(karakterem.Bounds) || golyoEnemy4.Top > 483 || golyoEnemy5.Top > 483)
                    {
                        lovesEnemy = false;
                        fegyverEnemy = false;
                        golyoEnemy1.Hide();
                        golyoEnemy2.Hide();
                        golyoEnemy3.Hide();
                        golyoEnemy4.Hide();
                        golyoEnemy5.Hide();
                        fegyverEnemy1.Hide();
                        fegyverEnemy2.Hide();
                        fegyverEnemy3.Hide();
                        fegyverEnemy4.Hide();
                        fegyverEnemy5.Hide();
                        timerEnemyGolyo1.Stop();

                        hpEnyem = hpEnyem - sebzeseEnemynek;
                        sebzesEnemy.Text = $"- {sebzeseEnemynek.ToString()}";
                        sebzesEnemy.Visible = true;
                        HpEnyem();
                       
                    }
                }
            }
            enHp.Text = hpEnyem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Character cs = new Character();
            cs.Show();
        }
    }
}
