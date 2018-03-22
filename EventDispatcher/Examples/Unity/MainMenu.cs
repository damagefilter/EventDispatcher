namespace GameKombinat.EventDispatcher.Examples.Unity {
    public class MainMenu : MonoBehaviour {

        public GameObject mainMenuPanel;

        private void Awake() {
            // register event at an early moment.
            // could also use the constructor as this isn't Unity API.
            TriggerMainMenuEvent.Register(OnMenuRequest);
        }

        private void OnDestroy() {
            // never forget to unregister what you have registered or else!
            TriggerMainMenuEvent.Unregister(OnMenuRequest);
        }

        private void OnMenuRequest(TriggerMainMenuEvent ev) {
            // Toggle the go that holds the main menu.
            mainMenuPanel.SetActive(!mainMenuPanel.activeSelf);
        }
    }
}
