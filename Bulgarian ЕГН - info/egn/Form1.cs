namespace egn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTheDateOfBirthInformation();
            GetTheGenderInformation();
            GetThePlaceOfBirth();
            CheckIfItIsValid();
        }

        private void CheckIfItIsValid()
        {
            string input = inputTextbox.Text;
            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                sum += (input[i] - '0') * weights[i];
            }

            int remainder = sum % 11;
            int controlDigit = remainder == 10 ? 0 : remainder;

            if (controlDigit == (input[9] - '0'))
            {
                isValidTextbox.Text = "�������";
            }

            else
            {
                isValidTextbox.Text = "�� � �������!";
            }
        }

        private void GetTheGenderInformation()
        {
            string input = inputTextbox.Text;
            int gender = int.Parse(input.Substring(8, 1));
            genderTextbox.Text = (gender % 2 == 0) ? "���" : "����";
        }

        private void GetTheDateOfBirthInformation()
        {
            string input = inputTextbox.Text;
            int year = int.Parse(input.Substring(0, 2));
            int month = int.Parse(input.Substring(2, 2));
            int day = int.Parse(input.Substring(4, 2));

            if (month > 40)
            {
                year += 2000;
                month -= 40;
            }

            else if (month > 20)
            {
                year += 1800;
                month -= 20;
            }

            else
            {
                year += 1900;
            }

            yearTextbox.Text = year.ToString();
            monthTextbox.Text = month.ToString();
            dayTextbox.Text = day.ToString();
        }




        private void GetThePlaceOfBirth()
        {
            string input = inputTextbox.Text;
            int placeOfBirth = int.Parse(input.Substring(6, 3));

            switch (placeOfBirth)
            {
                case >= 0 and <= 43:
                    placeTextbox.Text = "�����������";
                    break;


                case >= 44 and <= 93:
                    placeTextbox.Text = "������";
                    break;


                case >= 94 and <= 139:
                    placeTextbox.Text = "�����";
                    break;


                case >= 140 and <= 169:
                    placeTextbox.Text = "������ �������";
                    break;


                case >= 170 and <= 183:
                    placeTextbox.Text = "�����";
                    break;


                case >= 184 and <= 217:
                    placeTextbox.Text = "�����";
                    break;


                case >= 218 and <= 233:
                    placeTextbox.Text = "�������";
                    break;


                case >= 234 and <= 281:
                    placeTextbox.Text = "��������";
                    break;


                case >= 282 and <= 301:
                    placeTextbox.Text = "���������";
                    break;


                case >= 302 and <= 319:
                    placeTextbox.Text = "�����";
                    break;


                case >= 320 and <= 341:
                    placeTextbox.Text = "�������";
                    break;


                case >= 342 and <= 377:
                    placeTextbox.Text = "���������";
                    break;


                case >= 378 and <= 395:
                    placeTextbox.Text = "������";
                    break;


                case >= 396 and <= 435:
                    placeTextbox.Text = "������";
                    break;


                case >= 436 and <= 501:
                    placeTextbox.Text = "�������";
                    break;


                case >= 502 and <= 527:
                    placeTextbox.Text = "�������";
                    break;


                case >= 528 and <= 555:
                    placeTextbox.Text = "����";
                    break;


                case >= 556 and <= 575:
                    placeTextbox.Text = "��������";
                    break;


                case >= 576 and <= 601:
                    placeTextbox.Text = "������";
                    break;


                case >= 602 and <= 623:
                    placeTextbox.Text = "������";
                    break;


                case >= 624 and <= 721:
                    placeTextbox.Text = "����������";
                    break;


                case >= 722 and <= 751:
                    placeTextbox.Text = "�����������";
                    break;


                case >= 752 and <= 789:
                    placeTextbox.Text = "����� ������";
                    break;


                case >= 790 and <= 821:
                    placeTextbox.Text = "������";
                    break;


                case >= 822 and <= 843:
                    placeTextbox.Text = "���������";
                    break;


                case >= 844 and <= 871:
                    placeTextbox.Text = "�������";
                    break;


                case >= 872 and <= 903:
                    placeTextbox.Text = "�����";
                    break;


                case >= 904 and <= 925:
                    placeTextbox.Text = "�����";
                    break;


                case >= 926 and <= 999:
                    placeTextbox.Text = "����/����������";
                    break;


                default:
                    Exception ex = new Exception("���������� �����!");
                    placeTextbox.Text = ex.Message;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}