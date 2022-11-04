using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Diagnostics;

#pragma warning disable IDE1006 // Style nazewnictwa
namespace LT
{
	public partial class Form1 : Form
	{

		public static Random rm = new Random();
		string currentQuestion => QuestionLabel.Text;

		public Form1()
		{

            InitializeComponent();
			LearnTools.DictInit();
		}

		private void ShowAnswerButton_Click(object sender, EventArgs e)
		{
			AnswerLabel.Text = LearnTools.QuestionTable[currentQuestion];
		}

		private void NextQuestionButton_Click(object sender, EventArgs e)
		{
			AnswerLabel.ForeColor = System.Drawing.Color.Black;
			QuestionLabel.Text = LearnTools.RandomizeQuestion();
			AnswerLabel.Text = "?";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LearnTools.SaveJsonToFile(LearnTools.SerializeDict());
		}

		private void NewEntryButton_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void CheckAnswerButton_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(AnswerTextBox.Text)) { return; }
			string currentAnswer = AnswerTextBox.Text.Trim().ToLower();
			if (currentAnswer == LearnTools.QuestionTable[currentQuestion])
			{
                AnswerLabel.Text = LearnTools.QuestionTable[currentQuestion];
				AnswerLabel.ForeColor = System.Drawing.Color.Green;
			}
			else
			{
				AnswerLabel.Text = LearnTools.QuestionTable[currentQuestion];
				AnswerLabel.ForeColor = System.Drawing.Color.Red;
			}
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();
		private async void ManageEntriesButton_Click(object sender, EventArgs e)
		{
			AllocConsole();
			Console.ForegroundColor = ConsoleColor.White;
			await EnterCommand();
		}

		public static async Task EnterCommand()
		{
            string enteredCommand = Console.ReadLine();
            await CommandLine(enteredCommand);
        }

		public static async Task CommandLine(string command)
		{
            Console.Write("cmd > ");
            switch (command)
            {
				case "list":
					Console.WriteLine("test");
					break;
				default:
                    Console.WriteLine("Command: " + command);
					break;
            }
            await EnterCommand();
        }
	}
	public static class LearnTools
	{
		public static Dictionary<string, string> QuestionTable = new Dictionary<string, string>();
        public static string saveDirectory => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LT";
        public static string finalSaveDirectory => saveDirectory + "/questions.json";

        public static void DictInit()
		{
			if(File.Exists(finalSaveDirectory))
			{
				var questionsFromFile = File.ReadAllText(finalSaveDirectory);
				string questionsJson = JsonConvert.DeserializeObject(questionsFromFile).ToString();
				QuestionTable = JsonConvert.DeserializeObject<Dictionary<string, string>>(questionsJson);
            }
            else
			{
                QuestionTable.Add("test", "odp");
                QuestionTable.Add("test2", "odp2");
                QuestionTable.Add("test3", "odp3");
            }
			RandomizeQuestion();
		}

		public static string RandomizeQuestion()
		{
			Random rm = Form1.rm;
            int randomizedNumber = rm.Next(0, QuestionTable.Count);
			string resultedString = QuestionTable.ElementAt(randomizedNumber).Key;
			return resultedString;
		}
		
		public static object SerializeDict()
		{
			return JsonConvert.SerializeObject(QuestionTable);
		}

		public static void SaveJsonToFile(object json)
		{
			if(!Directory.Exists(saveDirectory))
			{
				Directory.CreateDirectory(saveDirectory);
			}
			StreamWriter sw = new StreamWriter(finalSaveDirectory);
			sw.Write(json);
			sw.Close();
		}

		public static void ReadFromJson()
		{
			var dataRead = File.ReadAllText(finalSaveDirectory);
			QuestionTable = JsonConvert.DeserializeObject<Dictionary<string, string>>(dataRead);
		}
	}
}
