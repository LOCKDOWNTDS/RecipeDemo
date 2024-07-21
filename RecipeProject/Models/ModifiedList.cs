namespace RecipeProjectMVC.Models
{
    public class ModifiedList<T>
    {
        private List<T> internalList = new List<T>();

        public T this[int index]
        {
            get
            {
                if (index < 1 || index > internalList.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index must be greater than 0 and less than or equal to the list size.");
                }
                return internalList[index - 1];
            }
            set
            {
                if (index < 1 || index > internalList.Count + 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index must be greater than 0 and less than or equal to the list size + 1.");
                }
                if (index == internalList.Count + 1)
                {
                    internalList.Add(value);
                }
                else
                {
                    internalList[index - 1] = value;
                }
            }
        }

        public void Add(T item)
        {
            internalList.Add(item);
        }

        public int Count => internalList.Count;

        public void RemoveAt(int index)
        {
            if (index < 1 || index > internalList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be greater than 0 and less than or equal to the list size.");
            }
            internalList.RemoveAt(index - 1);
        }
    }
}
