namespace MassTransit.SqlTransport
{
    public enum SqlReceiveMode
    {
        /// <summary>
        /// Messages are delivered normally in priority, enqueue_time order
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Messages are delivered in priority enqueue_time order, but only one message per PartitionKey at a time
        /// </summary>
        Partitioned = 1,

        /// <summary>
        /// Messages are delivered in priority enqueue_time order, with additional messages fetched from the server for the same PartitionKey
        /// </summary>
        PartitionedConcurrent = 2,

        /// <summary>
        /// Messages are delivered in first-in first-out order, but only one message per PartitionKey at a time
        /// </summary>
        PartitionedOrdered = 3,

        /// <summary>
        /// Messages are delivered in first-in first-out order, with additional messages fetched from the server for the same PartitionKey
        /// </summary>
        PartitionedOrderedConcurrent = 4,

        /// <summary>
        /// Messages are delivered in first-in first-out order, but only one message per PartitionKey at a time across all consumer instances
        /// </summary>
        /// <remarks>
        /// No matter how many consumer instances are started, next message in a partition is guaranteed to be delivered only after
        /// the previous message from this partition is processed.
        /// </remarks>
        PartitionedGloballyOrdered = 5,
    }
}
