namespace  WIS.Utils.Events {
    using UnityEngine;
    using UnityEngine.Events;
    public abstract class BaseGameEventListener<T, E, R> : MonoBehaviour, 
                                IGameEventListener<T> where E : BaseGameEvent<T> where R : UnityEvent<T> {
        [SerializeField]
        private E _GameEvent;
        public E GameEvent {
            get {
                return _GameEvent;
            }

            set {
                _GameEvent = value;
            }
        }

        [SerializeField]
        private R _Response;
        public R Response {
            get {
                return _Response;
            }

            set {
                _Response = value;
            }
        }

        private void OnEnable() {
            if (GameEvent == null) return;

            GameEvent.RegisterListener(this);
        }

        private void OnDisable() {
            if (GameEvent == null) return;

            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item) {
            if (Response == null) return;

            Response.Invoke(item);
        }
    }
}