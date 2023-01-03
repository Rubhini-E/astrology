using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace astro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Convert.ToString(txtname.Text);
            int year = Convert.ToInt32(txtyear.Text);
            int current = 2023;
            int age = current - year;

            //char[] names = name.ToCharArray();
            

           // if ((age <= 20 || age<40 ||age <60 || age<80 && names[0] =='a'|| names[0] == 'h'|| names[0] == 'j' || names[0] == 'y' || names[0]=='p'))
            if(age<=20)
            {
                lblshow.Content = "\n" + "Dear " +txtname.Text +  "\n"  +"your age is "+ age + "\n" + "\n"+ "your ambitions are exalted and you set yourself a high goal to aim of it";
            }
           // else if ((age < 40 || age < 20 || age < 60 || age < 80 && names[0] == 'b' || names[0] == 'e' || names[0] == 'i' || names[0] == 'm' || names[0] == 'q' || names[0] == 't'))
            else if(age<40)
            {
                lblshow.Content = "\n" + "Dear " + txtname.Text + "\n" + "your age is " + age + "\n" + "\n" + " you are forceful in character.you are large hearted and large minded";
            }
           // else if ((age < 60 || age < 40 || age< 20 || age < 80 && names[0] == 'c' || names[0] == 'f' || names[0] == 'k' || names[0] == 'n' || names[0] == 'r' || names[0] == 'v'))
            else if(age<60)
            {
                lblshow.Content = "\n" + "Dear " + txtname.Text + "\n" + "your age is " + age + "\n" + "\n" + " your memory is unusally good and you never forget a kindness";
            }
           // else if ((age < 80 || age < 40 || age < 60 || age < 20 && names[0] == 'd' || names[0] == 'g' || names[0] == 'l' || names[0] == 'o' || names[0] == 's' || names[0] == 'u'))
           else if(age<80)
            {
                lblshow.Content = "\n" + "Dear " + txtname.Text + "\n" + "your age is " + age + "\n" + "\n" + " you tend to be miserable in many ways because you are afraid to tell how you feel about others";
            }

             Char[] names = name.ToCharArray();
           
            if (names[0] == 'a' || names[0] == 'h' || names[0] == 'j' || names[0] == 'y' || names[0] == 'p')
            {
                lblshow1.Content = "you can do excellent work on your own"+ "\n"+ "you are also responsible,dedicated in any team and 2023 will bring u glorious love and joy";
            }
            else if (names[0] == 'b' || names[0] == 'e' || names[0] == 'i' || names[0] == 'm' || names[0] == 'q' || names[0] == 't')
            {
                lblshow1.Content = "you are able to stay calm and avoid lot of choas" + "\n" + "you are excel in most assigned jobs and still welcome love as an important part";
            }
            else if (names[0] == 'c' || names[0] == 'f' || names[0] == 'k' || names[0] == 'n' || names[0] == 'r' || names[0] == 'v')
            {
                lblshow1.Content = "your main objective in 2023 will be strengthening an existing relationship" + "\n" + "2023 is good time to continue to focus on goals where love is concerned";
            }
            else if (names[0] == 'd' || names[0] == 'g' || names[0] == 'l' || names[0] == 'o' || names[0] == 's' || names[0] == 'u')
            {
                lblshow1.Content = "you can decide to dig in and finally stand up to ur own competition" + "\n" + "plow through the hurdles that have been holding you back";
            }

        }

    }


    }