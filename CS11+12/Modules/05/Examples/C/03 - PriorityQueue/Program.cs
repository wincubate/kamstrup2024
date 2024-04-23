using Wincubate.Module05.C;

PriorityQueue<Connection, TimeOnly> pq = new();

pq.Enqueue(new Connection("vm-dev-1"), new TimeOnly(15, 57, 46, 231));
pq.Enqueue(new Connection("vm-test-4"), new TimeOnly(14, 01, 22, 908));
pq.Enqueue(new Connection("vm-test-3"), new TimeOnly(16, 12, 01, 004));
pq.Enqueue(new Connection("vm-test-1"), new TimeOnly(13, 00, 00, 447));
pq.Enqueue(new Connection("vm-dev-9"), new TimeOnly(15, 18, 48, 760));


// Refresh connections

//var toBeKeptAlive = pq.Dequeue();
//TimeOnly newTime = toBeKeptAlive.KeepAlive();
//pq.Enqueue(toBeKeptAlive, newTime);

// Dequeue and print
while (pq.TryDequeue(out Connection? connection, out TimeOnly time))
{
    Console.WriteLine($"{connection} last connected at {time.ToLongTimeString()}");
}
