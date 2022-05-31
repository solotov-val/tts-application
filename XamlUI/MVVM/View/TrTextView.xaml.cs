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
    /// Interaktionslogik für TrTextView.xaml
    /// </summary>
    public partial class TrTextView : UserControl
    {
        #region Variables
        int volume = 50;
        double speed = 1;
        String speakers;
        String choosenLanguage;
        DateTime convertClicked;

        EvaluateParameters ev = new EvaluateParameters();
        #endregion

        #region Private Methods
        /// <summary>
        /// Changing the TrLanguage Combobox Item calls this function to change the items of the TrSpeaker Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Changing the Language Combobox Item calls this function to change the items of the Speaker Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Clicking the Convert Button calls this function to create a .mp3 file with the help of the Amazon API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Convert_Click(object sender, RoutedEventArgs e)
        {
            String[] language = _TrLanguage.SelectedValue.ToString().Split(' ');
            ApiHelpClass.tts(language[2], _TrSpeaker.SelectedValue.ToString(), TranslateTextBox.Text);
        }
        /// <summary>
        /// Clicking the Translate Button calls this function to translate the text of InputTextBox to TranslateTextBox with the help of the DeepL API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            String input = InputTextBox.Text.ToString();
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

        /// <summary>
        /// Clicking the Play Button calls this funtion to play the last converted file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    wplayer.settings.volume = getVolume;
                    wplayer.settings.rate = getSpeed;
                }
            }
            else
            {
                MessageBox.Show("Error by searching for the file!");
            }
        }

        /// <summary>
        /// Clicking the Download Button will call this funtion to save the .mp3 file in Downloads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Returns Path of Downloads
        /// </summary>
        /// <returns></returns>
        string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }
        /// <summary>
        /// Changing the Text of the InputTextBox calls this function to recalculate the amount of words and chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void InputTextChanged(object sender, RoutedEventArgs e)
        {
            wordCount(InputTextBox.Text);
            charCount(InputTextBox.Text);
        }

        /// <summary>
        /// Calculates the amount of words in text
        /// </summary>
        /// <param name="text"></param>
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
                CurrentWordsLabel.Foreground = Brushes.DarkGray;
                _ConvertButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x29));
            }
            CurrentWordsLabel.Text = "Current Words: " + counter;

        }

        /// <summary>
        /// Calculates the amount of chars in text
        /// </summary>
        /// <param name="text"></param>
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
                CurrentSymbolsLabel.Foreground = Brushes.DarkGray;
                _ConvertButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x29));
            }
            CurrentSymbolsLabel.Text = "Current Symbols: " + counter;
        }
        /// <summary>
        /// Looks if Speed is in the range of 0.0-1.0, if it is empty or if a wrong sign is being tried to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SpeedChanged(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(_Speed.Text.ToString(), out double number))
            {
                if (number > 1.0)
                {
                    _Speed.Text = "1";
                    number = 1.0;
                }
                else if (number < 0.0)
                {
                    _Speed.Text = "0";
                    number = 0.0;
                }
                getSpeed = number;
            }
            else if (_Speed.Text == "")
            {

            }
            else
            {
                _Speed.Text = getSpeed.ToString();
            }

        }
        /// <summary>
        /// Looks if Volume is in the range of 0-100, if it is empty or if a wrong sign is being tried to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VolumeChanged(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(_Volume.Text.ToString(), out int number))
            {
                if (number > 100)
                {
                    _Volume.Text = "100";
                    number = 100;
                }
                else if (number < 0)
                {
                    _Volume.Text = "0";
                    number = 0;
                }
                getVolume = number;
            }
            else if (_Volume.Text == "")
            {

            }
            else
            {
                _Volume.Text = getVolume.ToString();
            }

        }
        #endregion

        #region Getter-Setter
        /// <summary>
        /// get and set speed of Windows Media Player
        /// </summary>
        public double getSpeed
        {
            get { return speed; }
            set { speed = value; }
        }

        /// <summary>
        /// get and set volume of Windows Media Player
        /// </summary>
        public int getVolume
        {
            get { return volume; }
            set { volume = value; }
        }
        #endregion
        public TrTextView()
        {
            InitializeComponent();
        }
    }
}
