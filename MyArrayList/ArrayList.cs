namespace MyLists
{
    public class ArrayList
    {
        public int Lenght { get; private set; }

        private int[] _array;

        // 3 конструктора(пустой, на основе одного элемента, на основе массива) (task 23)
        public ArrayList()
        {
            _array = new int[8];
            Lenght = 5;
        }

        public ArrayList(int value)
        {
            _array = new int[3];
            Lenght = 1;
            _array[0] = value;
        }

        public ArrayList(int[] array)
        {
            _array = array;
            Lenght = _array.Length;
        }
        // добавление значения в конец (task 1)
        public void AddLast(int value)
        {
            if (Lenght >= _array.Length)
            {
                UpSize();
            }
            _array[Lenght] = value;
            Lenght++;
        }
        // добавление значения в начало (task 2)
        public void AddFirst(int value)
        {
            if (Lenght >= _array.Length)
            {
                UpSize();
            }
            _array[0] = value;
            Lenght++;
        }
        // добавление значения по индексу (task 3)
        public void Insert(int index, int value)
        {
            if (Lenght + 1 >= _array.Length)
            {
                UpSize();
            }
            MoveOneStepRight(index);
            _array[index] = value;
            Lenght++;
        }
        // удаление из конца одного элемента (task 4)
        public void RemoveLast()
        {
            Lenght--;
        }
        // удаление из начала одного элемента (task 5)
        public void RemoveFirst()
        {
            MoveOneStepLeft(0);
            Lenght--;
        }
        // удаление по индексу одного элемента (task 6)
        public void RemoveByIndex(int index)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (i == index)
                {
                    MoveOneStepLeft(index);
                    break;
                }
            }
            Lenght--;
        }
        // удаление из конца N элементов (task 7)
        public void RemoveRangeFromEnd(int count)
        {
            Lenght -= count;
            int[] newArray = new int[Lenght];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        // удаление из начала N элементов (task 8)
        public void RemoveRangeFromBeginning(int count)
        {
            Lenght -= count;
            int[] newArray = new int[Lenght];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + count];               
            }
            _array = newArray;
        }
        // удаление по индексу N элементов (task 9)
        public void RemoveRangeFromIndex(int count, int index)
        {
            Lenght -= count;
            int[] newArray = new int[Lenght];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + count];
            }
            _array = newArray;
        }
        // вернуть длину (task 10)
        public int GetLenght()
        {
            return Lenght;
        } 
        // доступ по индексу (task 11)
        // первый индекс по значению(-1 - не нашел) (task 12)
        // изменение по индексу (task 13)
        // реверс(123 -> 321) (task 14)
        // поиск значения максимального элемента (task 15)
        // поиск значения минимального элемента (task 16)
        // поиск индекс максимального элемента (task 17)
        // поиск индекс минимального элемента (task 18)
        // сортировка по возрастанию (task 19)
        // сортировка по убыванию (task 20)
        // удаление по значению первого(вернуть индекс)(-1 - ничего не удалил) (task 21)
        // удаление по значению всех(вернуть кол-во)(0 - ничего не удалил) (task 22)







        // добавление списка(вашего самодельного) в конец (task 24)
        // добавление списка в начало (task 25)
        // добавление списка по индексу (task 26)

        /// <summary>
        /// delete later
        /// </summary>
        public void Write()
        {
            for (int i = 0; i < Lenght; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int [] newArray = new int[newLength];
            Copy(newArray);           
        }

        private void DownSize()
        {
            int newLength = _array.Length / 3;
            int [] newArray = new int[newLength];
            Copy(newArray);
        }

        private void Copy(int[] newArray)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private void MoveOneStepRight(int index)
        {
            Lenght++;
            int[] newArray = new int[Lenght];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Lenght; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }

        private void MoveOneStepLeft(int index)
        {
            int[] newArray = new int[_array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < _array.Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
        }




    }
}
