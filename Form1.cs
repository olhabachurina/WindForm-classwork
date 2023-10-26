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
                        textBox2.Text = $"ќсталось {years:F2} года(лет)";
                    }
                    else if (MonthsRadioButton.Checked)
                    {
                        double months = timeDifference.TotalDays / 30.44;
                        textBox2.Text = $"ќсталось {months:F2} мес€ца(ев)";
                    }
                    else if (DaysRadioButton.Checked)
                    {
                        int days = timeDifference.Days;
                        textBox2.Text = $"ќсталось {days} дн€(дней)";
                    }
                    else if (MinutesRadioButton.Checked)
                    {
                        int minutes = (int)timeDifference.TotalMinutes;
                        textBox2.Text = $"ќсталось {minutes} минут(ы)";
                    }
                    else if (SecondsRadioButton.Checked)
                    {
                        int seconds = (int)timeDifference.TotalSeconds;
                        textBox2.Text = $"ќсталось {seconds} секунд(ы)";
                    }
                }
                else
                {
                    textBox2.Text = "¬ведите корректную дату!";
                }
            }
        }
    }
