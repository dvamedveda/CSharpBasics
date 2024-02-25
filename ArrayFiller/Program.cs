namespace ArrayFiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int size;
            string sizeInput;
            bool sizeCorrect = false;

            do {
                Console.WriteLine("Enter array size, please");
                sizeInput = Console.ReadLine();
                if (!int.TryParse(sizeInput, out size))
                {
                    Console.WriteLine("Incorrect array size.");
                } else
                {
                    Console.WriteLine("Size accepted, current size = " + sizeInput);
                    sizeCorrect = true;
                }
            } while (!sizeCorrect);

            int[,] arrayOfArrays = new int[size,size];
            Console.WriteLine("Array initialized success");
            Console.WriteLine("Current array state: ");
            for (int i = 0; i < arrayOfArrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfArrays.GetLength(1); j++)
                {
                    Console.Write(arrayOfArrays[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string userChoise;
            do
            {
                Console.WriteLine("Next element? Enter 'yes' or 'no'");
                userChoise = Console.ReadLine();
                if (userChoise != "no" && userChoise != "yes")
                {
                    Console.WriteLine("Incorrect input!");
                    continue;
                } else if (userChoise == "no")
                {
                    Console.WriteLine("Program exiting");
                    Console.ReadKey();
                    break;
                } else
                {
                    

                    Console.WriteLine("Enter row number to filling:");
                    int rowIndex;
                    bool rowChecked = false;
                    do
                    {
                        string rowInput = Console.ReadLine();
                        bool rowIsNumber = int.TryParse(rowInput, out rowIndex);
                        if (rowIsNumber && rowIndex < arrayOfArrays.GetLength(0))
                        {
                            rowChecked = true;
                        } else
                        {
                            Console.WriteLine("Incorrect row index!");
                            Console.WriteLine("Reenter row index, please");
                            continue;
                        }

                    } while (!rowChecked);

                    Console.WriteLine("Enter column number to filling:");
                    int columnIndex;
                    bool columnChecked = false;
                    do
                    {
                        string columnInput = Console.ReadLine();
                        bool columnIsNumber = int.TryParse(columnInput, out columnIndex);
                        if (columnIsNumber && columnIndex < arrayOfArrays.GetLength(1))
                        {
                            columnChecked = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect column index!");
                            Console.WriteLine("Reenter column index, please");
                            continue;
                        }

                    } while (!columnChecked);

                    if (arrayOfArrays[rowIndex, columnIndex] == 0)
                    {
                        arrayOfArrays[rowIndex, columnIndex] = 1;
                    } else
                    {
                        Console.WriteLine("Element filled already, please choose another element");
                        continue;
                    }

                    Console.WriteLine("Success checked element at column " + rowIndex.ToString() + " and row " + columnIndex.ToString());
                    Console.WriteLine("Current array state: ");
                    for (int i = 0; i < arrayOfArrays.GetLength(0); i++)
                    {
                        for (int j = 0; j < arrayOfArrays.GetLength(1); j++)
                        {
                            Console.Write(arrayOfArrays[i, j]);
                            Console.Write(' ');
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }


            } while (true);
        }
    }
}
