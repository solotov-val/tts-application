using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XamlUI.MVVM.View
{
    /// <summary>
    /// Interaktionslogik für TrTextView.xaml
    /// </summary>
    public partial class TrTextView : UserControl
    {
        #region Private Methods
        void Convert_Click(object sender, RoutedEventArgs e)
        {
            ApiHelpClass.tts(_Language, _Speaker, TranslateTextBox.Text);
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
        void InputTextChanged(object sender, RoutedEventArgs e)
        {
            wordCount(InputTextBox.Text);
            charCount(InputTextBox.Text);
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
                CurrentWordsLabel.Foreground = Brushes.DarkGray;
                _ConvertButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x29));
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
                CurrentSymbolsLabel.Foreground = Brushes.DarkGray;
                _ConvertButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x29));
            }
            CurrentSymbolsLabel.Text = "Current Symbols: " + counter;
        }
        #endregion
        public TrTextView()
        {
            InitializeComponent();
        }
    }
}
