using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            
            
            //player1.PlayerPlay();
            Console.ReadKey();
        }


        
    }

    class Game
    {
        int numberOfPlayers;
        Player player1;
        Player player2;

        public Game()
        {   
            
            Console.WriteLine("Welcome to Rock Paper Scissors");
            Console.WriteLine("How many Players?");
            numberOfPlayers = Convert.ToInt16(Console.ReadLine());
            CreateGame();
            player1.PlayerPlay();
            player2.PlayerPlay();
            GameResult();

            
        }

        public void CreateGame()
        {
            switch (numberOfPlayers)
            {
                case 0:
                    player1 = new Player(false);
                    player2 = new Player(false);
                    Console.WriteLine("Computer vs Computer");

                    break;
                case 1:
                    player1 = new Player(true);
                    player2 = new Player(false);
                    Console.WriteLine("Human vs Computer");

                    break;
                case 2:
                    player1 = new Player(true);
                    player2 = new Player(false);
                    Console.WriteLine("Human vs Human");

                    break;
                default:
                    break;
            }    
        }

        public void GameResult()
        {
            Console.WriteLine("Player 1 chose " + player1.playerMove);
            Console.WriteLine("Player 2 chose " + player2.playerMove);
        }
    }

    class Player
    {
        public string name1;
        public string name2;
        public bool isHuman;
        public int score;
        public string playerMove;
        

        public Player(bool _isHuman)
        {
            if (isHuman == true)
            {
                Console.WriteLine("Please Enter Your Name");
                name1 = Console.ReadLine();
                isHuman = _isHuman;
            }
            else if (isHuman == false)
            {
                name2 = "Super Saiyan Cyborg";
                isHuman = _isHuman;

            }
        }

        public void PlayerPlay()
        {
            if(isHuman == true)
            {
                Console.WriteLine(name1 + ", please type your move: 'Rock', 'Paper' or 'Scissors'. Then press enter");
                playerMove = Console.ReadLine().ToLower();          
            }
            else if(isHuman == false)
            {
                Random rnd = new Random();
                int select = rnd.Next(1, 3);

                switch (select)
                {
                    case 1:
                        playerMove = "rock";
                        break;
                    case 2:
                        playerMove = "paper";
                        break;
                    case 3:
                        playerMove = "scissors";
                        break;
                    default:
                        break;
                }

            }
        }
    }
}