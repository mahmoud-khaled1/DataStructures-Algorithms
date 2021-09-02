## Table of contents C++
* [string](#string)
* [queue](#queue)
* [dequeue](#dequeue)
* ## Algorithms 
* [Big O Notation](#bigo)
* [Prefix Sum](#prefixsum)
* [Frequency array](#frequencyy)
* [Insertion Sort Algorithm ](#insertionsort)
* [Bubble Sort Algorithm ](#bubblesort)
* [Binary Search](#binarysearch)
* [Selection Sort](#selectionsort)
* [dynamic Programming](#dp)




## string
some important function in string 
* x.find("asd");    + // return index or ( npos) -1 
* if (x.find("asd") != string::npos)
   Found
* transform(s.begin(),s.end(),s.begin(),(int (*)(int))tolower );   //convert chars to small char
* x.erase(3, 2); // erase range from pos 3 to pos 4
* x.erase(pos); // erase from this pos to end of string 
* cout<<lower_bound(v.begin(),v.end(),87)-v.begin()<<endl; //prit pos of this value if Found or size of string if not found
* cout<<upper_bound(v.begin(),v.end(),7)-v.begin()<<endl; //prit pos of this value +1  if Found or size of string if not found
* Sort(str.begin(),s.end()) // sort ascending
* Sort(s.begin(), s.end(),greater<char>()); // sort descending
* stringstream geek(str); 
  geek >> IntVal;  // Convert from string to int 
* int number= stoi(“123”);  // Convert from string to int 
* string s=to_string(IntVal);  // Convert from int to string 
* getline(cin,str); // to read string with spaces  	
  
	
	
	
	
## queue
some important function in Queue STL  

	
## dequeue
some important function in dequeue STL  

## bigo
Hi there!  This covers the space and time Big-O complexities of common algorithms used in Computer Science. <br/>
![1](https://user-images.githubusercontent.com/43557035/128607264-121d9663-014d-48e6-b49f-fd61154b6e74.PNG)
![2](https://user-images.githubusercontent.com/43557035/128607391-ca4ef377-c561-43a3-8810-9dc88ef2ffe4.PNG)
![3](https://user-images.githubusercontent.com/43557035/128607394-6e54f4cc-34ba-432a-8ba4-9cecfa0e416a.PNG)

	
	
## prefixsum
Given an array arr[] of size n, its prefix sum array is another array prefixSum[] of the same size, such that the value of prefixSum[i] is arr[0] + arr[1] + arr[2] … arr[i].<br/>	

Examples : <br/>	

Input  : arr[] = {10, 20, 10, 5, 15}<br/>	
Output : prefixSum[] = {10, 30, 40, 45, 60}<br/>	

Explanation : While traversing the array, update <br/>	
the element by adding it with its previous element.<br/>	
prefixSum[0] = 10, <br/>	
prefixSum[1] = prefixSum[0] + arr[1] = 30, <br/>	
prefixSum[2] = prefixSum[1] + arr[2] = 40 and so on.<br/>	

Example :<br/>	
// prefix sum arrayclass<br/>	

    static void fillPrefixSum(int[] arr, int n,
                              int[] prefixSum)
    {
        prefixSum[0] = arr[0];
 
        // Adding present element
        // with previous element
        for (int i = 1; i < n; ++i)
            prefixSum[i] = prefixSum[i - 1] + arr[i];
    }
 
    // Driver code
    public static void Main()
    {
        int[] arr = { 10, 4, 16, 20 };
        int n = arr.Length;
        int[] prefixSum = new int[n];
 
        fillPrefixSum(arr, n, prefixSum);
 
        for (int i = 0; i < n; i++)
            Console.Write(prefixSum[i] + " ");
        Console.Write("");
    }
	
## frequencyy
The usage of frequency arrays has its limitations. Remember that you need an array whose size is equal to the value of the largest integer in the original array. Which means that you can't use a frequency array if the values in the original array can be up to 10^9 for example.<br/>	
	
You can use a frequency array to sort an array in O(M) time, where M is the value of the largest integer in the array. Which could be much more efficient than merge sort (which runs in O(NlogN)) in cases where the array size is large but the values inside the array are bounded with a small number. <br/>	
	
Example :<br/>	
Given an array which may contain duplicates, print all elements and their frequencies.<br/>	
Input :  arr[] = {10, 20, 20, 10, 10, 20, 5, 20}<br/>	
Output : 10--> 3<br/>	
         20--> 4<br/>	
         5-->  1<br/>	

    static void countFreq(int []arr, int n)
    {
        Dictionary<int, int> mp = new Dictionary<int,int>();
 
        // Traverse through array elements and
        // count frequencies
        for (int i = 0; i < n; i++)
        {
            if (mp.ContainsKey(arr[i]))
            {
                var val = mp[arr[i]];
                mp.Remove(arr[i]);
                mp.Add(arr[i], val + 1);
            }
            else
            {
                mp.Add(arr[i], 1);
            }
        }
         
        // Traverse through map and print frequencies
        foreach(KeyValuePair<int, int> entry in mp)
        {
            Console.WriteLine(entry.Key + " " + entry.Value);
        }
    }
 
    // Driver code
    public static void Main(String []args)
    {
        int []arr = {10, 20, 20, 10, 10, 20, 5, 20};
        int n = arr.Length;
        countFreq(arr, n);
    }
	
Time Complexity : O(n) <br/>	
Auxiliary Space : O(n)	<br/>	

## insertionsort

Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.<br/>	
Algorithm <br/>	
To sort an array of size n in ascending order: <br/>	
1: Iterate from arr[1] to arr[n] over the array. <br/>	
2: Compare the current element (key) to its predecessor. <br/>	
3: If the key element is smaller than its predecessor, compare it to the elements before. Move the greater elements one position up to make space for the swapped element.<br/>	
Example: <br/>	
![insertionsort](https://user-images.githubusercontent.com/43557035/128423153-d8751477-8831-491f-90f8-ec5f61b0fe62.png)

Another Example: <br/>	
12, 11, 13, 5, 6<br/>	
Let us loop for i = 1 (second element of the array) to 4 (last element of the array)<br/>	
i = 1. Since 11 is smaller than 12, move 12 and insert 11 before 12 <br/>	
11, 12, 13, 5, 6<br/>	
i = 2. 13 will remain at its position as all elements in A[0..I-1] are smaller than 13 <br/>	
11, 12, 13, 5, 6<br/>	
i = 3. 5 will move to the beginning and all other elements from 11 to 13 will move one position ahead of their current position. <br/>	
5, 11, 12, 13, 6<br/>	
i = 4. 6 will move to position after 5, and elements from 11 to 13 will move one position ahead of their current position. <br/>	
5, 6, 11, 12, 13 <br/>	
	
    void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i) {
            int key = arr[i];
            int j = i - 1;
 
            // Move elements of arr[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
Best Case :  : Complexity: O(n) if array is sorted .<br/>	
Average Case : Complexity: O(n^2) <br/>	
Worst Case   : Complexity: O(n^2) <br/>		
 
 
## bubblesort


Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
Example: <br/>	
First Pass: <br/>	
( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1. <br/>	
( 1 5 4 2 8 ) –>  ( 1 4 5 2 8 ), Swap since 5 > 4 <br/>	
( 1 4 5 2 8 ) –>  ( 1 4 2 5 8 ), Swap since 5 > 2 <br/>	
( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them.<br/>	
Second Pass: <br/>	
( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ) <br/>	
( 1 4 2 5 8 ) –> ( 1 2 4 5 8 ), Swap since 4 > 2 <br/>	
( 1 2 4 5 8 ) –> ( 1 2 4 5 8 ) <br/>	
( 1 2 4 5 8 ) –>  ( 1 2 4 5 8 ) <br/>	
Now, the array is already sorted, but our algorithm does not know if it is completed. The algorithm needs one whole pass without any swap to know it is sorted.v
Third Pass: <br/>	
( 1 2 4 5 8 ) –> ( 1 2 4 5 8 ) <br/>	
( 1 2 4 5 8 ) –> ( 1 2 4 5 8 ) <br/>	
( 1 2 4 5 8 ) –> ( 1 2 4 5 8 ) <br/>	
( 1 2 4 5 8 ) –> ( 1 2 4 5 8 ) <br/>	
 
	
    static void bubbleSort(int []arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    // swap temp and arr[i]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }	
Best Case :  : Complexity: O(n) if we put condition if first iteration didn't swap any element array is sorted .<br/>
Average Case : Complexity: O(n^2) <br/>
Worst Case   : Complexity: O(n^2) <br/>	
	
## binarysearch
	
Given a sorted array arr[] of n elements, write a function to search a given element x in arr[].
A simple approach is to do a linear search. The time complexity of the above algorithm is O(n). Another approach to perform the same task is using Binary Search. 
Binary Search: Search a sorted array by repeatedly dividing the search interval in half. Begin with an interval covering the whole array. If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half. Otherwise, narrow it to the upper half. Repeatedly check until the value is found or the interval is empty.<br/>

 	public static int BinarySearch(int[]arr,int l,int r,int x)
        {

            int mid;
            while (r>=l)
            {
                mid = (l + r) / 2;

                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] > x)
                    r =  - 1;
                else
                    l = mid + 1;
            }
	
            // We reach here when element is not present
            return -1;
        }
	
Time Complexity: O(log n) <br/>	

	
## selectionsort

The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.<br/>
	
Following example explains the above steps: <br/>

arr[] = 64 25 12 22 11<br/>

// Find the minimum element in arr[0...4]<br/>
// and place it at beginning<br/>
11 25 12 22 64<br/>

// Find the minimum element in arr[1...4]<br/>
// and place it at beginning of arr[1...4]<br/>
11 12 25 22 64<br/>

// Find the minimum element in arr[2...4]<br/>
// and place it at beginning of arr[2...4]<br/>
11 12 22 25 64<br/>

// Find the minimum element in arr[3...4]<br/>
// and place it at beginning of arr[3...4]<br/>
11 12 22 25 64 <br/>
	
    static void sort(int []arr)
    {
        int n = arr.Length;
 
        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;
 
            // Swap the found minimum element with the first
            // element
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
 Time Complexity: O(n^2)
	
## dp	
	
