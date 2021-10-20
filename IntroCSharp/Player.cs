using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCSharp
{
    public class Player
    {

        // member variables
        public string name;
        public string gesture;
        public string ChosenGesture;
        public int score;

        // constructor
        public Player(string name, string gesture, string ChooseGesture, int score)
        {
                this.name= name;
                this.gesture=gesture;
                this.ChosenGesture=ChosenGesture;
                this.score=score;
        }


        // member methods




    }
}
