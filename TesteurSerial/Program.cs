using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using Jeu2Des;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TesteurSerial
{
    [Serializable]
    class Program
    {
        //public static void WriteObject(string sauvegarde)
        //{
        //    Classement c1 = new Classement();
        //    FileStream fichier = new FileStream(sauvegarde, FileMode.OpenOrCreate);
        //    DataContractSerializer ser = new DataContractSerializer(typeof(Classement));
        //    ser.WriteObject(fichier, c1);
        //    fichier.Close();
        //}

        //public static void ReadObject(string sauvegarde)
        //{
        //    FileStream fs = new FileStream(sauvegarde, FileMode.OpenOrCreate);
        //    DataContractSerializer ser = new DataContractSerializer(typeof(Classement));

        //    Classement desarialisazedClassement = (Classement)ser.ReadObject(fs);

        //    fs.Close();

        //}
        //public static void WriteObject(List<Entree> sauvegarde)
        //{
        //    //Classement c2 = new Classement();
            
        //    Stream fichier2 = File.Create("sav.xml");
        //    XmlSerializer serializer = new XmlSerializer(sauvegarde.GetType());
        //    serializer.Serialize(fichier2, sauvegarde);
        //    fichier2.Close();
        //}
        
        //public static void ReadObject(Jeu jeu)
        //{
        //    if (File.Exists("sav.xml"))
        //    {
        //        Stream fichier2 = File.OpenRead("sav.xml");
        //        XmlSerializer serializer = new XmlSerializer(typeof(List<Entree>));
        //        Object obj = serializer.Deserialize(fichier2);
        //        jeu.classement.listeDesEntrees = (List<Entree>) obj ;
        //        fichier2.Close();

        //    }

          
        //}
       
        static void Main(string[] args)
        {
            Jeu MonJeu = new Jeu();
            //ReadObject(MonJeu);
            MonJeu.VoirClassement();
            Console.ReadKey();

            //dfsofjqsp

            //Jouons quelques parties ....
            MonJeu.JouerPartie(); //1ere partie avec un joueur par défaut
            MonJeu.JouerPartie(); //2eme partie avec un joueur par défaut
            MonJeu.JouerPartie("David"); //3eme partie
            MonJeu.JouerPartie("David"); //Encore une partie  
            MonJeu.JouerPartie("Sarah"); //Encore une partie 
            MonJeu.JouerPartie("Lucie"); //Encore une partie
            MonJeu.JouerPartie(); //Encore une partie 


            Console.WriteLine("\r\n***********************************");


            MonJeu.VoirClassement();

            

            //try
            //{
            MonJeu.Quitter();
            Console.ReadKey();
            //Classement Load("sav.xml");
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(
            //    "La serialisation à échoué: {0} StackTrace: {1}",
            //    exc.Message, exc.StackTrace);
            //}
            //finally
            //{
            //    Console.WriteLine("Appuyer <Enter> pour sortir....");
            //    Console.ReadLine();
            //}

        }
        
    }
}
