namespace GameKombinat.EventDispatcher.Examples.QueryLogging {
    /// <summary>
    /// Imagine this class being a manager for database connections.
    /// </summary>
    public class ExampleDatabaseAccess {

        // you could also make a new event instance every time but as it is with allocations. Do try to avoid them where possible
        private readonly QueryNotifierEvent notifier = new QueryNotifierEvent();

        /// <summary>
        /// Lets imagine that this is a method that will execute an sql query on a database connection.
        /// We leave out that bit for brevity.
        /// </summary>
        /// <param name="query"></param>
        public void SelectQuery(string query) {
            // Do some querying on a connection ...

            #region The important bit!

            // select query succeeded. Raise event with the last successful sql query
            notifier.Payload = query;
            notifier.Call();

            #endregion

            // return result set or some such thing...
        }
    }
}
