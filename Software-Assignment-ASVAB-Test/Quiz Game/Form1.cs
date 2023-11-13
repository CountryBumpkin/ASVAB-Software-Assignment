using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class Form1 : Form
    {

        // Quiz game variables
        int correctAnswer; // Store the correct answer for the current question
        int questionNumber = 1; // Track the current question number
        int score; // Track the player's score
        int percentage; // Calculate and store the percentage of correct answers
        int totalQuestions; // Define the total number of questions in the quiz


        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber); // Display the first question

            totalQuestions = 25; // Set the total number of questions in the quiz
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            // Get the button that triggered the event
            var senderObject = (Button)sender;

            // identify the selected answer
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            // Check if the selected answer is correct
            if (buttonTag == correctAnswer)
            {
                score++; // Increase the score if the answer is correct
            }

            // Check if all questions have been answered
            if (questionNumber == totalQuestions)
            {

                // work out the percentage of correct answers

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                // Display a message box with quiz results
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to take the quiz again"



                    );
                // Reset score and question number for a new quiz
                score = 0;
                questionNumber = 0;

                // Display the first question for a new quiz
                askQuestion(questionNumber);
            }



            // Move to the next question
            questionNumber++;
            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {
            // Switch statement to set up questions and answer options based on the question number
            switch (qnum)
            {
                case 1:
                    // Displays question image
                    pictureBox1.Image = Properties.Resources.Question_1;

                    // Sets the text for question and answer options
                    lblQuestion.Text = "Question 1: NaCl is commonly known as…";

                    button1.Text = "Nickle Chlorine";
                    button2.Text = "Pepper";
                    button3.Text = "Salt"; // Correct Answer 
                    button4.Text = "Sugar";

                    // Set the correct answer for this question
                    correctAnswer = 3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Question_2;


                    lblQuestion.Text = "Question 2: If there are three quarts of gas in a gallon container, how full is the container?";

                    button1.Text = "50%";
                    button2.Text = "60%";
                    button3.Text = "75%";
                    button4.Text = "80%";

                    correctAnswer = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Question_3;


                    lblQuestion.Text = "Question 3: Observe most nearly means: ";

                    button1.Text = "Maintain";
                    button2.Text = "Watch";
                    button3.Text = "Organise";
                    button4.Text = "Protest";

                    correctAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Question_4;


                    lblQuestion.Text = "Question 4: According to the paragraph, the economic power of nations is:";

                    button1.Text = "Controlled by political and military success.";
                    button2.Text = "The basis of their political success.";
                    button3.Text = "Limited to a few powerful nations.";
                    button4.Text = "Relatively unimportant.";

                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Question_5;


                    lblQuestion.Text = "Question 5: If X + Y = 6 and X – Y = 2, then:";

                    button1.Text = "X=1, Y=1";
                    button2.Text = "X=2, Y=1";
                    button3.Text = "X=4, Y=2";
                    button4.Text = "X=0, Y=2";

                    correctAnswer = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Question_6;


                    lblQuestion.Text = "Question 6: The rotor of a generator moves inside a circle of:";

                    button1.Text = "Batteries";
                    button2.Text = "Light Bulbs";
                    button3.Text = "Heating Coils";
                    button4.Text = "Magnets";

                    correctAnswer = 4;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Question_7;


                    lblQuestion.Text = "Question 7: The coolant in a car flows through the:";

                    button1.Text = "Differential";
                    button2.Text = "Brakes";
                    button3.Text = "Distributor";
                    button4.Text = "Engine Block";

                    correctAnswer = 4;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Question_8;


                    lblQuestion.Text = "Question 8: What simple machine magnifies effort when the handle of this corkscrew is pulled up?";

                    button1.Text = "A lever.";
                    button2.Text = "A screw.";
                    button3.Text = "A Wheel.";
                    button4.Text = "A Wedge.";

                    correctAnswer = 1;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Question_9;


                    lblQuestion.Text = "Question 9: Which figure best shows how the objects in the left box will appear if they are put together?";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 4;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.Question_10;


                    lblQuestion.Text = "Question 10: What is the function of an alternator?";

                    button1.Text = "Charges the battery and powers the electrics.";
                    button2.Text = "Delivers electric current from ignition to the combustion engine.";
                    button3.Text = "Ignites fuel-air mixture.";
                    button4.Text = "Acts as an emergency energy supply for the engine.";

                    correctAnswer = 1;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.Question_11;


                    lblQuestion.Text = "Question 11: Approximately how fast does the speed of light travel in a vacuum?";

                    button1.Text = "108,400 miles per second";
                    button2.Text = "144,000 miles per second";
                    button3.Text = "186,000 miles per second";
                    button4.Text = "224,000 miles per second";

                    correctAnswer = 3;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.Question_12;


                    lblQuestion.Text = "Question 12: Electric current is measured using which of these?";

                    button1.Text = "Hertz";
                    button2.Text = "Ohms";
                    button3.Text = "Voltage";
                    button4.Text = "Amps";

                    correctAnswer = 4;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.Question_13;


                    lblQuestion.Text = "Question 13: Which part of the cell is responsible for most chemical energy needed to power the cell’s biochemical reactions?";

                    button1.Text = "Nucleus";
                    button2.Text = "Lysosome";
                    button3.Text = "Cytoplasm";
                    button4.Text = "Mitochondria";

                    correctAnswer = 4;
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources.Question_14;


                    lblQuestion.Text = "Question 14: The following symbol refers to...";

                    button1.Text = "Fuse";
                    button2.Text = "Diode";
                    button3.Text = "Resistor";
                    button4.Text = "Inductor";

                    correctAnswer = 3;
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.Question_15;


                    lblQuestion.Text = "Question 15: Based on this paragraph, which of the following titles offers the most accurate interpretation of the passage?";

                    button1.Text = "“US Military to Enlist More Physicians to Combat PTSD”";
                    button2.Text = "“How the US Military Fails its Veterans”";
                    button3.Text = "“War and Trauma: How the Military and Medicine Interact”";
                    button4.Text = "“PTSD Affects 4 Percent of Personnel Once They Become Discharged”";

                    correctAnswer = 3;
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources.Question_16;


                    lblQuestion.Text = "Question 16: Which of the following events occur at fault lines?";

                    button1.Text = "Hurricanes";
                    button2.Text = "Rain Showers";
                    button3.Text = "Meteor Showers";
                    button4.Text = "Earthquakes";

                    correctAnswer = 4;
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources.Question_17;


                    lblQuestion.Text = "Question 17: Which of the following organs is responsible for blood detoxification?";

                    button1.Text = "Liver";
                    button2.Text = "Spleen";
                    button3.Text = "Thyroid Gland";
                    button4.Text = "Heart";

                    correctAnswer = 1;
                    break;
                case 18:
                    pictureBox1.Image = Properties.Resources.Question_18;


                    lblQuestion.Text = "Question 18: Which figure best shows how the objects in the left box will appear if they are put together?";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;
                case 19:
                    pictureBox1.Image = Properties.Resources.Question_19;


                    lblQuestion.Text = "Question 19: The smaller gear has 8 teeth, and the larger gear has 16 teeth. When the larger gear makes 12 revolutions, how many revolutions will the smaller gear make?";

                    button1.Text = "8";
                    button2.Text = "16";
                    button3.Text = "18";
                    button4.Text = "24";

                    correctAnswer = 4;
                    break;
                case 20:
                    pictureBox1.Image = Properties.Resources.Question_20;


                    lblQuestion.Text = "Question 20: An 80-lb child is sitting on one end of a seesaw. If another 80-lb child jumps from a high platform onto the other end of the seesaw, what will happen?";

                    button1.Text = "The first child will stay stationary on the ground.";
                    button2.Text = "The second child will bounce off the seesaw into the air.";
                    button3.Text = "The first child will bounce off the seesaw into the air.";
                    button4.Text = "The first child will be lifted into the air, but remain seated.";

                    correctAnswer = 4;
                    break;
                case 21:
                    pictureBox1.Image = Properties.Resources.Question_21;


                    lblQuestion.Text = "Question 21: Legitimate most nearly means?";

                    button1.Text = "Secret";
                    button2.Text = "Lawful";
                    button3.Text = "Leader";
                    button4.Text = "Phony";

                    correctAnswer = 2;
                    break;
                case 22:
                    pictureBox1.Image = Properties.Resources.Question_22;


                    lblQuestion.Text = "Question 22: What type of pliers would you use to make a precise bend to a wire before connecting it to a receptacle?";

                    button1.Text = "Tongue-and-groove pliers";
                    button2.Text = "Slip-joint pliers";
                    button3.Text = "Needle-nose pliers";
                    button4.Text = "Locking pliers";

                    correctAnswer = 3;
                    break;
                case 23:
                    pictureBox1.Image = Properties.Resources.Question_23;


                    lblQuestion.Text = "Question 23: Which tool is pictured?";

                    button1.Text = "Open-end wrench";
                    button2.Text = "Box-end wrench";
                    button3.Text = "Crescent wrench";
                    button4.Text = "Alan Key";

                    correctAnswer = 2;
                    break;
                case 24:
                    pictureBox1.Image = Properties.Resources.Question_24;


                    lblQuestion.Text = "Question 24: In the diagram, what is the location of the fuel pressure regulator?";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    correctAnswer = 3;
                    break;
                case 25:
                    pictureBox1.Image = Properties.Resources.Question_25;


                    lblQuestion.Text = "Question 25: How many grams are in one kilogram?";

                    button1.Text = "10";
                    button2.Text = "100";
                    button3.Text = "1000";
                    button4.Text = "10000";

                    correctAnswer = 3;
                    break;












            }









        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
