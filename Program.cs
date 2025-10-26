string[,] connect67 = new string[6, 7] { 
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " }, 
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " },
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " },
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " },
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " },
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " }, };

string turn = " o ";
bool win = false;   

while (win == false) {

    Console.WriteLine("Enter Coordinates Y (0 --> 6):");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("-----------------------------------------------------");

    bool moveMade = false;
    while (moveMade == false) {
        for (int i = 0; i < connect67.GetLength(0); i++) {
            Console.WriteLine("run");
            if (!(connect67[5 - i, y] == " 0 " || connect67[5 - i, y] == " 0 ")) {
                connect67[5, y] = turn;
                moveMade = true;
            }
        }
    }

    for (int i = 0; i < connect67.GetLength(0); i++) {
        Console.WriteLine(connect67[i, 0] + connect67[i, 1] + connect67[i, 2] + connect67[i, 3] + connect67[i, 4] + connect67[i, 5] + connect67[i, 6]);
    }

    if (turn == " 0 ") 
    {
        turn = " o "; 
    }
    else if (turn == " o ") 
    {
        turn = " 0 ";
    }
};