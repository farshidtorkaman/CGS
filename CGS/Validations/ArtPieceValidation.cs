using System;
using System.Collections.Generic;
using System.Text;
using CGS.Validations;
using CGS.Persistence;

namespace CGS.Validations
{
    public class ArtPieceValidation
    {
        public static bool IsIdValid(string ID)
        {
            bool isUnique = true;
            for (int i = 0; i < Data.MyArtPieces.Length; i++)
            {
                var ArtPieces = Data.MyArtPieces[i];
                if (ArtPieces.ID != null && ArtPieces.ID == ID)
                    isUnique = false;
            }

            bool isValid = isUnique && Validation.IsIdValid(ID);

            return isValid;
        }

        public static bool IsTitleValid(string title)
        {
            return Validation.IsAtMost40Char(title);
        }

        public static bool IsDateValid(string date)
        {
            bool condition = false;
            if (date.Length == 4)
                condition = true;

            foreach (var character in date)
            {
                if (!Char.IsNumber(character))
                    condition = false;
            }

            return condition;
        }

        public static bool IsArtistIdValid(string artistId)
        {
            bool isExist = false;
            for (int i = 0; i < Data.MyArtists.Length; i++)
            {
                var artists = Data.MyArtists[i];
                if (artists.ID != null && artists.ID == artistId)
                    isExist = true;
            }

            return isExist;
        }

        public static bool IsCuratorIdValid(string curatorId)
        {
            bool isExist = false;
            for (int i = 0; i < Data.MyCurators.Length; i++)
            {
                var curators = Data.MyCurators[i];
                if (curators.ID != null && curators.ID == curatorId)
                    isExist = true;
            }

            return isExist;
        }

        public static bool IsEstimedAndPriceValid(string esmited)
        {
            bool condition = true;
            foreach (var character in esmited)
            {
                if (!Char.IsNumber(character))
                    condition = false;
            }
            return condition;
        }

        public static bool IsStatusValid(string status)
        {
            bool condition = false;
            if (status.Length == 1 && (status == "D" || status == "S" || status == "O" || status == "d" || status == "s" || status == "o"))
                condition = true;

            return condition;
        }
    }
}
