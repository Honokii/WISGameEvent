namespace WIS.Utils.Events {
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}