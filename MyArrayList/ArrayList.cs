using System;

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
            MoveOneStepLeft(index);
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
        public int GetValue(int index)
        {
            if (Lenght == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            return _array[index];
        }

        // первый индекс по значению(-1 - не нашел) (task 12)
        public int ReturnFirstIndex(int value)
        {
            int firstIndex = -1;
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    firstIndex = i;
                    break;
                }
            }
            return firstIndex;
        }

        // изменение по индексу (task 13)
        public void ChangeByIndex(int index, int value)
        {
            if (Lenght == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            if (index > Lenght)
            {
                throw new Exception("The index does not exist");
            }
            _array[index] = value;
        }

        // реверс(123 -> 321) (task 14)
        public void Reverse()
        {
            int newLenght = _array.Length;
            int[] newArray = new int[newLenght];
            Copy(newArray);
            int n = newLenght / 2;
            for (int i = 0; i < n; i++)
            {
                int tmp = _array[i];
                _array[i] = newArray[newLenght - (i + 1)];
                newArray[newLenght - (i + 1)] = tmp;
            }
            _array = newArray;
        }

        // поиск значения максимального элемента (task 15)
        public int FindMaxValue()
        {
            if (Lenght == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int maxValue = _array[0];
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                }
            }
            return maxValue;
        }

        // поиск значения минимального элемента (task 16)
        public int FindMinValue()
        {
            if (Lenght == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int minValue = _array[0];
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] > minValue)
                {
                    minValue = _array[i];
                }
            }
            return minValue;
        }
        // поиск индекс максимального элемента (task 17)
        public int FindIndexOfMaxValue()
        {
            if (Lenght == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int index = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] > _array[index])
                {
                    index = i;
                }
            }
            return index;
        }

        // поиск индекс минимального элемента (task 18)
        public int FindIndexOfMinValue()
        {
            if (Lenght == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int index = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] < _array[index])
                {
                    index = i;
                }
            }
            return index;
        }

        // сортировка по возрастанию (task 19)
        public void SortAscending()
        {
            for (int i = 0; i < Lenght - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Lenght; j++)
                {
                    if (_array[j] < _array[min])
                    {
                        min = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[min];
                _array[min] = tmp;
            }
        }

        // сортировка по убыванию (task 20)
        public void SortDescending()
        {
            for (int i = 0; i < Lenght; i++)
            {
                for (int j = Lenght - 1; j > i; j--)
                {
                    if (_array[j] > _array[j - 1])
                    {
                        int tmp = _array[j];
                        _array[j] = _array[j - 1];
                        _array[j - 1] = tmp;
                    }
                }
            }

        }
        // удаление по значению первого(вернуть индекс)(-1 - ничего не удалил) (task 21)
        public int ClearFirstValue(int value)
        {
            int index = -1;
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    MoveOneStepLeft(i);
                    Lenght--; 
                    index = i;
                    break;
                }
            }
            return index;
        }

        // удаление по значению всех(вернуть кол-во)(0 - ничего не удалил) (task 22)
        public int ClearAllByValue(int value)
        {
            int count = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if(_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Lenght -= count;
            return count;
        }






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
