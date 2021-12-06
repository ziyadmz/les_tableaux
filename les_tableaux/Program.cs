using System;

namespace les_tableaux
{
    class Program
    {
        static void Main(string[] args)
        { 
            table tab = new table(5, "nombre");
            tab.ajouter_element('a', 0);
            tab.ajouter_element('b', 1);
            tab.ajouter_element('c', 2);
            tab.ajouter_element('d', 3);
            tab.ajouter_element('e', 4);
        }
    }
}
