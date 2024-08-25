using QueueUsingLinkedList;

QueueImpl queueImpl = new QueueImpl();
queueImpl.Enqueue(1);
queueImpl.Enqueue(2);
queueImpl.Enqueue(3);
queueImpl.Enqueue(4);
queueImpl.Enqueue(5);

Console.WriteLine(queueImpl.Peek());

queueImpl.Dequeue();
Console.WriteLine(queueImpl.Peek());
