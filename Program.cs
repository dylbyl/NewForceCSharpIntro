using System;
using System.Collections.Generic;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            Console.WriteLine("Planet List");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("Rocky Planets");

            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"The list contains {i}");
                }
                else
                {
                    Console.WriteLine($"The list does not contain {i}");
                }
            }
            /*
        Create a dictionary with key value pairs to
        represent words (key) and its definition (value)
    */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Burnout", "Also the feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Tired", "Ready for a nap after class");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Burnout"]);
            Console.WriteLine(wordsAndDefinitions["Tired"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            Dictionary<string, string> awesomeWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            awesomeWord.Add("word", "awesome");
            awesomeWord.Add("definition", "beyond cool");
            awesomeWord.Add("part of speech", "adjective");
            awesomeWord.Add("example sentence", "C# is awesome!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(awesomeWord);


            // create another Dictionary and add that to the list


            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                Console.WriteLine($"{idiom.Key}: {String.Join(" ", idiom.Value)}");
            }

            Dictionary<string, string> vehicleOne = new Dictionary<string, string>() {
                {"year", "2008"},
                {"model", "Damfresh"},
                {"make", "Biotraxquote"},
                {"color", "Sky Magenta"}
            };
            Dictionary<string, string> salesAgentOne = new Dictionary<string, string>() {
                {"mobile", "(896) 478-6975"},
                {"lastName", "Botsford"},
                {"firstName" , "Shaina"}
            };
            Dictionary<string, string> creditOne = new Dictionary<string, string>() {
                {"creditProvider", "J.P.Morgan Chase & Co."},
                {"account", "601109582720302"}
            };
            Dictionary<string, Dictionary<string, string>> vehicleDictionaryOne = new Dictionary<string, Dictionary<string, string>>(){
                {"vehicle", vehicleOne},
                {"salesAgent", salesAgentOne},
                {"credit", creditOne}
            };


            List<Dictionary<string, Dictionary<string, string>>> allVehicles = new List<Dictionary<string, Dictionary<string, string>>>(){
                {vehicleDictionaryOne}
            };

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Josh"},
                {"age", "22"}
            });
            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Traci"},
                {"age", "48"}
            });
            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Marty"},
                {"age", "49"}
            });
            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
            }

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("Viking", "Mars"),
                new KeyValuePair<string, string>("Opportunity", "Mars"),
                new KeyValuePair<string, string>("Curiosity", "Mars"),
                new KeyValuePair<string, string>("Mariner", "Venus"),
                new KeyValuePair<string, string>("Venera", "Venus"),
                new KeyValuePair<string, string>("Messenger", "Mercury"),
                new KeyValuePair<string, string>("Pioneer", "Jupiter"),
                new KeyValuePair<string, string>("Voyager", "Saturn"),
                new KeyValuePair<string, string>("Voyager", "Uranus"),
                new KeyValuePair<string, string>("Voyager", "Neptune")
            };

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probe in probeDestinations)
                {
                    if (probe.Value == planet){
                        matchingProbes.Add(probe.Key);
                    };
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }
        }
    }
}
