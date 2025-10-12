string[,] tictoe = new string[3, 3] { 
{ " 1 ", " 2 ", " 3 " }, 
{ " 4 ", " 5 ", " 6 " },
{ " 7 ", " 8 ", " 9 " } };
string turn = " X ";
bool win = false;

for (int i = 0; i < tictoe.GetLength(0); i++) {
        Console.WriteLine(tictoe[i, 0] + tictoe[i, 1] + tictoe[i, 2]);
    }

while (win == false) {

    Console.WriteLine("Enter Coordinates X (0 --> 2):");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Coordinates Y (0 --> 2):");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("-----------------------------------------------------");

    bool moveMade = false;
    while (moveMade == false) {
        if (tictoe[x, y] == " X " || tictoe[x, y] == " O ") {
            Console.WriteLine("Invalid Position");
            Console.WriteLine("Enter Coordinates X (0 --> 2):");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinates Y (0 --> 2):");
            y = Convert.ToInt32(Console.ReadLine());
        }
        else 
        {
            tictoe[x, y] = turn;
            moveMade = true;
        }
    }


    for (int i = 0; i < tictoe.GetLength(0); i++) {
        Console.WriteLine(tictoe[i, 0] + tictoe[i, 1] + tictoe[i, 2]);
    }

    Console.WriteLine("-----------------------------------------------------");
    
    if (turn == " O ") 
    {
        turn = " X "; 
    }
    else if (turn == " X ") 
    {
        turn = " O ";
    }
};