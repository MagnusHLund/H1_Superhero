using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Superhero
{
    /// <summary>
    /// The superhero class contains a bunch of properties, which contain the data about our super heroes
    /// </summary>
    internal class Superhero
    {
        private string _actualName = "";
        private string _heroName = "";
        private string _powers = "";
        private bool _hasSecretIdentity;
        private bool _wearsCostume;
        private bool _fightsAlone;
        private bool _hasStrongMoralComplex;
        private bool _hasNemesis;
        private bool _hasPrivateAnxiety;

        public string ActualName
        {
            get { return _actualName; }
            set { _actualName = value; }
        }

        public string HeroName 
        { 
            get { return _heroName; } 
            set { _heroName = value; }
        }

        public string Powers
        {
            get { return _powers; }
            set { _powers = value; }
        }

        public bool HasSecretIdentity
        {
            get { return _hasSecretIdentity; }
            set { _hasSecretIdentity = value; }
        }

        public bool WearsCostume
        {
            get { return _wearsCostume; }
            set { _wearsCostume = value; }
        }

        public bool FightsAlone
        {
            get { return _fightsAlone; }
            set { _fightsAlone = value; }
        }

        public bool HasStrongMoralComplex
        {
            get { return _hasStrongMoralComplex; }
            set { _hasStrongMoralComplex = value; }
        }

        public bool HasNemesis
        {
            get { return _hasNemesis; }
            set { _hasNemesis = value; }
        }

        public bool HasPrivateAnxiety
        {
            get { return _hasPrivateAnxiety; }
            set { _hasPrivateAnxiety = value; }
        }
    }
}
