using System.Diagnostics;

namespace OOP_EXAM
{
    internal class Program
    {
        #region Define Class For Answer
        public class Answer : ICloneable
        {
            public int AnswerId { get; set; }
            public string AnswerText { get; set; }

            public Answer(int answerId, string answerText)
            {
                AnswerId = answerId;
                AnswerText = answerText;
            }

            public override string ToString()
            {
                return $"{AnswerId}: {AnswerText}";
            }

            public object Clone()
            {
                return new Answer(AnswerId, AnswerText);
            }
        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------//
        #region . Design a Class to represent the Question Object, Question is consisting of: a.Header of the questionb.Body of the question c.Mark
        /* this Clas will be abstract as there will be no use for it as implimentation will be assgined in the inherated chlids*/

        // Base Question Class
        public abstract class Question : ICloneable, IComparable<Question>
        {

            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }

            public Answer[] AnswerList { get; set; }
            public int RightAnswer { get; set; }

            protected Question(string header, string body, int mark, int answerCount)
            {
                Header = header;
                Body = body;
                Mark = mark;
                AnswerList = new Answer[answerCount];

            }
            public abstract string ToString();
           
            public abstract void DisplayQuestion();

            public abstract int CompareTo(Question other);


            public abstract object Clone();
        }



        /* **************************************** Chlid TrueFalseQuestion Class ************************************   */

        public class TrueFalseQuestion : Question
        {
            /* here the count of answers is only 2 T/F  So there are no need to ask user about them */
            public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark, 2)
            {
                AnswerList[0] = new Answer(1, "True");
                AnswerList[1] = new Answer(2, "False");
                /* only two available answers */
            }

            public override void DisplayQuestion()
            {
                Console.WriteLine($" {Header} __________(Mark: {Mark})");
                Console.WriteLine(Body);
                foreach (var answer in AnswerList)
                {
                    Console.WriteLine(answer);
                }
            }

            public override object Clone()
            {
                TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(Header, Body, Mark);
                trueFalseQuestion.AnswerList = (Answer[])this.AnswerList.Clone();
                trueFalseQuestion.RightAnswer = this.RightAnswer;
                return trueFalseQuestion;
            }
            public override int CompareTo(Question other)
            {

                if (other == null) return -1; // Not Equal 

                if (other.RightAnswer == this.RightAnswer) return 1;//  Equal 
                else return -1;// Not Equal 



            }
            public override string ToString()
            {
                return $"{Header} (Mark: {Mark})";
            }
        }
        /* **************************************** Chlid TrueFalseQuestion Class ************************************   */


        public class MCQquestion : Question
        {
            /* here i do not know the count of asnwers  */
            public MCQquestion(string header, string body, int mark, int answerCount) : base(header, body, mark, answerCount) { }

            public override void DisplayQuestion()
            {
                Console.WriteLine($" {Header} ________(Mark: {Mark})");
                Console.WriteLine(Body);
                foreach (var answer in AnswerList)
                {
                    Console.WriteLine(answer);
                }
            }
            public override object Clone()
            {
                MCQquestion newMCQ = new MCQquestion(Header, Body, Mark, AnswerList.Length);
                newMCQ.AnswerList = (Answer[])this.AnswerList.Clone();
                newMCQ.RightAnswer = this.RightAnswer;
                return newMCQ;
            }
            public override int CompareTo(Question other)
            {

                if (other == null) return -1; // Not Equal 

                if (other.RightAnswer == this.RightAnswer) return 1;//  Equal 
                else return -1;// Not Equal 



            }

            public override string ToString()
            {
                return $"{Header} (Mark: {Mark})";
            }
        }

        #endregion
        #region Base Exam class
        public abstract class Exam
        {
            public int Time { get; set; }
            public int NumberOfQuestions { get; set; }

            public Question[] Questions { get; set; }
            public int[] UserAnswers { get; set; }
            protected Exam(int time, int numberOfQuestions)
            {
                Time = time;
                NumberOfQuestions = numberOfQuestions;
                Questions = new Question[numberOfQuestions];
                UserAnswers = new int[numberOfQuestions];

            }

            public abstract void ShowExam();


            public abstract void DisplayResults(double timeTaken);





        }
        /* Chlid  Classes */

        #region FinalExam
        public class FinalExam : Exam
        {
            public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
            {
            }

            public override void ShowExam()
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Console.WriteLine("-------------------------------------------------------------------------------------");

                Console.WriteLine("Starting Final Exam.......");
                Console.WriteLine("-------------------------------------");

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    Questions[i].DisplayQuestion();
                    Console.Write("Your answer (enter the answer id): ");
                    int AnswersMaxRange = Questions[i].AnswerList.Length;

                    UserAnswers[i] = ValidnumaricInput($"Enter Exam Time (in minutes, between 1 and {AnswersMaxRange}):", 1, AnswersMaxRange);

                  
                    Console.WriteLine();
                }

                stopwatch.Stop();
                DisplayResults(stopwatch.Elapsed.TotalMinutes);
            }

            public override void DisplayResults(double timeTaken)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");

                Console.WriteLine("Your Results:");
                int totalMarks = 0;
                int userGrade = 0;

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    Console.WriteLine($"Question {i + 1}: {Questions[i].Header} (Mark: {Questions[i].Mark})");
                    Console.WriteLine(Questions[i].Body);
                    foreach (var answer in Questions[i].AnswerList)
                    {
                        Console.WriteLine(answer);
                    }
                    Console.WriteLine($"Your answer: {UserAnswers[i]}");
                    Console.WriteLine($"Correct answer: {Questions[i].RightAnswer}");
                    if (UserAnswers[i] == Questions[i].RightAnswer)
                    {
                        userGrade += Questions[i].Mark;
                    }
                    totalMarks += Questions[i].Mark;
                    Console.WriteLine();
                }
                Console.WriteLine("-------------------------------------------------------------------------------------");

                Console.WriteLine($"Total Marks: {totalMarks}");
                Console.WriteLine($"Your Grade: {userGrade}");
                Console.WriteLine($"Time Taken: {timeTaken:F2} minutes");
                Console.WriteLine("-------------------------------------------------------------------------------------");

            }
        }
        #endregion
        /* Chlid  Classes */
        #region PracticalExam
        public class PracticalExam : Exam
        {
            public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

            public override void ShowExam()
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                Console.WriteLine("Starting Practical Exam......");
                Console.WriteLine("--------------------------");

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    Questions[i].DisplayQuestion();
                    int AnswersMaxRange = Questions[i].AnswerList.Length;
                    Console.Write("Your answer (Enter the answer id): ");
                    /*Vaildate on crroct answer be in the range*/
                    UserAnswers[i] = ValidnumaricInput($"Enter Exam Time (in minutes, between 1 and {AnswersMaxRange}):", 1, AnswersMaxRange);
                  
                    Console.WriteLine();
                }

                stopwatch.Stop();
                DisplayResults(stopwatch.Elapsed.TotalMinutes);
            }

            public override void DisplayResults(double timeTaken)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");

                Console.WriteLine("Parctial Exam Correct Answers:");
                Console.WriteLine("------------------------------------------");


                /* sum the question Grads */
                /*check on the answers and  sum the correct answers */
                /********************************* only Display the Correct Answers************************************ */

                int totalMarks = 0;
                int userGrade = 0;

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    
                    Console.WriteLine($"Question {i + 1}: Correct Answer=> {Questions[i].RightAnswer}");

                    if (UserAnswers[i] == Questions[i].RightAnswer)
                    {
                        userGrade += Questions[i].Mark;
                    }
                    totalMarks += Questions[i].Mark;
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------------");

                Console.WriteLine($"Total Marks: {totalMarks}");
                Console.WriteLine($"Your Marks: {userGrade}");
                Console.WriteLine($"Time Taken: {timeTaken} M");
            }
        }
        #endregion




        #endregion
        #region Subject Class
        public class Subject
        {
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam TypeOfExam { get; set; }

            public Subject(int subjectId, string subjectName, Exam exam)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
                TypeOfExam = exam;
            }

            public void CreateExam()
            {
                Console.WriteLine("Do you Want To Do The Exame____________ (1 for Yes / 2 for No) ");
                int Result;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out Result))
                    {
                        if (Result == 1 || Result == 2)
                        {
                            break; // correct data exist the loop 
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. The number must be between 1 and 2");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                if (Result == 1)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------");

                    Console.WriteLine($"Creating Exam for Subject: {SubjectName}");
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    TypeOfExam.ShowExam();

                }

            }
        }

        #endregion
        #region  Vaildation methods 

        /*overload to handel both vaildayion cases*/
        private static int ValidnumaricInput(string Message, int minValue, int maxValue)
        {
            int result;
            while (true)
            {
                Console.WriteLine(Message);
                if (int.TryParse(Console.ReadLine(), out result) && result >= minValue && result <= maxValue)
                {
                    return result;
                }
                Console.WriteLine($"Invalid input. please Add numaric data and  Please enter a number between {minValue} and {maxValue}.");
            }
        }
        private static int ValidnumaricInput(string Message, int minValue)
        {
            int result;
            while (true)
            {
                Console.WriteLine(Message);
                if (int.TryParse(Console.ReadLine(), out result) && result >= minValue)
                {
                    return result;
                }
                Console.WriteLine($"Invalid input.please Add numaric data and  Please enter a number greater than {minValue} .");
            }
        }
        private static string ValidStringInput(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input; // stop the loop 
                }

                Console.WriteLine("Invalid input. Please enter valid data.");
            }
        }
        #endregion
        #region Main Mehod
        static void Main(string[] args)
        {
            /*************************************************************************************************************/
            string subjectName = ValidStringInput("Enter Subject Name:");
            int subjectId = ValidnumaricInput("Enter Subject ID:", 1);
            int examChoice = ValidnumaricInput("Enter Type of Exam (1 for Final Exam / 2 for Practical Exam):", 1, 2);
            int examTime = ValidnumaricInput("Enter Exam Time (in minutes, between 30 and 180):", 30, 180); ;
            int numberOfQuestions = ValidnumaricInput("Enter Number of Questions:", 1);
            Exam exam;
            if (examChoice == 1)
            {

                exam = new FinalExam(examTime, numberOfQuestions);
            }
            else
            {
                exam = new PracticalExam(examTime, numberOfQuestions);
            }

            // Add questions to the exam
            for (int i = 0; i < numberOfQuestions; i++)
            {
                int questionType = 2;
                if (examChoice == 1)
                {
                    questionType = ValidnumaricInput($"Enter Question {i + 1} Type (1 for True/False / 2 for MCQ):", 1, 2);

                }
                string header;


                //*********************************************************\\
                if (questionType == 1)
                {
                    header = "True / False Question";
                }
                else
                {
                    header = "Mcq Question";

                }
                //*********************************************************\\

                string body = ValidStringInput("Enter Question Body:"); ;
                int mark = ValidnumaricInput($"Enter Question {i + 1} Mark:", 1); ;

                if (questionType == 1)
                {
                    exam.Questions[i] = new TrueFalseQuestion(header, body, mark);
                    int TFanswer = ValidnumaricInput($"Enter the answer of Question {i + 1}  (1 for True||  2 for False):", 1, 2);
                    exam.Questions[i].RightAnswer = TFanswer;

                }
                else
                {
                    /****************************************************************************************************/
                    /*multple choices must be more than one answer to choic between them*/
                    int answerCount = ValidnumaricInput("Enter Number of Answers:", 2);


                    /* Assgin  Answers  and The Correct Answers */
                    exam.Questions[i] = new MCQquestion(header, body, mark, answerCount);

                    for (int j = 0; j < answerCount; j++)
                    {
                        Console.WriteLine($"Enter Answer {j + 1} Text:");
                        string answerText = Console.ReadLine();
                        exam.Questions[i].AnswerList[j] = new Answer(j + 1, answerText);
                    }

                  
                    int CorrectAnswerNo;
                     CorrectAnswerNo = ValidnumaricInput("Enter Correct Answer No:", 1, answerCount);
                    exam.Questions[i].RightAnswer = CorrectAnswerNo;


                }
            }

            Subject subject = new Subject(subjectId, subjectName, exam);
            subject.CreateExam();

        }
        #endregion
    }
}
