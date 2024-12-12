namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double currentValue = 0; // Stores the current value of the calculator
        private string currentOperation = ""; // Stores the current operation (+, -, *, /)
        private bool isOperationPerformed = false; // Flag to handle multiple number inputs
        private Button currentOperationButton = null; // Track the current operation button

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0"; // Set initial text box value to 0
        }

        // Method to highlight the selected operation button
        private void HighlightOperationButton(Button selectedButton)
        {
            if (currentOperationButton != null)
            {
                currentOperationButton.BackColor = SystemColors.Control;
                currentOperationButton.ForeColor = SystemColors.ControlText;
            }

            currentOperationButton = selectedButton;

            currentOperationButton.BackColor = Color.LightBlue; // Highlight color
            currentOperationButton.ForeColor = Color.White;
        }

        // Button click handlers for numbers
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }

            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text += button.Text;

            // Reset operation button color when a number is clicked
            if (currentOperationButton != null)
            {
                currentOperationButton.BackColor = SystemColors.Control;
                currentOperationButton.ForeColor = SystemColors.ControlText;
            }
        }

        // Button click handlers for operations
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperation = button.Text;
            currentValue = Double.Parse(textBox1.Text);
            isOperationPerformed = true;

            // Highlight the selected operation button
            HighlightOperationButton(button);
        }

        // Button click handler for equals
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double newValue = Double.Parse(textBox1.Text);

            switch (currentOperation)
            {
                case "+":
                    textBox1.Text = (currentValue + newValue).ToString();
                    break;
                case "-":
                    textBox1.Text = (currentValue - newValue).ToString();
                    break;
                case "*":
                    textBox1.Text = (currentValue * newValue).ToString();
                    break;
                case "/":
                    if (newValue != 0)
                        textBox1.Text = (currentValue / newValue).ToString();
                    else
                        textBox1.Text = "Cannot divide by zero";
                    break;
            }

            currentOperation = ""; // Reset the operation
            isOperationPerformed = false;

            // Reset button highlighting after the operation is complete
            if (currentOperationButton != null)
            {
                currentOperationButton.BackColor = SystemColors.Control;
                currentOperationButton.ForeColor = SystemColors.ControlText;
            }
        }

        // Button click handler for clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isOperationPerformed = false;

            // Reset button highlighting after clearing
            if (currentOperationButton != null)
            {
                currentOperationButton.BackColor = SystemColors.Control;
                currentOperationButton.ForeColor = SystemColors.ControlText;
            }
        }

        // Operation buttons click handlers
        private void button10_Click(object sender, EventArgs e) { btnOperation_Click(sender, e); } // +
        private void button11_Click(object sender, EventArgs e) { btnOperation_Click(sender, e); } // -
        private void button12_Click(object sender, EventArgs e) { btnOperation_Click(sender, e); } // *
        private void button16_Click(object sender, EventArgs e) { btnOperation_Click(sender, e); } // /

        // Number buttons click handlers
        private void button1_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 1
        private void button2_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 2
        private void button3_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 3
        private void button4_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 4
        private void button5_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 5
        private void button6_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 6
        private void button7_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 7
        private void button8_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 8
        private void button9_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 9
        private void button14_Click(object sender, EventArgs e) { btnNumber_Click(sender, e); } // 0
    }
}
