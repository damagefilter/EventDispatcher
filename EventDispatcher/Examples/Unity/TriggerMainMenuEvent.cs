namespace GameKombinat.EventDispatcher.Examples.Unity {
    /// <summary>
    /// Event to tell a listener to trigger the main menu.
    /// It's just for control flow, no data inside is required.
    /// </summary>
    public class TriggerMainMenuEvent : Event<TriggerMainMenuEvent> {

    }
}
