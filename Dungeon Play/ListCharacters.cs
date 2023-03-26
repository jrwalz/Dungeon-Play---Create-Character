using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dungeon_Play {

    // This class creates the list array that will be used for the listbox in the accompanying form.
    public class ListCharacters : Character {
        
        // Array used for the listbox
        List<Character> newChar = new List<Character>();

        public ListCharacters() {}

        public ListCharacters(string nm, string cl, string ra, int str, int super, int intel, int wis, int con, int dex, int agi, int cha) 
            : base(nm, cl, ra, str, super, intel, wis, con, dex, agi, cha){
        }

        // Parses the information out from the Character.csv file and puts it into a Character class object.
        public void CharacterFile() {
            char[] delim = { ',' };   

            try{
                FileStream fs = File.OpenRead("Character.csv");
                using (StreamReader reader = new StreamReader(fs)){
                    while (!reader.EndOfStream) {
                    Character token = new Character();

                    // This gives the Field accessors of the class Character values before creating the new line object
                    // in the list array.
                    string[] tokens = reader.ReadLine().Split(delim);
                    token.Name = tokens[0];
                    token.Role = tokens[1];
                    token.Race = tokens[2];
                    if(Int32.TryParse(tokens[3], out int strength)){ token.Strength = strength; }
                    if (Int32.TryParse(tokens[4], out int superStrength)) { token.SuperStrength = superStrength; }
                    if (Int32.TryParse(tokens[5], out int intelligence)) { token.Intelligence = intelligence; }
                    if (Int32.TryParse(tokens[6], out int wisdom)) { token.Wisdom = wisdom; }
                    if (Int32.TryParse(tokens[7], out int constitution)) { token.Constitution = constitution; }
                    if (Int32.TryParse(tokens[8], out int dexterity)) { token.Dexterity = dexterity; }
                    if (Int32.TryParse(tokens[9], out int agility)) { token.Agility = agility; }
                    if (Int32.TryParse(tokens[10], out int charisma)) { token.Charisma = charisma; }

                    newChar.Add(token);                 
                 }
                 fs.Close();
                 reader.Close();
                }
            } catch(Exception ex) { Console.WriteLine(ex.Message); }

            Character characters = new Character(newChar);
        }

        // After a character is deleted from the list array, the Character.csv file is re-written with the new
        // list to not leave any gaps to display in the listbox.
        public void ChangeFile(List<Character> list) {
            int numberOfEntries = list.Count;
            try {
                
                FileStream fs = File.Create("Character.csv");             
                using (StreamWriter writer = new StreamWriter(fs)) {
                    for (int count = 0; count <= numberOfEntries; count++) {
                        
                        writer.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", list[count].Name, list[count].Role, list[count].Race, list[count].Strength, list[count].SuperStrength, list[count].Intelligence, list[count].Wisdom, list[count].Constitution, list[count].Dexterity, list[count].Agility, list[count].Charisma);
                    }

                    fs.Close();
                    writer.Close();
                }                  
            }catch{}
        }
    }
}
