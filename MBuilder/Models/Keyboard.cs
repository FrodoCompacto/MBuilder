using LowLevelHooking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MBuilder.Models
{
    class Keyboard
    {
        public List<VirtualKey> pressedKeys { get; private set; }

        public Keyboard()
        {
            pressedKeys = new List<VirtualKey>();
        }

        public Keyboard(List<VirtualKey> pressedKeys)
        {
            this.pressedKeys = pressedKeys;
        }

        public void addKey(VirtualKey key)
        {
            if (!pressedKeys.Contains(key))
            {
                pressedKeys.Add(key);
            }
        }

        public void removeKey(VirtualKey key) {
            if (pressedKeys.Contains(key))
            {
                pressedKeys.Remove(key);
            }
        }

        public void clearKeys()
        {
            pressedKeys.Clear();
        }

        public String toString()
        {
            String aux = "";

            pressedKeys.ForEach(key => {
                aux += key.ToString();
            });

            return aux;
        }

        public override bool Equals(object obj)
        {
            return obj is Keyboard keyboard &&
                   EqualityComparer<List<VirtualKey>>.Default.Equals(pressedKeys, keyboard.pressedKeys);
        }
    }
}
