string[,] connect67 = new string[6, 7] { 
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " }, 
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " },
{ " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " },
{ " _ ", " _ ", " _ ", " _ ", " _ ", " o ", " o " },
{ " _ ", " _ ", " _ ", " _ ", " o ", " o ", " o " },
{ " _ ", " _ ", " _ ", " o ", " o ", " o ", " 0 " }, };

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

    if (bottom < 0) {
        Console.WriteLine("Overflowed position, please try again");
        continue;
    }

    if (turn == " 0 ") {
        turn = " o "; 
    } else if (turn == " o ") {
        turn = " 0 ";
    }


    for (int i = 0; i < connect67.GetLength(0); i++) {
        Console.WriteLine(connect67[i, 0] + connect67[i, 1] + connect67[i, 2] + connect67[i, 3] + connect67[i, 4] + connect67[i, 5] + connect67[i, 6]);
    }

    int loopCount = 0;
    int count0 = 0;
    int counto = 0;
    

    while (loopCount < 6) {
        if (connect67[loopCount, y] == " 0 ") {
            count0 ++;
            counto = 0;
            if (count0 == 4) {
                Console.WriteLine("0 win!");
                win = true;
            }
        }
        else if (connect67[loopCount, y] == " o ") {
            counto ++;
            count0 = 0;
            if (counto == 4) {
                Console.WriteLine("o win!");
                win = true;
            }
        }
        loopCount ++; 
    }

    count0 = 0;
    counto = 0;
    loopCount = 0;

    while (loopCount < 7) {
        if (connect67[bottom, loopCount] == " 0 ") {
            count0 ++;
            counto = 0;
            if (count0 == 4) {
                Console.WriteLine("0 win!");
                win = true;
            }
        }
        else if (connect67[bottom, loopCount] == " o ") {
            counto ++;
            count0 = 0;
            if (counto == 4) {
                Console.WriteLine("o win!");
                win = true;
            }
        }
        loopCount ++; 
    }

    int curRow = bottom;
    int curCol = y;

    while (true) {
        if (curRow == 0 || curCol == 0) {
            break;
        }
        curRow --;
        curCol --;
    }

    int startRow = curRow;
    int startCol = curCol;

    while (true) {
        if (curRow == 5 || curCol == 6) {
            break;
        }
        curRow ++;
        curCol ++;
    }

    int endRow = curRow;
    int endCol = curCol;

    count0 = 0;
    counto = 0;
    loopCount = 0;

    while (loopCount < (endCol - startCol) + 1) {
        if (connect67[startRow + loopCount, startCol + loopCount] == " 0 ") {
            count0 ++;
            counto = 0;
            if (count0 == 4) {
                Console.WriteLine("0 win!");
                win = true;
            }
        }
        else if (connect67[startRow + loopCount, startCol + loopCount] == " o ") {
            counto ++;
            count0 = 0;
            if (counto == 4) {
                Console.WriteLine("o win!");
                win = true;
            }
        }
        loopCount ++; 
    }

    curRow = bottom;
    curCol = y;

    while (true) {
        if (curRow == 0 || curCol == 6) {
            break;
        }
        curRow --;
        curCol ++;
    }

    startRow = curRow;
    startCol = curCol;

    while (true) {
        if (curRow == 5 || curCol == 0) {
            break;
        }
        curRow ++;
        curCol --;
    }

    endRow = curRow;
    endCol = curCol;

    Console.WriteLine(startCol - endCol);

    while (loopCount < (startCol - endCol) + 1) {
        Console.WriteLine(connect67[startRow + loopCount, endCol + loopCount]);
        Console.WriteLine(startRow + loopCount);
        Console.WriteLine(endCol + loopCount);
        if (connect67[startRow + loopCount, endCol + loopCount] == " 0 ") {
            count0 ++;
            counto = 0;
            Console.WriteLine(count0);
            Console.WriteLine(counto);
            if (count0 == 4) {
                Console.WriteLine("0 win!");
                win = true;
            }
        }
        else if (connect67[startRow + loopCount, endCol + loopCount] == " o ") {
            counto ++;
            count0 = 0;
            Console.WriteLine(count0);
            Console.WriteLine(counto);
            if (counto == 4) {
                Console.WriteLine("o win!");
                win = true;
            }
        }
        loopCount ++; 
    }
}
