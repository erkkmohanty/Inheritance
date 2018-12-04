using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Inheritance
{
    class A
    {
        public void Print()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    class B:A, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public new void Print()
        {
            Console.WriteLine(GetType().Name);
            ObservableCollection<string> o=new ObservableCollection<string>();
            o.CollectionChanged += HandleChange;
        }
        private void HandleChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var x in e.NewItems)
            {
                // do something
            }

            foreach (var y in e.OldItems)
            {
                //do something
            }
            if (e.Action == NotifyCollectionChangedAction.Move)
            {
                //do something
            }
        }
    }
}
