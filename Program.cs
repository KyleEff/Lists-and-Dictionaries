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

        problemOne();
        problemTwo();
    }

    // Methods
    /*
     * 1) Write a program and continuously ask the user to enter different names,
     *      until the user presses Enter (without supplying a name).
     *      Depending on the number of names provided,
     *      display a message based on the above pattern. 
     */
    void problemOne() {

        var names = new ArrayList();// ArrayList to hold this names entered

        Console.WriteLine("ONE\nEnter names:"); // Title
        string name = Console.ReadLine(); // Receive input from the user

        while (name != "") { // While the name variable is not a blank string

            names.Add(name); // Add the name to the list
            name = Console.ReadLine(); // Wait for the next anme
        }

        //foreach (var i in names) Console.WriteLine(i); // Debug statement; prints the list of names

        switch (names.Count) { // Switch using the length of the list

            case 0: // No likes; Display nothing
                break;

            case 1: // 1 like;
                Console.WriteLine(names[0] + " likes your post.");
                break;

            case 2: // 2 likes
                Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
                break;

            default: // more than 2 likes
                Console.WriteLine(

                    names[0] + ", " + names[1] + ", and " +
                    Convert.ToString(names.Count - 2) + " others like your post."
                );
                break;
        } 
    }

    /*
     * 2) Write a program that asks the user to enter a sentence.
     *      Display each unique letter in the sentence,
     *      and how many times each one appeared. 
     */
    void problemTwo() {

        Console.WriteLine("\nTWO\nEnter a sentence:"); // Heading
        string sentence = Console.ReadLine().ToLower(); // The input from the user
        var tokens = sentence.ToCharArray(); // Splitting the string into a character array
        Dictionary<char, int> letters = new Dictionary<char, int>(); // Create a dictionary data structure


        foreach (var i in tokens) { // for each variable in tokens

            if (i == ' ') continue; // if the token is a space, skip

            else { // if the token is not a space

                if (!letters.ContainsKey(i)) // if the dictionary contains the token
                    letters.Add(i, 1); // then add the token as a key with a 1 value

                else // if the dictionary contains the token
                    letters[i]++; // increment the value
            }
        }

        foreach (var i in letters)
            Console.WriteLine(i); // Print Dictionary
    }

    public static void Main(string[] args) { new Program(); } // Driver Function
}

