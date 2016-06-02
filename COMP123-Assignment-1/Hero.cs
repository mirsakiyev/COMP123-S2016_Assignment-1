using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment_1
{
    /**
     * This class defines a hero
     *
     * @class Hero
     * @field _name {string}
     */
    public class Hero
    {
        // Initializing a random number
        Random rnd = new Random();

        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------


        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        


        //----------------------------------------------------------------------------------------------
        //-----------------------------PUBLIC PROPERTIES------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * <summary>
         * This is a property for our private _name field
         * </summary>
         * 
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }



        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * <summary>
         * This is default empty constructor for the Hero class
         * </summary>
         * 
         * 
         * @constructor Hero
        */
        public Hero()
        {
            // Initialize public properties
            this.Name = "unknown name";           
        }


        /**
        * <summary>This is the constructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * </summary>
        * 
        * @constructor Hero
        * @param {string} name
       */
        public Hero(string name)
        {          
            this.Name = name;
            generateAbilities();
            
        }


        //----------------------------------------------------------------------------------------------
        //-----------------------------------METHODS----------------------------------------------------
        //----------------------------------------------------------------------------------------------


        /**
         * <summary>
         * This method randomly generates the ability numbers(1-100) for the 
         * strength, speed and health properties.
         * </summary>
         * 
         * @method generateAbilities
         * @returns {void}
        */
        private void generateAbilities()
        {
            this._strength= rnd.Next(1, 101);
            this._speed = rnd.Next(1, 101);
            this._health = rnd.Next(1, 101);
        }

    }
}
