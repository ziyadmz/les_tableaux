using System;
using System.Collections.Generic;
using System.Text;

namespace les_tableaux
{
    class table
    {
        int taille;
        string type;
        int[] tableau;
        float[] tableauf;
        char[] tableauc;
        string[] tableaus;

        public int Taille
        {
            get { return taille; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Type
        {
            get { return type; }
        }
        public table(int taille, string type)
        {
            if (Type == "nombre entier")
            {  
                type = "nombre entier";
                tableau = new int[taille = Taille];
            }
            if (Type == "nombre réel")
            {
                type = "nombre réel";
                tableauf = new float[taille = Taille];
            }
            else if (Type == "char")
            { 
                type = "char";
                tableauc = new char[taille = Taille];
            }
            else if (Type == "string")
            {
                type = "string";
                tableaus = new string[taille = Taille];
            }
        }
        public bool ajouter_element(int element, int position)
        {
            if (position >= taille)
                return false;
            else
            {
                tableau[position] = element;
                return true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool ajouter_element(float element, int position)
        {
            if (position >= taille)
                return false;
            else
            {
                tableauf[position] = element;
                return true;
            }
        }
        public bool ajouter_element(char element, int position)
        {
            if (position >= taille)
                return false;
            else
            {
                tableauc[position] = element;
                return true;
            }
        }
        public bool ajouter_element(string element, int position)
        {
            if (position >= taille)
                return false;
            else
            {
                tableaus[position] = element;
                return true;
            }
        }
        public bool Supprimer_element(int position)
        {
            if (type == "nombre entier")
            {
                if (position >= taille)
                    return false;
                else
                {
                    for (int i = position + 1; i < position; i++)
                    {
                        tableau[i - 1] = tableau[i];
                    }
                    return true;
                }
            }
            else if (type == "nombre réel")
            {
                if (position >= taille)
                    return false;
                else
                {
                    for (int i = position + 1; i < position; i++)
                    {
                        tableauf[i - 1] = tableauf[i];
                    }
                    return true;
                }
            }
            else if (type == "string")
            {
                if (position >= taille)
                    return false;
                else
                {
                    for (int i = position + 1; i < position; i++)
                    {
                        tableaus[i - 1] = tableaus[i];
                    }
                    return true;
                }
            }
            else
            {
                if (position >= taille)
                    return false;
                else
                {
                    for (int i = position + 1; i < position; i++)
                    {
                        tableauc[i - 1] = tableauc[i];
                    }
                    return true;
                }
            }
        }
        public void Trier_tableau()
            {
                if (type == "nombre entier")
                {
                    int nvelement;
                    for (int i = 0; i < taille; i++)
                    {
                        for (int j = i + 1; j < taille; j++)
                        {
                            if (tableau[j] < tableau[i])
                            {
                                nvelement = tableau[j];
                                tableau[j] = tableau[i];
                                tableau[i] = nvelement;
                            }
                        }
                    }
                }
                else if (type == "nombre réel")
                {
                    float nvelement;
                    for (int i = 0; i < taille; i++)
                    {
                        for (int j = i + 1; j < taille; j++)
                        {
                            if (tableauf[j].CompareTo(tableauf[i]) < 0)
                            {
                                nvelement = tableauf[j];
                                tableauf[j] = tableauf[i];
                                tableauf[i] = nvelement;
                            }
                        }
                    }
                }
                else if (type == "string")
                {
                    string nvelement;
                    for (int i = 0; i < taille; i++)
                    {
                        for (int j = i + 1; j < taille; j++)
                        {
                            if (tableaus[j].CompareTo(tableaus[i]) < 0)
                            {
                                nvelement = tableaus[j];
                                tableaus[j] = tableaus[i];
                                tableaus[i] = nvelement;
                            }
                        }
                    }
                }
                else if (type == "char")
                {
                    char nvelement;
                    for (int i = 0; i < taille; i++)
                    {
                        for (int j = i + 1; j < taille; j++)
                        {
                            if (tableauc[j].CompareTo(tableauc[i]) < 0)
                            {
                                nvelement = tableauc[j];
                                tableauc[j] = tableauc[i];
                                tableauc[i] = nvelement;
                            }
                        }
                    }
                }
        }
        public void Affiche()
        {
            if (type == "nombre entier")
            {
                foreach (double tab in tableau)
                {
                    Console.WriteLine(tab);
                }
            }
            else if (type == "nombre réel")
            {
                foreach (float tab in tableauf)
                {
                    Console.WriteLine(tab);
                }
            }
            else if (type == "string")
            {
                foreach (string tab in tableaus)
                {
                    Console.WriteLine(tab);
                }
            }
            else if (type == "char")
            {
                foreach (char tab in tableauc)
                {
                    Console.WriteLine(tab);
                }
            }

        }
    }
}

