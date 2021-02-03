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
                new AttrViewModel { PmAttributes = "妖精", PmWeakness = 1 },
        };
        }

        private AttrViewModel _pmattr;
        public AttrViewModel Pmattr
        {
            get { return _pmattr; }
            set { SetProperty(ref _pmattr, value); }
        }

        private ICommand _normal;
        public ICommand Normal
        {
            get
            {
                if (_normal == null)
                {
                    _normal = new RelayCommand((x) =>
                    {
                        if(Pmattr != null)
                        {
                            MessageBox.Show(Pmattr.ToString());
                        }
                    });
                     
                }
                return _normal;
            }
            set { SetProperty(ref _normal, value); }
        }
    }
}
