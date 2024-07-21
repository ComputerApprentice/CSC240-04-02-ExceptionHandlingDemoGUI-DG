namespace CSC240_04_02_ExceptionHandlingDemoGUI_DG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Number Converted Successfully.");
            }
            catch
            {
                MessageBox.Show("Entered text is not a number, please retry.");
                textBox1.Text = "";
        }
    }
}
