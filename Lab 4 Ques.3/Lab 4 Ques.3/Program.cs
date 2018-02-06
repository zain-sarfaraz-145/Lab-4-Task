//3. Write a main method for your Vehicle class that creates a few vehicles and prints out their field values. Make the fields in your Vehicle class private, 
/////and add accessor and mutator methods for the fields.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4_Ques._3
{
    class vehicle
    {
        public int get_choice;
        private static string car = "\nName: Civic \nEngine: 1600 CC \nColor: Black \nCompany: Honda";
        private static string bike = "\nName: CB 1000R \nName: Honda \nColor: Red";
        private static string truck = "\nModel:4X \nName: Coach \nColor: White";
        private static string bus = "\nName: Hyundai Xcient \nHyundai \nColor: Silver";
        public int choi
        {
            get
            {
                return get_choice;
            }
            set
            {
                get_choice = value;
            }

        }
        public static void Field(vehicle v)
        {
            switch (v.get_choice)
            { 
                case 1:
                    Console.WriteLine(car);
                    break;
                case 2:

                    Console.WriteLine(bike);
                    break;
                case 3:

                    Console.WriteLine(truck);
                    break;
                case 4:

                    Console.WriteLine(bus);
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            vehicle v_obj = new vehicle();
            Console.Write("List of Vehicles \n1.Car \n2.Bike \n3.Truck \n4.Bus");
            Console.Write("\nEnter your Choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                v_obj.choi = choice;
                vehicle.Field(v_obj);

            }
            else if (choice == 2)
            {

                v_obj.choi = choice;
                vehicle.Field(v_obj);
            }
            else if (choice == 3)
            {

                v_obj.choi = choice;
                vehicle.Field(v_obj);
            }
            else if (choice == 4)
            {

                v_obj.choi = choice;
                vehicle.Field(v_obj);
            }
            else
            {
                Console.WriteLine("\nInvalid Input ");
                    
            }
            Console.ReadKey();
        }
    }
}
