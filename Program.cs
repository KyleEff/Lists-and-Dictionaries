/*
 * Kyle Free
 * GAME 1343 - Game and Simulation Programming I
 * 2/25/2022
 * List and Dictionary Exercise
*/

using System;
using System.Collections;
using System.Collections.Generic;

class Program {

    // Constructor
    public Program() {

        //problemOne();
        problemTwo();
    }

    // Methods
    /*
     * Write a program and continuously ask the user to enter different names,
     *      until the user presses Enter (without supplying a name).
     *      Depending on the number of names provided,
     *      display a message based on the above pattern. 
     */
    void problemOne() {

        var names = new ArrayList();

        Console.WriteLine("ONE\nEnter names:");
        string name = Console.ReadLine();

        while (name != "") {

            names.Add(name);
            name = Console.ReadLine();
        }

        //foreach (var i in names) Console.WriteLine(i);


        switch (names.Count) {

            case 0:
                break;

            case 1:
                Console.WriteLine(names[0] + " likes your post.");
                break;

            case 2:
                Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
                break;

            default:
                Console.WriteLine(

                    names[0] + ", " + names[1] + ", and " +
                    Convert.ToString(names.Count - 2) + " others like your post."
                );
                break;
        } 
    }

    /*
     * Write a program that asks the user to enter a sentence.
     *      Display each unique letter in the sentence,
     *      and how many times each one appeared. 
     */
    void problemTwo() {

        Console.WriteLine("TWO\nEnter a sentence:");
        string sentence = Console.ReadLine().ToLower();
        var tokens = sentence.ToCharArray();
        Dictionary<char, int> letters = new Dictionary<char, int>();

        

        foreach (var i in tokens) {

            if (i == ' ') continue;

            else {

                if (!letters.ContainsKey(i))
                    letters.Add(i, 1);

                else
                    letters[i]++;

            }
        }

        foreach (var i in letters)
            Console.WriteLine(i);
    }

    public static void Main(string[] args) { new Program(); }
}

