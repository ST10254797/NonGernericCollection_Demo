using System.Collections;

ArrayList arrayList = new ArrayList(); // dynamic array and can hold any datatype

//adding element
arrayList.Add("Apple");
arrayList.Add("Peach");
arrayList.Add("Orange");



//access elemetnts within the array
Console.WriteLine("Array List Elements");
foreach(var item in arrayList)
{
    Console.WriteLine(item);
}
// remove an element from within the arraylist
arrayList.Remove("Apple");
Console.WriteLine("Array List Elements after removing an element");
foreach  (var item in arrayList)
{
    Console.WriteLine(item);
}
//HashTable: a collection of key-value pairs
//Requires that the keys be unique and des not allow for duplication of keys
//Keys and values can be of any datatype
//fast lookup based on key value

//Collection name() = new Contructor()
Hashtable hashtable = new Hashtable();

// Adding key-value pairs to HashTable
hashtable.Add("Key1", "Value1");
hashtable.Add("Key2", "Value2");
hashtable.Add("Key3", "Value3");

//Accessing the values using the keys from the HashTable
Console.WriteLine("\nHashtable Elements: ");
foreach (var key in hashtable.Keys)
{
    Console.WriteLine($"key: {key}, Value:{hashtable[key]}");    
}

// remove a key-value pair from the HashTable
hashtable.Remove("Key2");
Console.WriteLine("\nHashtable elements after being removed:");
foreach (var key in hashtable.Keys)
{
    Console.WriteLine($"Key: {key}, Value: {hashtable[key]}");
}