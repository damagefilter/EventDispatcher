namespace GameKombinat.EventDispatcher.Examples.Unity {
    /// <summary>
    /// The exemplary input handler.
    /// It raises the menu trigger if Esc is pressed.
    /// The good bits? The Input handler doesn't need to know about the
    /// details of how to do this exactly. It just informs the thing on the other side that it should do it.
    /// </summary>
    public class InputManager : MonoBehaviour {

        private readonly TriggerMainMenuEvent menuTrigger = new TriggerMainMenuEvent();

        private void Update() {
            if (Input.GetKey(KeyCode.Esc)) {
                menuTrigger.Call();
            }
        }
    }
}
