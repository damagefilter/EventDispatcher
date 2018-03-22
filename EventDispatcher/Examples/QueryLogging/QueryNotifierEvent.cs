namespace GameKombinat.EventDispatcher.Examples.QueryLogging {
    public class QueryNotifierEvent : Event<QueryNotifierEvent> {
        public string Payload {
            get;
            set;
        }
    }
}
