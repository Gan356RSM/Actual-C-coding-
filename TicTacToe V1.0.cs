string[,] tictoe = new string[3, 3] { 
{ " 1 ", " 2 ", " 3 " }, 
{ " 4 ", " 5 ", " 6 " },
{ " 7 ", " 8 ", " 9 " } };
string turn = " X ";
bool win = false;
(int, int)[] a1 = {(0,0), (0,1), (0,2)};
(int, int)[] a2 = {(1,0), (1,1), (1,2)};
(int, int)[] a3 = {(2,0), (2,1), (2,2)};
(int, int)[] a4 = {(0,0), (1,0), (2,0)};
(int, int)[] a5 = {(0,1), (1,1), (2,1)};
(int, int)[] a6 = {(0,2), (1,2), (2,2)};
(int, int)[] a7 = {(0,0), (1,1), (2,2)};
(int, int)[] a8 = {(0,2), (1,1), (2,0)};
(int, int)[][] winCondition = { a1, a2, a3, a4, a5, a6, a7, a8 };

void Check(string Thing) {
    foreach ((int, int)[] won in winCondition) {
        if (tictoe[won[0].Item1,won[0].Item2] == Thing && tictoe[won[1].Item1,won[1].Item2] == Thing && tictoe[won[2].Item1,won[2].Item2] == Thing) {
            Console.WriteLine("You won");
            win = true;
        }
    }
}


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

    Check(" X ");
    Check(" O ");
    
};
