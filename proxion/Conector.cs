using System;
using System.Collections.Generic;
using System.Text;

namespace proxion
{
    static class Conector
    {
        //testeproxion
        static private string servidor = "localhost";
        static private string porta = "3306";
        static private string bancoDados = "proxion";
        static private string usuario = "root";
        static private string senha = "";
        static private string user = "root";


        static public string strConec = $"server={servidor};port={porta};User Id={usuario};UID={user};database={bancoDados};password={senha}; SSL MODE = 0";

    }
}
