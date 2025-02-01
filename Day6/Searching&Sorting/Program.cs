using System;

class Program
{
    static void Main()
    {
        int[] nums = { 5, 3, 8, 4, 10, 20, 30, 40 };
        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Linear Search");
            Console.WriteLine("2. Binary Search");
            Console.WriteLine("3. Bubble Sort");
            Console.WriteLine("4. Selection Sort");
            Console.WriteLine("5. Insertion Sort");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter target number: ");
                    int target1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Index: " + LinearSearch(nums, target1));
                    break;
                case 2:
                    Array.Sort(nums); // Binary search requires sorted array
                    Console.Write("Enter target number: ");
                    int target2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Index: " + BinarySearch(nums, target2));
                    break;
                case 3:
                    BubbleSort(nums);
                    Console.WriteLine("Sorted Array: " + string.Join(", ", nums));
                    break;
                case 4:
                    SelectionSort(nums);
                    Console.WriteLine("Sorted Array: " + string.Join(", ", nums));
                    break;
                case 5:
                    InsertionSort(nums);
                    Console.WriteLine("Sorted Array: " + string.Join(", ", nums));
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex]) minIndex = j;
            }
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i], j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}
