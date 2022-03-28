using UnityEngine;
using WIS.Utils.Events;

//Event
//Set the menu name as you see fit.
[CreateAssetMenu(fileName = "NewOnGameEvent", menuName = "WIS/GameEvents/OnGameEvent")]
public class OnGameEvent : BaseGameEvent<OnGameEventArgs> { }

//Arguments
//Put parameters here if you want to pass that through the event
public class OnGameEventArgs {

}