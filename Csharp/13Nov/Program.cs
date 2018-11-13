using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports1
{
    class details
    {
        public string Name;
        public int Id;
        public int Score = 0;
    }
    class player : details
    {

        public void player_input_details()
        {
            Console.WriteLine("Enter the player name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the player id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the player score");
            Score = Convert.ToInt32(Console.ReadLine());
        }
        public void player_output_details()
        {
            Console.WriteLine("player name     " + "          player id      " + "          player score");
            Console.WriteLine(Name + "\t\t\t\t" + Id + "\t\t\t" + Score);
        }


    }
    class team : details
    {

        public player[] p = new player[5];


        public void team_input_details()
        {
            Console.WriteLine("Enter the team name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the team id");
            Id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                p[i] = new player();
                p[i].player_input_details();
            }
            CalculateScore();

        }
        public void team_output_details()
        {
            Console.WriteLine("team name     " + "          team id      ");
            Console.WriteLine(Name + "\t\t\t\t\t\t" + "\t\t\t\t\t\t" + Id);
            for (int i = 0; i < 5; i++)
                p[i].player_output_details();
        }
        public void CalculateScore()
        {
            for (int i = 0; i < 5; i++)
            {
                Score += p[i].Score;
            }
        }

    }
    class match
    {
        public team t1 = new team();
        public team t2 = new team();
        public player ManOfTheMatch = new player();
      
        public void FindManOfMatch()
        {
            for (int i = 0; i < 5; i++)
            {
                if (ManOfTheMatch.Score < t1.p[i].Score)
                {
                    ManOfTheMatch = t1.p[i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (ManOfTheMatch.Score < t2.p[i].Score) 
                {
                    ManOfTheMatch = t2.p[i];
                }
            }
        }
        public void display()
        {
            Console.WriteLine("Total score of team1  is " + t1.Score);
            Console.WriteLine("Total score of team2  is " + t2.Score);
            if (t1.Score > t2.Score)
                Console.WriteLine("Team1 won the match");
            else
                Console.WriteLine("Team2 won the match");
            ManOfTheMatch.player_output_details();
        }



    }
    class Class1
    {

        static void Main(string[] args)
        {
            match m = new match();
            m.t1.team_input_details();
            m.t1.team_output_details();
            m.t2.team_input_details();
            m.t2.team_output_details();

            m.FindManOfMatch();
            m.display();
            Console.ReadLine();


        }
    }
}
