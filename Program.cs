using System;

namespace TXT
{
    class WriteTextFile
    {
        static void Main()
        {

            string[] names = new string[1];
            string[] times = new string[1];

            string[] n = { " ", " ", " ", " ", " " };
            string[] t = { "0,0", "0,0", "0,0", "0,0", "0,0" };

            try//si les 2 fichiers n'existent pas
            {
                n = System.IO.File.ReadAllLines(@"Names.txt");
                t = System.IO.File.ReadAllLines(@"Times.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                System.IO.File.WriteAllLines(@"Names.txt", names);
                System.IO.File.WriteAllLines(@"Times.txt", times);
            }

            //Get name and time
            
            string nom = "HELL";    //TO BE ADDED FROM UNITY
            string temps = "0,1";   //TO BE ADDED FROM UNITY

            string[] nN = { " ", " ", " ", " ", " ", " " };
            string[] nT = { "0,0", "0,0", "0,0", "0,0", "0,0" ,"0,0"};

            string[] nnT = System.IO.File.ReadAllLines(@"Times.txt");
            int len = nnT.Length;
            for (int i = 0; i < len; i++)
            {
                nT[i] = System.IO.File.ReadAllLines(@"Times.txt")[i];
                nN[i] = System.IO.File.ReadAllLines(@"Names.txt")[i];
            }

            int indice = 0;
            for(int i=0;i<5;i++)
            {
                if(nN[i] == " ")
                {
                    break;
                }
                indice = i;
            }

            if (nN[5]!=" ")
            {
                nN = new string[6] { " ", " ", " ", " ", " "," " };
                nT = new string[6] { "0,0", "0,0", "0,0", "0,0", "0,0", "0,0" };
            }
            else
            {
                nN[indice + 1] = nom;
                nT[indice + 1] = temps;
            }

            if (n[0]!=" ")
            {
                string temp1;
                string temp2;

                for (int j = 0; j <= 4; j++)//Bubble sort to sort the two arrays
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
            }
            else
            {
                names[0] = nom;
                times[0] = temps;
                System.IO.File.WriteAllLines(@"Names.txt", names);
                System.IO.File.WriteAllLines(@"Times.txt", times);
            }

        }
    }
}

