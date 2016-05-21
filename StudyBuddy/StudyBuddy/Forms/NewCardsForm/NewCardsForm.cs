using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace StudyBuddy
{
    public partial class NewCardsForm : Form
    {
        public NewCardsForm()
        {
            InitializeComponent();
        }

        string currentQuizFile = Properties.Settings.Default.QuizDirectory + @"\" + Properties.Settings.Default.currentSelectedQuiz + ".xml";
        XmlDocument xmlDoc = new XmlDocument();

        private void checkBackground()
        {
            if (Properties.Settings.Default.nightMode)
            {
                BackColor = Color.Black;
                newQuizDescriptionLabel.BackColor = Color.Black;
                newQuizDescriptionLabel.ForeColor = Color.White;
                quizNameLabel.BackColor = Color.Black;
                quizNameLabel.ForeColor = Color.White;
                numberOfQuestionsLabel.BackColor = Color.Black;
                numberOfQuestionsLabel.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                newQuizDescriptionLabel.BackColor = Color.White;
                newQuizDescriptionLabel.ForeColor = Color.Black;
                quizNameLabel.BackColor = Color.White;
                quizNameLabel.ForeColor = Color.Black;
                numberOfQuestionsLabel.BackColor = Color.White;
                numberOfQuestionsLabel.ForeColor = Color.Black;
            }
        }

        private bool quizHasHints()
        {
            xmlDoc.Load(currentQuizFile); // Loads the XML
            if (xmlDoc.SelectSingleNode("StudyBuddy/HintInfo") == null)
                return false;
            return true;
        }

        private void NewCardsForm_Load(object sender, EventArgs e)
        {
            checkBackground();
            if (Properties.Settings.Default.backButtonPressed || Properties.Settings.Default.editMode)
            {
                xmlDoc.Load(currentQuizFile); // Loads the XML
                quizNameTextBox.Text = xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/TestName").InnerText;
                questionNumbersComboBox.Text = xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText;
                hintCheckBox.Checked = quizHasHints();
            }
            else
            {
                questionNumbersComboBox.SelectedIndex = 0;
            }
        }

        private void cardGroupNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.QuizDirectory + @"\" + quizNameTextBox.Text + ".xml") && quizNameTextBox.Text != Properties.Settings.Default.currentSelectedQuiz)
            {
                nextButton.Enabled = false;
                alreadyExistsLabel.Text = "The quiz '" + quizNameTextBox.Text + "' already exists.";
                alreadyExistsLabel.Visible = true;
            }
            else if (quizNameTextBox.Text == "")
            {
                nextButton.Enabled = false;
                alreadyExistsLabel.Text = "Please enter a valid quiz name.";
                alreadyExistsLabel.Visible = true;
            }
            else
            {
                nextButton.Enabled = true;
                alreadyExistsLabel.Visible = false;
            }
        }

        private void createQuiz()
        {
            if (!File.Exists(Properties.Settings.Default.QuizDirectory + @"\" + quizNameTextBox.Text + ".xml"))
            {
                XmlTextWriter xWriter = new XmlTextWriter(Properties.Settings.Default.QuizDirectory + @"\" + quizNameTextBox.Text + ".xml", Encoding.UTF8);
                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement("StudyBuddy"); // <StudyBuddy>
                xWriter.WriteStartElement("TestInfo"); // <TestInfo>
                xWriter.WriteStartElement("TestName"); // <TestName>
                xWriter.WriteString(quizNameTextBox.Text); // quizNameNameTextBox.Text
                xWriter.WriteEndElement(); // </TestName>
                xWriter.WriteStartElement("NumberOfTestQuestions"); // <NumberOfTestQuestions>
                xWriter.WriteString(questionNumbersComboBox.Text); // questionNumbersComboBox.Text
                xWriter.WriteEndElement(); // </NumberOfTestQuestions>
                xWriter.WriteEndElement(); // </TestInfo>

                if (questionNumbersComboBox.SelectedIndex >= 0)
                {
                    // Write the questions.
                    xWriter.WriteStartElement("QuestionInfo"); // <QuestionInfo>
                    xWriter.WriteStartElement("Question1"); // <Question1>
                    xWriter.WriteEndElement(); // </Question1>

                    if (questionNumbersComboBox.SelectedIndex >= 1)
                    {
                        xWriter.WriteStartElement("Question2"); // <Question2>
                        xWriter.WriteEndElement(); // </Question2>

                        if (questionNumbersComboBox.SelectedIndex >= 2)
                        {
                            xWriter.WriteStartElement("Question3"); // <Question3>
                            xWriter.WriteEndElement(); // </Question3>

                            if (questionNumbersComboBox.SelectedIndex >= 3)
                            {
                                xWriter.WriteStartElement("Question4"); // <Question4>
                                xWriter.WriteEndElement(); // </Question4>

                                if (questionNumbersComboBox.SelectedIndex >= 4)
                                {
                                    xWriter.WriteStartElement("Question5"); // <Question5>
                                    xWriter.WriteEndElement(); // </Question5>

                                    if (questionNumbersComboBox.SelectedIndex >= 5)
                                    {
                                        xWriter.WriteStartElement("Question6"); // <Question6>
                                        xWriter.WriteEndElement(); // </Question6>

                                        if (questionNumbersComboBox.SelectedIndex >= 6)
                                        {
                                            xWriter.WriteStartElement("Question7"); // <Question7>
                                            xWriter.WriteEndElement(); // </Question7>

                                            if (questionNumbersComboBox.SelectedIndex >= 7)
                                            {
                                                xWriter.WriteStartElement("Question8"); // <Question8>
                                                xWriter.WriteEndElement(); // </Question8>

                                                if (questionNumbersComboBox.SelectedIndex >= 8)
                                                {
                                                    xWriter.WriteStartElement("Question9"); // <Question9>
                                                    xWriter.WriteEndElement(); // </Question9>

                                                    if (questionNumbersComboBox.SelectedIndex == 9)
                                                    {
                                                        xWriter.WriteStartElement("Question10"); // <Question10>
                                                        xWriter.WriteEndElement(); // </Question10>
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    xWriter.WriteEndElement(); // </QuestionInfo>

                    // Write the answers
                    xWriter.WriteStartElement("AnswerInfo");
                    xWriter.WriteStartElement("Answer1");
                    xWriter.WriteEndElement(); // </Answer1>
                    if (questionNumbersComboBox.SelectedIndex >= 1)
                    {
                        xWriter.WriteStartElement("Answer2"); // <Answer2>
                        xWriter.WriteEndElement(); // </Answer2>

                        if (questionNumbersComboBox.SelectedIndex >= 2)
                        {
                            xWriter.WriteStartElement("Answer3"); // <Answer3>
                            xWriter.WriteEndElement(); // </Answer3>

                            if (questionNumbersComboBox.SelectedIndex >= 3)
                            {
                                xWriter.WriteStartElement("Answer4"); // <Answer4>
                                xWriter.WriteEndElement(); // </Answer4>

                                if (questionNumbersComboBox.SelectedIndex >= 4)
                                {
                                    xWriter.WriteStartElement("Answer5"); // <Answer5>
                                    xWriter.WriteEndElement(); // </Answer5>

                                    if (questionNumbersComboBox.SelectedIndex >= 5)
                                    {
                                        xWriter.WriteStartElement("Answer6"); // <Answer6>
                                        xWriter.WriteEndElement(); // </Answer6>

                                        if (questionNumbersComboBox.SelectedIndex >= 6)
                                        {
                                            xWriter.WriteStartElement("Answer7"); // <Answer7>
                                            xWriter.WriteEndElement(); // </Answer7>

                                            if (questionNumbersComboBox.SelectedIndex >= 7)
                                            {
                                                xWriter.WriteStartElement("Answer8"); // <Answer8>
                                                xWriter.WriteEndElement(); // </Answer8>

                                                if (questionNumbersComboBox.SelectedIndex >= 8)
                                                {
                                                    xWriter.WriteStartElement("Answer9"); // <Answer9>
                                                    xWriter.WriteEndElement(); // </Answer9>

                                                    if (questionNumbersComboBox.SelectedIndex == 9)
                                                    {
                                                        xWriter.WriteStartElement("Answer10"); // <Answer10>
                                                        xWriter.WriteEndElement(); // </Answer10>
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    xWriter.WriteEndElement(); // </AnswerInfo>
                    if (hintCheckBox.Checked)
                    {
                        xWriter.WriteStartElement("HintInfo");
                        if (questionNumbersComboBox.SelectedIndex >= 0)
                        {
                            xWriter.WriteStartElement("Hint1");
                            xWriter.WriteEndElement();
                            if (questionNumbersComboBox.SelectedIndex >= 1)
                            {
                                xWriter.WriteStartElement("Hint2");
                                xWriter.WriteEndElement();
                                if (questionNumbersComboBox.SelectedIndex >= 2)
                                {
                                    xWriter.WriteStartElement("Hint3");
                                    xWriter.WriteEndElement();
                                    if (questionNumbersComboBox.SelectedIndex >= 3)
                                    {
                                        xWriter.WriteStartElement("Hint4");
                                        xWriter.WriteEndElement();
                                        if (questionNumbersComboBox.SelectedIndex >= 4)
                                        {
                                            xWriter.WriteStartElement("Hint5");
                                            xWriter.WriteEndElement();
                                            if (questionNumbersComboBox.SelectedIndex >= 5)
                                            {
                                                xWriter.WriteStartElement("Hint6");
                                                xWriter.WriteEndElement();
                                                if (questionNumbersComboBox.SelectedIndex >= 6)
                                                {
                                                    xWriter.WriteStartElement("Hint7");
                                                    xWriter.WriteEndElement();
                                                    if (questionNumbersComboBox.SelectedIndex >= 7)
                                                    {
                                                        xWriter.WriteStartElement("Hint8");
                                                        xWriter.WriteEndElement();
                                                        if (questionNumbersComboBox.SelectedIndex >= 8)
                                                        {
                                                            xWriter.WriteStartElement("Hint9");
                                                            xWriter.WriteEndElement();
                                                            if (questionNumbersComboBox.SelectedIndex >= 9)
                                                            {
                                                                xWriter.WriteStartElement("Hint10");
                                                                xWriter.WriteEndElement();
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        xWriter.WriteEndElement();
                    }
                }
                xWriter.Close();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.editMode)
                createQuiz();
            else if (Properties.Settings.Default.editMode)
            {
                currentQuizFile = Properties.Settings.Default.QuizDirectory + @"\" + quizNameTextBox.Text + ".xml";

                // If the user has changed the name, we will need to override the old xml file with the new name.
                if (xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/TestName").InnerText != quizNameTextBox.Text)
                {
                    xmlDoc.Load(currentQuizFile);
                    File.Move(currentQuizFile, Properties.Settings.Default.QuizDirectory + @"\" + quizNameTextBox.Text + ".xml");
                    xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/TestName").InnerText = quizNameTextBox.Text;
                    xmlDoc.Save(currentQuizFile);
                }
                // TODO: Just make a new XML at this point, instead of doing surgery on the XML file.
                if (xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText != questionNumbersComboBox.Text)
                {
                    // Get a copy of all of the questions/answers.
                    // First Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question1") != null)
                        Properties.Settings.Default.question1Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question1").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer1") != null)
                        Properties.Settings.Default.answer1Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer1").InnerText;

                    // Second Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question2") != null)
                        Properties.Settings.Default.question2Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question2").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer2") != null)
                        Properties.Settings.Default.answer2Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer2").InnerText;

                    // Third Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question3") != null)
                        Properties.Settings.Default.question3Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question3").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer3") != null)
                        Properties.Settings.Default.answer3Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer3").InnerText;

                    // Fourth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question4") != null)
                        Properties.Settings.Default.question4Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question4").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer4") != null)
                        Properties.Settings.Default.answer4Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer4").InnerText;

                    // Fifth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question5") != null)
                        Properties.Settings.Default.question5Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question5").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer5") != null)
                        Properties.Settings.Default.answer5Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer5").InnerText;

                    // Sixth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question6") != null)
                        Properties.Settings.Default.question6Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question6").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer6") != null)
                        Properties.Settings.Default.answer6Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer6").InnerText;

                    // Seventh Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question7") != null)
                        Properties.Settings.Default.question7Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question7").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer7") != null)
                        Properties.Settings.Default.answer7Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer7").InnerText;

                    // Eighth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question8") != null)
                        Properties.Settings.Default.question8Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question8").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer6") != null)
                        Properties.Settings.Default.answer8Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer8").InnerText;

                    // Ninth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question9") != null)
                        Properties.Settings.Default.question9Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question9").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer9") != null)
                        Properties.Settings.Default.answer9Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer9").InnerText;

                    // Tenth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question10") != null)
                        Properties.Settings.Default.question10Save = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question10").InnerText;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer10") != null)
                        Properties.Settings.Default.answer10Save = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer10").InnerText;
                    Properties.Settings.Default.Save();

                    File.Delete(Properties.Settings.Default.QuizDirectory + @"\" + quizNameTextBox.Text + ".xml");
                    createQuiz();
                    string textBoxInfo = quizNameTextBox.Text;
                    currentQuizFile = Properties.Settings.Default.QuizDirectory + @"\" + textBoxInfo + ".xml";
                    xmlDoc.Load(currentQuizFile);

                    // Load the questions/answers to the new xml file.
                    // First Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question1") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question1").InnerText = Properties.Settings.Default.question1Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer1") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer1").InnerText = Properties.Settings.Default.answer1Save;

                    // Second Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question2") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question2").InnerText = Properties.Settings.Default.question2Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer2") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer2").InnerText = Properties.Settings.Default.answer2Save;

                    // Third Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question3") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question3").InnerText = Properties.Settings.Default.question3Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer3") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer3").InnerText = Properties.Settings.Default.answer3Save;

                    // Fourth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question4") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question4").InnerText = Properties.Settings.Default.question4Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer4") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer4").InnerText = Properties.Settings.Default.answer4Save;

                    // Fifth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question5") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question5").InnerText = Properties.Settings.Default.question5Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer5") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer5").InnerText = Properties.Settings.Default.answer5Save;

                    // Sixth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question6") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question6").InnerText = Properties.Settings.Default.question6Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer6") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer6").InnerText = Properties.Settings.Default.answer6Save;

                    // Seventh Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question7") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question7").InnerText = Properties.Settings.Default.question7Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer7") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer7").InnerText = Properties.Settings.Default.answer7Save;

                    // Eighth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question8") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question8").InnerText = Properties.Settings.Default.question8Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer8") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer8").InnerText = Properties.Settings.Default.answer8Save;

                    // Ninth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question9") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question9").InnerText = Properties.Settings.Default.question9Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer9") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer9").InnerText = Properties.Settings.Default.answer9Save;

                    // Tenth Question/Answer
                    if (xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question10") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question10").InnerText = Properties.Settings.Default.question10Save;
                    if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer10") != null)
                        xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer10").InnerText = Properties.Settings.Default.answer10Save;

                    xmlDoc.Save(currentQuizFile);
                }
            }
            clearAllQuestions();
            Properties.Settings.Default.currentSelectedQuiz = quizNameTextBox.Text;
            Properties.Settings.Default.Save();
            Dispose();
            NewQuestionsForm nqf = new NewQuestionsForm();
            nqf.ShowDialog();
        }

        private void NewCardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.backButtonPressed = false;
            Properties.Settings.Default.currentSelectedQuiz = null;
            Properties.Settings.Default.Save();
        }

        private void clearAllQuestions()
        {
            Properties.Settings.Default.question1Save = null;
            Properties.Settings.Default.answer1Save = null;
            Properties.Settings.Default.question2Save = null;
            Properties.Settings.Default.answer2Save = null;
            Properties.Settings.Default.question3Save = null;
            Properties.Settings.Default.answer3Save = null;
            Properties.Settings.Default.question4Save = null;
            Properties.Settings.Default.answer4Save = null;
            Properties.Settings.Default.question5Save = null;
            Properties.Settings.Default.answer5Save = null;
            Properties.Settings.Default.question6Save = null;
            Properties.Settings.Default.answer6Save = null;
            Properties.Settings.Default.question7Save = null;
            Properties.Settings.Default.answer7Save = null;
            Properties.Settings.Default.question8Save = null;
            Properties.Settings.Default.answer8Save = null;
            Properties.Settings.Default.question9Save = null;
            Properties.Settings.Default.answer9Save = null;
            Properties.Settings.Default.question10Save = null;
            Properties.Settings.Default.answer10Save = null;
            Properties.Settings.Default.Save();
        }
    }
}
