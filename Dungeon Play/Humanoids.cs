using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Play {

    // Abstract class for security purposes to pass Field and accessor values to
    // the Character class, but also to seperate main program values particuraly if the
    // program was expanded upon.  This program uses a horizontal single layer inheritance
    // with it being Abstract and Character classes downline and being the parent of Character,
    // ListCharacters, and CreateCharacter classes.
    public abstract class Humanoids {

        // Abstract Field variables.
        private string _name;
        private string _role;
        private string _race;
        private int _strength;
        private int _superStrength;
        private int _intelligence;
        private int _wisdom;
        private int _constitution;
        private int _dexterity;
        private int _agility;
        private int _charisma;

        // Abstract class accessors.
        public string Name {
            get {
                return this._name;
            }
            set {
                _name = value;
            }
        }

        public string Role {
            get {
                return this._role;
            }
            set {
                _role = value;
            }
        }

        public string Race {
            get {
                return this._race;
            }
            set {
                _race = value;
            }
        }

        public int Strength {
            get {
                return this._strength;
            }
            set {
                _strength = value;
            }
        }

        public int SuperStrength {
            get {
                return this._superStrength;
            }
            set {
                _superStrength = value;
            }
        }

        public int Intelligence {
            get {
                return this._intelligence;
            }
            set {
                _intelligence = value;
            }
        }

        public int Wisdom {
            get {
                return this._wisdom;
            }
            set {
                _wisdom = value;
            }
        }

        public int Constitution {
            get {
                return this._constitution;
            }
            set {
                _constitution = value;
            }
        }

        public int Dexterity {
            get {
                return this._dexterity;
            }
            set {
                _dexterity = value;
            }
        }

        public int Agility {
            get {
                return this._agility;
            }
            set {
                _agility = value;
            }
        }

        public int Charisma {
            get {
                return this._charisma;
            }
            set {
                _charisma = value;
            }
        }

        public Humanoids(){}

        // Inherited constructor by four other Classes.
        public Humanoids(string nm, string cl, string ra, int str, int super, int intel, int wis, int con, int dex, int agi, int cha) 
        {
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
    }
}
