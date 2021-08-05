## Table of contents C++
* [string](#string)
* [queue](#queue)
* [dequeue](#dequeue)
* ## Algorithms 
* [Prefix Sum](#prefixsum)






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

## prefixsum

