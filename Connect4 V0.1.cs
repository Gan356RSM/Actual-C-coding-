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

    bool validPos = false;
    while (validPos == false) {
        
        if (y > 6 || y < 0) {
            Console.WriteLine("Overflowed position, please try again ");
            Console.WriteLine("Enter Coordinates Y (0 --> 6):");
            y = Convert.ToInt32(Console.ReadLine());
        } else {
            validPos = true;
        }
    }

    Console.WriteLine("-----------------------------------------------------");

    string lastTurn = " o ";
    int bottom = 5;
    while (bottom > -1) {
        if (connect67[bottom, y] == " _ ") {
            connect67[bottom, y] = turn; 
            lastTurn = turn;
            break;
        }
        bottom --;
    }

    if (turn == " 0 ") {
        turn = " o "; 
    } else if (turn == " o ") {
        turn = " 0 ";
    }

    if (bottom < 0) {
        Console.WriteLine("Overflowed position, please try again");
        turn = lastTurn;
    }

    for (int i = 0; i < connect67.GetLength(0); i++) {
        Console.WriteLine(connect67[i, 0] + connect67[i, 1] + connect67[i, 2] + connect67[i, 3] + connect67[i, 4] + connect67[i, 5] + connect67[i, 6]);
    }

    int loopCount = 0;
    int count0 = 0;
    int counto = 0;
    

    while (loopCount >= 6) {
        if (connect67[loopCount, y] == " 0 ") {
            count0 ++;
            Console.WriteLine(" 0 UP ");
            Console.WriteLine(count0);
            Console.WriteLine(counto);
        }
        else if (connect67[loopCount, y] == " o ") {
            counto ++;
            Console.WriteLine(" o UP ");
            Console.WriteLine(count0);
            Console.WriteLine(counto);
        }
        loopCount ++;
    }
};
