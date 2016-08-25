﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using JetBrains.Annotations;

namespace FirstFloor.ModernUI {
    public class BetterObservableCollection<T> : ObservableCollection<T> {
        public BetterObservableCollection() {}

        public BetterObservableCollection(List<T> list) : base(list) {}

        public BetterObservableCollection([NotNull] IEnumerable<T> collection) : base(collection) {}

        public static BetterObservableCollection<T> Create([NotNull] IEnumerable<T> collection) => new BetterObservableCollection<T>(collection);

        public virtual void AddRange([NotNull] IEnumerable<T> range) {
            if (range == null) throw new ArgumentNullException(nameof(range));

            var list = range.ToList();
            if (list.Count > 3 && list.Count > Count) {
                foreach (var item in list) {
                    Items.Add(item);
                }

                OnPropertyChanged(new PropertyChangedEventArgs("Count"));
                OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            } else {
                foreach (var item in list) {
                    Add(item);
                }
            }
        }

        public virtual void RemoveRange(IEnumerable<T> items) {
            foreach (var item in items) {
                Remove(item);
            }
        }

        public virtual bool ReplaceIfDifferBy([NotNull] IEnumerable<T> range) {
            if (range == null) throw new ArgumentNullException(nameof(range));

            var list = range as IList<T> ?? range.ToList();
            if (Items.SequenceEqual(list)) return false;

            Items.Clear();
            foreach (var item in list) {
                Items.Add(item);
            }

            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            return true;
        }

        public virtual void ReplaceEverythingBy([NotNull] IEnumerable<T> range) {
            if (range == null) throw new ArgumentNullException(nameof(range));
            
            Items.Clear();
            foreach (var item in range) {
                Items.Add(item);
            }

            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void Replace(T item, T newItem) {
            var index = IndexOf(item);
            if (index < 0) return;
            this[index] = newItem;
        }
    }
}
