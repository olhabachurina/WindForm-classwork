namespace WindForm_classwork
{
   
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (DateTime.TryParse(textBox1.Text, out DateTime targetDate))
                {
                    TimeSpan timeDifference = targetDate - DateTime.Now;

                    if (YearsRadioButton.Checked)
                    {
                        double years = timeDifference.TotalDays / 365.25;
                        textBox2.Text = $"�������� {years:F2} ����(���)";
                    }
                    else if (MonthsRadioButton.Checked)
                    {
                        double months = timeDifference.TotalDays / 30.44;
                        textBox2.Text = $"�������� {months:F2} ������(��)";
                    }
                    else if (DaysRadioButton.Checked)
                    {
                        int days = timeDifference.Days;
                        textBox2.Text = $"�������� {days} ���(����)";
                    }
                    else if (MinutesRadioButton.Checked)
                    {
                        int minutes = (int)timeDifference.TotalMinutes;
                        textBox2.Text = $"�������� {minutes} �����(�)";
                    }
                    else if (SecondsRadioButton.Checked)
                    {
                        int seconds = (int)timeDifference.TotalSeconds;
                        textBox2.Text = $"�������� {seconds} ������(�)";
                    }
                }
                else
                {
                    textBox2.Text = "������� ���������� ����!";
                }
            }
        }
    }
