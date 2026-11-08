namespace Backend;

public class DoublyLinkedList<T> where T : IComparable<T>
{
    private DoubleNode<T>? _head;
    private DoubleNode<T>? _tail;

    public DoublyLinkedList()
    {
        _head = null; // This line can be removed
        _tail = null; // This line can be removed
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }
        newNode.Next = _head;
        _head.Prev = newNode;
        _head = newNode;
    }

    public void InsertAtEnd(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }
        _tail.Next = newNode;
        newNode.Prev = _tail;
        _tail = newNode;
    }

    public void InsertInOrder(T data)
    {
        var newNode = new DoubleNode<T>(data);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }

        var current = _head;

        while (current != null && current.Data!.CompareTo(data) < 0) 
        { 
            current = current.Next;
        }

        if (current == _head) 
        {
            newNode.Next = _head;
            _head.Prev = newNode;
            _head = newNode;
            return;
        }

        if (current == null) 
        {
            _tail!.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;
            return;
        }

        newNode.Next = current;
        newNode.Prev = current.Prev;
        current.Prev!.Next = newNode;
        current.Prev = newNode;
    }

    public void SortDescending() 
    {
        var current = _head;

        while (current != null)
        {
            var next = current.Next;

            current.Next = current.Prev;
            current.Prev = next;

            current = next;
        }

        var temp = _head;
        _head = _tail;
        _tail= temp;
    }

    public List<T> GetModes()
    {
        var modes = new List<T>();
        var maxCount = 0;
        var current = _head;

        while (current != null)
        {
            var count = 0;
            var search = _head;

            while (search != null)
            {
                if (current.Data!.CompareTo(search.Data) == 0)
                {
                    count++;
                }

                search = search.Next;
            }

            if (count > maxCount)
            {
                maxCount = count;
                modes.Clear();
                modes.Add(current.Data!);
            }

            else if (count == maxCount && !modes.Contains(current.Data!))
            {
                modes.Add(current.Data!);
            }

            current = current.Next;
        }

        return modes;
    }

    public void DisplayOccurrences()
    {
        var current = _head;
        var displayed = new List<T>();

        while (current != null)
        {
            if (!displayed.Contains(current.Data!))
            {
                var count = 0;
                var search = _head;

                while(search != null) 
                {
                    if (current.Data!.CompareTo(search.Data!) == 0 )
                    {
                        count++;
                    }

                    search= search.Next;
                }

                Console.WriteLine($"{current.Data} {new string('*', count)}");
                displayed.Add(current.Data!);
            }

            current= current.Next;
        }
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.CompareTo(data) == 0)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Remove(T data)
    {
        var current = _head;

        while (current != null)
        {
            if (current.Data!.CompareTo(data) == 0 )
            {
                if (current.Prev == null) 
                {
                    _head = current.Next;
                }
                else
                {
                    current.Prev.Next = current.Next;
                }

                if (current.Next == null)
                {
                    _tail = current.Prev;
                }
                else
                {
                    current.Next.Prev = current.Prev;
                }

                return;
            }

            current = current.Next;
        }
    }

    public void RemoveAll(T data) 
    {
        var current = _head;

        while (current != null)
        {
            var next = current.Next;

            if (current.Data!.CompareTo(data) == 0)
            {
                if (current.Prev == null)
                {
                    _head = current.Next;
                }
                else
                {
                    current.Prev.Next = current.Next;
                }

                if (current.Next == null)
                {
                    _tail = current.Prev;
                }
                else
                {
                    current.Next.Prev = current.Prev;
                }
            }

            current = next;
        }
    }

    public override string ToString() 
    {
        var output = string.Empty;
        var current = _head;
        while (current != null)
        {
            output += $"{current.Data} <-> ";
            current = current.Next;
        }
        return $"{output} null";
    }

    public string ToStringReverse()
    {
        var output = string.Empty;
        var current = _tail;
        while (current != null)
        {
            output += $"{current.Data} <-> ";
            current = current.Prev;
        }
        return $"{output} null";
    }
}
