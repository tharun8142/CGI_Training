
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of Furniture
    public class BookShelf:Furniture
    {
        //Add  NoOfShelves  property
        public int NoOfShelves { get; set; }
        //overrride the Accept method to read NoOfShelves property also
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("enter NoOfLegs");
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        //
        //override the Display method to include the display of NoOfShelves property also
        public override void Display()
        {
            base.Display();
            Console.Write("NoOfShelves"+NoOfShelves);
            
        }



    }
}

















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
