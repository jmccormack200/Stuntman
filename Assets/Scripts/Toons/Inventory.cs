using System;
using UnityEngine;
using System.Collections;

/// <summary>
/// Contains a collection of items 
/// </summary>
public class Inventory : IEnumerable {
    
    public ArrayList items { get; private set; }

    // IEnumerator methods allow a 'foreach' to be used on the Inventory class
    #region IEnumerator Stuff

    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)new InventoryEnumerator(this);
    }

    // For use with foreach
    private class InventoryEnumerator : IEnumerator
    {
        private Inventory _inventory;
        private int _index;

        public InventoryEnumerator(Inventory inventory)
        {
            _inventory = inventory;
            _index = -1;
        }

        public void Reset()
        {
            _index = -1;
        }

        public object Current
        {
            get
            {
                return _inventory.items[_index];
            }
        }

        public bool MoveNext()
        {
            _index++;
            if (_index >= _inventory.items.Count)
                return false;
            else
                return true;
        }
    }
    #endregion

    public Inventory()
    {
        items = new ArrayList();
    }

    public void addItem(Item item)
    {
        items.Add(item);
    }

    public int Count()
    {
        return items.Count;
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

}
