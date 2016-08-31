using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace ToolsExample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnParse;
		private System.Windows.Forms.Button btnPOSTag;
		private System.Windows.Forms.Button btnChunk;
		private System.Windows.Forms.Button btnTokenize;
		private System.Windows.Forms.Button btnNameFind;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.Button btnSplit;
		private System.Windows.Forms.TextBox txtIn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string mModelPath;

		private OpenNLP.Tools.SentenceDetect.MaximumEntropySentenceDetector mSentenceDetector;
		private OpenNLP.Tools.Tokenize.EnglishMaximumEntropyTokenizer mTokenizer;
		private OpenNLP.Tools.PosTagger.EnglishMaximumEntropyPosTagger mPosTagger;
		private OpenNLP.Tools.Chunker.EnglishTreebankChunker mChunker;
        private OpenNLP.Tools.Parser.EnglishTreebankParser mParser;
        private Button button1;
		private OpenNLP.Tools.NameFind.EnglishNameFinder mNameFinder;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//mModelPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
			//mModelPath = new System.Uri(mModelPath).LocalPath + @"\Models\";
           // mModelPath = @"C:\Projects\DotNet\OpenNLP\OpenNLP\Models\";
            mModelPath = @"C:\Users\Norbert\Desktop\work\Research files 1\newfiles\honey-bear-slurp\SlurpNLP\Models\";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnParse = new System.Windows.Forms.Button();
            this.btnPOSTag = new System.Windows.Forms.Button();
            this.btnChunk = new System.Windows.Forms.Button();
            this.btnTokenize = new System.Windows.Forms.Button();
            this.btnNameFind = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(360, 104);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 21;
            this.btnParse.Text = "Parse";
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnPOSTag
            // 
            this.btnPOSTag.Location = new System.Drawing.Point(184, 104);
            this.btnPOSTag.Name = "btnPOSTag";
            this.btnPOSTag.Size = new System.Drawing.Size(75, 23);
            this.btnPOSTag.TabIndex = 20;
            this.btnPOSTag.Text = "POS tag";
            this.btnPOSTag.Click += new System.EventHandler(this.btnPOSTag_Click);
            // 
            // btnChunk
            // 
            this.btnChunk.Location = new System.Drawing.Point(272, 104);
            this.btnChunk.Name = "btnChunk";
            this.btnChunk.Size = new System.Drawing.Size(75, 23);
            this.btnChunk.TabIndex = 19;
            this.btnChunk.Text = "Chunk";
            this.btnChunk.Click += new System.EventHandler(this.btnChunk_Click);
            // 
            // btnTokenize
            // 
            this.btnTokenize.Location = new System.Drawing.Point(96, 104);
            this.btnTokenize.Name = "btnTokenize";
            this.btnTokenize.Size = new System.Drawing.Size(75, 23);
            this.btnTokenize.TabIndex = 18;
            this.btnTokenize.Text = "Tokenize";
            this.btnTokenize.Click += new System.EventHandler(this.btnTokenize_Click);
            // 
            // btnNameFind
            // 
            this.btnNameFind.Location = new System.Drawing.Point(448, 104);
            this.btnNameFind.Name = "btnNameFind";
            this.btnNameFind.Size = new System.Drawing.Size(75, 23);
            this.btnNameFind.TabIndex = 16;
            this.btnNameFind.Text = "Find Names";
            this.btnNameFind.Click += new System.EventHandler(this.btnNameFind_Click);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.Location = new System.Drawing.Point(8, 177);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOut.Size = new System.Drawing.Size(523, 359);
            this.txtOut.TabIndex = 15;
            this.txtOut.WordWrap = false;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(8, 104);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 14;
            this.btnSplit.Text = "Split";
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtIn
            // 
            this.txtIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIn.Location = new System.Drawing.Point(8, 8);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(523, 88);
            this.txtIn.TabIndex = 13;
            this.txtIn.Text = "Mr. Jones went shopping. His grocery bill came to $23.45.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Create CSV File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(539, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnPOSTag);
            this.Controls.Add(this.btnChunk);
            this.Controls.Add(this.btnTokenize);
            this.Controls.Add(this.btnNameFind);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtIn);
            this.Name = "MainForm";
            this.Text = "OpenNLP Tools Example";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		#region Button click events

        private static String appendDQ(String str)
        {
            return "\"" + str + "\"";
        }

        public static void createCSVfile(List<string> list)
        {
            string path = "C:/Users/Norbert/Desktop/tester.csv";
            //System.IO.StreamWriter writeToCSV = new System.IO.StreamWriter(new System.IO.StreamWriter(path, true));
            System.IO.StreamWriter writeToCSV = new System.IO.StreamWriter(path,true);
            string content, value;
            content = value = "";

            IEnumerator<string> myIterator = list.GetEnumerator();

            while (myIterator.MoveNext())
            {
                value = myIterator.Current;
                if (!value.Equals("##"))
                {
                    content = content + value + ",";
                }
                else
                {
                    writeToCSV.WriteLine(content);
                    content = value = "";
                    if (myIterator.MoveNext())
                    {
                        value = myIterator.Current;
                    }
                }
            }
            writeToCSV.Close();
        }
        public void editing()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("C:/Users/Norbert/Desktop/ID+Text.csv");
            string textPath = "C:/Users/Norbert/Desktop/SentenceAnalysis.txt";
            string path = "C:/Users/Norbert/Desktop/peek.txt";
            System.IO.StreamWriter myWriter = new System.IO.StreamWriter(path, true);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(textPath, true);
            string line = "";
            string nextLine = "";
            Boolean longLine = false;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line.Length >= 6)
                {
                    if (!Char.IsDigit(Char.Parse(line.Substring(0, 1))) && !Char.IsDigit(Char.Parse(line.Substring(1, 1))) && !Char.IsDigit(Char.Parse(line.Substring(2, 1))) && !Char.IsDigit(Char.Parse(line.Substring(3, 1))) && !Char.IsDigit(Char.Parse(line.Substring(4, 1))) && !Char.IsDigit(Char.Parse(line.Substring(5, 1))))
                    {
                        longLine = true;
                    }
                    else
                    {
                        nextLine = reader.Peek().ToString();
                        myWriter.WriteLine(nextLine);
                        longLine = false;
                    }
                }
                else
                {
                    longLine = true;
                }
                
                writer.WriteLine(line);
                if (longLine)
                {
                    writer.WriteLine(Environment.NewLine);
                }
            }

            writer.Close();
            reader.Close();
            myWriter.Close();
        }

        public void makeSentences()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("C:/Users/Norbert/Desktop/ID+Text.csv");
            string textPath = "C:/Users/Norbert/Desktop/newFormat.csv";
            System.IO.StreamWriter textToCSV = new System.IO.StreamWriter(textPath, true);
            int id = 0, nextID = 0, counter = 0;
            string line = "",nextLine = "", sentences = "";
            string ID = "";
            Boolean nextLineIDText = false;
            string[] result;
            
            while (!reader.EndOfStream)
            {
                if (counter == 0)
                {
                    line = reader.ReadLine();
                }
                else
                {
                    line = nextLine;
                }
                //if (line.StartsWith("\"") || line.Substring(7,1).Equals("\"") || line.EndsWith("\""))
                //{
                //    char.TryParse(String.Empty, out myChar);
                //    line.Replace('\"', myChar);
                //}
                
                sentences = "";
                counter++;
                nextLineIDText = false;
                
                if (line.Length >= 6)
                {
                    try
                    {
                        id = int.Parse(line.Substring(0, 6));
                        sentences = sentences + line.Substring(7);
                    }
                    catch (FormatException)
                    {
                        sentences = sentences + line;
                    }
                }
                else
                {
                    sentences = sentences + line;
                }

                while (!nextLineIDText)
                {
                    if (!reader.EndOfStream)
                    {
                        nextLine = reader.ReadLine();
                    }
                    else
                    {
                        nextLine = null;
                        break;
                    }

                    if (nextLine.Length >= 6)
                    {
                        try
                        {
                            nextID = int.Parse(nextLine.Substring(0, 6));
                            nextLineIDText = true;
                        }
                        catch (FormatException)
                        {
                            nextLineIDText = false;
                            sentences = sentences + nextLine;
                        }
                    }
                    else
                    {
                        nextLineIDText = false;
                        sentences = sentences + nextLine;
                    }
                }

                if(sentences.StartsWith("\"") ){
                    sentences = sentences.Substring(1);
                } else if(sentences.EndsWith("\"") ){
                    sentences = sentences.Substring(0, sentences.Length - 1);
                }

                line = nextLine;
                result = SplitSentences(sentences);

                ID = id.ToString();

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = appendDQ( result[i] );
                    textToCSV.WriteLine(ID + "," + result[i]);
                }
               

                sentences = ""; ID = "";
                id = 0;
            }
            textToCSV.Close();
            reader.Close();
        }

		private void btnSplit_Click(object sender, System.EventArgs e)
		{		
			string[] sentences = SplitSentences(txtIn.Text);
			
			txtOut.Text = string.Join("\r\n\r\n", sentences);
		}

		private void btnTokenize_Click(object sender, System.EventArgs e)
		{
			StringBuilder output = new StringBuilder();

			string[] sentences = SplitSentences(txtIn.Text);

			foreach(string sentence in sentences)
			{
				string[] tokens = TokenizeSentence(sentence);
				output.Append(string.Join(" | ", tokens)).Append("\r\n\r\n");
			}

			txtOut.Text = output.ToString();
		}

		private void btnPOSTag_Click(object sender, System.EventArgs e)
		{
			StringBuilder output = new StringBuilder();

			string[] sentences = SplitSentences(txtIn.Text);

			foreach(string sentence in sentences)
			{
				string[] tokens = TokenizeSentence(sentence);
				string[] tags = PosTagTokens(tokens);

				for (int currentTag = 0; currentTag < tags.Length; currentTag++)
				{
					output.Append(tokens[currentTag]).Append("/").Append(tags[currentTag]).Append(" ");
				}

				output.Append("\r\n\r\n");
			}

			txtOut.Text = output.ToString();
		}

		private void btnChunk_Click(object sender, System.EventArgs e)
		{
			StringBuilder output = new StringBuilder();

			string[] sentences = SplitSentences(txtIn.Text);

			foreach(string sentence in sentences)
			{
				string[] tokens = TokenizeSentence(sentence);
				string[] tags = PosTagTokens(tokens);

				output.Append(ChunkSentence(tokens, tags)).Append("\r\n");
			}

			txtOut.Text = output.ToString();
		}

		private void btnParse_Click(object sender, System.EventArgs e)
		{
			StringBuilder output = new StringBuilder();

			string[] sentences = SplitSentences(txtIn.Text);

			foreach(string sentence in sentences)
			{
				output.Append(ParseSentence(sentence).Show()).Append("\r\n\r\n");
			}

			txtOut.Text = output.ToString();
		}

		private void btnNameFind_Click(object sender, System.EventArgs e)
		{
			StringBuilder output = new StringBuilder();

			string[] sentences = SplitSentences(txtIn.Text);

			foreach(string sentence in sentences)
			{
                output.Append(FindNames(sentence)).Append("\r\n");
			}

			txtOut.Text = output.ToString();
		}

		#endregion

		#region NLP methods

		public string[] SplitSentences(string paragraph)
		{
			if (mSentenceDetector == null)
			{
				mSentenceDetector = new OpenNLP.Tools.SentenceDetect.EnglishMaximumEntropySentenceDetector(mModelPath + "EnglishSD.nbin");
			}

			return mSentenceDetector.SentenceDetect(paragraph);
		}

		private string[] TokenizeSentence(string sentence)
		{
			if (mTokenizer == null)
			{
				mTokenizer = new OpenNLP.Tools.Tokenize.EnglishMaximumEntropyTokenizer(mModelPath + "EnglishTok.nbin");
			}

			return mTokenizer.Tokenize(sentence);
		}

		private string[] PosTagTokens(string[] tokens)
		{
			if (mPosTagger == null)
			{
				mPosTagger = new OpenNLP.Tools.PosTagger.EnglishMaximumEntropyPosTagger(mModelPath + "EnglishPOS.nbin", mModelPath + @"\Parser\tagdict");
			}

			return mPosTagger.Tag(tokens);
		}

		private string ChunkSentence(string[] tokens, string[] tags)
		{
			if (mChunker == null)
			{
				mChunker = new OpenNLP.Tools.Chunker.EnglishTreebankChunker(mModelPath + "EnglishChunk.nbin");
			}
			
			return mChunker.GetChunks(tokens, tags);
		}

		private OpenNLP.Tools.Parser.Parse ParseSentence(string sentence)
		{
			if (mParser == null)
			{
				mParser = new OpenNLP.Tools.Parser.EnglishTreebankParser(mModelPath, true, false);
			}

			return mParser.DoParse(sentence);
		}

		private string FindNames(string sentence)
		{
			if (mNameFinder == null)
			{
				mNameFinder = new OpenNLP.Tools.NameFind.EnglishNameFinder(mModelPath + "namefind\\");
			}

			string[] models = new string[] {"date", "location", "money", "organization", "percentage", "person", "time"};
			return mNameFinder.GetNames(models, sentence);
		}

		#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            makeSentences();
            txtOut.Text = "Done!";
        }
		
	}
}
