using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using XamlUI.MVVM.Model;

namespace XamlUI.MVVM.View
{
    /// <summary>
    /// Interaktionslogik für TrFileView.xaml
    /// </summary>
    public partial class TrFileView : UserControl
    {
        #region Variables
        Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
        String speakers;
        String choosenLanguage;
        DateTime convertClicked;

        EvaluateParameters ev = new EvaluateParameters();
        #endregion

        #region Private Methods
        void UpdateTrSpeaker(object sender, RoutedEventArgs e)
        {
            choosenLanguage = _TrLanguage.SelectedItem.ToString();
            String[] words = choosenLanguage.Split(' ');
            choosenLanguage = words[2];

            speakers = ev.evaluateSpeaker(choosenLanguage);

            int len = 0;
            for (int i = 0; i < speakers.Length - 1; i++)
            {
                if (speakers[i] == ' ' && Char.IsLetter(speakers[i + 1]) && (i > 0))
                {
                    len++;
                }
            }

            len++;

            if (len == 1)
            {
                _TrSpeaker.Items.Clear();
                _TrSpeaker.Items.Add(speakers);
            }
            else
            {
                String[] sp = speakers.Split(' ');
                _TrSpeaker.Items.Clear();
                for (int i = 0; i < len; i++)
                {
                    _TrSpeaker.Items.Add("" + sp[i]);
                }
            }
        }
        void UpdateSpeaker(object sender, RoutedEventArgs e)
        {
            choosenLanguage = _Language.SelectedItem.ToString();
            String[] words = choosenLanguage.Split(' ');
            choosenLanguage = words[2];

            speakers = ev.evaluateSpeaker(choosenLanguage);

            int len = 0;
            for (int i = 0; i < speakers.Length - 1; i++)
            {
                if (speakers[i] == ' ' && Char.IsLetter(speakers[i + 1]) && (i > 0))
                {
                    len++;
                }
            }

            len++;

            if (len == 1)
            {
                _Speaker.Items.Clear();
                _Speaker.Items.Add(speakers);
            }
            else
            {
                String[] sp = speakers.Split(' ');
                _Speaker.Items.Clear();
                for (int i = 0; i < len; i++)
                {
                    _Speaker.Items.Add("" + sp[i]);
                }
            }
        }
        void Convert_Click(object sender, RoutedEventArgs e)
        {
            String[] language = _TrLanguage.SelectedValue.ToString().Split(' ');
            ApiHelpClass.tts(language[2], _TrSpeaker.SelectedValue.ToString(), TranslateTextBox.Text);
        }
        void Translate_Click(object sender, RoutedEventArgs e)
        {
            convertClicked = DateTime.Now;
            String authKey = "";
            if (File.Exists("..\\..\\Keys\\KeyAPI.txt"))
            {
                authKey = File.ReadAllText("..\\..\\Keys\\KeyAPI.txt");
            }
            else
            {
                MessageBox.Show("Error by searching for the KeyAPI file!");
            }

            String input = FileTextBox.Text.ToString();
            String[] temp = _Language.SelectedValue.ToString().Split(' ');
            String language = ev.evaluateLanguage(temp[2]);
            String[] trtemp = _TrLanguage.SelectedValue.ToString().Split(' ');
            String trlanguage = ev.evaluateLanguage(trtemp[2]);
            ApiHelpClass.translate(authKey, language, trlanguage, input);

            if (File.Exists("temptranslate.txt"))
            {
                String path = System.AppDomain.CurrentDomain.BaseDirectory + "\\temptranslate.txt";
                String text = File.ReadAllText(path);
                TranslateTextBox.Text = text;
            }
            else
            {
                MessageBox.Show("No answer yet from API");
            }
        }

        void PlayFile_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("filename.txt"))
            {
                String filename = File.ReadAllText("filename.txt");

                if (File.Exists(filename))
                {
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    wplayer.URL = filename;
                    wplayer.controls.play();
                }
            }
            else
            {
                MessageBox.Show("Error by searching for the file!");
            }
        }

        void Download_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("filename.txt"))
            {
                String filename = File.ReadAllText("filename.txt");
                String startPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\" + filename + ".mp3";
                string destinationPath = GetDownloadFolderPath() + "\\" + filename;

                if (File.Exists(filename))
                {
                    try
                    {
                        File.Copy(filename, destinationPath, true);
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error by searching for the file!");
            }
        }

        string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }
        void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            dialog.ShowDialog();
            FileTextBox.Text = "";
            String path = dialog.FileName;
            String text = "";

            if (path == null)
            {
                MessageBox.Show("No path selected!");
            }
            else
            {
                try
                {
                    text = File.ReadAllText(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Loading of the file failed!");
                }

                FileTextBox.Text = text;
            }
        }
        void FileTextChanged(object sender, RoutedEventArgs e)
        {
            wordCount(FileTextBox.Text);
            charCount(FileTextBox.Text);
        }

        void wordCount(String text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == ' ' && Char.IsLetter(text[i + 1]) && (i > 0))
                {
                    counter++;
                }
            }

            counter++;

            if (counter > 50)
            {
                _ConvertButton.IsEnabled = false;
                _ConvertButton.Foreground = Brushes.DarkGreen;
                CurrentWordsLabel.Foreground = Brushes.Red;
            }
            else
            {
                _ConvertButton.IsEnabled = true;
                _ConvertButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x29));
                CurrentWordsLabel.Foreground = Brushes.DarkGray;
            }
            CurrentWordsLabel.Text = "Current Words: " + counter;

        }

        void charCount(String text)
        {
            int counter = 0;

            foreach (char c in text)
            {
                counter++;
            }

            if (counter > 250)
            {
                _ConvertButton.IsEnabled = false;
                _ConvertButton.Foreground = Brushes.DarkGreen;
                CurrentSymbolsLabel.Foreground = Brushes.Red;
            }
            else
            {
                _ConvertButton.IsEnabled = true;
                _ConvertButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x29));
                CurrentSymbolsLabel.Foreground = Brushes.DarkGray;
            }
            CurrentSymbolsLabel.Text = "Current Symbols: " + counter;
        }
        #endregion
        public TrFileView()
        {
            InitializeComponent();
        }
    }
}
