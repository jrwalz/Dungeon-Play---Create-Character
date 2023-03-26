using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dungeon_Play {

    // Sets the rules for how random character stats are created and passes the values up
    // to the Character class.
    public class CreateCharacter : Character {

        public CreateCharacter(){}

        public CreateCharacter(string nm, string cl, string ra, int str, int super, int intel, int wis, int con, int dex, int agi, int cha)
             : base(nm, cl, ra, str, super, intel, wis, con, dex, agi, cha) {
            Name = nm;
            Role = cl;
            Race = ra;
            Strength = str;
            Intelligence = intel;
            Wisdom = wis;
            Constitution = con;
            Dexterity = dex;
            Agility = agi;
            Charisma = cha;
            SuperStrength = super;
        }

        // Randomly creates stats, but they are influenced with minimum values to expedite
        // the users play experience.
        public Character RollStats() {
    
            // Closer to a true random than just using Random class by itself.
            var seed = (int)DateTime.Now.Ticks;
            var ran = new System.Random(seed);

            int strength = ran.Next(ran.Next(1, 3) * 3, 19);
            int intelligence = ran.Next(ran.Next(1, 3) * 3, 19);
            int wisdom = ran.Next(ran.Next(1, 3) * 3, 19);
            int dexterity = ran.Next(ran.Next(1, 3) * 3, 19);
            int agility = ran.Next(ran.Next(1, 3) * 3, 19);
            int constitution = ran.Next(ran.Next(1, 3) * 3, 19);
            int charisma = ran.Next(ran.Next(1, 3) * 3, 19);

            // If the player rolls a maximum strength of 18, it then determines the diety
            // level of that role by giving another chance to increase it furthur and that
            // is broken up into four possible values.
            int superStrength = 0;
            int superRandom = 0;
            if (strength == 18) {
                superRandom = ran.Next(1, 101);
            }

            if (superRandom > 0 && superRandom < 51) {
                superStrength = 0;
            } else if (superRandom > 50 && superRandom < 75) {
                superStrength = 50;
                strength += 1;
            } else if (superRandom > 75 && superRandom < 100) {
                superStrength = 75;
                strength += 2;
            } else if (superRandom == 100) {
                superStrength = 100;
                strength += 3;
            } else {
            }

            // Creates a new character and initially passes that to the CreateCharacter class, but either way
            // inheritance takes care of the polymorphism.
            Character randomCharacter = new CreateCharacter("", "", "", strength, superStrength, intelligence, wisdom, constitution, dexterity, agility, charisma);
            return randomCharacter;
        }
    }
}
