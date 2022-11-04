using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace LT
{
	public partial class Form2 : Form
	{
        public static string saveDirectory => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/LT";
        public static string finalSaveDirectory => saveDirectory + "/questions.json";

        public Form2()
		{
			InitializeComponent();
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string key = KeyTextBox.Text;
			string value = ValueTextBox.Text;

			StreamReader sr = new StreamReader(finalSaveDirectory);
			string oldDictString = sr.ReadToEnd();
			var jObject = JObject.Parse(oldDictString);
			jObject.Add(key, value);
			sr.Close();

			string finalOldDict = jObject.ToString();
			var newDict = JsonConvert.SerializeObject(finalOldDict, Formatting.None);
			newDict = newDict.Replace(@"\r", "");
            newDict = newDict.Replace(@"\n", "");
            newDict = newDict.Replace(@"\", "");
			newDict = newDict.Remove(0, 1);
			newDict = newDict.Remove(newDict.Length - 1, 1);
			StreamWriter sw = new StreamWriter(finalSaveDirectory);
			sw.Write(newDict);
			sw.Close();
			LearnTools.ReadFromJson();
			Close();
        }

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

