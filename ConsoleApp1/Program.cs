using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WAP to accept a food name, price & quantity
//&give 5 % off then display the food name & its price(using constructor)

namespace ConsoleApp1
{
    internal class Program
    {
        public class Food
        {
            private string name;
            private int quantity;
            private double price;
            public Food()
            {
                name=name;
                quantity = 10;
                price = 100;
            }
            public Food(string name, int quantity, double price)
            {
                this.name = name;
                this.quantity = quantity;
                this.price = price; 
            }
            public void Discount(int discount)
            {
                double amt = (double)price / 5* discount;
                price = price - amt;
            }
            public string Print()
            {
                return $"{name}-> {quantity} -> {price}";
            }

            static void Main(string[] args)
            {
                Food f = new Food();
                Console.WriteLine(f.Print());

                Food f2 = new Food("name", 10, 899);
                f2.Discount(10);
                Console.WriteLine(f2.Print());


            }

            
             
            }
        }
    }

    
