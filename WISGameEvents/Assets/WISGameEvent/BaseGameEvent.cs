namespace WIS.Utils.Events {
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class BaseGameEvent<T> : ScriptableObject
    {
        private readonly List<IGameEventListener<T>> _EventListeners = new List<IGameEventListener<T>>();

        public void Raise(T item) {
            for (int i = _EventListeners.Count -1; i >= 0; i--) {
                _EventListeners[i].OnEventRaised(item);
            }
        }

        public void RegisterListener(IGameEventListener<T> listener) {
            if (_EventListeners.Contains(listener)) {
                return;
            }

            _EventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener) {
            if (!_EventListeners.Contains(listener)) {
                return;
            }

            _EventListeners.Remove(listener);
        }
    }
}