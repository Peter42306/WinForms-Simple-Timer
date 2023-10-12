namespace WinFormsAppSimpleTimer
{
    public partial class Form1 : Form
    {
        
        private int remainingSeconds = 0; // Initialize the remaining seconds for the countdown timer
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Set the timer interval to 1000 milliseconds (1 second)
            timer1.Tick += Timer1_Tick; // Attach the Timer1_Tick method to the Tick event of timer1
            buttonStart.Click += ButtonStart_Click; // Attach the ButtonStart_Click method to the Click event of buttonStart
            buttonStop.Click += ButtonStop_Click; // Attach the ButtonStop_Click method to the Click event of buttonStop
        }

        // This method is called on each tick of the timer (every 1 second)
        private void Timer1_Tick(object? sender, EventArgs e)
        {
            // If there are remaining seconds to count down
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                textBox1.Text = remainingSeconds.ToString();// Update the text in textBox1 to show the remaining seconds
            }
            else
            {
                timer1.Stop();// Stop the timer when the countdown is over
                MessageBox.Show(this, "Timer is over", "Time notification", MessageBoxButtons.OK, MessageBoxIcon.Information);// Show a message box indicating that the timer is over      
            }
        }

        // This method is called when the STOP button is clicked
        private void ButtonStop_Click(object? sender, EventArgs e)
        {
            timer1.Stop(); // Stop the countdown timer
        }

        // This method is called when the START button is clicked
        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            remainingSeconds = (int)numericUpDown1.Value;// Get the number of seconds from the numericUpDown control
            timer1.Start();// Start the timer to begin the countdown
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}