using System;
using System.Windows.Forms;
using MyCalculator;
namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;
        private string lastOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            // An operator was pressed; perform the last operation and store the new operator.
            char operation = (sender as Button).Text[0];
            string lastoperationName = (sender as Button).Name;
            ICalculator calc ;
            if (lastOperation == "C")
            {
                accumulator = 0;
            }
            else
            {
                double currentValue = double.Parse(Display.Text);
                switch (lastOperation)
                {
                    //case '+': accumulator += currentValue; break;
                    case "Add":
                        calc = new Add();
                        accumulator = calc.Calculate(new CalculatorContext(accumulator, currentValue));
                        break;

                    case "Substract":
                        calc = new Substract();
                        accumulator = calc.Calculate(new CalculatorContext(accumulator, currentValue));
                        break;
                    case "Multiply": accumulator = currentValue; break;
                    case "Divide": accumulator = currentValue; break;
                    case "Square":
                        calc = new Square();
                        accumulator = calc.Calculate(new CalculatorContext(accumulator, currentValue));
                        break;


                    default: accumulator = currentValue; break;
                }
            }

            lastOperation = lastoperationName;
            Display.Text = lastoperationName == "Equal" ? accumulator.ToString() : "0";
        }

        private void Number_Pressed(object sender, EventArgs e)
        {
            // Add it to the display.
            string number = (sender as Button).Text;
            Display.Text = Display.Text == "0" ? number : Display.Text + number;
        }

    }
}
