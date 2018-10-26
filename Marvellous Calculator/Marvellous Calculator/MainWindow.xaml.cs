using System;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using Marvellous_Calculator;
namespace Marvellous_Calculator
{
    public partial class MainWindow : Window
    {
        private char opflag;
        private ArithmaticOp AOP;
        private NumberSystemLable NSL;
        private BitwiseOp BO;
        private BitMask BM;
        private int tempAns,tempAns2;        
        private string CurrenOpString;
        public Button[] btn;
        public HistoryIO HIO;
       
        public MainWindow()
        {
            InitializeComponent();
            this.Width = 380;
            AOP = new ArithmaticOp();
            BO = new BitwiseOp();
            BM = new BitMask();
            HIO = new HistoryIO();
            tempAns = 0;
            tempAns2 = 1;
            CurrenOpString = null;
            btn = new Button[32];
            btn[0] = m1; btn[1] = m2; btn[2] = m3; btn[3] = m4; btn[4] = m5; btn[5] = m6; btn[6] = m7; btn[7] = m8;
            btn[8] = m9; btn[9] = m10; btn[10] = m11; btn[11] = m12; btn[12] = m13; btn[13] = m14; btn[14] = m15; btn[15] = m16;
            btn[16] = m17; btn[17] = m18; btn[18] = m19; btn[19] = m20; btn[20] = m21; btn[21] = m22; btn[22] = m23; btn[23] = m24;
            btn[24] = m25; btn[25] = m26; btn[26] = m27; btn[27] = m28; btn[28] = m29; btn[29] = m30; btn[30] = m31; btn[31] = m32;       
        }

        private void LInput(string str)
        {
            CurrenOpString += " " + str;
            CurrentOp.Content = CurrenOpString;       
        }

       
        private void SetNumbersys(string s)
        {
            NSL = new NumberSystemLable(s);
            HexOut.Content = NSL.HexX();
            OctalOut.Content = NSL.OctalX();
            BinaryOut.Content = NSL.BinaryX();
            DecimalOut.Content = s;
        }

        private void Input(string sin)
        {            
            if (Display.Text == "0")
            {
                Display.Text = "";
            }
            string str = Display.Text + sin;
            TSetMask(Convert.ToInt32(str));
            SetNumbersys(str);
            Display.Text = str;
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if(sender == one)
            {
                Input("1");
            }
           else if(sender == two)
            {
                Input("2");
            }
            else if (sender == three)
            {
                Input("3");
            }
            else if (sender == four)
            {
                Input("4");
            }
            else if (sender == five)
            {
                Input("5");
            }
            else if (sender == six)
            {
                Input("6");
            }
            else if (sender == seven)
            {
                Input("7");
            }
            else if (sender == eight)
            {
                Input("8");
            }
            else if (sender == nine)
            {
                Input("9");
            }
            else if (sender == OFF)
            {
                this.Close();
            }
            else if (sender == zero)
            {
                if((Display.Text == "") || (Display.Text == "0"))
                {
                    
                }
                else
                {
                    Input("0");
                }
            }

        }

        private void Back_Clear(object sender, RoutedEventArgs e)
        {
            if(sender == BACK)
            {                
                Display.Undo();                
            }
            else if(sender == C)
            {
                
                string history = Convert.ToString(CurrentOp.Content);
                HIO.UpdateHistory(history);
                               
                History_panel.Content = HIO.PrintHistory();
                
                CurrentOp.Content = null;
                CurrenOpString = null;
                Display.Text = "0";
                SetNumbersys("0");
                TSetMask(0);
            }
        }

        private void Arithmatic_Click(object sender, RoutedEventArgs e)
        {

            int iNo1 = Convert.ToInt32(Display.Text);

            if (sender == add)
            { 
                opflag = '+';                
                int temp= AOP.AddX(iNo1, 0);
                tempAns += temp;
                LInput( Display.Text+" +");
            }
            else if (sender == sub)
            {
                opflag = '-';                
                int temp = AOP.SubX(iNo1, 0);
                if (tempAns == 0) { tempAns = temp; }
                else { tempAns -= temp; }
                LInput(Display.Text + " -");
            }
            else if (sender == mult)
            {
                opflag = '*';
                int temp = AOP.MultX(iNo1, 1);
                tempAns2 *= temp;
                LInput(Display.Text + " *");
            }
            else if (sender == div)
            {
                opflag = '/';
                int temp = AOP.DivX(iNo1, 1);
                if (tempAns2 == 1) { tempAns2 = temp; }
                else { tempAns2 /= temp; }
                   
                LInput(Display.Text + " /");
            }
            else if (sender == mod)
            {
                opflag = '%';
                tempAns = iNo1;
                LInput(Display.Text + " MOD");
            }
            Display.Text = "0";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            int iNo2 = Convert.ToInt32(Display.Text);
            string s = null;
            if (opflag == '+')
            {
                opflag = ' ';
                s = (AOP.AddX(iNo2, tempAns)).ToString();                
               
            }
            else if (opflag == '-')
            {
    
                opflag = ' ';                
                s = (AOP.SubX(tempAns,iNo2)).ToString();                
            }
            else if (opflag == '*')
            {
                opflag = ' ';                
                s = (AOP.MultX(tempAns2, iNo2)).ToString();                
            }
            else if (opflag == '/')
            {
                opflag = ' ';                
                s = (AOP.DivX(tempAns2, iNo2)).ToString();               
            }
            else if (opflag == '%')
            {
                opflag = ' ';
                s = (AOP.ModX(tempAns, iNo2)).ToString();
            }
            else if (opflag == '&')
            {
                opflag = ' ';
                s = (BO.AndX(tempAns, iNo2)).ToString();
            }
            else if (opflag == '|')
            {
                opflag = ' ';
                s = (BO.OrX(tempAns, iNo2)).ToString();
            }
            else if (opflag == '^')
            {
                opflag = ' ';
                s = (BO.XorX(tempAns, iNo2)).ToString();
            }
            TSetMask(Convert.ToInt32(s));
            Display.Text = s;
            LInput(iNo2 + " = " + Display.Text);
            SetNumbersys(s);           
            tempAns = 0;
            tempAns2 = 1;
        }

        private void Bitwise_Op(object sender, RoutedEventArgs e)
        {
            int iNo1 = Convert.ToInt32(Display.Text);            
            if (sender == AND)
            {
                opflag = '&';
                tempAns = BO.AndX(iNo1, iNo1);
                LInput(Display.Text + " &");
            }
            else if(sender == OR)
            {
                opflag = '|';
                tempAns = BO.OrX(iNo1, 0);
                LInput(Display.Text + " |");
            }
            else if (sender == XOR)
            {
                opflag = '^';
                tempAns = BO.XorX(iNo1, 0);
                LInput(Display.Text + " ^");
            }            
            Display.Text = "0";
        }

        private void NOT_Click(object sender, RoutedEventArgs e)
        {
            int iNo1 = Convert.ToInt32(Display.Text);
            LInput("~" + Display.Text);
            tempAns = BO.NotX(iNo1);
            Display.Text = Convert.ToString(tempAns);            
        }

        private void Binary_Mask(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {            
            if(PanelO.Content.Equals(">"))
            {
                this.Width = 920;
                PanelO.Content = "<";                
                History_panel.Content = HIO.PrintHistory();
            }
            else if(PanelO.Content.Equals("<"))
            {
                this.Width = 380;
                PanelO.Content = ">";
            }
        }

        private void TSetMask(int no)
        {
            BitArray b = new BitArray(32);
            b = BM.SetMask(no);           
            int[] a = { 0 };
            b.CopyTo(a, 0);
            SetNumbersys(Convert.ToString(a[0]));
            Display.Text = Convert.ToString(a[0]);

            for (int i = 0; i <= 31; i++)
            {
                if (b[i] == true)
                {
                    btn[i].Content = "1";
                    btn[i].Background = Brushes.Black;
                }
                else if (b[i] == false)
                {
                    btn[i].Content = "0";
                    btn[i].Background = Brushes.DimGray;
                }
            }
        }

        private void clear_history_Click(object sender, RoutedEventArgs e)
        {
            HIO.ClearHistory();
            History_panel.Content = HIO.PrintHistory();
        }

        private void Mask_Click(object sender, RoutedEventArgs e)
        {
            BitArray b = new BitArray(32);
            int i = 0;
            int[] a = { 0 };
            for(i = 0;i <= 31; i++)
            {
                if(sender == btn[i])
                {
                   
                    break;
                }
            }
            
            b = BM.ToggleBit(i);
            b.CopyTo(a, 0);
            TSetMask(a[0]);
        }

       
    }
}

