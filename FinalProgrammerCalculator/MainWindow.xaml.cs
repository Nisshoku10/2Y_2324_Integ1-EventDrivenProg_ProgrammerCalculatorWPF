using System.Windows;
using System.Windows.Controls;

namespace FinalProgrammerCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region vars
        string _input = "";
        string _hexInput = "";
        string _decInput = "";
        string _octInput = "";
        string _binInput = "";

        Button[] btnNums = new Button[10];
        int num1 = 0;
        int num2 = 0;
        int ope = -1; 
        #endregion
        #region Program Start
        public MainWindow()
        {
            InitializeComponent();
            InitializeButtons();
        }
        private void InitializeButtons()
        {
            btnNums[0] = Btn0;
            btnNums[1] = Btn1;
            btnNums[2] = Btn2;
            btnNums[3] = Btn3;
            btnNums[4] = Btn4;
            btnNums[5] = Btn5;
            btnNums[6] = Btn6;
            btnNums[7] = Btn7;
            btnNums[8] = Btn8;
            btnNums[9] = Btn9;

            for (int x = 0; x < btnNums.Length; x++)
                btnNums[x].Content = x;

            BtnAdd.Content = "+";
            BtnMin.Content = "-";
            BtnMul.Content = "x";
            BtnDiv.Content = "/";
            BtnEquals.Content = "=";

            BtnA.Content = "A";
            BtnB.Content = "B";
            BtnC.Content = "C";
            BtnD.Content = "D";
            BtnE.Content = "E";
            BtnF.Content = "F";

            BtnReset.Content = "CE";

            Btn0.IsEnabled = true;
            Btn1.IsEnabled = true;
            Btn2.IsEnabled = true;
            Btn3.IsEnabled = true;
            Btn4.IsEnabled = true;
            Btn5.IsEnabled = true;
            Btn6.IsEnabled = true;
            Btn7.IsEnabled = true;
            Btn8.IsEnabled = true;
            Btn9.IsEnabled = true;

            BtnA.IsEnabled = false;
            BtnB.IsEnabled = false;
            BtnC.IsEnabled = false;
            BtnD.IsEnabled = false;
            BtnE.IsEnabled = false;
            BtnF.IsEnabled = false;

            BtnHex.IsEnabled = true;
            BtnDec.IsEnabled = false;
            BtnOct.IsEnabled = true;
            BtnBin.IsEnabled = true;

            BtnDec.IsChecked = true;
            _input = DecBox.Text;
        }
        #endregion
        private void numberEnter(int? x, char? y)
        {
            _hexInput = HexBox.Text;
            _decInput = DecBox.Text;
            _octInput = OctBox.Text;
            _binInput = BinBox.Text;

            if (x != null)
            {
                if (BtnHex.IsChecked == true)
                {
                    _input += x;
                    _hexInput += x;
                    _decInput = Convert.ToInt32(_hexInput, 16).ToString();
                    _octInput = Convert.ToInt32(_hexInput, 16).ToString();
                    _binInput = Convert.ToString(Convert.ToInt32(_hexInput, 16), 2);
                }

                else if (BtnDec.IsChecked == true)
                {
                    _input += x;
                    _decInput += x;
                    _hexInput = Convert.ToInt32(_decInput, 10).ToString("X").ToUpper();
                    _octInput = Convert.ToInt32(_decInput, 10).ToString();
                    _binInput = Convert.ToString(Convert.ToInt32(_decInput, 10), 2);
                }

                else if (BtnOct.IsChecked == true)
                {
                    _input += x;
                    _octInput += x;
                    _decInput = Convert.ToInt32(_octInput, 8).ToString();
                    _hexInput = Convert.ToInt32(_octInput, 8).ToString("X").ToUpper();
                    _binInput = Convert.ToString(Convert.ToInt32(_octInput, 8), 2);
                }

                else if (BtnBin.Content.ToString() == "BIN")
                {
                    _input += x;
                    _binInput += x;
                    _decInput = Convert.ToInt32(_binInput, 2).ToString();
                    _hexInput = Convert.ToInt32(_binInput, 2).ToString("X").ToUpper();
                    _octInput = Convert.ToInt32(_binInput, 2).ToString();
                }

                HexBox.Text = _hexInput;
                DecBox.Text = _decInput;
                OctBox.Text = _octInput;
                BinBox.Text = _binInput;

                if (ope == -1)
                {
                    num1 = Convert.ToInt32(_decInput);
                }
                else
                {
                    num2 = Convert.ToInt32(_decInput);
                }
            }
            if (y != null)
            {
                if (BtnHex.IsChecked == true)
                {
                    _input += y;
                    _hexInput += y;
                    _decInput = Convert.ToInt32(_hexInput, 16).ToString();
                    _octInput = Convert.ToInt32(_hexInput, 16).ToString();
                    _binInput = Convert.ToString(Convert.ToInt32(_hexInput, 16), 2);
                }

                else if (BtnDec.IsChecked == true)
                {
                    _input += y;
                    _decInput += y;
                    _hexInput = Convert.ToInt32(_decInput, 10).ToString("X").ToUpper();
                    _octInput = Convert.ToInt32(_decInput, 10).ToString();
                    _binInput = Convert.ToString(Convert.ToInt32(_decInput, 10), 2);
                }

                else if(BtnOct.IsChecked == true)
                {
                    _input += y;
                    _octInput += y;
                    _decInput = Convert.ToInt32(_octInput, 8).ToString();
                    _hexInput = Convert.ToInt32(_octInput, 8).ToString("X").ToUpper();
                    _binInput = Convert.ToString(Convert.ToInt32(_octInput, 8), 2);
                }

                else if (BtnBin.IsChecked == true)
                {
                    _input += y;
                    _binInput += y;
                    _decInput = Convert.ToInt32(_binInput, 2).ToString();
                    _hexInput = Convert.ToInt32(_binInput, 2).ToString("X").ToUpper();
                    _octInput = Convert.ToInt32(_binInput, 2).ToString();
                }

                HexBox.Text = _hexInput;
                DecBox.Text = _decInput;
                OctBox.Text = _octInput;
                BinBox.Text = _binInput;

                if (ope == -1)
                {
                    num1 = Convert.ToInt32(_decInput);
                }
                else
                {
                    num2 = Convert.ToInt32(_decInput);
                    if (ope != -1)
                    {
                        CaseOpe();
                    }
                }
            }
        }
        #region KeypadEvents
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(9, null);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(8, null);
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(7, null);
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(6, null);                  
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(5, null);
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(4, null);
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(3, null);
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(2, null);
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(1, null);
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(0, null);
        }
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(null, 'A');

        }
        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(null, 'B');

        }
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(null, 'C');

        }
        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(null, 'D');

        }
        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(null, 'E');

        }
        private void btnF_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(null, 'F');
        }
        #endregion
        #region OperationEvents
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ope = 0;
            HexBox.Text = "";
            DecBox.Text = "";
            OctBox.Text = "";
            BinBox.Text = "";
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            ope = 1;
            HexBox.Text = "";
            DecBox.Text = "";
            OctBox.Text = "";
            BinBox.Text = "";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            ope = 2;
            HexBox.Text = "";
            DecBox.Text = "";
            OctBox.Text = "";
            BinBox.Text = "";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            ope = 3;
            HexBox.Text = "";
            DecBox.Text = "";
            OctBox.Text = "";
            BinBox.Text = "";
        }
        #endregion
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            CaseOpe();
            
            _input = num1.ToString();
            _hexInput = Convert.ToString(num1, 16);
            _decInput = num1.ToString();
            _octInput = Convert.ToString(num1, 8);
            _binInput = Convert.ToString(num1, 2);

            HexBox.Text = _hexInput;
            DecBox.Text = _decInput;
            OctBox.Text = _octInput;
            BinBox.Text = _binInput;

            ope = -1;
        }
        #region Calculator States
        private void BtnHex_Click(object sender, RoutedEventArgs e)
        {
            Btn0.IsEnabled = true;
            Btn1.IsEnabled = true;
            Btn2.IsEnabled = true;
            Btn3.IsEnabled = true;
            Btn4.IsEnabled = true;
            Btn5.IsEnabled = true;
            Btn6.IsEnabled = true;
            Btn7.IsEnabled = true;
            Btn8.IsEnabled = true;
            Btn9.IsEnabled = true;

            BtnA.IsEnabled = true;
            BtnB.IsEnabled = true;
            BtnC.IsEnabled = true;
            BtnD.IsEnabled = true;
            BtnE.IsEnabled = true;
            BtnF.IsEnabled = true;

            BtnHex.IsEnabled = false;
            BtnDec.IsEnabled = true;
            BtnOct.IsEnabled = true;
            BtnBin.IsEnabled = true;

            _input = _hexInput;
            HexBox.Text = _input;
        }
        private void BtnDec_Click(object sender, RoutedEventArgs e)
        {
            Btn0.IsEnabled = true;
            Btn1.IsEnabled = true;
            Btn2.IsEnabled = true;
            Btn3.IsEnabled = true;
            Btn4.IsEnabled = true;
            Btn5.IsEnabled = true;
            Btn6.IsEnabled = true;
            Btn7.IsEnabled = true;
            Btn8.IsEnabled = true;
            Btn9.IsEnabled = true;

            BtnA.IsEnabled = false;
            BtnB.IsEnabled = false;
            BtnC.IsEnabled = false;
            BtnD.IsEnabled = false;
            BtnE.IsEnabled = false;
            BtnF.IsEnabled = false;

            BtnHex.IsEnabled = true;
            BtnDec.IsEnabled = false;
            BtnOct.IsEnabled = true;
            BtnBin.IsEnabled = true;

            _input = _decInput;
            DecBox.Text = _input;
        }
        private void BtnOct_Click(object sender, RoutedEventArgs e)
        {
            Btn0.IsEnabled = true;
            Btn1.IsEnabled = true;
            Btn2.IsEnabled = true;
            Btn3.IsEnabled = true;
            Btn4.IsEnabled = true;
            Btn5.IsEnabled = true;
            Btn6.IsEnabled = true;
            Btn7.IsEnabled = true;
            Btn8.IsEnabled = false;
            Btn9.IsEnabled = false;

            BtnA.IsEnabled = false;
            BtnB.IsEnabled = false;
            BtnC.IsEnabled = false;
            BtnD.IsEnabled = false;
            BtnE.IsEnabled = false;
            BtnF.IsEnabled = false;

            BtnHex.IsEnabled = true;
            BtnDec.IsEnabled = true;
            BtnOct.IsEnabled = false;
            BtnBin.IsEnabled = true;

            _input = _octInput;
            OctBox.Text = _input;
        }
        private void BtnBin_Click(object sender, RoutedEventArgs e)
        {
            Btn0.IsEnabled = true;
            Btn1.IsEnabled = true;
            Btn2.IsEnabled = false;
            Btn3.IsEnabled = false;
            Btn4.IsEnabled = false;
            Btn5.IsEnabled = false;
            Btn6.IsEnabled = false;
            Btn7.IsEnabled = false;
            Btn8.IsEnabled = false;
            Btn9.IsEnabled = false;

            BtnA.IsEnabled = false;
            BtnB.IsEnabled = false;
            BtnC.IsEnabled = false;
            BtnD.IsEnabled = false;
            BtnE.IsEnabled = false;
            BtnF.IsEnabled = false;

            BtnHex.IsEnabled = true;
            BtnDec.IsEnabled = true;
            BtnOct.IsEnabled = true;
            BtnBin.IsEnabled = false;

            _input = _binInput;
            BinBox.Text = _input;
        }
        #endregion
        private void ResetButton(object sender, RoutedEventArgs e)
        {
            _input = "";
            _hexInput = "";
            _decInput = "";
            _octInput = "";
            _binInput = "";
            num1 = 0;
            num2 = 0;
            ope = -1;

            HexBox.Text = "";
            DecBox.Text = "";
            OctBox.Text = "";
            BinBox.Text = "";
        }
        private void CaseOpe()
        {
            switch (ope)
            {
                case 0:
                    num1 += num2;
                    break;
                case 1:
                    num1 -= num2;
                    break;
                case 2:
                    num1 *= num2;
                    break;
                case 3:
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by 0.");
                        return;
                    }

                    num1 /= num2;
                    break;
            }
        }
    }
}