using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
            where T : class
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection { get { return false; } }

        public IList GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }

    }
}
