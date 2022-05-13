// See https://aka.ms/new-console-template for more information
using HashTable;

Console.WriteLine("Welcome to HashTable!");


HashTableMethods<string, int> hashTable = new (7);
hashTable.Insert("To", 1);
hashTable.Insert("be", 2);
hashTable.Insert("or", 3);
hashTable.Insert("not", 4);
hashTable.Insert("to", 5);
hashTable.Insert("be", 6);


Console.WriteLine("Value of key 'be' is: " + hashTable.GetValue("be"));
