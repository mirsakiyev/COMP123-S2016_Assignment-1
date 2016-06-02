using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Assignment #1
 * Author : Aslan Mirsakiyev
 * Student ID : 300850326
 * Date : 02.06.2016
 * Submitted to : Tom Tsiliopoulos
 * GitHub link : 
 *
 * Instructions:

    1. The Hero Class must include the following Properties and Methods: (23 Marks: Functionality):
          +  a. Private Instance Variables: strength (int), speed (int), health (int) and name(string) (3
                    Marks: Functionality).

          +  b. Public Properties: Name (string). The value of the public Name property will be stored in
                    the private name Instance Variable (1 Marks: Functionality).
    
          +  c. The constructor Method should take one parameter, name (string) and pass its value to
                    the private name Instance Variable. It will also call the generateAbilities method 
                    (3 Marks: Functionality)

          +  d. A private generateAbilities Method randomly generates the ability numbers for the
                    strength, speed and health properties. Each ability will be an integer between 1 and 100
                    (4 Marks: Functionality).

          +  e. A public Fight Method calls the private hitAttempt method. If hitAttempt returns true,
                    then it will call the private hitDamage method. The damage amount will then be
                    displayed in a message on the Console. Ensure that you use appropriate spacing and
                    padding to make the output as pretty as possible (4 Marks: Functionality).

            f. A private hitAttempt Method that will randomly determine if the Hero hits (this should
                    be only 20% of the time) otherwise it will return false. (3 Marks: Functionality).

            g. A private hitDamage Method that calculates the damage the Hero causes to the target
                    on a hit. The damage will be calculated by multiplying the Hero’s strength property by a
                    number between 1 and 6. The method will return this value. (3 Marks: Functionality).

            h. A public Show Method that will display the Hero’s ability scores to the console. Ensure
                    that you use appropriate spacing and padding to make the output as pretty as possible
                    (2 Marks: Functionality).
 *
 *
*/

namespace COMP123_Assignment_1
{
    /**
     * This class is the driver class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            string separator = "-------------------------------------";

            //----------------------------------------------------------------------------------------------
            //----------------Create a new instance(aslan) of the Person class------------------------------
            //----------------------------------------------------------------------------------------------
            Hero aslan = new Hero();
            aslan.Name = "Aslan";        


        }
    }
}
