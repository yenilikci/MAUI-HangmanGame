using System.ComponentModel;
using System.Diagnostics;

namespace HangmanGame;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    #region Fields
    List<string> words = new List<string>()
     {
        "python",
        "javascript",
        "maui",
        "csharp",
        "mongodb",
        "sql",
        "xaml",
        "word",
        "excel",
        "powerpoint",
        "code",
        "hotreload",
        "snippets"
     };
    string answer = "";

    #endregion

    public MainPage()
	{
		InitializeComponent();
        PickWord();
	}

    #region Game Engine
    private void PickWord()
    {
        answer = words[new Random().Next(0, words.Count)];
        Debug.WriteLine(answer);
    }
    #endregion
}

