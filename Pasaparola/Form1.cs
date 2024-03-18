using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)//Anahtar kod enter eşitse
            {
              switch (soruno)
                {   //cevap1
                    case 1:
                        if(textBox1.Text=="akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                        //cevap2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;



                    //cevap5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap8
                    case 8:
                        if (textBox1.Text == "")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap13
                    case 13:
                        if (textBox1.Text == "laleli")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;



                    //cevap15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;


                    //cevap19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;




                    //cevap21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;




                    //cevap23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;

                    //cevap24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            lbl_DOĞRU.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            lbl_YANLIŞ.Text = yanlis.ToString();
                        }
                        break;




                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //Linklabel Tıklandığında Başla yerine artık Sonraki Yazsın
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();//Formun Sol Üst Köşesi-->this.Text 

            if(soruno==1)
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesi?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle Ünlü Marmara İlimiz :?";
                button2.BackColor = Color.Yellow;

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü?";
                button3.BackColor = Color.Yellow;

            }


            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla Ünlü İlimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamlısı?";
                button5.BackColor = Color.Yellow;

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerinin Yazılı Hali?";
                button6.BackColor = Color.Yellow;

            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin Kötü Karne Getirince Bakıştığı Nesne?";
                button8.BackColor = Color.Yellow;

            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle Ünlü İlimiz?";
                button9.BackColor = Color.Yellow;

            }



            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin Diğer İsmi?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri Bir Topluluk?";
                button11.BackColor = Color.Yellow;

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın Meşhur Meyvesi?";
                button12.BackColor = Color.Yellow;

            }


            if (soruno == 13)
            {
                richTextBox1.Text = "Her Yıl Bahar Aylarında Düzelenen Çiçek Festivali?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3.Ayı?";
                button14.BackColor = Color.Yellow;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli Bir Müzik Aleti?";
                button15.BackColor = Color.Yellow;

            }

            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların Pek Sevmediği Pirinç Havuç gibi Sebzelerle Yapaılan Yemek?";
                button17.BackColor = Color.Yellow;

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayı Sultanı?";
                button18.BackColor = Color.Yellow;

            }



            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede Yılan?";
                button19.BackColor = Color.Yellow;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin Mega Starı";
                button20.BackColor = Color.Yellow;

            }


            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit Kelimesinin Eş Anlamlısı??";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı İle Ünlü İlimiz?";
                button22.BackColor = Color.Yellow;

            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek Kelimesinin EŞ Anlamlısı?";
                button23.BackColor = Color.Yellow;

            }

            if (soruno == 24)
            {
                richTextBox1.Text = "Ege Bölgesinde en çok Ağacı bulunan Yağı da yapılan bir kahvaltı besini?";
                button24.BackColor = Color.Yellow;
            }


          



        }
    }
}
