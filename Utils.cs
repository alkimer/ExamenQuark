using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Utils
    {
        public static bool IsValidField(string s, Type expectedType)
        {

            switch (expectedType.Name)
            {
                case "Single":

                    try
                    {
                        float a = float.Parse(s);
                        return true;
                    }
                    catch (FormatException)
                    {
                        return false;
                    }

                case "Int32":

                    try
                    {
                        int a = int.Parse(s);
                        return true;
                    }
                    catch (FormatException)
                    {
                        return false;
                    }

                case "TCuello":
                    {
                        try
                        {
                            if (Enum.IsDefined(typeof(Enums.TCuello), s.ToLower()))
                            { return true; }
                            else { return false; }
                        }
                        catch (FormatException)
                        {
                            return false;
                        }
                    }

                case "TManga":
                    {
                        try
                        {
                            if (Enum.IsDefined(typeof(Enums.TManga), s.ToLower()))
                            { return true; }
                            else { return false; }
                        }
                        catch (FormatException)
                        {
                            return false;
                        }
                    }

                case "TPantalon":
                    {
                        try
                        {
                            if (Enum.IsDefined(typeof(Enums.TPantalon), s.ToLower()))
                            { return true; }
                            else { return false; }
                        }
                        catch (FormatException)
                        {
                            return false;
                        }
                    }

                case "TCalidad":
                    {
                        try
                        {
                            if (Enum.IsDefined(typeof(Enums.TCalidad), s.ToLower()))
                            { return true; }
                            else { return false; }
                        }
                        catch (FormatException)
                        {
                            return false;
                        }
                    }


                default: return true;

            }

        }

    }
}
