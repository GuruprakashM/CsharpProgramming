using System;


namespace ArrayListDS
{
    public partial class ArrayList// List is the Generic Type It has only similar data type
    {
         private dynamic[] Array{get;set;}//array

         private int _capacity;//field
         private int _count;//field
         public int Capacity{get{return _capacity;} }//Property// number of Size in Array
         public int Count {get{return _count;}}//property// number if elements array
         
         public dynamic this[int i]
         {
            get{return Array[i];}
            set{Array[i]=value;}
         }
         public ArrayList()//this is the starting values of both count and capacity
         {
            _count=0;
            _capacity=4;
            Array = new dynamic[_capacity];

         }
         public ArrayList(int size)
         {
            _count=0;
            _capacity=size;
            Array = new dynamic[_capacity];
         }
         public void AddElement(dynamic data)
         {
            if(_count==_capacity)
            {
               GrowSize();
            }
            Array[_count]=data;
            _count++;
         }
         public void GrowSize()
         {
             _capacity=_capacity*2;
           dynamic[] ArrayMax= new dynamic[_capacity];// int[] a= new int[10];

             for (var i=0; i<_count; i++)
             {
                ArrayMax[i]=Array[i];
             }
            Array=ArrayMax;
         }

         

         
    }
}