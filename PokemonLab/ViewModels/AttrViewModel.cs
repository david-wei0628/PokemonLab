using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingLibrary;

namespace PokemonLab.ViewModels
{
    public class AttrViewModel : NotifyPropertyBase
    {
        private string _pmattributes;
        public string PmAttributes
        {
            get { return _pmattributes; }
            set { SetProperty(ref _pmattributes, value); }
        }

        private int _pmweakness;
        public int PmWeakness
        {
            get { return _pmweakness; }
            set { SetProperty(ref _pmweakness, value); }
        }

        private bool _OAE;
        public bool OAE
        {
            get { return _OAE; }
            set { SetProperty(ref _OAE, value); }
        }

        public override string ToString()
        {
            return PmAttributes;
        }
    }
}
