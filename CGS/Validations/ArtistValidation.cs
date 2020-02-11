using System;
using System.Collections.Generic;
using System.Text;
using CGS.Validations;
using CGS.Persistence;

namespace CGS.Validations
{
    public class ArtistValidation
    {
        public static bool IsIdValid(string ID)
        {
            bool isUnique = true;
            for (int i = 0; i < Data.MyArtists.Length; i++)
            {
                var Artists = Data.MyArtists[i];
                if (Artists.ID != null && Artists.ID == ID)
                    isUnique = false;
            }

            bool isValid = isUnique && Validation.IsIdValid(ID); 
            
            return isValid;
        }

        public static bool IsNameValid(string name)
        {
            bool condition = true;
            foreach (var character in name)
            {
                if(!Char.IsLetter(character))
                    condition = false;
            }

            return condition && Validation.IsAtMost40Char(name);
        }
    }
}
