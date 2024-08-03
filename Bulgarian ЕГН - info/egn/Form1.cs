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
                isValidTextbox.Text = "Валидно";
            }

            else
            {
                isValidTextbox.Text = "Не е валидно!";
            }
        }

        private void GetTheGenderInformation()
        {
            string input = inputTextbox.Text;
            int gender = int.Parse(input.Substring(8, 1));
            genderTextbox.Text = (gender % 2 == 0) ? "Мъж" : "Жена";
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
                    placeTextbox.Text = "Благоевград";
                    break;


                case >= 44 and <= 93:
                    placeTextbox.Text = "Бургас";
                    break;


                case >= 94 and <= 139:
                    placeTextbox.Text = "Варна";
                    break;


                case >= 140 and <= 169:
                    placeTextbox.Text = "Велико Търново";
                    break;


                case >= 170 and <= 183:
                    placeTextbox.Text = "Видин";
                    break;


                case >= 184 and <= 217:
                    placeTextbox.Text = "Враца";
                    break;


                case >= 218 and <= 233:
                    placeTextbox.Text = "Габрово";
                    break;


                case >= 234 and <= 281:
                    placeTextbox.Text = "Кърджали";
                    break;


                case >= 282 and <= 301:
                    placeTextbox.Text = "Кюстендил";
                    break;


                case >= 302 and <= 319:
                    placeTextbox.Text = "Ловеч";
                    break;


                case >= 320 and <= 341:
                    placeTextbox.Text = "Монтана";
                    break;


                case >= 342 and <= 377:
                    placeTextbox.Text = "Пазарджик";
                    break;


                case >= 378 and <= 395:
                    placeTextbox.Text = "Перник";
                    break;


                case >= 396 and <= 435:
                    placeTextbox.Text = "Плевен";
                    break;


                case >= 436 and <= 501:
                    placeTextbox.Text = "Пловдив";
                    break;


                case >= 502 and <= 527:
                    placeTextbox.Text = "Разград";
                    break;


                case >= 528 and <= 555:
                    placeTextbox.Text = "Русе";
                    break;


                case >= 556 and <= 575:
                    placeTextbox.Text = "Силистра";
                    break;


                case >= 576 and <= 601:
                    placeTextbox.Text = "Сливен";
                    break;


                case >= 602 and <= 623:
                    placeTextbox.Text = "Смолян";
                    break;


                case >= 624 and <= 721:
                    placeTextbox.Text = "София–град";
                    break;


                case >= 722 and <= 751:
                    placeTextbox.Text = "София–окръг";
                    break;


                case >= 752 and <= 789:
                    placeTextbox.Text = "Стара Загора";
                    break;


                case >= 790 and <= 821:
                    placeTextbox.Text = "Добрич";
                    break;


                case >= 822 and <= 843:
                    placeTextbox.Text = "Търговище";
                    break;


                case >= 844 and <= 871:
                    placeTextbox.Text = "Хасково";
                    break;


                case >= 872 and <= 903:
                    placeTextbox.Text = "Шумен";
                    break;


                case >= 904 and <= 925:
                    placeTextbox.Text = "Ямбол";
                    break;


                case >= 926 and <= 999:
                    placeTextbox.Text = "Друг/Неизвестен";
                    break;


                default:
                    Exception ex = new Exception("Неправилен номер!");
                    placeTextbox.Text = ex.Message;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}