using System;

namespace TXT
{
    class WriteTextFile
    {
        static void Main()
        {
            //Get name and time
            string nom = "ElieSSS";    //TO BE ADDED FROM UNITY
            string temps = "7,1";    //TO BE ADDED FROM UNITY

            string[] nN = { " ", " ", " ", " ", " " };//String array for names
            string[] nT = { "9999999,0", "9999999,0", "9999999,0", "9999999,0", "9999999,0" };//String array for times
            int len = 0;
            try
            {
                string[] nnT = System.IO.File.ReadAllLines(@"Times.txt");//used to get the length of the saved data
                len = nnT.Length;
                Console.WriteLine("length: " + len);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            for (int i = 0; i < len; i++)
            {
                nT[i] = System.IO.File.ReadAllLines(@"Times.txt")[i];
                nN[i] = System.IO.File.ReadAllLines(@"Names.txt")[i];
            }

            int indice = 0;//Pour savoir notre indice
            for(int i=0;i<5;i++)// pour calculer l'indice
            {
                if (nN[i] == " ")
                {
                    indice = i;
                    break;
                }
            }

            if (nN[4]!=" ")//si elle est complete on la reset
            {
                nN = new string[5] { " ", " ", " ", " ", " " };
                nT = new string[5] { "9999999,0", "9999999,0", "9999999,0", "9999999,0", "9999999,0" };
            }
            else// si elle n'est pas complete on ajout les nouveau valeurs
            {
                if (indice != 0)
                {
                    nN[indice] = nom;
                    nT[indice] = temps;
                    Console.WriteLine("indice: " + indice);
                }
            }

            if (nN[0]!=" ")//si il y a deja des valeurs
            {
                string temp1;
                string temp2;
                //Bubble sort to sort the two arrays
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (Convert.ToDouble(nT[i]) > Convert.ToDouble(nT[i + 1]))//si le temps i+1 est plus grand que le temps i
                        {
                            temp1 = nT[i + 1];
                            nT[i + 1] = nT[i];
                            nT[i] = temp1;

                            temp2 = nN[i + 1];
                            nN[i + 1] = nN[i];
                            nN[i] = temp2;
                        }
                    }
                }
                System.IO.File.WriteAllLines(@"Names.txt", nN);//set new values for the names
                System.IO.File.WriteAllLines(@"Times.txt", nT);//set new values for the times
                Console.WriteLine("entered in if cond");
            }
            else if(nN[0] == " ")// si la liste est initialement vide
            {
                nN[0] = nom;
                nT[0] = temps;
                System.IO.File.WriteAllLines(@"Names.txt", nN);
                System.IO.File.WriteAllLines(@"Times.txt", nT);
                Console.WriteLine("entered in else cond");
            }
        }
    }
}

