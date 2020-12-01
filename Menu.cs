using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU4_Algoritmos
{

    /// <summary>
    /// Para futuras implementaciones.
    /// </summary>
    public static class Menu
    {
        static void MenuL1() 
        {
            bool rep = true;
            try
            {
                do
                {
                    switch (int.Parse(Console.ReadLine()))
                    {




                        default:
                            break;
                    }

                } while (rep);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
