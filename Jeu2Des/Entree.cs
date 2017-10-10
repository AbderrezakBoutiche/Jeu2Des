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
    [DataContract]
    public class Entree : IComparable<Entree>
    {
        //------------------------------------------------------  Les Attributs  -------------------------------------------------

        #region Les Attributs
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Score { get; set; }
        #endregion



        //---------------------------------------------------  Les Constructeurs  ------------------------------------------------
        #region Les Constructeurs

        
        public Entree(string _nom, int _score)
        {
            this.Nom = _nom;
            this.Score = _score;
        }
        public Entree (Entree entree)
        {
            this.Nom = entree.Nom;
            this.Score = entree.Score;

        }
        public Entree()
        {
            this.Nom = "Player";
            this.Score = 0;
        }
        #endregion



        //-----------------------------------------------------  Les Méthodes  ---------------------------------------------------
        #region Les Méthodes
        public override string ToString()
        {
            return $" {Nom} son Score est de {Score}";
        }
        

        public int CompareTo(Entree other)
        {
            if (other == null) return 1;
            Entree obj = other as Entree;
            if (other != null)
                return this.Score.CompareTo(other.Score);

            throw new ArgumentException("Object n'est une partie");
            
        }
        #endregion
        
    }
}
