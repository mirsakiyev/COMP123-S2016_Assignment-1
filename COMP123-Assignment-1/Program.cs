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
            a. Private Instance Variables: strength (int), speed (int), health (int) and name(string) (3
                    Marks: Functionality).

            b. Public Properties: Name (string). The value of the public Name property will be stored in
                    the private name Instance Variable (1 Marks: Functionality).
    
            c. The constructor Method should take one parameter, name (string) and pass its value to
            the private name Instance Variable. It will also call the generateAbilities method (3
            Marks: Functionality)
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
            //----------------Create a new instance(rick) of the Person class-------------------------------
            //----------------------------------------------------------------------------------------------
            Hero rick = new Hero();
            rick.Name = "Rick";
            rick.Age = 40;
            rick.SaysHello();
            rick.ShowAge();           
        }
    }
}
