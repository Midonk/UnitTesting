using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListSystem
{
    
    public struct Person
    {
        public Person(string firstName, string lastName, string enemy)
        {
            FirstName = firstName;
            LastName = lastName;
            Enemy = enemy;
        }

        public string FirstName;
        public string LastName;
        public string Enemy;
    }

    public struct Module
    {
        public Module(string name, int length)
        {
            Name = name;
            Length = length;
        }

        public string Name;
        public int Length;
    }

    public struct PointObject
    {
        public PointObject(string name, Vector3 pos, string tag)
        {
            Name = name;
            Pos = pos;
            Tag = tag;
        }

        public string Name;
        public Vector3 Pos;
        public string Tag;
    }

    public struct Product
    {
        public Product(string name, string category, float price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public string Name;
        public string Category;
        public float Price;


    }
}
