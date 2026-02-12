namespace My_Assembly_Code
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
           
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string[] user_input = input.Text.Split(' '); // (chris) Read from input textbox & assign split strings to user_input
            foreach (var thing in user_input)
            {
                MessageBox.Show($"Substring: {thing}"); // (chris) DEBUG: show values of user_input       
            }
        }
    }
}
