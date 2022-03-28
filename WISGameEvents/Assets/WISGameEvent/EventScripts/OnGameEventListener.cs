using System;
using UnityEngine.Events;
using WIS.Utils.Events;

//Listener
public class OnGameEventListener : BaseGameEventListener<OnGameEventArgs, OnGameEvent, OnGameEventResponse> { }

//Response
[Serializable]
public class OnGameEventResponse : UnityEvent<OnGameEventArgs> { }