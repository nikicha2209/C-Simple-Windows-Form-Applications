using System.Windows.Forms;
namespace test_informatika_9v_22;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();

    }
    private List<Question> questions = new List<Question>();
    private int currentQuestionIndex = 0;
    private int correctAnswers = 0;
    private int remainingTime;

    private void LoadQuestions()
    {
        string filePath = "reader.txt";
        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string questionText = line;
                        List<string> answers = new List<string>();

                        for (int i = 0; i < 4; i++)
                        {
                            line = sr.ReadLine();
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                answers.Add(line);
                            }
                        }

                        string correctAnswer = sr.ReadLine();

                        Question question = new Question(questionText, correctAnswer);
                        question.Answers.AddRange(answers);
                        questions.Add(question);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Файлът с въпросите не е намерен.");
        }
    }




    private void DisplayCurrentQuestion()
    {
        if (currentQuestionIndex >= 0 && currentQuestionIndex < questions.Count)
        {
            Question currentQuestion = questions[currentQuestionIndex];

            richTextBox1.Text = $"{currentQuestion.Text}\n";
            for (int i = 0; i < currentQuestion.Answers.Count; i++)
            {
                richTextBox1.AppendText($"{currentQuestion.Answers[i]}\n");
            }

            radioButton1.Text = "а)";
            radioButton2.Text = "б)";
            radioButton3.Text = "в)";
            radioButton4.Text = "г)";

            UpdateRemainingQuestionsLabel();
        }
    }

    private void UpdateRemainingQuestionsLabel()
    {
        int remainingQuestions = questions.Count - currentQuestionIndex;
        label4.Text = $"{remainingQuestions}";
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadQuestions();
        DisplayCurrentQuestion();
        StartTimer();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonNextQuestion_Click(object sender, EventArgs e)
    {
        string selectedAnswer = GetSelectedAnswer().Substring(0, 1);
        if (selectedAnswer != null)
        {
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                correctAnswers++;
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayCurrentQuestion();
            }
            else
            {
                MessageBox.Show($"Тестът завърши. Правилни отговори: {correctAnswers}");
            }
        }
        else
        {
            MessageBox.Show("Моля, изберете отговор.");
        }
    }

    private string GetSelectedAnswer()
    {
        if (radioButton1.Checked) return radioButton1.Text;
        if (radioButton2.Checked) return radioButton2.Text;
        if (radioButton3.Checked) return radioButton3.Text;
        if (radioButton4.Checked) return radioButton4.Text;
        return null;
    }

    private void StartTimer()
    {
        remainingTime = 20 * 60;
        timer1.Start();
    }


    private void EndTest()
    {
        MessageBox.Show($"Тестът завърши. Правилни отговори: {correctAnswers} от {questions.Count}");
        Close();
    }


    private void timer1_Tick(object sender, EventArgs e)
    {
        if (remainingTime > 0)
        {
            remainingTime--;

            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;
            label2.Text = $"{minutes}:{seconds:00}";
        }
        else
        {
            timer1.Stop();
            EndTest();
        }
    }

    class Question
    {
        public string Text { get; private set; }
        public List<string> Answers { get; private set; }

        public string CorrectAnswer { get; private set; }

        public Question(string text, string correctAnswer)
        {
            Text = text;
            Answers = new List<string>();
            CorrectAnswer = correctAnswer;
        }
    }
}