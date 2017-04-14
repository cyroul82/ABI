﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Data.Entity;

namespace ABI
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : class
    {

        private IBindingList _bindingList;
        public bool ContainsListCollection
        {
            get
            {
                return false;
            }
        }

        public IList GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
