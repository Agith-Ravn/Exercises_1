package Test2;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) { //throws?
        Scanner console = new Scanner(System.in); //input?
        var range = 250;
        var counts = new int[range];
        String text = "something";
        while (text != null && text.length() > 0)
        {
            text = console.nextLine();
            for(var character : text.toCharArray())
            {
                counts[(int)character]++;
            }
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    System.out.println(character + " - " + counts[i]);
                }
            }
        }
    }
}
