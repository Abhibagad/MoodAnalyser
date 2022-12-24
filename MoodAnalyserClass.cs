using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
     public class MoodAnalyserClass
    {
        string input;
        public MoodAnalyserClass(string input)
        {
            this.input = input;
        }
        public string AnalyseMood()
        {
            if (this.input.Contains("Sad"))
                return "Sad Mood";
            else
                return "Happy Mood";
        }
    }
    
}

