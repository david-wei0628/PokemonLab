using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BindingLibrary;
using System.Windows;

namespace PokemonLab.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        public ObservableCollection<AttrViewModel> _attributes;
        public ObservableCollection<AttrViewModel> Attributes
        {
            get { return _attributes; }
            set { SetProperty(ref _attributes, value); }
        }

        public MainViewModel()
        {
            Attributes = PokemonAttr();
            Propertystatus = "單一屬性";
            Selectattribute = "";

        }

        private static ObservableCollection<AttrViewModel> PokemonAttr()
        {
            return new ObservableCollection<AttrViewModel>
            {
                new AttrViewModel { PmAttributes = "一般" , PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "火", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "水", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "草", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "電", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "冰", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "格鬥", PmWeakness = 1 } ,
                new AttrViewModel { PmAttributes = "毒", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "飛行", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "地面", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "超能", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "蟲", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "岩石", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "幽靈", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "龍", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "惡", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "鋼", PmWeakness = 1 },
                new AttrViewModel { PmAttributes = "妖精", PmWeakness = 1 }
        };
        }

        private string _selectattribute;
        public string Selectattribute
        {
            get { return _selectattribute; }
            set { SetProperty(ref _selectattribute, value); }
        }

        private bool _OAE;
        public bool OAE
        {
            get { return _OAE; }
            set { SetProperty(ref _OAE, value); }
        }

        private string _propertystatus ;
        public string Propertystatus 
        {
            get { return _propertystatus; }
            set { SetProperty(ref _propertystatus, value); }
        }

        private ICommand _Oa;
        public ICommand Oa
        {
            get
            {
                _Oa = new RelayCommand((x) =>
                 {
                     OAE = !OAE;
                     if(OAE)
                     { Propertystatus ="複合屬性"; }
                     else 
                     { 
                         Propertystatus ="單一屬性";
                         Selectattribute = "";
                         Attributes = PokemonAttr();
                     }
                 });
                return _Oa;
            }
        }

        private ICommand _restatus;
        public ICommand Restatus
        {
            get 
            {
                _restatus = new RelayCommand((x) =>
                {
                    Selectattribute = "";
                    Attributes = PokemonAttr();
                });
                return _restatus;
            }
        }

        private ICommand _normal;
        public ICommand Normal
        {
            get
            {
                _normal = new RelayCommand((x) =>
                 {
                     if (!OAE) 
                     { 
                         Attributes = PokemonAttr();
                         Selectattribute = Attributes[0].PmAttributes;
                     }
                     else
                     {
                         if (Selectattribute == "")
                         { Selectattribute = Attributes[0].PmAttributes; }
                         else
                         { Selectattribute = Selectattribute + " / " + Attributes[0].PmAttributes; }
                     }
                     Attributes[6].PmWeakness = Attributes[6].PmWeakness * 2;
                     Attributes[13].PmWeakness = Attributes[13].PmWeakness * 0;
                     
                 });
                return _normal;
            }
        }

        private ICommand _fire;
        public ICommand Fire
        {
            get
            {
                _fire = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[1].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[1].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[1].PmAttributes; }
                    }
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *0.5;
                    Attributes[2].PmWeakness = Attributes[2].PmWeakness *2;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *0.5;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *2;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *2;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *0.5;
                    Attributes[17].PmWeakness = Attributes[17].PmWeakness *0.5;
                });
                return _fire;
            }
        }

        private ICommand _water;
        public ICommand Water
        {
            get
            {
                _water = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[2].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[2].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[2].PmAttributes; }
                    }
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *0.5;
                    Attributes[2].PmWeakness = Attributes[2].PmWeakness *0.5;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *2;
                    Attributes[4].PmWeakness = Attributes[4].PmWeakness *2;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *0.5;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *0.5;
                });
                return _water;
            }
        }

        private ICommand _grass;
        public ICommand Grass
        {
            get
            {
                _grass = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[3].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[3].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[3].PmAttributes; }
                    }
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *2;
                    Attributes[2].PmWeakness = Attributes[2].PmWeakness *0.5;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[4].PmWeakness = Attributes[4].PmWeakness *0.5;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *2;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *2;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *0.5;
                    Attributes[9].PmWeakness = Attributes[9].PmWeakness *2;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *2;
                });
                return _grass;
            }
        }

        private ICommand _electric;
        public ICommand Electric
        {
            get
            {
                _electric = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[4].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[4].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[4].PmAttributes; }
                    }
                    Attributes[4].PmWeakness = Attributes[4].PmWeakness *0.5;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *2;
                    Attributes[9].PmWeakness = Attributes[9].PmWeakness *0.5;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *0.5;
                });
                return _electric;
            }
        }

        private ICommand _ice;
        public ICommand Ice
        {
            get
            {
                _ice = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[5].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[5].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[5].PmAttributes; }
                    }
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *2;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *0.5;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *2;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *2;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *2;
                });
                return _ice;
            }
        }

        private ICommand _fighting;
        public ICommand Fighting
        {
            get
            {
                _fighting = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[6].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[6].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[6].PmAttributes; }
                    }
                    Attributes[9].PmWeakness = Attributes[9].PmWeakness *2;
                    Attributes[10].PmWeakness = Attributes[10].PmWeakness *2;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *0.5;
                    Attributes[15].PmWeakness = Attributes[15].PmWeakness *0.5;
                    Attributes[17].PmWeakness = Attributes[17].PmWeakness *2;
                });
                return _fighting;
            }
        }

        private ICommand _poison;
        public ICommand Posison
        {
            get
            {
                _poison = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[7].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[7].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[7].PmAttributes; }
                    }
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *0.5;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *0.5;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *2;
                    Attributes[10].PmWeakness = Attributes[10].PmWeakness *2;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[17].PmWeakness = Attributes[17].PmWeakness *0.5;
                });
                return _poison;
            }
        }

        private ICommand _ground;
        public ICommand Ground
        {
            get
            {
                _ground = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[8].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[8].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[8].PmAttributes; }
                    }
                    Attributes[2].PmWeakness = Attributes[2].PmWeakness *2;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *2;
                    Attributes[4].PmWeakness = Attributes[4].PmWeakness *0;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *2;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *2;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *2;
                });
                return _ground;
            }
        }

        private ICommand _flying;
        public ICommand Flying
        {
            get
            {
                _flying = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[9].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[9].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[9].PmAttributes; }
                    }
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[4].PmWeakness = Attributes[4].PmWeakness *2;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *2;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *0.5;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *0;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *2;
                });
                return _flying;
            }
        }

        private ICommand _psychic;
        public ICommand Psychic
        {
            get
            {
                _psychic = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[10].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[10].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[10].PmAttributes; }
                    }
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *0.5;
                    Attributes[10].PmWeakness = Attributes[10].PmWeakness *0.5;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *2;
                    Attributes[13].PmWeakness = Attributes[13].PmWeakness *2;
                    Attributes[15].PmWeakness = Attributes[15].PmWeakness *2;
                });
                return _psychic;
            }
        }

        private ICommand _bug;
        public ICommand Bug
        {
            get
            {
                _bug = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[11].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[11].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[11].PmAttributes; }
                    }
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *2;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *0.5;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *0.5;
                    Attributes[9].PmWeakness = Attributes[9].PmWeakness *2;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *2;
                });
                return _bug;
            }
        }

        private ICommand _rock;
        public ICommand Rock
        {
            get
            {
                _rock = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[12].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[12].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[12].PmAttributes; }
                    }
                    Attributes[0].PmWeakness = Attributes[0].PmWeakness *0.5;
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *0.5;
                    Attributes[2].PmWeakness = Attributes[2].PmWeakness *2;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *2;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *2;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *0.5;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *2;
                    Attributes[9].PmWeakness = Attributes[9].PmWeakness *0.5;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *2;
                });
                return _rock;
            }
        }

        private ICommand _ghost;
        public ICommand Ghost
        {
            get
            {
                _ghost = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[13].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[13].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[13].PmAttributes; }
                    }
                    Attributes[0].PmWeakness = Attributes[0].PmWeakness *0;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *0;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *0.5;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[13].PmWeakness = Attributes[13].PmWeakness *2;
                    Attributes[15].PmWeakness = Attributes[15].PmWeakness *2;
                });
                return _ghost;
            }
        }

        private ICommand _dragon;
        public ICommand Dragon
        {
            get
            {
                _dragon = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[14].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[14].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[14].PmAttributes; }
                    }
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *0.5;
                    Attributes[2].PmWeakness = Attributes[2].PmWeakness *0.5;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[4].PmWeakness = Attributes[4].PmWeakness *0.5;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *2;
                    Attributes[14].PmWeakness = Attributes[14].PmWeakness *2;
                    Attributes[17].PmWeakness = Attributes[17].PmWeakness *2;
                });
                return _dragon;
            }
        }

        private ICommand _dark;
        public ICommand Dark
        {
            get
            {
                _dark = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[15].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[15].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[15].PmAttributes; }
                    }
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *2;
                    Attributes[10].PmWeakness = Attributes[13].PmWeakness *0;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *2;
                    Attributes[13].PmWeakness = Attributes[13].PmWeakness *0.5;
                    Attributes[15].PmWeakness = Attributes[15].PmWeakness *0.5;
                    Attributes[17].PmWeakness = Attributes[17].PmWeakness *2;
                });
                return _dark;
            }
        }

        private ICommand _steel;
        public ICommand Steel
        {
            get
            {
                _steel = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[16].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[16].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[16].PmAttributes; }
                    }
                    Attributes[0].PmWeakness = Attributes[0].PmWeakness *0.5;
                    Attributes[1].PmWeakness = Attributes[1].PmWeakness *2;
                    Attributes[3].PmWeakness = Attributes[3].PmWeakness *0.5;
                    Attributes[5].PmWeakness = Attributes[5].PmWeakness *0.5;
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *2;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *0;
                    Attributes[8].PmWeakness = Attributes[8].PmWeakness *2;
                    Attributes[9].PmWeakness = Attributes[9].PmWeakness *0.5;
                    Attributes[10].PmWeakness = Attributes[10].PmWeakness *0.5;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[12].PmWeakness = Attributes[12].PmWeakness *0.5;
                    Attributes[14].PmWeakness = Attributes[14].PmWeakness *0.5;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *0.5;
                    Attributes[17].PmWeakness = Attributes[17].PmWeakness *0.5;
                });
                return _steel;
            }
        }

        private ICommand _fairy;
        public ICommand Fairy
        {
            get
            {
                _fairy = new RelayCommand((x) =>
                {
                    if (!OAE)
                    {
                        Attributes = PokemonAttr();
                        Selectattribute = Attributes[17].PmAttributes;
                    }
                    else
                    {
                        if (Selectattribute == "")
                        { Selectattribute = Attributes[17].PmAttributes; }
                        else
                        { Selectattribute = Selectattribute + " / " + Attributes[17].PmAttributes; }
                    }
                    Attributes[6].PmWeakness = Attributes[6].PmWeakness *0.5;
                    Attributes[7].PmWeakness = Attributes[7].PmWeakness *2;
                    Attributes[11].PmWeakness = Attributes[11].PmWeakness *0.5;
                    Attributes[14].PmWeakness = Attributes[14].PmWeakness *0;
                    Attributes[15].PmWeakness = Attributes[15].PmWeakness *0.5;
                    Attributes[16].PmWeakness = Attributes[16].PmWeakness *2;
                });
                return _fairy;
            }
        }
    }
}
