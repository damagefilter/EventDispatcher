using System;
using System.Collections.Generic;

namespace GameKombinat.EventDispatcher.Examples.QueryLogging {
    /// <summary>
    /// Exemplary log select queries by passing it to a logging service or some such thing.
    /// </summary>
    public class ExampleQueryLogger : IDisposable {

        private Queue<string> loggingQueue;

        public ExampleQueryLogger() {
            loggingQueue = new Queue<string>(10);
            // Register our listener for the query notification event here
            QueryNotifierEvent.Register(OnQueryNotification);
        }

        public void Dispose() {
            // don't forget to de-register when the object is disposed.
            QueryNotifierEvent.Unregister(OnQueryNotification);
        }

        /// <summary>
        /// In our example, this is raied in the ExampleDatabaseAccess.SelectQuery() method.
        /// We can have any number of listeners to this. Everythign that requires this notification can register the same way
        /// and will receive the same event object. If you want it, you could even modify the data during the execution.
        /// </summary>
        /// <param name="ev"></param>
        private void OnQueryNotification(QueryNotifierEvent ev) {
            loggingQueue.Enqueue(ev.Payload);
        }
    }
}
