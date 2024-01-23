using System;


class HumanPlayer{
    
  
    private int points;
    public HumanPlayer(int initial)
    {
        this.points = initial;
    }
    public int GetPoints()
    {
        return this.points;
    }
    public void WinRound()
    {
        this.points = this.points + 5;
    }
    public void LoseRound()
    {
        this.points = this.points - 5;
    }
    public string HumanDecision()
    {
        Console.Write("\nPlease Enter Your Pick (R-Rock,P-Paper,S-Scissor): ");
        string human_choice = Console.ReadLine();
        return human_choice;
    }
}
class ComputerPlayer{
    public string ComputerDecision()
    {
        Random rand = new Random(); 
        int rand_num = rand.Next(1,4);
        if(rand_num == 1)
        {
            return "R";
        }
        else if(rand_num == 2)
        {
            return "P";
        }
        else
        {
            return "S";
        }
    }
}


class RockPaperScissors {
    
  static bool HumanWins(string human_choice,string computer_choice)
  {
      if(human_choice == "R" && computer_choice == "S")
      {
          return true;
      }
      else if(human_choice == "S" && computer_choice == "P")
      {
          return true;
      }
      else if(human_choice == "P" && computer_choice == "R")
      {
          return true;
      }
      else
      {
          return false;
      }
      
  }
    
  static void Main() {
      
    HumanPlayer HP = new HumanPlayer(5);
    ComputerPlayer CP = new ComputerPlayer(); 
    
    Console.WriteLine("\nYour current score is: "+HP.GetPoints());
    Console.WriteLine("---------------------------\n");
    while(true)
    {    
        string human_choice = HP.HumanDecision();       
    
        string computer_choice = CP.ComputerDecision();
        
        Console.WriteLine("Computer Selects: "+computer_choice);
        
        if(human_choice == computer_choice)
        {
            Console.WriteLine("\nIt was a tie!\n");
        }
        else
        { 
            if(HumanWins(human_choice,computer_choice))
            { 
                Console.WriteLine("\nHurray! You have won this round\n");
                HP.WinRound();
            }
            else
            {  
                Console.WriteLine("\nNo! You have lost this round\n");
                HP.LoseRound();
            }
        } 
    
        Console.WriteLine("Your current score is: "+HP.GetPoints());
        Console.WriteLine("---------------------------\n");
        
        if(HP.GetPoints() == 0)
        {
            Console.WriteLine("You have lost all your points!");
            break;
        }
        
        Console.Write("Do you want to play again(Y/N): ");
        string play_again = Console.ReadLine();
        
        if(play_again == "N")
        {
            break;
        }
    }
    
    Console.WriteLine("\nThank you for playing \n");
    
  }
}