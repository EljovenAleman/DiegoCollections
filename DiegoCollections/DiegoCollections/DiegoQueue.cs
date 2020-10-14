namespace DiegoCollections
{
    public class DiegoQueue<T>
    {
        public T[] myList = new T[0];

        public void Enqueue(T enqueueThis)
        {
            T[] newArray = new T[myList.Length + 1];

            for (int i = 0; i < myList.Length; i++)
            {
                newArray[i] = myList[i];
            }

            newArray[myList.Length] = enqueueThis;

            myList = newArray;
        }

        public T Dequeue()
        {
            T returnThis = myList[0];

            T[] newArray = new T[myList.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = myList[i+1];
            }

            myList = newArray;

            return returnThis; 
        }

        public T Peek()
        {
            return myList[0];
        }

        public int GetLength()
        {
            return myList.Length;
        }

        public void Reverse()
        {
            T[] newArray = new T[myList.Length];
            for(int i=0; i<myList.Length;i++)
            {
                newArray[i] = myList[myList.Length - i-1];
            }

            myList = newArray;
        }

        public void Clear()
        {
            T[] newArray = new T[0];
            myList = newArray;
        }


    }


}
