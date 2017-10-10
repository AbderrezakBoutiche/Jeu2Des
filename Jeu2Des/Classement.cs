using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Jeu2Des
{
    [Serializable]
    //[DataContract]
    public class Classement : IExtensibleDataObject
    {

        //------------------------------------------------------  Les Attributs  -------------------------------------------------
        #region Les Attributs
        //[DataMember]
        public Entree entree { get; set; }

        private ExtensionDataObject extensionDataValue;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataValue;
            }

            set
            {
                extensionDataValue = value;
            }
        }

        

       // [DataMember]
        public List<Entree> listeDesEntrees;
        #endregion

       

       



        //----------------------------------------------------  Les Constructeurs  -----------------------------------------------
        #region Les Constructeurs
        public Classement ()
        {
            listeDesEntrees = new List<Entree>();
        }
        
        #endregion




        //-----------------------------------------------------  Les Méthodes  ---------------------------------------------------
        #region Les Méthodes

        public void AjouterEntree(string nom, int score)
        {
            listeDesEntrees.Add(new Entree(nom, score));
            

        }
        public void FaireClassement()
        {
            listeDesEntrees.Sort();
            listeDesEntrees.Reverse();

            foreach (Entree joueur in listeDesEntrees)
            {
                Console.WriteLine(joueur);
            }
        }


        public void TopN (int N )
        {
            if (listeDesEntrees.Count != 0)
            {
                 listeDesEntrees.Sort();
                 listeDesEntrees.Reverse();
                for (int i = 0; i < N; i++)
                {
                       Console.WriteLine(listeDesEntrees[i].Nom + " son score est de " +  listeDesEntrees[i].Score);
                 }
            }
           

        }

        public void Save()
        {
          

            Stream fichier2 = File.Create("sav.xml");
            XmlSerializer serializer = new XmlSerializer(listeDesEntrees.GetType());
            serializer.Serialize(fichier2, listeDesEntrees);
            fichier2.Close();
        }


        public void Load()
        {
            if (File.Exists("sav.xml"))
            {
                Stream fichier2 = File.OpenRead("sav.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Entree>));
                Object obj = serializer.Deserialize(fichier2);
                this.listeDesEntrees = (List<Entree>)obj;
                fichier2.Close();

            }


        }
        #endregion



    }
}
