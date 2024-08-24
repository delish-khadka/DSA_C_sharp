using QueueUsingArrays;
QueueImpl queueImpl = new QueueImpl(5);

queueImpl.Enqueue(1);
queueImpl.Enqueue(2);
queueImpl.Enqueue(3);
queueImpl.Enqueue(4);
queueImpl.Enqueue(5);

queueImpl.Peek();

queueImpl.Dequeue();
queueImpl.Peek();