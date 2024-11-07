namespace ConsoleApp2
{

    public class Matrix
    {
        private int[,] matrix;

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
        }

        public int Rows { get { return matrix.GetLength(0); } }
        public int Columns { get { return matrix.GetLength(1); } }

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public void Input()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write("Введите элемент [{0},{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public int FindMaxElement()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        public int FindMinElement()
        {
            int min = matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Размеры матриц должны быть одинаковыми");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        public static string operator ==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Матрицы разных размеров");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            int c = -1;
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        continue;
                    }
                    else
                    {
                        c = 1;
                        throw new ArgumentException("Матрицы разные");
                    }
                }
            }

            if (c == -1)
            {
                return "Матрицы равны";
            }
            else
            {
                throw new ArgumentException("Матрицы разные");
            }

        }
        public static string operator !=(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                Console.WriteLine("Матрицы разных размеров");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            int c = -1;
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        continue;
                    }
                    else
                    {
                        c = 1;
                        throw new ArgumentException("Матрицы разные");
                    }
                }
            }

            if (c == -1)
            {
                return "Матрицы равны";
            }
            else
            {
                throw new ArgumentException("Матрицы разные");
            }
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Компоненты матрицы должны иметь одинаковые размеры");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Компоненты матрицы должны иметь одинаковые размеры");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] * b[i, j];
                }
            }
            return result;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }

    
    public class ReadingList
    {
        private Book[] books;     
        private int count = 0;    

        public ReadingList(int capacity)
        {
            books = new Book[capacity];
        }

        
        public static ReadingList operator +(ReadingList readingList, Book book)
        {
            if (readingList.count < readingList.books.Length)
            {
                readingList.books[readingList.count] = book;
                readingList.count++;
                Console.WriteLine($"'{book.Title}' добавлена в список.");
            }
            else
            {
                Console.WriteLine("Список заполнен. Невозможно добавить новую книгу.");
            }
            return readingList;
        }

        
        public static ReadingList operator -(ReadingList readingList, Book book)
        {
            int index = -1;

           
            for (int i = 0; i < readingList.count; i++)
            {
                if (readingList.books[i] == book)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine($"'{book.Title}' нет в списке.");
            }
            else
            {
                
                for (int i = index; i < readingList.count - 1; i++)
                {
                    readingList.books[i] = readingList.books[i + 1];
                }

                readingList.books[readingList.count - 1] = null; 
                readingList.count--;
                Console.WriteLine($"'{book.Title}' удалена из списка.");
            }

            return readingList;
        }

        
        public bool ContainsBook(Book book)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i] == book)
                {
                    return true;
                }
            }
            return false;
        }

        
        public void DisplayBooks()
        {
            Console.WriteLine("Список книг для прочтения:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }
            if (count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
