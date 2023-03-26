using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Play {

    // This is the main class which holds the static list array object for the program, and it
    // is the accessor class to the abstract class of Humanoids.  This class can also retrieve or
    // send information for character objects.
    public class Character : Humanoids {

        // Primary static memory list array for the program.
        private static List<Character> characters;

        // Primary list array Field variable.
        private List<Character> _characters;

        public List<Character> Characters {
            get { return this._characters; }
            set { _characters = value; }
        }

        public Character(){}

        public Character(List<Character> newChar){
            Characters = newChar;
            characters = newChar;
        }

        // Constructor which passes information to the abstract class's constructor and holds the values for when a new character
        // is created.
        public Character(string nm, string cl, string ra, int str, int super, int intel, int wis, int con, int dex, int agi, int cha) 
            : base(nm, cl, ra, str, super, intel, wis, con, dex, agi, cha) {
            Name = nm; Role = cl; Race = ra; Strength = str; Intelligence = intel; Wisdom = wis; Constitution = con;
            Dexterity = dex; Agility = agi; Charisma = cha; SuperStrength = super;
        }

        // Returns a Character list array.
        public List<Character> GetCharacters() {
            return characters;
        }

        // Adds a character to the list array.
        public void AddCharacter(Character rolled) {    
            characters.Add(rolled); 
        }
    }
}
